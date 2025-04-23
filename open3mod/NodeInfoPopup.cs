///////////////////////////////////////////////////////////////////////////////////
// Open 3D Model Viewer (open3mod) (v2.0)
// [NodeInfoPopup.cs]
// (c) 2012-2015, Open3Mod Contributors
//
// Licensed under the terms and conditions of the 3-clause BSD license. See
// the LICENSE file in the root folder of the repository for the details.
//
// HIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING, BUT NOT LIMITED TO, THE IMPLIED
// WARRANTIES OF MERCHANTABILITY AND FITNESS FOR A PARTICULAR PURPOSE ARE 
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT OWNER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL, SPECIAL, EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO, PROCUREMENT OF SUBSTITUTE GOODS OR SERVICES; 
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION) HOWEVER CAUSED AND 
// ON ANY THEORY OF LIABILITY, WHETHER IN CONTRACT, STRICT LIABILITY, OR TORT 
// (INCLUDING NEGLIGENCE OR OTHERWISE) ARISING IN ANY WAY OUT OF THE USE OF THIS 
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.
///////////////////////////////////////////////////////////////////////////////////

using System.Diagnostics;
using System.Windows.Forms;
using Assimp;

namespace open3mod
{
    public partial class NodeInfoPopup : UserControl
    {
        private HierarchyInspectionView _owner;

        public NodeInfoPopup()
        {
            InitializeComponent();
        }


        public HierarchyInspectionView Owner
        {
            set { _owner = value; }
        }


        /// <summary>
        /// 根据给定的 Assimp 节点设置信息弹出窗口的内容。
        /// 
        /// 调用此方法时，调用者已调整了节点信息弹出窗口的位置。
        /// </summary>
        public void Populate(Assimp.Scene scene, Node node, NodePurpose purpose)
        {
            Debug.Assert(scene != null);
            Debug.Assert(node != null);
            Debug.Assert(_owner != null);
            switch (purpose)
            {
                case NodePurpose.Joint:
                    labelCaption.Text = "关节";
                    break;
                case NodePurpose.ImporterGenerated:
                    labelCaption.Text = "根节点";
                    break;
                case NodePurpose.GenericMeshHolder:
                    labelCaption.Text = "节点";
                    break;
                case NodePurpose.Camera:
                    labelCaption.Text = "相机";
                    break;
                case NodePurpose.Light:
                    labelCaption.Text = "灯光";
                    break;
                default:
                    Debug.Assert(false);
                    break;
            }

            // 递归计算子节点数量
            var children = 0;
            CountChildren(node, ref children);

            var animated = false;

            // 检查此节点是否有任何动画通道
            for (var i = 0; i < scene.AnimationCount && !animated; ++i )
            {
                var anim = scene.Animations[i];
                for(var j = 0; j < anim.NodeAnimationChannelCount; ++j)
                {
                    if(anim.NodeAnimationChannels[j].NodeName == node.Name)
                    {
                        animated = true;
                        break;
                    }
                }
            }

            labelInfo.Text = string.Format("{0} 个子节点\n{1}", children, (animated ? "有动画" : "无动画"));
        }


        private void CountChildren(Node node, ref int children)
        {
            children += node.ChildCount;
            for(var i = 0; i < node.ChildCount; ++i)
            {
                CountChildren(node.Children[i], ref children);
            }
        }
    }
}

/* vi: set shiftwidth=4 tabstop=4: */