namespace pgAdminMain
{
    partial class Form1
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("DataBases");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("PostgreSQL11", new System.Windows.Forms.TreeNode[] {
            treeNode4});
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Servers", new System.Windows.Forms.TreeNode[] {
            treeNode5});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStripdb1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.creatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataBaseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
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
            this.contextMenuStripdb1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.contextMenuStripdb2.SuspendLayout();
            this.contextMenuStripsche.SuspendLayout();
            this.contextMenuStriptab.SuspendLayout();
            this.contextMenuStriptab2.SuspendLayout();
            this.contextMenuStripco.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStripdb1
            // 
            this.contextMenuStripdb1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripdb1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creatToolStripMenuItem,
            this.refreshToolStripMenuItem});
            this.contextMenuStripdb1.Name = "contextMenuStrip1";
            this.contextMenuStripdb1.Size = new System.Drawing.Size(157, 60);
            // 
            // creatToolStripMenuItem
            // 
            this.creatToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dataBaseToolStripMenuItem});
            this.creatToolStripMenuItem.Name = "creatToolStripMenuItem";
            this.creatToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.creatToolStripMenuItem.Text = "Creat";
            // 
            // dataBaseToolStripMenuItem
            // 
            this.dataBaseToolStripMenuItem.Name = "dataBaseToolStripMenuItem";
            this.dataBaseToolStripMenuItem.Size = new System.Drawing.Size(173, 30);
            this.dataBaseToolStripMenuItem.Text = "Database";
            this.dataBaseToolStripMenuItem.Click += new System.EventHandler(this.dataBaseToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem
            // 
            this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
            this.refreshToolStripMenuItem.Size = new System.Drawing.Size(156, 28);
            this.refreshToolStripMenuItem.Text = "Refresh...";
            this.refreshToolStripMenuItem.Click += new System.EventHandler(this.refreshToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.splitContainer1.Panel1.Controls.Add(this.treeView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1220, 755);
            this.splitContainer1.SplitterDistance = 492;
            this.splitContainer1.TabIndex = 1;
            // 
            // treeView1
            // 
            this.treeView1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.treeView1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Default;
            this.treeView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.treeView1.Name = "treeView1";
            treeNode4.ContextMenuStrip = this.contextMenuStripdb1;
            treeNode4.ImageIndex = 2;
            treeNode4.Name = "DataBases";
            treeNode4.NodeFont = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode4.SelectedImageKey = "3.png";
            treeNode4.Text = "DataBases";
            treeNode5.ImageIndex = 1;
            treeNode5.Name = "PostgreSQL11";
            treeNode5.NodeFont = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode5.SelectedImageKey = "2.png";
            treeNode5.Text = "PostgreSQL11";
            treeNode6.ImageIndex = 0;
            treeNode6.Name = "Servers";
            treeNode6.NodeFont = new System.Drawing.Font("幼圆", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            treeNode6.SelectedImageKey = "1.png";
            treeNode6.Text = "Servers";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(492, 755);
            this.treeView1.TabIndex = 1;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect_2);
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
            this.imageList1.Images.SetKeyName(7, "8.png");
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Controls.Add(this.tabPage6);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(724, 755);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 28);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage1.Size = new System.Drawing.Size(716, 723);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dashboard";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 28);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage2.Size = new System.Drawing.Size(716, 723);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Properties";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 28);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(716, 723);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "SQL";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 28);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(716, 723);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Statistics";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 28);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(716, 723);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Dependencies";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 28);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(716, 723);
            this.tabPage6.TabIndex = 5;
            this.tabPage6.Text = "Dependents";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // contextMenuStripdb2
            // 
            this.contextMenuStripdb2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripdb2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem,
            this.deleteDropToolStripMenuItem,
            this.refreshToolStripMenuItem1});
            this.contextMenuStripdb2.Name = "contextMenuStripdb2";
            this.contextMenuStripdb2.Size = new System.Drawing.Size(189, 88);
            this.contextMenuStripdb2.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripdb2_Opening);
            // 
            // createToolStripMenuItem
            // 
            this.createToolStripMenuItem.Name = "createToolStripMenuItem";
            this.createToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.createToolStripMenuItem.Text = "Create";
            // 
            // deleteDropToolStripMenuItem
            // 
            this.deleteDropToolStripMenuItem.Name = "deleteDropToolStripMenuItem";
            this.deleteDropToolStripMenuItem.Size = new System.Drawing.Size(188, 28);
            this.deleteDropToolStripMenuItem.Text = "Delete/Drop";
            this.deleteDropToolStripMenuItem.Click += new System.EventHandler(this.deleteDropToolStripMenuItem_Click);
            // 
            // refreshToolStripMenuItem1
            // 
            this.refreshToolStripMenuItem1.Name = "refreshToolStripMenuItem1";
            this.refreshToolStripMenuItem1.Size = new System.Drawing.Size(188, 28);
            this.refreshToolStripMenuItem1.Text = "Refresh...";
            // 
            // contextMenuStripsche
            // 
            this.contextMenuStripsche.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripsche.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem1,
            this.refreshToolStripMenuItem2});
            this.contextMenuStripsche.Name = "contextMenuStripsche";
            this.contextMenuStripsche.Size = new System.Drawing.Size(157, 60);
            this.contextMenuStripsche.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripsche_Opening);
            // 
            // createToolStripMenuItem1
            // 
            this.createToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.schemaToolStripMenuItem});
            this.createToolStripMenuItem1.Name = "createToolStripMenuItem1";
            this.createToolStripMenuItem1.Size = new System.Drawing.Size(156, 28);
            this.createToolStripMenuItem1.Text = "Create";
            // 
            // schemaToolStripMenuItem
            // 
            this.schemaToolStripMenuItem.Name = "schemaToolStripMenuItem";
            this.schemaToolStripMenuItem.Size = new System.Drawing.Size(171, 30);
            this.schemaToolStripMenuItem.Text = "Schema...";
            // 
            // refreshToolStripMenuItem2
            // 
            this.refreshToolStripMenuItem2.Name = "refreshToolStripMenuItem2";
            this.refreshToolStripMenuItem2.Size = new System.Drawing.Size(156, 28);
            this.refreshToolStripMenuItem2.Text = "Refresh...";
            // 
            // contextMenuStriptab
            // 
            this.contextMenuStriptab.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStriptab.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem2,
            this.refreshToolStripMenuItem3});
            this.contextMenuStriptab.Name = "contextMenuStriptab";
            this.contextMenuStriptab.ShowCheckMargin = true;
            this.contextMenuStriptab.Size = new System.Drawing.Size(179, 60);
            this.contextMenuStriptab.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStriptab_Opening);
            // 
            // createToolStripMenuItem2
            // 
            this.createToolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1});
            this.createToolStripMenuItem2.Name = "createToolStripMenuItem2";
            this.createToolStripMenuItem2.Size = new System.Drawing.Size(178, 28);
            this.createToolStripMenuItem2.Text = "Create";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(139, 30);
            this.toolStripMenuItem1.Text = "Table";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // refreshToolStripMenuItem3
            // 
            this.refreshToolStripMenuItem3.Name = "refreshToolStripMenuItem3";
            this.refreshToolStripMenuItem3.Size = new System.Drawing.Size(178, 28);
            this.refreshToolStripMenuItem3.Text = "Refresh...";
            // 
            // contextMenuStriptab2
            // 
            this.contextMenuStriptab2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStriptab2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createToolStripMenuItem3,
            this.deleteDropToolStripMenuItem1,
            this.refreshToolStripMenuItem4});
            this.contextMenuStriptab2.Name = "contextMenuStriptab2";
            this.contextMenuStriptab2.Size = new System.Drawing.Size(189, 88);
            // 
            // createToolStripMenuItem3
            // 
            this.createToolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.columnToolStripMenuItem});
            this.createToolStripMenuItem3.Name = "createToolStripMenuItem3";
            this.createToolStripMenuItem3.Size = new System.Drawing.Size(188, 28);
            this.createToolStripMenuItem3.Text = "Create";
            // 
            // columnToolStripMenuItem
            // 
            this.columnToolStripMenuItem.Name = "columnToolStripMenuItem";
            this.columnToolStripMenuItem.Size = new System.Drawing.Size(156, 30);
            this.columnToolStripMenuItem.Text = "column";
            this.columnToolStripMenuItem.Click += new System.EventHandler(this.columnToolStripMenuItem_Click);
            // 
            // deleteDropToolStripMenuItem1
            // 
            this.deleteDropToolStripMenuItem1.Name = "deleteDropToolStripMenuItem1";
            this.deleteDropToolStripMenuItem1.Size = new System.Drawing.Size(188, 28);
            this.deleteDropToolStripMenuItem1.Text = "Delete/Drop";
            // 
            // refreshToolStripMenuItem4
            // 
            this.refreshToolStripMenuItem4.Name = "refreshToolStripMenuItem4";
            this.refreshToolStripMenuItem4.Size = new System.Drawing.Size(188, 28);
            this.refreshToolStripMenuItem4.Text = "Refresh";
            // 
            // contextMenuStripco
            // 
            this.contextMenuStripco.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripco.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteDropToolStripMenuItem2,
            this.refreshToolStripMenuItem5});
            this.contextMenuStripco.Name = "contextMenuStripco";
            this.contextMenuStripco.Size = new System.Drawing.Size(189, 60);
            // 
            // deleteDropToolStripMenuItem2
            // 
            this.deleteDropToolStripMenuItem2.Name = "deleteDropToolStripMenuItem2";
            this.deleteDropToolStripMenuItem2.Size = new System.Drawing.Size(188, 28);
            this.deleteDropToolStripMenuItem2.Text = "Delete/Drop";
            // 
            // refreshToolStripMenuItem5
            // 
            this.refreshToolStripMenuItem5.Name = "refreshToolStripMenuItem5";
            this.refreshToolStripMenuItem5.Size = new System.Drawing.Size(188, 28);
            this.refreshToolStripMenuItem5.Text = "Refresh...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1220, 755);
            this.Controls.Add(this.splitContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.Text = "pgAdmin";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.contextMenuStripdb1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.contextMenuStripdb2.ResumeLayout(false);
            this.contextMenuStripsche.ResumeLayout(false);
            this.contextMenuStriptab.ResumeLayout(false);
            this.contextMenuStriptab2.ResumeLayout(false);
            this.contextMenuStripco.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
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
    }
}

