namespace pgAdminMain
{
    partial class login_fail
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
            this.Confirm_fail = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "登陆失败！\r\n请检查登陆信息";
            // 
            // Confirm_fail
            // 
            this.Confirm_fail.Location = new System.Drawing.Point(169, 151);
            this.Confirm_fail.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Confirm_fail.Name = "Confirm_fail";
            this.Confirm_fail.Size = new System.Drawing.Size(113, 36);
            this.Confirm_fail.TabIndex = 2;
            this.Confirm_fail.Text = "Confirm";
            this.Confirm_fail.UseVisualStyleBackColor = true;
            this.Confirm_fail.Click += new System.EventHandler(this.Confirm_fail_Click);
            // 
            // login_fail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 251);
            this.Controls.Add(this.Confirm_fail);
            this.Controls.Add(this.label1);
            this.Name = "login_fail";
            this.Text = "login_fail";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Confirm_fail;
    }
}