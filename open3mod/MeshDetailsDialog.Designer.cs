namespace open3mod
{
    partial class MeshDetailsDialog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MeshDetailsDialog));
            this.labelVertexCount = new System.Windows.Forms.Label();
            this.labelFaceCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelMaterialName = new System.Windows.Forms.Label();
            this.pictureBoxMaterial = new System.Windows.Forms.PictureBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.buttonDeleteVertexData = new System.Windows.Forms.Button();
            this.listBoxVertexData = new System.Windows.Forms.ListBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.labelBoneCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonDeleteFaceData = new System.Windows.Forms.Button();
            this.listBoxFaceData = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelVertexCount
            // 
            this.labelVertexCount.AutoSize = true;
            this.labelVertexCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVertexCount.Location = new System.Drawing.Point(81, 33);
            this.labelVertexCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelVertexCount.Name = "labelVertexCount";
            this.labelVertexCount.Size = new System.Drawing.Size(121, 17);
            this.labelVertexCount.TabIndex = 7;
            this.labelVertexCount.Text = "<顶点数量> 顶点";
            // 
            // labelFaceCount
            // 
            this.labelFaceCount.AutoSize = true;
            this.labelFaceCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelFaceCount.Location = new System.Drawing.Point(81, 18);
            this.labelFaceCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelFaceCount.Name = "labelFaceCount";
            this.labelFaceCount.Size = new System.Drawing.Size(91, 17);
            this.labelFaceCount.TabIndex = 8;
            this.labelFaceCount.Text = "<面数量> 面";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(348, 47);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 15);
            this.label4.TabIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.labelMaterialName);
            this.groupBox1.Controls.Add(this.pictureBoxMaterial);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(613, 14);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(261, 314);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "材质";
            // 
            // labelMaterialName
            // 
            this.labelMaterialName.AutoSize = true;
            this.labelMaterialName.Location = new System.Drawing.Point(20, 30);
            this.labelMaterialName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaterialName.Name = "labelMaterialName";
            this.labelMaterialName.Size = new System.Drawing.Size(83, 15);
            this.labelMaterialName.TabIndex = 3;
            this.labelMaterialName.Text = "<材质名称>";
            // 
            // pictureBoxMaterial
            // 
            this.pictureBoxMaterial.Location = new System.Drawing.Point(24, 48);
            this.pictureBoxMaterial.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pictureBoxMaterial.Name = "pictureBoxMaterial";
            this.pictureBoxMaterial.Size = new System.Drawing.Size(216, 187);
            this.pictureBoxMaterial.TabIndex = 2;
            this.pictureBoxMaterial.TabStop = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(97, 246);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(127, 15);
            this.linkLabel1.TabIndex = 1;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "在材质列表中选择";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.OnJumpToMaterial);
            // 
            // button1
            // 
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(24, 273);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(216, 27);
            this.button1.TabIndex = 0;
            this.button1.Text = "更改";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.buttonDeleteVertexData);
            this.groupBox2.Controls.Add(this.listBoxVertexData);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Location = new System.Drawing.Point(281, 14);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox2.Size = new System.Drawing.Size(324, 314);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "顶点数据";
            // 
            // buttonDeleteVertexData
            // 
            this.buttonDeleteVertexData.Enabled = false;
            this.buttonDeleteVertexData.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteVertexData.Image")));
            this.buttonDeleteVertexData.Location = new System.Drawing.Point(269, 30);
            this.buttonDeleteVertexData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteVertexData.Name = "buttonDeleteVertexData";
            this.buttonDeleteVertexData.Size = new System.Drawing.Size(35, 33);
            this.buttonDeleteVertexData.TabIndex = 10;
            this.buttonDeleteVertexData.UseVisualStyleBackColor = true;
            this.buttonDeleteVertexData.Click += new System.EventHandler(this.OnDeleteSelectedVertexComponent);
            // 
            // listBoxVertexData
            // 
            this.listBoxVertexData.FormattingEnabled = true;
            this.listBoxVertexData.ItemHeight = 15;
            this.listBoxVertexData.Items.AddRange(new object[] {
            "XYZ 位置",
            "法线",
            "切线空间基",
            "纹理坐标 #1",
            "纹理坐标 #2",
            "纹理坐标 #3",
            "纹理坐标 #4",
            "顶点颜色 #1",
            "顶点颜色 #2",
            "顶点颜色 #3",
            "顶点颜色 #4",
            "骨骼权重"});
            this.listBoxVertexData.Location = new System.Drawing.Point(21, 30);
            this.listBoxVertexData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxVertexData.Name = "listBoxVertexData";
            this.listBoxVertexData.Size = new System.Drawing.Size(239, 124);
            this.listBoxVertexData.TabIndex = 4;
            this.listBoxVertexData.SelectedValueChanged += new System.EventHandler(this.OnSelectedVertexComponentChanged);
            // 
            // button5
            // 
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(21, 273);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(205, 27);
            this.button5.TabIndex = 9;
            this.button5.Text = "将顶点颜色转换为纹理";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(21, 207);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(205, 27);
            this.button4.TabIndex = 8;
            this.button4.Text = "生成 UV 坐标";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(21, 173);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(205, 27);
            this.button3.TabIndex = 7;
            this.button3.Text = "计算切线空间";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(21, 240);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(205, 27);
            this.button2.TabIndex = 6;
            this.button2.Text = "计算法线";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.OnGenerateNormals);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.labelBoneCount);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.labelVertexCount);
            this.groupBox3.Controls.Add(this.labelFaceCount);
            this.groupBox3.Location = new System.Drawing.Point(20, 14);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox3.Size = new System.Drawing.Size(253, 77);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "统计信息";
            // 
            // labelBoneCount
            // 
            this.labelBoneCount.AutoSize = true;
            this.labelBoneCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelBoneCount.Location = new System.Drawing.Point(81, 48);
            this.labelBoneCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelBoneCount.Name = "labelBoneCount";
            this.labelBoneCount.Size = new System.Drawing.Size(141, 17);
            this.labelBoneCount.TabIndex = 12;
            this.labelBoneCount.Text = "<骨骼数量> 骨骼";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 48);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "骨骼:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 33);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "顶点:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "面:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button8);
            this.groupBox4.Controls.Add(this.button7);
            this.groupBox4.Controls.Add(this.buttonDeleteFaceData);
            this.groupBox4.Controls.Add(this.listBoxFaceData);
            this.groupBox4.Location = new System.Drawing.Point(20, 98);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox4.Size = new System.Drawing.Size(253, 230);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "面数据";
            // 
            // button8
            // 
            this.button8.Enabled = false;
            this.button8.Location = new System.Drawing.Point(21, 122);
            this.button8.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(205, 27);
            this.button8.TabIndex = 12;
            this.button8.Text = "转换为线框模式";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Enabled = false;
            this.button7.Location = new System.Drawing.Point(21, 156);
            this.button7.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(205, 27);
            this.button7.TabIndex = 11;
            this.button7.Text = "转换为点云模式";
            this.button7.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteFaceData
            // 
            this.buttonDeleteFaceData.Enabled = false;
            this.buttonDeleteFaceData.Image = ((System.Drawing.Image)(resources.GetObject("buttonDeleteFaceData.Image")));
            this.buttonDeleteFaceData.Location = new System.Drawing.Point(207, 27);
            this.buttonDeleteFaceData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonDeleteFaceData.Name = "buttonDeleteFaceData";
            this.buttonDeleteFaceData.Size = new System.Drawing.Size(35, 33);
            this.buttonDeleteFaceData.TabIndex = 11;
            this.buttonDeleteFaceData.UseVisualStyleBackColor = true;
            // 
            // listBoxFaceData
            // 
            this.listBoxFaceData.FormattingEnabled = true;
            this.listBoxFaceData.ItemHeight = 15;
            this.listBoxFaceData.Items.AddRange(new object[] {
            "点",
            "线",
            "三角形"});
            this.listBoxFaceData.Location = new System.Drawing.Point(21, 27);
            this.listBoxFaceData.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.listBoxFaceData.Name = "listBoxFaceData";
            this.listBoxFaceData.Size = new System.Drawing.Size(176, 64);
            this.listBoxFaceData.TabIndex = 5;
            // 
            // MeshDetailsDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(891, 344);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.Name = "MeshDetailsDialog";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "<网格名称> 详细信息";
            this.TopMost = true;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMaterial)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelVertexCount;
        private System.Windows.Forms.Label labelFaceCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBoneCount;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox pictureBoxMaterial;
        private System.Windows.Forms.Label labelMaterialName;
        private System.Windows.Forms.Button buttonDeleteVertexData;
        private System.Windows.Forms.ListBox listBoxVertexData;
        private System.Windows.Forms.ListBox listBoxFaceData;
        private System.Windows.Forms.Button buttonDeleteFaceData;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;



    }
}