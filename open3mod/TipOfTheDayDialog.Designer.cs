namespace open3mod
{
    partial class TipOfTheDayDialog
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TipOfTheDayDialog));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            this.checkBoxDoNotShowAgain = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelTipText = new System.Windows.Forms.Label();
            this.pictureBoxTipPic = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipPic)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button1.Location = new System.Drawing.Point(135, 7);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "下一条";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnNext);
            // 
            // button2
            // 
            this.button2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.button2.Location = new System.Drawing.Point(4, 7);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(123, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "上一条";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnPrevious);
            // 
            // buttonOk
            // 
            this.buttonOk.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.buttonOk.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonOk.Location = new System.Drawing.Point(778, 7);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(133, 27);
            this.buttonOk.TabIndex = 2;
            this.buttonOk.Text = "确定";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // checkBoxDoNotShowAgain
            // 
            this.checkBoxDoNotShowAgain.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.checkBoxDoNotShowAgain.AutoSize = true;
            this.checkBoxDoNotShowAgain.Checked = global::CoreSettings.CoreSettings.Default.ShowTipsOnStartup;
            this.checkBoxDoNotShowAgain.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxDoNotShowAgain.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::CoreSettings.CoreSettings.Default, "ShowTipsOnStartup", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxDoNotShowAgain.Location = new System.Drawing.Point(666, 11);
            this.checkBoxDoNotShowAgain.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxDoNotShowAgain.Name = "checkBoxDoNotShowAgain";
            this.checkBoxDoNotShowAgain.Size = new System.Drawing.Size(104, 19);
            this.checkBoxDoNotShowAgain.TabIndex = 3;
            this.checkBoxDoNotShowAgain.Text = "启动时显示";
            this.checkBoxDoNotShowAgain.UseVisualStyleBackColor = true;
            this.checkBoxDoNotShowAgain.CheckedChanged += new System.EventHandler(this.OnChangeStartup);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.labelTipText);
            this.panel1.Controls.Add(this.pictureBoxTipPic);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 314);
            this.panel1.TabIndex = 4;
            // 
            // labelTipText
            // 
            this.labelTipText.AutoSize = true;
            this.labelTipText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipText.Location = new System.Drawing.Point(320, 14);
            this.labelTipText.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTipText.Name = "labelTipText";
            this.labelTipText.Size = new System.Drawing.Size(248, 120);
            this.labelTipText.TabIndex = 1;
            this.labelTipText.Text = "You can use the force to control \r\nalmost everything.\r\n\r\nJust make sure the force" +
    " is strong\r\nin you. Do not attempt to count\r\nMidi-Chlorians.";
            // 
            // pictureBoxTipPic
            // 
            this.pictureBoxTipPic.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxTipPic.Image")));
            this.pictureBoxTipPic.Location = new System.Drawing.Point(17, 14);
            this.pictureBoxTipPic.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxTipPic.Name = "pictureBoxTipPic";
            this.pictureBoxTipPic.Size = new System.Drawing.Size(293, 207);
            this.pictureBoxTipPic.TabIndex = 0;
            this.pictureBoxTipPic.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.buttonOk);
            this.panel2.Controls.Add(this.checkBoxDoNotShowAgain);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(915, 40);
            this.panel2.TabIndex = 5;
            // 
            // TipOfTheDayDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 354);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "TipOfTheDayDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "每日提示";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClose);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxTipPic)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.CheckBox checkBoxDoNotShowAgain;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxTipPic;
        private System.Windows.Forms.Label labelTipText;
        private System.Windows.Forms.Panel panel2;
    }
}