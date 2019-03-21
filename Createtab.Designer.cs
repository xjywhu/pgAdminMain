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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Gerenel = new System.Windows.Forms.TabPage();
            this.text_box_tablename = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Columns = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Save = new System.Windows.Forms.Button();
            this.button_addrows = new System.Windows.Forms.Button();
            this.N = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataType = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.Length = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NotNULL = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PrimaryKey = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Gerenel.SuspendLayout();
            this.Columns.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tabControl1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.Save, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 82.31441F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17.68559F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1139, 578);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Gerenel);
            this.tabControl1.Controls.Add(this.Columns);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1133, 469);
            this.tabControl1.TabIndex = 0;
            // 
            // Gerenel
            // 
            this.Gerenel.Controls.Add(this.text_box_tablename);
            this.Gerenel.Controls.Add(this.label1);
            this.Gerenel.Font = new System.Drawing.Font("幼圆", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Gerenel.Location = new System.Drawing.Point(4, 25);
            this.Gerenel.Name = "Gerenel";
            this.Gerenel.Padding = new System.Windows.Forms.Padding(3);
            this.Gerenel.Size = new System.Drawing.Size(1099, 439);
            this.Gerenel.TabIndex = 0;
            this.Gerenel.Text = "Gerenel";
            this.Gerenel.UseVisualStyleBackColor = true;
            // 
            // text_box_tablename
            // 
            this.text_box_tablename.Location = new System.Drawing.Point(343, 74);
            this.text_box_tablename.Name = "text_box_tablename";
            this.text_box_tablename.Size = new System.Drawing.Size(423, 27);
            this.text_box_tablename.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 82);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // Columns
            // 
            this.Columns.Controls.Add(this.button_addrows);
            this.Columns.Controls.Add(this.dataGridView1);
            this.Columns.Location = new System.Drawing.Point(4, 25);
            this.Columns.Name = "Columns";
            this.Columns.Padding = new System.Windows.Forms.Padding(3);
            this.Columns.Size = new System.Drawing.Size(1125, 440);
            this.Columns.TabIndex = 1;
            this.Columns.Text = "Columns";
            this.Columns.UseVisualStyleBackColor = true;
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
            this.delete});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 27;
            this.dataGridView1.Size = new System.Drawing.Size(1119, 434);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dataGridView1_EditingControlShowing);
            // 
            // Save
            // 
            this.Save.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Save.Location = new System.Drawing.Point(532, 495);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 62);
            this.Save.TabIndex = 1;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // button_addrows
            // 
            this.button_addrows.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button_addrows.Font = new System.Drawing.Font("宋体", 42F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button_addrows.Location = new System.Drawing.Point(792, 162);
            this.button_addrows.Name = "button_addrows";
            this.button_addrows.Size = new System.Drawing.Size(99, 66);
            this.button_addrows.TabIndex = 1;
            this.button_addrows.Text = "+";
            this.button_addrows.UseVisualStyleBackColor = true;
            this.button_addrows.Click += new System.EventHandler(this.button_addrows_Click);
            // 
            // N
            // 
            this.N.HeaderText = "Name";
            this.N.Name = "N";
            this.N.Width = 68;
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
            this.ClientSize = new System.Drawing.Size(1139, 578);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Createtab";
            this.Text = "Createtab";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.Gerenel.ResumeLayout(false);
            this.Gerenel.PerformLayout();
            this.Columns.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.Button Save;
        private System.Windows.Forms.TabPage Gerenel;
        private System.Windows.Forms.TextBox text_box_tablename;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Columns;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button_addrows;
        private System.Windows.Forms.DataGridViewTextBoxColumn N;
        private System.Windows.Forms.DataGridViewComboBoxColumn DataType;
        private System.Windows.Forms.DataGridViewTextBoxColumn Length;
        private System.Windows.Forms.DataGridViewCheckBoxColumn NotNULL;
        private System.Windows.Forms.DataGridViewCheckBoxColumn PrimaryKey;
        private System.Windows.Forms.DataGridViewButtonColumn delete;
    }
}