namespace pgAdminMain
{
    partial class ChangeType
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBox_datatype = new System.Windows.Forms.ComboBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.skinLabel3);
            this.panel1.Controls.Add(this.textBox_length);
            this.panel1.Controls.Add(this.skinButton1);
            this.panel1.Controls.Add(this.skinLabel1);
            this.panel1.Controls.Add(this.comboBox_datatype);
            this.panel1.Location = new System.Drawing.Point(-1, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(803, 376);
            this.panel1.TabIndex = 0;
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
            this.comboBox_datatype.Location = new System.Drawing.Point(347, 111);
            this.comboBox_datatype.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBox_datatype.Name = "comboBox_datatype";
            this.comboBox_datatype.Size = new System.Drawing.Size(136, 26);
            this.comboBox_datatype.TabIndex = 9;
            this.comboBox_datatype.SelectedIndexChanged += new System.EventHandler(this.comboBox_datatype_SelectedIndexChanged);

            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(240, 116);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(92, 21);
            this.skinLabel1.TabIndex = 10;
            this.skinLabel1.Text = "Datatype";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Location = new System.Drawing.Point(244, 233);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 20;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(150, 48);
            this.skinButton1.TabIndex = 11;
            this.skinButton1.Text = "确认\r\n";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("华文新魏", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(246, 175);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(78, 21);
            this.skinLabel3.TabIndex = 19;
            this.skinLabel3.Text = "Length";
            this.skinLabel3.Visible = false;
            // 
            // textBox_length
            // 
            this.textBox_length.Enabled = false;
            this.textBox_length.Location = new System.Drawing.Point(347, 173);
            this.textBox_length.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(181, 28);
            this.textBox_length.TabIndex = 18;
            this.textBox_length.Visible = false;
            // 
            // ChangeType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "ChangeType";
            this.Text = "ChangeType";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private CCWin.SkinControl.SkinButton skinButton1;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.ComboBox comboBox_datatype;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private System.Windows.Forms.TextBox textBox_length;
    }
}