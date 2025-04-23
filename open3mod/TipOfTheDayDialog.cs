///////////////////////////////////////////////////////////////////////////////////
// Open 3D Model Viewer (open3mod) (v2.0)
// [TipOfTheDayDialog.cs]
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

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;

using System.Windows.Forms;

namespace open3mod
{
    public partial class TipOfTheDayDialog : Form
    {
        private static String[] _tips = new[]
            {
@"您可以通过按回车键锁定搜索结果。

再次按下回车键可在搜索结果中循环切换。
当前选中项会以黄色高亮显示。",

@"您可以通过在场景浏览器中右键单击
场景的某些部分并选择 '隐藏' 来永久隐藏它们。",

 @"双击纹理可查看其完整尺寸。
如果纹理查看器已打开，将鼠标悬停在小纹理上可快速预览。",

  @"在工具栏中，您可以突出显示场景中的关节。
在查看带骨骼的模型时，这非常有用。
播放动画时，可视化效果会反映骨骼的运动。",

  @"将鼠标悬停在场景浏览器中的关节上时，
关节高亮显示功能会自动开启，并且选中的关节会被高亮显示。",

   @"使用靶心模式锁定当前 3D 视图。
当您将鼠标悬停在 3D 场景的某些部分上时，
场景浏览器会自动在场景层级中突出显示它们。",
            };

        private int _cursor;


        public TipOfTheDayDialog()
        {
            InitializeComponent();
            SetTip(CoreSettings.CoreSettings.Default.NextTip);
        }


        private void SetTip(int nextTip)
        {
            while(nextTip < 0)
            {
                nextTip += _tips.Length;
            }
            _cursor = nextTip % _tips.Length;

            pictureBoxTipPic.Image = ImageFromResource.Get("open3mod.Images.TipOfTheDay.Tip" + _cursor + ".png");
            labelTipText.Text = _tips[_cursor];
        }


        private void OnPrevious(object sender, EventArgs e)
        {
            SetTip(_cursor - 1);   
        }


        private void OnNext(object sender, EventArgs e)
        {
            SetTip(_cursor + 1);
        }


        private void OnClose(object sender, FormClosingEventArgs e)
        {
            CoreSettings.CoreSettings.Default.NextTip = (_cursor + 1)%_tips.Length;
        }


        private void OnChangeStartup(object sender, EventArgs e)
        {
            // for some reason the prop binding does not work.
            CoreSettings.CoreSettings.Default.ShowTipsOnStartup = checkBoxDoNotShowAgain.Checked;
        }
    }
}

/* vi: set shiftwidth=4 tabstop=4: */