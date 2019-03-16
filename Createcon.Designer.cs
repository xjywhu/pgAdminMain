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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.comboBox_datatype = new System.Windows.Forms.ComboBox();
            this.checkBox_notnull = new System.Windows.Forms.CheckBox();
            this.textBox_length = new System.Windows.Forms.TextBox();
            this.textBox_default = new System.Windows.Forms.TextBox();
            this.save = new System.Windows.Forms.Button();
            this.cancle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(176, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(161, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "DataType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(161, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 15);
            this.label3.TabIndex = 3;
            this.label3.Text = "Length";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(153, 236);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Not NuLL?";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(143, 285);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 15);
            this.label5.TabIndex = 5;
            this.label5.Text = "Default Value";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(342, 73);
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
            this.comboBox_datatype.Location = new System.Drawing.Point(359, 126);
            this.comboBox_datatype.Name = "comboBox_datatype";
            this.comboBox_datatype.Size = new System.Drawing.Size(121, 23);
            this.comboBox_datatype.TabIndex = 8;
            this.comboBox_datatype.SelectedIndexChanged += new System.EventHandler(this.comboBox_datatype_SelectedIndexChanged);
            // 
            // checkBox_notnull
            // 
            this.checkBox_notnull.AutoSize = true;
            this.checkBox_notnull.Location = new System.Drawing.Point(402, 236);
            this.checkBox_notnull.Name = "checkBox_notnull";
            this.checkBox_notnull.Size = new System.Drawing.Size(18, 17);
            this.checkBox_notnull.TabIndex = 9;
            this.checkBox_notnull.UseVisualStyleBackColor = true;
            // 
            // textBox_length
            // 
            this.textBox_length.Enabled = false;
            this.textBox_length.Location = new System.Drawing.Point(342, 180);
            this.textBox_length.Name = "textBox_length";
            this.textBox_length.Size = new System.Drawing.Size(161, 25);
            this.textBox_length.TabIndex = 10;
            // 
            // textBox_default
            // 
            this.textBox_default.Location = new System.Drawing.Point(326, 275);
            this.textBox_default.Name = "textBox_default";
            this.textBox_default.Size = new System.Drawing.Size(195, 25);
            this.textBox_default.TabIndex = 11;
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(474, 362);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(75, 23);
            this.save.TabIndex = 12;
            this.save.Text = "Save";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.save_Click);
            // 
            // cancle
            // 
            this.cancle.Location = new System.Drawing.Point(256, 362);
            this.cancle.Name = "cancle";
            this.cancle.Size = new System.Drawing.Size(75, 23);
            this.cancle.TabIndex = 13;
            this.cancle.Text = "Cancle";
            this.cancle.UseVisualStyleBackColor = true;
            this.cancle.Click += new System.EventHandler(this.cancle_Click);
            // 
            // Createcon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cancle);
            this.Controls.Add(this.save);
            this.Controls.Add(this.textBox_default);
            this.Controls.Add(this.textBox_length);
            this.Controls.Add(this.checkBox_notnull);
            this.Controls.Add(this.comboBox_datatype);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Createcon";
            this.Text = "Createcon";
          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.ComboBox comboBox_datatype;
        private System.Windows.Forms.CheckBox checkBox_notnull;
        private System.Windows.Forms.TextBox textBox_length;
        private System.Windows.Forms.TextBox textBox_default;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button cancle;
    }
}