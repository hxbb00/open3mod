﻿using System.Windows.Forms;
using OpenTK.Graphics;

namespace open3mod
{
    partial class MainWindow
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
            _ui.Dispose();
            _renderer.Dispose();

            if (disposing)
            {               
                if (components != null)
                {
                    components.Dispose();
                }
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemReload = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.recentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.wusonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jeepToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duckToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wustonAnimatedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lostEmpireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
            this.scaleOffsetSceneToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generateNormalsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItemView = new System.Windows.Forms.ToolStripMenuItem();
            this.fullViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.twoViewsHorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fourViewsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.wireframeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.texturedToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cullingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.framerateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.showBoundingBoxesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showNormalVectorsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showAnimationSkeletonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
            this.backgroundColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
            this.logViewerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSelectRenderer = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonUndo = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonRedo = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonFullView = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTwoViews = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonTwoViewsHor = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonFourViews = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonWireframe = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowTextures = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowShaded = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShowBB = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowNormals = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonCulling = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonShowSkeleton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShowFPS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonShowSettings = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabContextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllButThisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonTabClose = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.toolStripStatistics = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.directorySearcher1 = new System.DirectoryServices.DirectorySearcher();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBarBrightness = new System.Windows.Forms.TrackBar();
            this.glControl1 = new open3mod.RenderControl();
            this.menuStrip1.SuspendLayout();
            this.toolStripSelectRenderer.SuspendLayout();
            this.tabContextMenuStrip.SuspendLayout();
            this.statusStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.toolStripMenuItemView,
            this.toolsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1401, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.toolStripMenuItemReload,
            this.toolStripSeparator2,
            this.recentToolStripMenuItem,
            this.toolStripMenuItem4,
            this.toolStripSeparator3,
            this.quitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.fileToolStripMenuItem.Text = "文件";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.openToolStripMenuItem.Text = "打开";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OnFileMenuOpen);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.closeAllToolStripMenuItem.Text = "全部关闭";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.OnFileMenuCloseAll);
            // 
            // toolStripMenuItemReload
            // 
            this.toolStripMenuItemReload.Name = "toolStripMenuItemReload";
            this.toolStripMenuItemReload.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItemReload.Text = "重新加载";
            this.toolStripMenuItemReload.Click += new System.EventHandler(this.OnReloadCurrentTab);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // recentToolStripMenuItem
            // 
            this.recentToolStripMenuItem.Name = "recentToolStripMenuItem";
            this.recentToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.recentToolStripMenuItem.Text = "最近文件";
            this.recentToolStripMenuItem.Click += new System.EventHandler(this.OnFileMenuRecent);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wusonToolStripMenuItem,
            this.jeepToolStripMenuItem,
            this.duckToolStripMenuItem,
            this.wustonAnimatedToolStripMenuItem,
            this.lostEmpireToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(152, 26);
            this.toolStripMenuItem4.Text = "示例场景";
            // 
            // wusonToolStripMenuItem
            // 
            this.wusonToolStripMenuItem.Name = "wusonToolStripMenuItem";
            this.wusonToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.wusonToolStripMenuItem.Text = "蜘蛛";
            this.wusonToolStripMenuItem.Click += new System.EventHandler(this.wusonToolStripMenuItem_Click);
            // 
            // jeepToolStripMenuItem
            // 
            this.jeepToolStripMenuItem.Name = "jeepToolStripMenuItem";
            this.jeepToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.jeepToolStripMenuItem.Text = "吉普车";
            this.jeepToolStripMenuItem.Click += new System.EventHandler(this.jeepToolStripMenuItem_Click);
            // 
            // duckToolStripMenuItem
            // 
            this.duckToolStripMenuItem.Name = "duckToolStripMenuItem";
            this.duckToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.duckToolStripMenuItem.Text = "鸭子";
            this.duckToolStripMenuItem.Click += new System.EventHandler(this.duckToolStripMenuItem_Click);
            // 
            // wustonAnimatedToolStripMenuItem
            // 
            this.wustonAnimatedToolStripMenuItem.Name = "wustonAnimatedToolStripMenuItem";
            this.wustonAnimatedToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.wustonAnimatedToolStripMenuItem.Text = "蜘蛛（动画版）";
            this.wustonAnimatedToolStripMenuItem.Click += new System.EventHandler(this.wustonAnimatedToolStripMenuItem_Click);
            // 
            // lostEmpireToolStripMenuItem
            // 
            this.lostEmpireToolStripMenuItem.Name = "lostEmpireToolStripMenuItem";
            this.lostEmpireToolStripMenuItem.Size = new System.Drawing.Size(197, 26);
            this.lostEmpireToolStripMenuItem.Text = "失落帝国";
            this.lostEmpireToolStripMenuItem.Click += new System.EventHandler(this.lostEmpireToolStripMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(149, 6);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(152, 26);
            this.quitToolStripMenuItem.Text = "退出";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.OnFileMenuQuit);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator13,
            this.scaleOffsetSceneToolStripMenuItem,
            this.generateNormalsToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.editToolStripMenuItem.Text = "编辑";
            // 
            // undoToolStripMenuItem
            // 
            this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
            this.undoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.undoToolStripMenuItem.Text = "撤销";
            this.undoToolStripMenuItem.Click += new System.EventHandler(this.OnGlobalUndo);
            // 
            // redoToolStripMenuItem
            // 
            this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
            this.redoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.redoToolStripMenuItem.Text = "重做";
            this.redoToolStripMenuItem.Click += new System.EventHandler(this.OnGlobalRedo);
            // 
            // toolStripSeparator13
            // 
            this.toolStripSeparator13.Name = "toolStripSeparator13";
            this.toolStripSeparator13.Size = new System.Drawing.Size(221, 6);
            // 
            // scaleOffsetSceneToolStripMenuItem
            // 
            this.scaleOffsetSceneToolStripMenuItem.Enabled = false;
            this.scaleOffsetSceneToolStripMenuItem.Name = "scaleOffsetSceneToolStripMenuItem";
            this.scaleOffsetSceneToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.scaleOffsetSceneToolStripMenuItem.Text = "自适应缩放";
            // 
            // generateNormalsToolStripMenuItem
            // 
            this.generateNormalsToolStripMenuItem.Name = "generateNormalsToolStripMenuItem";
            this.generateNormalsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.generateNormalsToolStripMenuItem.Text = "生成法线";
            this.generateNormalsToolStripMenuItem.Click += new System.EventHandler(this.OnGenerateNormals);
            // 
            // toolStripMenuItemView
            // 
            this.toolStripMenuItemView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fullViewToolStripMenuItem,
            this.twoViewsToolStripMenuItem,
            this.twoViewsHorToolStripMenuItem,
            this.fourViewsToolStripMenuItem,
            this.toolStripSeparator6,
            this.wireframeToolStripMenuItem,
            this.texturedToolStripMenuItem,
            this.lightingToolStripMenuItem,
            this.cullingToolStripMenuItem,
            this.framerateToolStripMenuItem,
            this.toolStripSeparator7,
            this.showBoundingBoxesToolStripMenuItem,
            this.showNormalVectorsToolStripMenuItem,
            this.showAnimationSkeletonToolStripMenuItem,
            this.toolStripSeparator14,
            this.backgroundColorToolStripMenuItem,
            this.resetBackgroundToolStripMenuItem});
            this.toolStripMenuItemView.Name = "toolStripMenuItemView";
            this.toolStripMenuItemView.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItemView.Text = "视图";
            // 
            // fullViewToolStripMenuItem
            // 
            this.fullViewToolStripMenuItem.CheckOnClick = true;
            this.fullViewToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fullViewToolStripMenuItem.Image")));
            this.fullViewToolStripMenuItem.Name = "fullViewToolStripMenuItem";
            this.fullViewToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.fullViewToolStripMenuItem.Text = "单 3D 视图";
            this.fullViewToolStripMenuItem.Click += new System.EventHandler(this.ToggleFullView);
            // 
            // twoViewsToolStripMenuItem
            // 
            this.twoViewsToolStripMenuItem.CheckOnClick = true;
            this.twoViewsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("twoViewsToolStripMenuItem.Image")));
            this.twoViewsToolStripMenuItem.Name = "twoViewsToolStripMenuItem";
            this.twoViewsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.twoViewsToolStripMenuItem.Text = "双 3D 视图（垂直）";
            this.twoViewsToolStripMenuItem.Click += new System.EventHandler(this.ToggleTwoViews);
            // 
            // twoViewsHorToolStripMenuItem
            // 
            this.twoViewsHorToolStripMenuItem.CheckOnClick = true;
            this.twoViewsHorToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("twoViewsHorToolStripMenuItem.Image")));
            this.twoViewsHorToolStripMenuItem.Name = "twoViewsHorToolStripMenuItem";
            this.twoViewsHorToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.twoViewsHorToolStripMenuItem.Text = "双 3D 视图（水平）";
            this.twoViewsHorToolStripMenuItem.Click += new System.EventHandler(this.ToggleTwoViewsHorizontal);
            // 
            // fourViewsToolStripMenuItem
            // 
            this.fourViewsToolStripMenuItem.CheckOnClick = true;
            this.fourViewsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fourViewsToolStripMenuItem.Image")));
            this.fourViewsToolStripMenuItem.Name = "fourViewsToolStripMenuItem";
            this.fourViewsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.fourViewsToolStripMenuItem.Text = "四 3D 视图";
            this.fourViewsToolStripMenuItem.Click += new System.EventHandler(this.ToggleFourViews);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(222, 6);
            // 
            // wireframeToolStripMenuItem
            // 
            this.wireframeToolStripMenuItem.CheckOnClick = true;
            this.wireframeToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("wireframeToolStripMenuItem.Image")));
            this.wireframeToolStripMenuItem.Name = "wireframeToolStripMenuItem";
            this.wireframeToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.wireframeToolStripMenuItem.Text = "线框模式";
            this.wireframeToolStripMenuItem.Click += new System.EventHandler(this.ToggleWireframe);
            // 
            // texturedToolStripMenuItem
            // 
            this.texturedToolStripMenuItem.CheckOnClick = true;
            this.texturedToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("texturedToolStripMenuItem.Image")));
            this.texturedToolStripMenuItem.Name = "texturedToolStripMenuItem";
            this.texturedToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.texturedToolStripMenuItem.Text = "纹理模式";
            this.texturedToolStripMenuItem.Click += new System.EventHandler(this.ToggleTextures);
            // 
            // lightingToolStripMenuItem
            // 
            this.lightingToolStripMenuItem.CheckOnClick = true;
            this.lightingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("lightingToolStripMenuItem.Image")));
            this.lightingToolStripMenuItem.Name = "lightingToolStripMenuItem";
            this.lightingToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.lightingToolStripMenuItem.Text = "光照模式";
            this.lightingToolStripMenuItem.Click += new System.EventHandler(this.ToggleShading);
            // 
            // cullingToolStripMenuItem
            // 
            this.cullingToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cullingToolStripMenuItem.Image")));
            this.cullingToolStripMenuItem.Name = "cullingToolStripMenuItem";
            this.cullingToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.cullingToolStripMenuItem.Text = "背面剔除";
            this.cullingToolStripMenuItem.Click += new System.EventHandler(this.ToggleCulling);
            // 
            // framerateToolStripMenuItem
            // 
            this.framerateToolStripMenuItem.CheckOnClick = true;
            this.framerateToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("framerateToolStripMenuItem.Image")));
            this.framerateToolStripMenuItem.Name = "framerateToolStripMenuItem";
            this.framerateToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.framerateToolStripMenuItem.Text = "显示帧率";
            this.framerateToolStripMenuItem.Click += new System.EventHandler(this.ToggleFps);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(222, 6);
            // 
            // showBoundingBoxesToolStripMenuItem
            // 
            this.showBoundingBoxesToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showBoundingBoxesToolStripMenuItem.Image")));
            this.showBoundingBoxesToolStripMenuItem.Name = "showBoundingBoxesToolStripMenuItem";
            this.showBoundingBoxesToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.showBoundingBoxesToolStripMenuItem.Text = "显示边界框";
            this.showBoundingBoxesToolStripMenuItem.Click += new System.EventHandler(this.ToggleShowBb);
            // 
            // showNormalVectorsToolStripMenuItem
            // 
            this.showNormalVectorsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showNormalVectorsToolStripMenuItem.Image")));
            this.showNormalVectorsToolStripMenuItem.Name = "showNormalVectorsToolStripMenuItem";
            this.showNormalVectorsToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.showNormalVectorsToolStripMenuItem.Text = "显示法线向量";
            this.showNormalVectorsToolStripMenuItem.Click += new System.EventHandler(this.ToggleShowNormals);
            // 
            // showAnimationSkeletonToolStripMenuItem
            // 
            this.showAnimationSkeletonToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("showAnimationSkeletonToolStripMenuItem.Image")));
            this.showAnimationSkeletonToolStripMenuItem.Name = "showAnimationSkeletonToolStripMenuItem";
            this.showAnimationSkeletonToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.showAnimationSkeletonToolStripMenuItem.Text = "显示动画骨骼";
            this.showAnimationSkeletonToolStripMenuItem.Click += new System.EventHandler(this.ToggleShowSkeleton);
            // 
            // toolStripSeparator14
            // 
            this.toolStripSeparator14.Name = "toolStripSeparator14";
            this.toolStripSeparator14.Size = new System.Drawing.Size(222, 6);
            // 
            // backgroundColorToolStripMenuItem
            // 
            this.backgroundColorToolStripMenuItem.Name = "backgroundColorToolStripMenuItem";
            this.backgroundColorToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.backgroundColorToolStripMenuItem.Text = "背景颜色";
            this.backgroundColorToolStripMenuItem.Click += new System.EventHandler(this.OnChangeBackgroundColor);
            // 
            // resetBackgroundToolStripMenuItem
            // 
            this.resetBackgroundToolStripMenuItem.Name = "resetBackgroundToolStripMenuItem";
            this.resetBackgroundToolStripMenuItem.Size = new System.Drawing.Size(225, 26);
            this.resetBackgroundToolStripMenuItem.Text = "重置背景";
            this.resetBackgroundToolStripMenuItem.Click += new System.EventHandler(this.OnResetBackground);
            // 
            // toolsToolStripMenuItem
            // 
            this.toolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripSeparator11,
            this.logViewerToolStripMenuItem,
            this.exportToolStripMenuItem,
            this.exportAllToolStripMenuItem,
            this.toolStripSeparator8,
            this.optionsToolStripMenuItem});
            this.toolsToolStripMenuItem.Name = "toolsToolStripMenuItem";
            this.toolsToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.toolsToolStripMenuItem.Text = "工具";
            this.toolsToolStripMenuItem.Click += new System.EventHandler(this.ToolsToolStripMenuItemClick);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem3.Text = "设置文件关联";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.OnSetFileAssociations);
            // 
            // toolStripSeparator11
            // 
            this.toolStripSeparator11.Name = "toolStripSeparator11";
            this.toolStripSeparator11.Size = new System.Drawing.Size(221, 6);
            // 
            // logViewerToolStripMenuItem
            // 
            this.logViewerToolStripMenuItem.Name = "logViewerToolStripMenuItem";
            this.logViewerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.logViewerToolStripMenuItem.Text = "日志查看器";
            this.logViewerToolStripMenuItem.Click += new System.EventHandler(this.OnShowLogViewer);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportToolStripMenuItem.Text = "导出";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.OnExport);
            // 
            // exportAllToolStripMenuItem
            // 
            this.exportAllToolStripMenuItem.Enabled = false;
            this.exportAllToolStripMenuItem.Name = "exportAllToolStripMenuItem";
            this.exportAllToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.exportAllToolStripMenuItem.Text = "全部导出";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(221, 6);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.optionsToolStripMenuItem.Text = "选项";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.OnShowSettings);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem2,
            this.toolStripSeparator10,
            this.aboutToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(53, 24);
            this.toolStripMenuItem1.Text = "帮助";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(224, 26);
            this.toolStripMenuItem2.Text = "每日小贴士";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.OnTipOfTheDay);
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(221, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aboutToolStripMenuItem.Text = "关于";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItemClick);
            // 
            // toolStripSelectRenderer
            // 
            this.toolStripSelectRenderer.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStripSelectRenderer.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton,
            this.toolStripSeparator12,
            this.toolStripButtonUndo,
            this.toolStripButtonRedo,
            this.toolStripSeparator4,
            this.toolStripButtonFullView,
            this.toolStripButtonTwoViews,
            this.toolStripButtonTwoViewsHor,
            this.toolStripButtonFourViews,
            this.toolStripSeparator,
            this.toolStripButtonWireframe,
            this.toolStripButtonShowTextures,
            this.toolStripButtonShowShaded,
            this.toolStripSeparator1,
            this.toolStripButtonShowBB,
            this.toolStripButtonShowNormals,
            this.toolStripButtonCulling,
            this.toolStripButtonShowSkeleton,
            this.toolStripSeparator5,
            this.toolStripButtonShowFPS,
            this.toolStripSeparator9,
            this.toolStripButtonShowSettings});
            this.toolStripSelectRenderer.Location = new System.Drawing.Point(0, 28);
            this.toolStripSelectRenderer.Name = "toolStripSelectRenderer";
            this.toolStripSelectRenderer.Size = new System.Drawing.Size(1401, 27);
            this.toolStripSelectRenderer.TabIndex = 2;
            this.toolStripSelectRenderer.Text = "toolStrip1";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(29, 24);
            this.openToolStripButton.Text = "打开";
            this.openToolStripButton.ToolTipText = "打开3D文件";
            this.openToolStripButton.Click += new System.EventHandler(this.OnFileMenuOpen);
            // 
            // toolStripSeparator12
            // 
            this.toolStripSeparator12.Name = "toolStripSeparator12";
            this.toolStripSeparator12.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonUndo
            // 
            this.toolStripButtonUndo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonUndo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonUndo.Image")));
            this.toolStripButtonUndo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonUndo.Name = "toolStripButtonUndo";
            this.toolStripButtonUndo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonUndo.Text = "撤销";
            this.toolStripButtonUndo.Click += new System.EventHandler(this.OnGlobalUndo);
            // 
            // toolStripButtonRedo
            // 
            this.toolStripButtonRedo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonRedo.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonRedo.Image")));
            this.toolStripButtonRedo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonRedo.Name = "toolStripButtonRedo";
            this.toolStripButtonRedo.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonRedo.Text = "重做";
            this.toolStripButtonRedo.Click += new System.EventHandler(this.OnGlobalRedo);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonFullView
            // 
            this.toolStripButtonFullView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFullView.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFullView.Image")));
            this.toolStripButtonFullView.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFullView.Name = "toolStripButtonFullView";
            this.toolStripButtonFullView.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonFullView.Text = "单 3D 视图";
            this.toolStripButtonFullView.ToolTipText = "单 3D 视图";
            this.toolStripButtonFullView.Click += new System.EventHandler(this.ToggleFullView);
            // 
            // toolStripButtonTwoViews
            // 
            this.toolStripButtonTwoViews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTwoViews.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTwoViews.Image")));
            this.toolStripButtonTwoViews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTwoViews.Name = "toolStripButtonTwoViews";
            this.toolStripButtonTwoViews.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonTwoViews.Text = "双 3D 视图（垂直）";
            this.toolStripButtonTwoViews.ToolTipText = "双 3D 视图（垂直）";
            this.toolStripButtonTwoViews.Click += new System.EventHandler(this.ToggleTwoViews);
            // 
            // toolStripButtonTwoViewsHor
            // 
            this.toolStripButtonTwoViewsHor.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonTwoViewsHor.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonTwoViewsHor.Image")));
            this.toolStripButtonTwoViewsHor.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonTwoViewsHor.Name = "toolStripButtonTwoViewsHor";
            this.toolStripButtonTwoViewsHor.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonTwoViewsHor.Text = "双 3D 视图（水平）";
            this.toolStripButtonTwoViewsHor.ToolTipText = "双 3D 视图（水平）";
            this.toolStripButtonTwoViewsHor.Click += new System.EventHandler(this.ToggleTwoViewsHorizontal);
            // 
            // toolStripButtonFourViews
            // 
            this.toolStripButtonFourViews.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonFourViews.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonFourViews.Image")));
            this.toolStripButtonFourViews.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonFourViews.Name = "toolStripButtonFourViews";
            this.toolStripButtonFourViews.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonFourViews.Text = "四 3D 视图";
            this.toolStripButtonFourViews.ToolTipText = "四 3D 视图";
            this.toolStripButtonFourViews.Click += new System.EventHandler(this.ToggleFourViews);
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonWireframe
            // 
            this.toolStripButtonWireframe.CheckOnClick = true;
            this.toolStripButtonWireframe.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonWireframe.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonWireframe.Image")));
            this.toolStripButtonWireframe.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonWireframe.Name = "toolStripButtonWireframe";
            this.toolStripButtonWireframe.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonWireframe.Text = "线框模式";
            this.toolStripButtonWireframe.ToolTipText = "线框模式";
            this.toolStripButtonWireframe.Click += new System.EventHandler(this.ToggleWireframe);
            // 
            // toolStripButtonShowTextures
            // 
            this.toolStripButtonShowTextures.CheckOnClick = true;
            this.toolStripButtonShowTextures.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowTextures.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowTextures.Image")));
            this.toolStripButtonShowTextures.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowTextures.Name = "toolStripButtonShowTextures";
            this.toolStripButtonShowTextures.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowTextures.Text = "纹理模式";
            this.toolStripButtonShowTextures.ToolTipText = "纹理模式";
            this.toolStripButtonShowTextures.Click += new System.EventHandler(this.ToggleTextures);
            // 
            // toolStripButtonShowShaded
            // 
            this.toolStripButtonShowShaded.CheckOnClick = true;
            this.toolStripButtonShowShaded.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowShaded.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowShaded.Image")));
            this.toolStripButtonShowShaded.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowShaded.Name = "toolStripButtonShowShaded";
            this.toolStripButtonShowShaded.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowShaded.Text = "光照模式";
            this.toolStripButtonShowShaded.ToolTipText = "光照模式";
            this.toolStripButtonShowShaded.Click += new System.EventHandler(this.ToggleShading);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonShowBB
            // 
            this.toolStripButtonShowBB.CheckOnClick = true;
            this.toolStripButtonShowBB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowBB.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowBB.Image")));
            this.toolStripButtonShowBB.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowBB.Name = "toolStripButtonShowBB";
            this.toolStripButtonShowBB.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowBB.Text = "显示边界框";
            this.toolStripButtonShowBB.ToolTipText = "显示边界框";
            this.toolStripButtonShowBB.Click += new System.EventHandler(this.ToggleShowBb);
            // 
            // toolStripButtonShowNormals
            // 
            this.toolStripButtonShowNormals.CheckOnClick = true;
            this.toolStripButtonShowNormals.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowNormals.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowNormals.Image")));
            this.toolStripButtonShowNormals.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowNormals.Name = "toolStripButtonShowNormals";
            this.toolStripButtonShowNormals.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowNormals.Text = "显示法线向量";
            this.toolStripButtonShowNormals.ToolTipText = "显示法线向量";
            this.toolStripButtonShowNormals.Click += new System.EventHandler(this.ToggleShowNormals);
            // 
            // toolStripButtonCulling
            // 
            this.toolStripButtonCulling.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonCulling.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonCulling.Image")));
            this.toolStripButtonCulling.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonCulling.Name = "toolStripButtonCulling";
            this.toolStripButtonCulling.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonCulling.Text = "背面剔除";
            this.toolStripButtonCulling.ToolTipText = "背面剔除";
            this.toolStripButtonCulling.Click += new System.EventHandler(this.ToggleCulling);
            // 
            // toolStripButtonShowSkeleton
            // 
            this.toolStripButtonShowSkeleton.CheckOnClick = true;
            this.toolStripButtonShowSkeleton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowSkeleton.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowSkeleton.Image")));
            this.toolStripButtonShowSkeleton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowSkeleton.Name = "toolStripButtonShowSkeleton";
            this.toolStripButtonShowSkeleton.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowSkeleton.Text = "显示动画骨骼";
            this.toolStripButtonShowSkeleton.ToolTipText = "显示动画骨骼";
            this.toolStripButtonShowSkeleton.Click += new System.EventHandler(this.ToggleShowSkeleton);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonShowFPS
            // 
            this.toolStripButtonShowFPS.CheckOnClick = true;
            this.toolStripButtonShowFPS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowFPS.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowFPS.Image")));
            this.toolStripButtonShowFPS.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowFPS.Name = "toolStripButtonShowFPS";
            this.toolStripButtonShowFPS.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowFPS.Text = "显示帧率 (FPS)";
            this.toolStripButtonShowFPS.ToolTipText = "显示帧率 (FPS)";
            this.toolStripButtonShowFPS.Click += new System.EventHandler(this.ToggleFps);
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripButtonShowSettings
            // 
            this.toolStripButtonShowSettings.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButtonShowSettings.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButtonShowSettings.Image")));
            this.toolStripButtonShowSettings.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButtonShowSettings.Name = "toolStripButtonShowSettings";
            this.toolStripButtonShowSettings.Size = new System.Drawing.Size(29, 24);
            this.toolStripButtonShowSettings.Text = "设置";
            this.toolStripButtonShowSettings.ToolTipText = "设置";
            this.toolStripButtonShowSettings.Click += new System.EventHandler(this.OnShowSettings);
            // 
            // tabControl1
            // 
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 55);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1401, 766);
            this.tabControl1.TabIndex = 3;
            this.tabControl1.Selected += new System.Windows.Forms.TabControlEventHandler(this.OnTabSelected);
            this.tabControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnShowTabContextMenu);
            // 
            // tabContextMenuStrip
            // 
            this.tabContextMenuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.tabContextMenuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.closeToolStripMenuItem,
            this.closeAllButThisToolStripMenuItem});
            this.tabContextMenuStrip.Name = "tabContextMenuStrip";
            this.tabContextMenuStrip.Size = new System.Drawing.Size(139, 52);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.closeToolStripMenuItem.Text = "关闭";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.OnCloseTabFromContextMenu);
            // 
            // closeAllButThisToolStripMenuItem
            // 
            this.closeAllButThisToolStripMenuItem.Name = "closeAllButThisToolStripMenuItem";
            this.closeAllButThisToolStripMenuItem.Size = new System.Drawing.Size(138, 24);
            this.closeAllButThisToolStripMenuItem.Text = "关闭其他";
            this.closeAllButThisToolStripMenuItem.Click += new System.EventHandler(this.OnCloseAllTabsButThisFromContextMenu);
            // 
            // buttonTabClose
            // 
            this.buttonTabClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonTabClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.buttonTabClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTabClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonTabClose.Location = new System.Drawing.Point(1344, 37);
            this.buttonTabClose.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.buttonTabClose.Name = "buttonTabClose";
            this.buttonTabClose.Size = new System.Drawing.Size(37, 28);
            this.buttonTabClose.TabIndex = 4;
            this.buttonTabClose.Text = "X";
            this.buttonTabClose.UseVisualStyleBackColor = true;
            this.buttonTabClose.Click += new System.EventHandler(this.OnCloseTab);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "3D 模型文件|*.3ds;*.obj;*.fbx;*.dae;*.blend;*.x|所有文件|*.*";
            this.openFileDialog.Multiselect = true;
            // 
            // toolStripStatistics
            // 
            this.toolStripStatistics.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripStatistics.Name = "toolStripStatistics";
            this.toolStripStatistics.Size = new System.Drawing.Size(0, 20);
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatistics,
            this.toolStripStatusLabel1});
            this.statusStrip.Location = new System.Drawing.Point(0, 821);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip.Size = new System.Drawing.Size(1401, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackColor = System.Drawing.Color.Transparent;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(167, 20);
            this.toolStripStatusLabel1.Text = "| 按住鼠标右键移动光源";
            // 
            // directorySearcher1
            // 
            this.directorySearcher1.ClientTimeout = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerPageTimeLimit = System.TimeSpan.Parse("-00:00:01");
            this.directorySearcher1.ServerTimeLimit = System.TimeSpan.Parse("-00:00:01");
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Location = new System.Drawing.Point(1075, 823);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "亮度";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarBrightness
            // 
            this.trackBarBrightness.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.trackBarBrightness.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.trackBarBrightness.DataBindings.Add(new System.Windows.Forms.Binding("Value", global::open3mod.GraphicsSettings.Default, "OutputBrightness", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.trackBarBrightness.Location = new System.Drawing.Point(1151, 823);
            this.trackBarBrightness.Margin = new System.Windows.Forms.Padding(0);
            this.trackBarBrightness.Maximum = 100;
            this.trackBarBrightness.Name = "trackBarBrightness";
            this.trackBarBrightness.Size = new System.Drawing.Size(251, 56);
            this.trackBarBrightness.TabIndex = 6;
            this.trackBarBrightness.Value = global::open3mod.GraphicsSettings.Default.OutputBrightness;
            // 
            // glControl1
            // 
            this.glControl1.AllowDrop = true;
            this.glControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.glControl1.BackColor = System.Drawing.Color.Black;
            this.glControl1.Location = new System.Drawing.Point(236, 81);
            this.glControl1.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.glControl1.Name = "glControl1";
            this.glControl1.Size = new System.Drawing.Size(989, 722);
            this.glControl1.TabIndex = 0;
            this.glControl1.VSync = true;
            this.glControl1.Load += new System.EventHandler(this.OnGlLoad);
            this.glControl1.DragDrop += new System.Windows.Forms.DragEventHandler(this.OnDrag);
            this.glControl1.DragEnter += new System.Windows.Forms.DragEventHandler(this.OnDragEnter);
            this.glControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.GlPaint);
            this.glControl1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OnKeyDown);
            this.glControl1.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnKeyUp);
            this.glControl1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.OnMouseDown);
            this.glControl1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.OnMouseDoubleClick);
            this.glControl1.MouseEnter += new System.EventHandler(this.OnMouseEnter);
            this.glControl1.MouseLeave += new System.EventHandler(this.OnMouseLeave);
            this.glControl1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.OnMouseMove);
            this.glControl1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.OnMouseUp);
            this.glControl1.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.OnPreviewKeyDown);
            this.glControl1.Resize += new System.EventHandler(this.OnGlResize);
            // 
            // MainWindow
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1401, 847);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarBrightness);
            this.Controls.Add(this.buttonTabClose);
            this.Controls.Add(this.glControl1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.toolStripSelectRenderer);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MinimumSize = new System.Drawing.Size(1061, 685);
            this.Name = "MainWindow";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "3D模型查看器";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.OnCloseForm);
            this.Load += new System.EventHandler(this.OnLoad);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStripSelectRenderer.ResumeLayout(false);
            this.toolStripSelectRenderer.PerformLayout();
            this.tabContextMenuStrip.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarBrightness)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStrip toolStripSelectRenderer;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem recentToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemView;
        private System.Windows.Forms.ToolStripMenuItem fullViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripButton toolStripButtonWireframe;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowTextures;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowShaded;
        private System.Windows.Forms.ToolStripButton toolStripButtonShowFPS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripButton toolStripButtonFullView;
        private System.Windows.Forms.ToolStripButton toolStripButtonTwoViewsHor;
        private System.Windows.Forms.ToolStripButton toolStripButtonFourViews;
        private System.Windows.Forms.ToolStripMenuItem logViewerToolStripMenuItem;
        private RenderControl glControl1;
        private TabControl tabControl1;
        private ContextMenuStrip tabContextMenuStrip;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem closeAllButThisToolStripMenuItem;
        private Button buttonTabClose;
        private OpenFileDialog openFileDialog;
        private ToolStripButton toolStripButtonShowBB;
        private ToolStripButton toolStripButtonShowNormals;
        private ToolStripButton toolStripButtonShowSkeleton;
        private ToolStripSeparator toolStripSeparator5;
        private ToolStripButton toolStripButtonShowSettings;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportAllToolStripMenuItem;
        private ToolStripStatusLabel toolStripStatistics;
        private StatusStrip statusStrip;
        private ToolStripMenuItem twoViewsHorToolStripMenuItem;
        private ToolStripMenuItem fourViewsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator6;
        private ToolStripMenuItem wireframeToolStripMenuItem;
        private ToolStripMenuItem texturedToolStripMenuItem;
        private ToolStripMenuItem lightingToolStripMenuItem;
        private ToolStripMenuItem framerateToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator7;
        private ToolStripMenuItem showBoundingBoxesToolStripMenuItem;
        private ToolStripMenuItem showNormalVectorsToolStripMenuItem;
        private ToolStripMenuItem showAnimationSkeletonToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator8;
        private ToolStripMenuItem optionsToolStripMenuItem;
        private System.DirectoryServices.DirectorySearcher directorySearcher1;
        private ColorDialog colorDialog1;
        private ToolStripSeparator toolStripSeparator9;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripSeparator toolStripSeparator10;
        private ToolStripMenuItem toolStripMenuItem3;
        private ToolStripSeparator toolStripSeparator11;
        private TrackBar trackBarBrightness;
        private Label label1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private ToolStripMenuItem toolStripMenuItem4;
        private ToolStripMenuItem wusonToolStripMenuItem;
        private ToolStripMenuItem wustonAnimatedToolStripMenuItem;
        private ToolStripMenuItem lostEmpireToolStripMenuItem;
        private ToolStripMenuItem jeepToolStripMenuItem;
        private ToolStripMenuItem duckToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator12;
        private ToolStripButton toolStripButtonRedo;
        private ToolStripButton toolStripButtonUndo;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem undoToolStripMenuItem;
        private ToolStripMenuItem redoToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItemReload;
        private ToolStripSeparator toolStripSeparator13;
        private ToolStripMenuItem scaleOffsetSceneToolStripMenuItem;
        private ToolStripMenuItem generateNormalsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator14;
        private ToolStripMenuItem backgroundColorToolStripMenuItem;
        private ToolStripMenuItem resetBackgroundToolStripMenuItem;
        private ToolStripButton toolStripButtonTwoViews;
        private ToolStripMenuItem twoViewsToolStripMenuItem;
        private ToolStripButton toolStripButtonCulling;
        private ToolStripMenuItem cullingToolStripMenuItem;
    }
}

