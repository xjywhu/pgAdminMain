namespace pgAdminMain
{
    partial class MainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("DataBases");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("PostgreSQL11", new System.Windows.Forms.TreeNode[] {
            treeNode1});
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Servers", new System.Windows.Forms.TreeNode[] {
            treeNode2});
            this.contextMenuStripdb1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.creatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStripdb2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDropToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripsche = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.schemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStriptab = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStriptab2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.createToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.columnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteDropToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStripco = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteDropToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.alterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.treeView1 = new CCWin.SkinControl.SkinTreeView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.tabPage3 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage5 = new CCWin.SkinControl.SkinTabPage();
            this.tabPage6 = new CCWin.SkinControl.SkinTabPage();
            this.zhx_Background = new pgAdminMain.QueryBackground();
            this.info_Schema = new pgAdminMain.Info_schema();
            this.contextMenuStripdb1.SuspendLayout();
            this.contextMenuStripdb2.SuspendLayout();
            this.contextMenuStripsche.SuspendLayout();
            this.contextMenuStriptab.SuspendLayout();
            this.contextMenuStriptab2.SuspendLayout();
            this.contextMenuStripco.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripdb1
            // 
            this.contextMenuStripdb1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripdb1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStripdb1.Name = "contextMenuStrip1";
            this.contextMenuStripdb1.Size = new System.Drawing.Size(146, 52);
            // 
            // creatToolStripMenuItem
            // 
            this.creatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseToolStripMenuItem});
            this.creatToolStripMenuItem.Name = "creatToolStripMenuItem";
            this.creatToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.creatToolStripMenuItem.Text = "Creat";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(151, 26);
            this.dataBaseToolStripMenuItem.Text = "Database";
            this.dataBaseToolStripMenuItem.Click += new System.EventHandler(this.dataBaseToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(145, 24);
            this.refreshToolStripMenuItem.Text = "Refresh...";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem4_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1.png");
            this.imageList1.Images.SetKeyName(1, "2.png");
            this.imageList1.Images.SetKeyName(2, "3.png");
            this.imageList1.Images.SetKeyName(3, "4.png");
            this.imageList1.Images.SetKeyName(4, "5.png");
            this.imageList1.Images.SetKeyName(5, "6.png");
            this.imageList1.Images.SetKeyName(6, "7.png");
            // 
            // contextMenuStripdb2
            // 
            this.contextMenuStripdb2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripdb2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.deleteDropToolStripMenuItem,
            this.refreshToolStripMenuItem1});
            this.contextMenuStripdb2.Name = "contextMenuStripdb2";
            this.contextMenuStripdb2.Size = new System.Drawing.Size(170, 76);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // deleteDropToolStripMenuItem
            // 
            this.deleteDropToolStripMenuItem.Name = "deleteDropToolStripMenuItem";
            this.deleteDropToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.deleteDropToolStripMenuItem.Text = "Delete/Drop";
            this.deleteDropToolStripMenuItem.Click += new System.EventHandler(this.deleteDropToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(169, 24);
            this.refreshToolStripMenuItem1.Text = "Refresh...";
            this.refreshToolStripMenuItem1.Click += new System.EventHandler(this.refreshToolStripMenuItem4_Click);
            // 
            // contextMenuStripsche
            // 
            this.contextMenuStripsche.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripsche.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.refreshToolStripMenuItem2});
            this.contextMenuStripsche.Name = "contextMenuStripsche";
            this.contextMenuStripsche.Size = new System.Drawing.Size(146, 52);
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schemaToolStripMenuItem});
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(145, 24);
            this.createToolStripMenuItem1.Text = "Create";
            // 
            // schemaToolStripMenuItem
            // 
            this.schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            this.schemaToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.schemaToolStripMenuItem.Text = "Schema...";
            // 
            // refreshToolStripMenuItem2
            // 
            this.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2";
            this.refreshToolStripMenuItem2.Size = new System.Drawing.Size(145, 24);
            this.refreshToolStripMenuItem2.Text = "Refresh...";
            this.refreshToolStripMenuItem2.Click += new System.EventHandler(this.refreshToolStripMenuItem4_Click);
            // 
            // contextMenuStriptab
            // 
            this.contextMenuStriptab.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStriptab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2,
            this.refreshToolStripMenuItem3});
            this.contextMenuStriptab.Name = "contextMenuStriptab";
            this.contextMenuStriptab.ShowCheckMargin = true;
            this.contextMenuStriptab.Size = new System.Drawing.Size(233, 80);
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(232, 24);
            this.createToolStripMenuItem2.Text = "Create";
            this.createToolStripMenuItem2.Click += new System.EventHandler(this.createToolStripMenuItem2_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(216, 26);
            this.toolStripMenuItem1.Text = "Table";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem3
            // 
            this.refreshToolStripMenuItem3.Name = "refreshToolStripMenuItem3";
            this.refreshToolStripMenuItem3.Size = new System.Drawing.Size(232, 24);
            this.refreshToolStripMenuItem3.Text = "Refresh...";
            this.refreshToolStripMenuItem3.Click += new System.EventHandler(this.refreshToolStripMenuItem4_Click);
            // 
            // contextMenuStriptab2
            // 
            this.contextMenuStriptab2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStriptab2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem3,
            this.deleteDropToolStripMenuItem1,
            this.refreshToolStripMenuItem4});
            this.contextMenuStriptab2.Name = "contextMenuStriptab2";
            this.contextMenuStriptab2.Size = new System.Drawing.Size(170, 76);
            // 
            // createToolStripMenuItem3
            // 
            this.createToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnToolStripMenuItem});
            this.createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            this.createToolStripMenuItem3.Size = new System.Drawing.Size(169, 24);
            this.createToolStripMenuItem3.Text = "Create";
            // 
            // columnToolStripMenuItem
            // 
            this.columnToolStripMenuItem.Name = "columnToolStripMenuItem";
            this.columnToolStripMenuItem.Size = new System.Drawing.Size(138, 26);
            this.columnToolStripMenuItem.Text = "column";
            this.columnToolStripMenuItem.Click += new System.EventHandler(this.columnToolStripMenuItem_Click);
            // 
            // deleteDropToolStripMenuItem1
            // 
            this.deleteDropToolStripMenuItem1.Name = "deleteDropToolStripMenuItem1";
            this.deleteDropToolStripMenuItem1.Size = new System.Drawing.Size(169, 24);
            this.deleteDropToolStripMenuItem1.Text = "Delete/Drop";
            this.deleteDropToolStripMenuItem1.Click += new System.EventHandler(this.deleteDropToolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem4
            // 
            this.refreshToolStripMenuItem4.Name = "refreshToolStripMenuItem4";
            this.refreshToolStripMenuItem4.Size = new System.Drawing.Size(169, 24);
            this.refreshToolStripMenuItem4.Text = "Refresh";
            this.refreshToolStripMenuItem4.Click += new System.EventHandler(this.refreshToolStripMenuItem4_Click);
            // 
            // contextMenuStripco
            // 
            this.contextMenuStripco.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripco.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDropToolStripMenuItem2,
            this.refreshToolStripMenuItem5,
            this.alterToolStripMenuItem});
            this.contextMenuStripco.Name = "contextMenuStripco";
            this.contextMenuStripco.Size = new System.Drawing.Size(170, 76);
            // 
            // deleteDropToolStripMenuItem2
            // 
            this.deleteDropToolStripMenuItem2.Name = "deleteDropToolStripMenuItem2";
            this.deleteDropToolStripMenuItem2.Size = new System.Drawing.Size(169, 24);
            this.deleteDropToolStripMenuItem2.Text = "Delete/Drop";
            this.deleteDropToolStripMenuItem2.Click += new System.EventHandler(this.deleteDropToolStripMenuItem2_Click);
            // 
            // refreshToolStripMenuItem5
            // 
            this.refreshToolStripMenuItem5.Name = "refreshToolStripMenuItem5";
            this.refreshToolStripMenuItem5.Size = new System.Drawing.Size(169, 24);
            this.refreshToolStripMenuItem5.Text = "Refresh...";
            this.refreshToolStripMenuItem5.Click += new System.EventHandler(this.refreshToolStripMenuItem4_Click);
            // 
            // alterToolStripMenuItem
            // 
            this.alterToolStripMenuItem.Name = "alterToolStripMenuItem";
            this.alterToolStripMenuItem.Size = new System.Drawing.Size(169, 24);
            this.alterToolStripMenuItem.Text = "Alter";
            this.alterToolStripMenuItem.Click += new System.EventHandler(this.alterToolStripMenuItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.splitContainer1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 95);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1084, 534);
            this.panel2.TabIndex = 6;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1084, 534);
            this.splitContainer1.SplitterDistance = 365;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.Color.Silver;
            this.treeView1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.HideSelection = false;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Name = "treeView1";
            treeNode1.ContextMenuStrip = this.contextMenuStripdb1;
            treeNode1.ImageIndex = 2;
            treeNode1.Name = "DataBases";
            treeNode1.NodeFont = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Bold);
            treeNode1.SelectedImageKey = "3.png";
            treeNode1.Text = "DataBases";
            treeNode2.ImageIndex = 1;
            treeNode2.Name = "PostgreSQL11";
            treeNode2.NodeFont = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Bold);
            treeNode2.SelectedImageKey = "2.png";
            treeNode2.Text = "PostgreSQL11";
            treeNode3.ImageIndex = 0;
            treeNode3.Name = "Servers";
            treeNode3.NodeFont = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode3.SelectedImageKey = "1.png";
            treeNode3.Text = "Servers";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(365, 534);
            this.treeView1.TabIndex = 3;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(439, 76);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(597, 224);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.AnimationStart = true;
            this.tabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Font = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabControl1.HeadBack = null;
            this.tabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl1.ItemSize = new System.Drawing.Size(237, 36);
            this.tabControl1.ItemStretch = true;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowDown")));
            this.tabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowHover")));
            this.tabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseHover")));
            this.tabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseNormal")));
            this.tabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageDown")));
            this.tabControl1.PageHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageHover")));
            this.tabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabControl1.PageNorml = null;
            this.tabControl1.Radius = 30;
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(715, 534);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.zhx_Background);
            this.tabPage3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage3.Location = new System.Drawing.Point(0, 36);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(715, 498);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.TabItemImage = null;
            this.tabPage3.Text = "SQL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.info_Schema);
            this.tabPage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage5.Location = new System.Drawing.Point(0, 36);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(715, 498);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.TabItemImage = null;
            this.tabPage5.Text = "Information_Schema";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage6.Location = new System.Drawing.Point(0, 36);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(715, 498);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.TabItemImage = null;
            this.tabPage6.Text = "Dependents";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // zhx_Background
            // 
            this.zhx_Background.BackColor = System.Drawing.Color.Linen;
            this.zhx_Background.Dock = System.Windows.Forms.DockStyle.Fill;
            this.zhx_Background.Font = new System.Drawing.Font("华文新魏", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.zhx_Background.Location = new System.Drawing.Point(0, 0);
            this.zhx_Background.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.zhx_Background.Name = "zhx_Background";
            this.zhx_Background.Size = new System.Drawing.Size(715, 498);
            this.zhx_Background.TabIndex = 0;
            // 
            // info_Schema
            // 
            this.info_Schema.BackColor = System.Drawing.Color.Linen;
            this.info_Schema.Dock = System.Windows.Forms.DockStyle.Fill;
            this.info_Schema.Location = new System.Drawing.Point(0, 0);
            this.info_Schema.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.info_Schema.Name = "info_Schema";
            this.info_Schema.Size = new System.Drawing.Size(715, 498);
            this.info_Schema.TabIndex = 1;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CadetBlue;
            this.ClientSize = new System.Drawing.Size(1084, 629);
            this.Controls.Add(this.panel2);
            this.Name = "MainForm";
            this.Text = "pgAdmin";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.contextMenuStripdb1.ResumeLayout(false);
            this.contextMenuStripdb2.ResumeLayout(false);
            this.contextMenuStripsche.ResumeLayout(false);
            this.contextMenuStriptab.ResumeLayout(false);
            this.contextMenuStriptab2.ResumeLayout(false);
            this.contextMenuStripco.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private CCWin.SkinControl.SkinSplitContainer splitContainer1;
      //  public System.Windows.Forms.TreeView treeView1;
        //private System.Windows.Forms.TabControl tabControl1;
        private CCWin.SkinControl.SkinTabControl tabControl1;
        private CCWin.SkinControl.SkinTabPage tabPage3;
        private CCWin.SkinControl.SkinTabPage tabPage5;
        private CCWin.SkinControl.SkinTabPage tabPage6;
        public System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripdb1;
        private System.Windows.Forms.ToolStripMenuItem creatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dataBaseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripdb2;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDropToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem1;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripsche;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem schemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem2;
        public System.Windows.Forms.ContextMenuStrip contextMenuStriptab;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem3;
        public System.Windows.Forms.ContextMenuStrip contextMenuStriptab2;
        private System.Windows.Forms.ToolStripMenuItem createToolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem columnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteDropToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem4;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripco;
        private System.Windows.Forms.ToolStripMenuItem deleteDropToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem refreshToolStripMenuItem5;
        private QueryBackground zhx_Background;
        private Info_schema info_Schema;
       // private CCWin.SkinControl.SkinTreeView treeView11;
        public  CCWin.SkinControl.SkinTreeView treeView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.ToolStripMenuItem alterToolStripMenuItem;
    }
}

