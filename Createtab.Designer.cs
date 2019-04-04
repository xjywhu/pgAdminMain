namespace pgAdminMain
{
    partial class Createtab
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Createtab));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new CCWin.SkinControl.SkinTabControl();
            this.Gerenel = new CCWin.SkinControl.SkinTabPage();
            this.text_box_tablename = new CCWin.SkinControl.SkinTextBox();
            this.label1 = new CCWin.SkinControl.SkinLabel();
            this.Columns = new CCWin.SkinControl.SkinTabPage();
            this.label2 = new CCWin.SkinControl.SkinLabel();
            this.button_addrows = new CCWin.SkinControl.SkinButton();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new CCWin.SkinControl.SkinButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotNULL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.df = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Gerenel.SuspendLayout();
            this.Columns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Save, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.31441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68559F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(924, 487);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.AnimationStart = true;
            this.tabControl1.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabControl1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl1.ArrowBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.tabControl1.BackColor = System.Drawing.Color.White;
            this.tabControl1.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabControl1.Controls.Add(this.Gerenel);
            this.tabControl1.Controls.Add(this.Columns);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
            this.tabControl1.DrawType = CCWin.SkinControl.DrawStyle.Draw;
            this.tabControl1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.tabControl1.HeadBack = null;
            this.tabControl1.HeadPalace = true;
            this.tabControl1.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabControl1.ItemSize = new System.Drawing.Size(100, 36);
            this.tabControl1.Location = new System.Drawing.Point(4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowDown")));
            this.tabControl1.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageArrowHover")));
            this.tabControl1.PageArrowRectangle = new System.Drawing.Rectangle(6, 6, 6, 6);
            this.tabControl1.PageArrowVisble = false;
            this.tabControl1.PageBaseColor = System.Drawing.Color.Silver;
            this.tabControl1.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseHover")));
            this.tabControl1.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageCloseNormal")));
            this.tabControl1.PageDown = ((System.Drawing.Image)(resources.GetObject("tabControl1.PageDown")));
            this.tabControl1.PageHover = null;
            this.tabControl1.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Right;
            this.tabControl1.PageNorml = null;
            this.tabControl1.Radius = 20;
            this.tabControl1.SelectedIndex = 1;
            this.tabControl1.Size = new System.Drawing.Size(916, 392);
            this.tabControl1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // Gerenel
            // 
            this.Gerenel.BackColor = System.Drawing.Color.White;
            this.Gerenel.Controls.Add(this.text_box_tablename);
            this.Gerenel.Controls.Add(this.label1);
            this.Gerenel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Gerenel.Location = new System.Drawing.Point(0, 36);
            this.Gerenel.Name = "Gerenel";
            this.Gerenel.Padding = new System.Windows.Forms.Padding(3);
            this.Gerenel.Size = new System.Drawing.Size(916, 356);
            this.Gerenel.TabIndex = 0;
            this.Gerenel.TabItemImage = null;
            this.Gerenel.Text = "Gerenel";
            this.Gerenel.UseVisualStyleBackColor = true;
            // 
            // text_box_tablename
            // 
            this.text_box_tablename.BackColor = System.Drawing.Color.Transparent;
            this.text_box_tablename.DownBack = null;
            this.text_box_tablename.Icon = null;
            this.text_box_tablename.IconIsButton = false;
            this.text_box_tablename.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_box_tablename.IsPasswordChat = '\0';
            this.text_box_tablename.IsSystemPasswordChar = false;
            this.text_box_tablename.Lines = new string[0];
            this.text_box_tablename.Location = new System.Drawing.Point(196, 92);
            this.text_box_tablename.Margin = new System.Windows.Forms.Padding(0);
            this.text_box_tablename.MaxLength = 32767;
            this.text_box_tablename.MinimumSize = new System.Drawing.Size(25, 23);
            this.text_box_tablename.MouseBack = null;
            this.text_box_tablename.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.text_box_tablename.Multiline = true;
            this.text_box_tablename.Name = "text_box_tablename";
            this.text_box_tablename.NormlBack = null;
            this.text_box_tablename.Padding = new System.Windows.Forms.Padding(4);
            this.text_box_tablename.ReadOnly = false;
            this.text_box_tablename.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.text_box_tablename.Size = new System.Drawing.Size(245, 52);
            // 
            // 
            // 
            this.text_box_tablename.SkinTxt.Location = new System.Drawing.Point(0, 0);
            this.text_box_tablename.SkinTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.text_box_tablename.SkinTxt.Multiline = true;
            this.text_box_tablename.SkinTxt.Name = "BaseText";
            this.text_box_tablename.SkinTxt.Size = new System.Drawing.Size(89, 22);
            this.text_box_tablename.SkinTxt.TabIndex = 0;
            this.text_box_tablename.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_box_tablename.SkinTxt.WaterText = "";
            this.text_box_tablename.TabIndex = 1;
            this.text_box_tablename.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.text_box_tablename.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.text_box_tablename.WaterText = "";
            this.text_box_tablename.WordWrap = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.BorderColor = System.Drawing.Color.White;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(105, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Columns
            // 
            this.Columns.BackColor = System.Drawing.Color.White;
            this.Columns.Controls.Add(this.label2);
            this.Columns.Controls.Add(this.button_addrows);
            this.Columns.Controls.Add(this.dataGridView1);
            this.Columns.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Columns.Location = new System.Drawing.Point(0, 36);
            this.Columns.Name = "Columns";
            this.Columns.Padding = new System.Windows.Forms.Padding(3);
            this.Columns.Size = new System.Drawing.Size(916, 356);
            this.Columns.TabIndex = 1;
            this.Columns.TabItemImage = null;
            this.Columns.Text = "Columns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(902, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(201, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "(xxxx-xx-xx,年份-月份-日期)";
            // 
            // button_addrows
            // 
            this.button_addrows.BackColor = System.Drawing.Color.Transparent;
            this.button_addrows.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.button_addrows.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.button_addrows.DownBack = null;
            this.button_addrows.Font = new System.Drawing.Font("宋体", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addrows.Location = new System.Drawing.Point(5, 7);
            this.button_addrows.MouseBack = null;
            this.button_addrows.Name = "button_addrows";
            this.button_addrows.NormlBack = null;
            this.button_addrows.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.button_addrows.Size = new System.Drawing.Size(33, 28);
            this.button_addrows.TabIndex = 1;
            this.button_addrows.Text = "+";
            this.button_addrows.UseVisualStyleBackColor = true;
            this.button_addrows.Click += new System.EventHandler(this.button_addrows_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.N,
            this.DataType,
            this.Length,
            this.NotNULL,
            this.PrimaryKey,
            this.df,
            this.delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(910, 350);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Save.DownBack = null;
            this.Save.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.Save.Location = new System.Drawing.Point(398, 419);
            this.Save.MouseBack = null;
            this.Save.Name = "Save";
            this.Save.NormlBack = null;
            this.Save.Radius = 20;
            this.Save.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Save.Size = new System.Drawing.Size(127, 48);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 80);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(924, 487);
            this.panel1.TabIndex = 1;
            // 
            // N
            // 
            this.N.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.N.HeaderText = "Name";
            this.N.Name = "N";
            this.N.Width = 96;
            // 
            // DataType
            // 
            this.DataType.HeaderText = "DataType";
            this.DataType.Items.AddRange(new object[] {
            "Int",
            "character varying[]",
            "date",
            "smallint",
            "char"});
            this.DataType.Name = "DataType";
            this.DataType.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.DataType.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Length
            // 
            this.Length.HeaderText = "Length";
            this.Length.Name = "Length";
            this.Length.ReadOnly = true;
            // 
            // NotNULL
            // 
            this.NotNULL.HeaderText = "Not NULL?";
            this.NotNULL.Name = "NotNULL";
            this.NotNULL.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.NotNULL.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // PrimaryKey
            // 
            this.PrimaryKey.HeaderText = "Primary Key?";
            this.PrimaryKey.Name = "PrimaryKey";
            this.PrimaryKey.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrimaryKey.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // df
            // 
            this.df.HeaderText = "default value";
            this.df.Name = "df";
            // 
            // delete
            // 
            this.delete.HeaderText = "delete";
            this.delete.Name = "delete";
            this.delete.Text = "----";
            // 
            // Createtab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(924, 567);
            this.Controls.Add(this.panel1);
            this.Name = "Createtab";
            this.Text = "Createtab";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Gerenel.ResumeLayout(false);
            this.Gerenel.PerformLayout();
            this.Columns.ResumeLayout(false);
            this.Columns.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinTabControl tabControl1;
        private CCWin.SkinControl.SkinButton Save;
        private CCWin.SkinControl.SkinTabPage Gerenel;
        private CCWin.SkinControl.SkinTextBox text_box_tablename;
        private CCWin.SkinControl.SkinLabel label1;
        private CCWin.SkinControl.SkinTabPage Columns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private CCWin.SkinControl.SkinButton button_addrows;
        private CCWin.SkinControl.SkinLabel label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotNULL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrimaryKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn df;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}