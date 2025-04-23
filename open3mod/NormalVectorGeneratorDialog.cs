using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.DirectoryServices.ActiveDirectory;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using Amib.Threading;
using Assimp;
using Action = System.Action;
using Timer = System.Windows.Forms.Timer;

namespace open3mod
{
    /// <summary>
    /// 用于为单个或多个网格计算法线的对话框。
    /// </summary>
    public sealed partial class NormalVectorGeneratorDialog : Form
    {
        private const float DefaultThresholdAngle = 45.0f;

        private readonly Scene _scene;

        private class ProcessedMesh
        {
            public Mesh Mesh { get; set; }
            public Mesh PreviewMesh { get; set; }
            public NormalVectorGenerator Generator { get; set; }
        };

        private readonly List<ProcessedMesh> _meshesToProcess; 
        private float _thresholdAngleInDegrees = DefaultThresholdAngle;
        private volatile float _lastCompletedUpdateAngle = -1.0f;
        private volatile bool _isInitialUpdate = true;
        private Thread _updateThread;
        private readonly AutoResetEvent _syncEvent = new AutoResetEvent(false);
        private bool _committed = false;

        /// <summary>
        /// 实时更新意味着在移动平滑度滑块时更新法线。这会消耗 CPU 资源，
        /// 对于较大的场景可能不是一个好主意，因此我们将其设置为可配置。
        /// </summary>
        public bool RealtimeUpdateEnabled
        {
            get { return checkBoxRealtimePreview.Checked; }
        }

        /// <summary>
        /// 为单个网格构造。
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="mesh"></param>
        /// <param name="meshName">用于 UI 一致性的网格显示名称</param>
        public NormalVectorGeneratorDialog(Scene scene, Mesh mesh, string meshName)
            : this(scene,new List<Mesh> { mesh }, meshName)
        {    }


        /// <summary>
        /// 为一组网格构造。
        /// </summary>
        /// <param name="scene"></param>
        /// <param name="mesh"></param>
        /// <param name="description">要显示在标题中的字符串</param>
        public NormalVectorGeneratorDialog(Scene scene, IEnumerable<Mesh> mesh, string description)
        {
            Debug.Assert(scene != null);
            _scene = scene;
            _meshesToProcess = mesh.Select(m => new ProcessedMesh {Mesh = m}).ToList();

            InitializeComponent();
            buttonApply.Enabled = !checkBoxRealtimePreview.Checked;

            Text = string.Format("{0} - {1}", description, Text);
            // 在初始更新完成之前保持用户体验禁用。
            foreach (Control control in Controls)
            {
                if (control != labelStatusText)
                {
                    control.Enabled = false;
                }
            }
            // 如果启用了实时更新，则启动更新线程
            trackBarAngle.Value = (int)_thresholdAngleInDegrees;
        }

        /// <summary>
        /// 使用单独的线程池进行粗粒度（= 网格级别）并行化。
        /// 
        /// 智能线程池（STP）在递归使用时会显示死锁。这可以通过设置优先级来缓解，
        /// 但使用单独的线程池要安全得多。考虑到线程随后将运行大型作业，设置几个线程的额外成本相对较小。
        /// </summary>
        private static readonly SmartThreadPool CoarseThreadPool = new SmartThreadPool();

        /// <summary>
        /// 更新当前网格中的法线并刷新 3D 视图。
        /// </summary>
        private void UpdateNormals(float angle)
        {
            SafeInvoke(new Action(() => labelStatusText.Text = _isInitialUpdate ? "准备中 ..." : "更新中 ..."));
            _meshesToProcess.ParallelDo(
                entry =>
                {
                    if (entry.PreviewMesh == null)
                    {
                        entry.PreviewMesh = MeshUtil.DeepCopy(entry.Mesh);
                    }
                    if (entry.Generator == null)
                    {
                        entry.Generator = new NormalVectorGenerator(entry.PreviewMesh);
                    }
                    entry.Generator.Compute(angle);

                    // 使用 BeginInvoke() 将网格覆盖更改分派到 GUI/渲染线程。
                    if (InvokeRequired)
                    {
                        BeginInvoke(new Action(() => _scene.SetOverrideMesh(entry.Mesh, entry.PreviewMesh)));
                    }
                    else
                    {
                        _scene.SetOverrideMesh(entry.Mesh, entry.PreviewMesh);
                    }
                }, 1 /* 每个网格的粒度 */, CoarseThreadPool);
            Action closeAction = null;
            closeAction = new Action(
                () =>
                {
                    if (!trackBarAngle.Capture)
                    {
                        labelStatusText.Text = "";
                    }
                    else
                    {
                        // 如果鼠标当前被捕获，则不要重置文本以避免闪烁。
                        // 相反，在 150 毫秒后再次检查。
                        var timer = new Timer { Interval = 150 };
                        timer.Tick += (sender, args) =>
                        {
                            timer.Enabled = false;
                            closeAction();
                        }
                    ;
                        timer.Start();
                    }
                    if (_isInitialUpdate)
                    {
                        foreach (Control control in Controls)
                        {
                            control.Enabled = true;
                        }
                        _isInitialUpdate = false;
                    }
                });
            SafeInvoke(closeAction);
        }

