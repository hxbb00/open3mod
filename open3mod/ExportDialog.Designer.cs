namespace open3mod
{
    partial class ExportDialog
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
            this.buttonSelectFolder = new System.Windows.Forms.Button();
            this.comboBoxExportFormats = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.progressBarExport = new System.Windows.Forms.ProgressBar();
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxCopyTexturesToFolder = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.checkBoxCopyTexturesToSubfolder = new System.Windows.Forms.CheckBox();
            this.textBoxPath = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.checkBoxNoOverwriteConfirm = new System.Windows.Forms.CheckBox();
            this.checkBoxOpenExportedFile = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeSceneHierarchy = new System.Windows.Forms.CheckBox();
            this.checkBoxIncludeAnimations = new System.Windows.Forms.CheckBox();
            this.checkBoxUseRelativeTexturePaths = new System.Windows.Forms.CheckBox();
            this.buttonExportRun = new System.Windows.Forms.Button();
            this.labelExportStatus = new System.Windows.Forms.Label();
            this.textBoxExportLog = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonSelectFolder
            // 
            this.buttonSelectFolder.Location = new System.Drawing.Point(673, 29);
            this.buttonSelectFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonSelectFolder.Name = "buttonSelectFolder";
            this.buttonSelectFolder.Size = new System.Drawing.Size(53, 27);
            this.buttonSelectFolder.TabIndex = 1;
            this.buttonSelectFolder.Text = "...";
            this.buttonSelectFolder.UseVisualStyleBackColor = true;
            this.buttonSelectFolder.Click += new System.EventHandler(this.buttonSelectFolder_Click);
            // 
            // comboBoxExportFormats
            // 
            this.comboBoxExportFormats.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExportFormats.FormattingEnabled = true;
            this.comboBoxExportFormats.Location = new System.Drawing.Point(140, 33);
            this.comboBoxExportFormats.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.comboBoxExportFormats.Name = "comboBoxExportFormats";
            this.comboBoxExportFormats.Size = new System.Drawing.Size(463, 23);
            this.comboBoxExportFormats.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "文件格式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 35);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "路径";
            // 
            // progressBarExport
            // 
            this.progressBarExport.Location = new System.Drawing.Point(181, 565);
            this.progressBarExport.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.progressBarExport.Name = "progressBarExport";
            this.progressBarExport.Size = new System.Drawing.Size(619, 27);
            this.progressBarExport.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBarExport.TabIndex = 7;
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "选择输出文件夹";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 70);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(52, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "文件名";
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(103, 67);
            this.textBoxFileName.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.Size = new System.Drawing.Size(560, 25);
            this.textBoxFileName.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxCopyTexturesToFolder);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.checkBoxCopyTexturesToSubfolder);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxFileName);
            this.groupBox1.Controls.Add(this.buttonSelectFolder);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.textBoxPath);
            this.groupBox1.Location = new System.Drawing.Point(41, 242);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(759, 192);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出";
            // 
            // textBoxCopyTexturesToFolder
            // 
            this.textBoxCopyTexturesToFolder.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::open3mod.ExportSettings.Default, "CopyTexturesToFolder_Target", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxCopyTexturesToFolder.Location = new System.Drawing.Point(245, 155);
            this.textBoxCopyTexturesToFolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxCopyTexturesToFolder.Name = "textBoxCopyTexturesToFolder";
            this.textBoxCopyTexturesToFolder.Size = new System.Drawing.Size(417, 25);
            this.textBoxCopyTexturesToFolder.TabIndex = 11;
            this.textBoxCopyTexturesToFolder.Text = global::open3mod.ExportSettings.Default.CopyTexturesToFolder_Target;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label4.Location = new System.Drawing.Point(11, 104);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(549, 30);
            this.label4.TabIndex = 10;
            this.label4.Text = "注意：某些文件格式（如 Obj）会使用多个文件来表示一个场景。在这种情况下，\r\n此处输入的名称将作为主文件的名称。";
            // 
            // checkBoxCopyTexturesToSubfolder
            // 
            this.checkBoxCopyTexturesToSubfolder.AutoSize = true;
            this.checkBoxCopyTexturesToSubfolder.Checked = global::open3mod.ExportSettings.Default.CopyTexturesToFolder;
            this.checkBoxCopyTexturesToSubfolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxCopyTexturesToSubfolder.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::open3mod.ExportSettings.Default, "CopyTexturesToFolder", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxCopyTexturesToSubfolder.Location = new System.Drawing.Point(15, 159);
            this.checkBoxCopyTexturesToSubfolder.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxCopyTexturesToSubfolder.Name = "checkBoxCopyTexturesToSubfolder";
            this.checkBoxCopyTexturesToSubfolder.Size = new System.Drawing.Size(179, 19);
            this.checkBoxCopyTexturesToSubfolder.TabIndex = 7;
            this.checkBoxCopyTexturesToSubfolder.Text = "将纹理复制到子文件夹";
            this.checkBoxCopyTexturesToSubfolder.UseVisualStyleBackColor = true;
            // 
            // textBoxPath
            // 
            this.textBoxPath.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::open3mod.ExportSettings.Default, "OutputPath", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.textBoxPath.Location = new System.Drawing.Point(103, 31);
            this.textBoxPath.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxPath.Name = "textBoxPath";
            this.textBoxPath.Size = new System.Drawing.Size(560, 25);
            this.textBoxPath.TabIndex = 2;
            this.textBoxPath.Text = global::open3mod.ExportSettings.Default.OutputPath;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.checkBoxNoOverwriteConfirm);
            this.groupBox2.Controls.Add(this.checkBoxOpenExportedFile);
            this.groupBox2.Controls.Add(this.checkBoxIncludeSceneHierarchy);
            this.groupBox2.Controls.Add(this.checkBoxIncludeAnimations);
            this.groupBox2.Controls.Add(this.checkBoxUseRelativeTexturePaths);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.comboBoxExportFormats);
            this.groupBox2.Location = new System.Drawing.Point(41, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(759, 208);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "导出";
            // 
            // checkBoxNoOverwriteConfirm
            // 
            this.checkBoxNoOverwriteConfirm.AutoSize = true;
            this.checkBoxNoOverwriteConfirm.Location = new System.Drawing.Point(28, 174);
            this.checkBoxNoOverwriteConfirm.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxNoOverwriteConfirm.Name = "checkBoxNoOverwriteConfirm";
            this.checkBoxNoOverwriteConfirm.Size = new System.Drawing.Size(164, 19);
            this.checkBoxNoOverwriteConfirm.TabIndex = 17;
            this.checkBoxNoOverwriteConfirm.Text = "不确认直接覆盖文件";
            this.checkBoxNoOverwriteConfirm.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpenExportedFile
            // 
            this.checkBoxOpenExportedFile.AutoSize = true;
            this.checkBoxOpenExportedFile.Checked = global::open3mod.ExportSettings.Default.OpenExportedFileInViewer;
            this.checkBoxOpenExportedFile.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::open3mod.ExportSettings.Default, "OpenExportedFileInViewer", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxOpenExportedFile.Location = new System.Drawing.Point(28, 148);
            this.checkBoxOpenExportedFile.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxOpenExportedFile.Name = "checkBoxOpenExportedFile";
            this.checkBoxOpenExportedFile.Size = new System.Drawing.Size(194, 19);
            this.checkBoxOpenExportedFile.TabIndex = 16;
            this.checkBoxOpenExportedFile.Text = "在查看器中打开导出文件";
            this.checkBoxOpenExportedFile.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeSceneHierarchy
            // 
            this.checkBoxIncludeSceneHierarchy.AutoSize = true;
            this.checkBoxIncludeSceneHierarchy.Checked = global::open3mod.ExportSettings.Default.IncludeSceneHierarchy;
            this.checkBoxIncludeSceneHierarchy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeSceneHierarchy.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::open3mod.ExportSettings.Default, "IncludeSceneHierarchy", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxIncludeSceneHierarchy.Location = new System.Drawing.Point(316, 82);
            this.checkBoxIncludeSceneHierarchy.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxIncludeSceneHierarchy.Name = "checkBoxIncludeSceneHierarchy";
            this.checkBoxIncludeSceneHierarchy.Size = new System.Drawing.Size(149, 19);
            this.checkBoxIncludeSceneHierarchy.TabIndex = 10;
            this.checkBoxIncludeSceneHierarchy.Text = "包含场景层级结构";
            this.checkBoxIncludeSceneHierarchy.UseVisualStyleBackColor = true;
            // 
            // checkBoxIncludeAnimations
            // 
            this.checkBoxIncludeAnimations.AutoSize = true;
            this.checkBoxIncludeAnimations.Checked = global::open3mod.ExportSettings.Default.IncludeAnimations;
            this.checkBoxIncludeAnimations.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxIncludeAnimations.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::open3mod.ExportSettings.Default, "IncludeAnimations", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxIncludeAnimations.Location = new System.Drawing.Point(316, 108);
            this.checkBoxIncludeAnimations.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxIncludeAnimations.Name = "checkBoxIncludeAnimations";
            this.checkBoxIncludeAnimations.Size = new System.Drawing.Size(89, 19);
            this.checkBoxIncludeAnimations.TabIndex = 9;
            this.checkBoxIncludeAnimations.Text = "包含动画";
            this.checkBoxIncludeAnimations.UseVisualStyleBackColor = true;
            // 
            // checkBoxUseRelativeTexturePaths
            // 
            this.checkBoxUseRelativeTexturePaths.AutoSize = true;
            this.checkBoxUseRelativeTexturePaths.Checked = global::open3mod.ExportSettings.Default.UseRelativeTexturePaths;
            this.checkBoxUseRelativeTexturePaths.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxUseRelativeTexturePaths.DataBindings.Add(new System.Windows.Forms.Binding("Checked", global::open3mod.ExportSettings.Default, "UseRelativeTexturePaths", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.checkBoxUseRelativeTexturePaths.Location = new System.Drawing.Point(28, 82);
            this.checkBoxUseRelativeTexturePaths.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.checkBoxUseRelativeTexturePaths.Name = "checkBoxUseRelativeTexturePaths";
            this.checkBoxUseRelativeTexturePaths.Size = new System.Drawing.Size(149, 19);
            this.checkBoxUseRelativeTexturePaths.TabIndex = 8;
            this.checkBoxUseRelativeTexturePaths.Text = "使用相对纹理路径";
            this.checkBoxUseRelativeTexturePaths.UseVisualStyleBackColor = true;
            // 
            // buttonExportRun
            // 
            this.buttonExportRun.Location = new System.Drawing.Point(47, 565);
            this.buttonExportRun.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonExportRun.Name = "buttonExportRun";
            this.buttonExportRun.Size = new System.Drawing.Size(127, 27);
            this.buttonExportRun.TabIndex = 12;
            this.buttonExportRun.Text = "导出";
            this.buttonExportRun.UseVisualStyleBackColor = true;
            this.buttonExportRun.Click += new System.EventHandler(this.buttonExport);
            // 
            // labelExportStatus
            // 
            this.labelExportStatus.AutoSize = true;
            this.labelExportStatus.Location = new System.Drawing.Point(185, 492);
            this.labelExportStatus.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelExportStatus.Name = "labelExportStatus";
            this.labelExportStatus.Size = new System.Drawing.Size(0, 15);
            this.labelExportStatus.TabIndex = 13;
            // 
            // textBoxExportLog
            // 
            this.textBoxExportLog.Location = new System.Drawing.Point(41, 441);
            this.textBoxExportLog.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.textBoxExportLog.Multiline = true;
            this.textBoxExportLog.Name = "textBoxExportLog";
            this.textBoxExportLog.ReadOnly = true;
            this.textBoxExportLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxExportLog.Size = new System.Drawing.Size(757, 104);
            this.textBoxExportLog.TabIndex = 14;
            // 
            // ExportDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 609);
            this.Controls.Add(this.textBoxExportLog);
            this.Controls.Add(this.labelExportStatus);
            this.Controls.Add(this.buttonExportRun);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.progressBarExport);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "ExportDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "导出";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonSelectFolder;
        private System.Windows.Forms.TextBox textBoxPath;
        private System.Windows.Forms.ComboBox comboBoxExportFormats;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar progressBarExport;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxCopyTexturesToFolder;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox checkBoxCopyTexturesToSubfolder;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBoxUseRelativeTexturePaths;
        private System.Windows.Forms.CheckBox checkBoxIncludeSceneHierarchy;
        private System.Windows.Forms.CheckBox checkBoxIncludeAnimations;
        private System.Windows.Forms.Button buttonExportRun;
        private System.Windows.Forms.Label labelExportStatus;
        private System.Windows.Forms.TextBox textBoxExportLog;
        private System.Windows.Forms.CheckBox checkBoxNoOverwriteConfirm;
        private System.Windows.Forms.CheckBox checkBoxOpenExportedFile;
    }
}