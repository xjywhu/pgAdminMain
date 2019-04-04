namespace pgAdminMain
{
    partial class QueryBackground
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.richTextBox2 = new CCWin.SkinControl.SkinChatRichTextBox();
            this.SkinButton1 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.dataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.DeleteButton2 = new CCWin.SkinControl.SkinButton();
            this.InsertButton3 = new CCWin.SkinControl.SkinButton();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox2
            // 
            this.richTextBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.richTextBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox2.Font = new System.Drawing.Font("MS Reference Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox2.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.richTextBox2.Location = new System.Drawing.Point(15, 517);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(15, 20, 15, 20);
            this.richTextBox2.Name = "richTextBox2";
            this.tableLayoutPanel1.SetRowSpan(this.richTextBox2, 3);
            this.richTextBox2.SelectControl = null;
            this.richTextBox2.SelectControlIndex = 0;
            this.richTextBox2.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.richTextBox2.Size = new System.Drawing.Size(471, 133);
            this.richTextBox2.TabIndex = 9;
            this.richTextBox2.Text = "";
            // 
            // SkinButton1
            // 
            this.SkinButton1.BackColor = System.Drawing.Color.Transparent;
            this.SkinButton1.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.SkinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.SkinButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SkinButton1.DownBack = null;
            this.SkinButton1.Location = new System.Drawing.Point(504, 501);
            this.SkinButton1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SkinButton1.MouseBack = null;
            this.SkinButton1.MouseBaseColor = System.Drawing.SystemColors.HotTrack;
            this.SkinButton1.Name = "SkinButton1";
            this.SkinButton1.NormlBack = null;
            this.SkinButton1.Radius = 30;
            this.SkinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.SkinButton1.Size = new System.Drawing.Size(209, 53);
            this.SkinButton1.TabIndex = 7;
            this.SkinButton1.Text = "Execute\r\n";
            this.SkinButton1.UseVisualStyleBackColor = false;
            this.SkinButton1.Click += new System.EventHandler(this.ExexuteButton1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Honeydew;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.97207F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30.02793F));
            this.tableLayoutPanel1.Controls.Add(this.dataGridView1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.richTextBox2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.SkinButton1, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.DeleteButton2, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.InsertButton3, 1, 3);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 88.90977F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.09023F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 59F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 52F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(716, 670);
            this.tableLayoutPanel1.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InactiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SunkenVertical;
            this.dataGridView1.ColumnFont = null;
            this.dataGridView1.ColumnForeColor = System.Drawing.Color.Black;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.ColumnSelectBackColor = System.Drawing.SystemColors.ButtonShadow;
            this.dataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.tableLayoutPanel1.SetColumnSpan(this.dataGridView1, 2);
            this.dataGridView1.DefaultCellBackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.dataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.LineNumberForeColor = System.Drawing.Color.Black;
            this.dataGridView1.Location = new System.Drawing.Point(9, 8);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(9, 8, 9, 8);
            this.dataGridView1.MouseCellBackColor = System.Drawing.Color.Teal;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ButtonShadow;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.dataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(698, 481);
            this.dataGridView1.TabIndex = 8;
            this.dataGridView1.TitleBack = null;
            this.dataGridView1.TitleBackColorBegin = System.Drawing.Color.AliceBlue;
            this.dataGridView1.TitleBackColorEnd = System.Drawing.Color.AliceBlue;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            // 
            // DeleteButton2
            // 
            this.DeleteButton2.BackColor = System.Drawing.Color.Transparent;
            this.DeleteButton2.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.DeleteButton2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.DeleteButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DeleteButton2.DownBack = null;
            this.DeleteButton2.Location = new System.Drawing.Point(504, 562);
            this.DeleteButton2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.DeleteButton2.MouseBack = null;
            this.DeleteButton2.Name = "DeleteButton2";
            this.DeleteButton2.NormlBack = null;
            this.DeleteButton2.Radius = 30;
            this.DeleteButton2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.DeleteButton2.Size = new System.Drawing.Size(209, 51);
            this.DeleteButton2.TabIndex = 10;
            this.DeleteButton2.Text = "Delete";
            this.DeleteButton2.UseVisualStyleBackColor = false;
            this.DeleteButton2.Click += new System.EventHandler(this.DeleteButton2_Click);
            // 
            // InsertButton3
            // 
            this.InsertButton3.BackColor = System.Drawing.Color.Transparent;
            this.InsertButton3.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.InsertButton3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.InsertButton3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.InsertButton3.DownBack = null;
            this.InsertButton3.Location = new System.Drawing.Point(504, 620);
            this.InsertButton3.MouseBack = null;
            this.InsertButton3.Name = "InsertButton3";
            this.InsertButton3.NormlBack = null;
            this.InsertButton3.Radius = 30;
            this.InsertButton3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.InsertButton3.Size = new System.Drawing.Size(209, 47);
            this.InsertButton3.TabIndex = 11;
            this.InsertButton3.Text = "Insert";
            this.InsertButton3.UseVisualStyleBackColor = false;
            this.InsertButton3.Click += new System.EventHandler(this.InsertButton3_Click);
            // 
            // QueryBackground
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "QueryBackground";
            this.Size = new System.Drawing.Size(716, 670);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinChatRichTextBox richTextBox2;
        private CCWin.SkinControl.SkinButton SkinButton1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private CCWin.SkinControl.SkinDataGridView dataGridView1;
        private CCWin.SkinControl.SkinButton DeleteButton2;
        private CCWin.SkinControl.SkinButton InsertButton3;
    }
}