        private void SafeInvoke(Action action)
        {
            try
            {
                BeginInvoke(action);
            }
            catch (InvalidOperationException)
            {
                // 忽略。如果在对话框构造函数返回之前调度此操作，就会发生这种情况。
                return;
            }
        }

        /// <summary>
        /// 安排延迟更新，如果需要则启动更新线程。
        /// </summary>
        private void ScheduleUpdateNormals()
        {
            if (_updateThread == null)
            {
                _updateThread = new Thread(
                    () =>
                    {
                        while (true)
                        {
                            try
                            {
                                float angle = _thresholdAngleInDegrees;
                                UpdateNormals(angle);
                                _lastCompletedUpdateAngle = angle;
                                _syncEvent.WaitOne();
                            }
                            catch (ThreadAbortException)
                            {
                                break;
                            }
                            catch (ThreadInterruptedException) { }
                        }
                    });
                _updateThread.Start();
            }
            else
            {
                _syncEvent.Set();
                _updateThread.Interrupt();
            }
        }

        /// <summary>
        /// 加入并清理更新线程。
        /// </summary>
        private void StopUpdateThread()
        {
            if (_updateThread == null)
            {
                return;
            }
            labelStatusText.Text = "";
            _updateThread.Abort();
            _updateThread.Join();
            _updateThread = null;
        }

        /// <summary>
        /// 更新法线并为操作创建一个撤销栈条目。
        /// </summary>
        private void Commit()
        {
            StopUpdateThread();
            if (Math.Abs(_lastCompletedUpdateAngle - _thresholdAngleInDegrees) > 0.001f)
            {
                UpdateNormals(_thresholdAngleInDegrees);
            }
            var meshesToProcess = _meshesToProcess.Select(_ => _).ToList();
            var originalMeshes = _meshesToProcess.Select(entry => MeshUtil.ShallowCopy(entry.Mesh)).ToList();
            _scene.UndoStack.PushAndDo("计算法线",
                () =>
                {                   
                    foreach (var entry in meshesToProcess)
                    {
                        MeshUtil.ShallowCopy(entry.Mesh, entry.PreviewMesh);
                    }
                },
                () =>
                {
                    meshesToProcess.ZipAction(originalMeshes,
                        (entry, origMesh) =>
                        {
                            MeshUtil.ShallowCopy(entry.Mesh, origMesh);
                        });
                },
                () =>
                {
                    foreach (var entry in meshesToProcess)
                    {
                        _scene.SetOverrideMesh(entry.Mesh, null);
                    }
                    _scene.RequestRenderRefresh();
                });
            _committed = true;
        }

        /// <summary>
        /// 撤销对网格所做的所有更改。
        /// </summary>
        private void Revert()
        {
            StopUpdateThread();
            foreach (var entry in _meshesToProcess)
            {
                _scene.SetOverrideMesh(entry.Mesh, null);
                MeshUtil.ClearMesh(entry.PreviewMesh);
            }
            _meshesToProcess.Clear();
        }

        // 事件处理程序
        private void CheckBoxRealtimePreviewCheckedChanged(object sender, EventArgs e)
        {
            buttonApply.Enabled = !checkBoxRealtimePreview.Checked;
            if (RealtimeUpdateEnabled)
            {
                ScheduleUpdateNormals();
            }
        }

        private void OnChangeSmoothness(object sender, EventArgs e)
        {
            _thresholdAngleInDegrees = trackBarAngle.Value;
            labelAngle.Text = string.Format("{0} 度", trackBarAngle.Value.ToString());
            if (RealtimeUpdateEnabled)
            {
                ScheduleUpdateNormals();
            }
        }

        private void OnManualApply(object sender, EventArgs e)
        {
            ScheduleUpdateNormals();
        }

        private void OnOk(object sender, EventArgs e)
        {
            Commit();
            Close();
        }    

        private void OnCancel(object sender, EventArgs e)
        {
            Revert();
            Close();
        }

        private void OnClose(object sender, FormClosingEventArgs e)
        {
            StopUpdateThread();
            if (!_committed)
            {
                Revert();
            }
        } 
    }
}
