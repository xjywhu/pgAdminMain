namespace pgAdminMain
{
    partial class Createcon
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
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_datatype = new System.Windows.Forms.ComboBox();
            this.checkBox_notnull = new System.Windows.Forms.CheckBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_default = new System.Windows.Forms.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.label6 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.save = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(295, 113);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(161, 25);
            this.textBox_name.TabIndex = 6;
            // 
            // comboBox_datatype
            // 
            this.comboBox_datatype.FormattingEnabled = true;
            this.comboBox_datatype.Items.AddRange(new object[] {
            "Int",
            "character varying[]",
            "date",
            "smallint",
            "char"});
            this.comboBox_datatype.Location = new System.Drawing.Point(312, 166);
            this.comboBox_datatype.Name = "comboBox_datatype";
            this.comboBox_datatype.Size = new System.Drawing.Size(121, 23);
            this.comboBox_datatype.TabIndex = 8;
            this.comboBox_datatype.SelectedIndexChanged += new System.EventHandler(this.comboBox_datatype_SelectedIndexChanged);
            // 
            // checkBox_notnull
            // 
            this.checkBox_notnull.AutoSize = true;
            this.checkBox_notnull.Location = new System.Drawing.Point(360, 276);
            this.checkBox_notnull.Name = "checkBox_notnull";
            this.checkBox_notnull.Size = new System.Drawing.Size(18, 17);
            this.checkBox_notnull.TabIndex = 9;
            this.checkBox_notnull.UseVisualStyleBackColor = true;
            // 
            // textBox_length
            // 
            this.textBox_length.Enabled = false;
            this.textBox_length.Location = new System.Drawing.Point(295, 220);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(161, 25);
            this.textBox_length.TabIndex = 10;
            // 
            // textBox_default
            // 
            this.textBox_default.Location = new System.Drawing.Point(276, 325);
            this.textBox_default.Name = "textBox_default";
            this.textBox_default.Size = new System.Drawing.Size(195, 25);
            this.textBox_default.TabIndex = 11;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(132, 115);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(59, 18);
            this.skinLabel1.TabIndex = 15;
            this.skinLabel1.Text = "Name";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(128, 165);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(92, 18);
            this.skinLabel2.TabIndex = 16;
            this.skinLabel2.Text = "DataType";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(132, 220);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(66, 18);
            this.skinLabel3.TabIndex = 17;
            this.skinLabel3.Text = "Length";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(128, 272);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(93, 18);
            this.skinLabel4.TabIndex = 18;
            this.skinLabel4.Text = "Not Null?";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(111, 327);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(128, 18);
            this.skinLabel5.TabIndex = 19;
            this.skinLabel5.Text = "Default Value";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.BorderColor = System.Drawing.Color.White;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(490, 327);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(201, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "(xxxx-xx-xx,年份-月份-日期)";
            this.label6.Visible = false;
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.skinButton1.Location = new System.Drawing.Point(199, 369);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 20;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(101, 45);
            this.skinButton1.TabIndex = 21;
            this.skinButton1.Text = "Cancel";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.save.DownBack = null;
            this.save.DownBaseColor = System.Drawing.Color.Blue;
            this.save.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.save.Location = new System.Drawing.Point(429, 369);
            this.save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.save.MouseBack = null;
            this.save.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.save.Name = "save";
            this.save.NormlBack = null;
            this.save.Radius = 20;
            this.save.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.save.Size = new System.Drawing.Size(101, 45);
            this.save.TabIndex = 22;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = false;
            this.save.Click += new System.EventHandler(this.save_Click_1);
            // 
            // Createcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 450);
            this.Controls.Add(this.save);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.skinLabel5);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.textBox_default);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.checkBox_notnull);
            this.Controls.Add(this.comboBox_datatype);
            this.Controls.Add(this.textBox_name);
            this.Name = "Createcon";
            this.Text = "Createcon";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_datatype;
        private System.Windows.Forms.CheckBox checkBox_notnull;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_default;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel label6;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinButton save;
    }
}