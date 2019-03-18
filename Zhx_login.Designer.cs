namespace pgAdminMain
{
    partial class Zhx_login
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
            this.server_login = new System.Windows.Forms.TextBox();
            this.port_login = new System.Windows.Forms.TextBox();
            this.passward_login = new System.Windows.Forms.TextBox();
            this.label1_login = new System.Windows.Forms.Label();
            this.label2_login = new System.Windows.Forms.Label();
            this.label3_login = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label4_login = new System.Windows.Forms.Label();
            this.username_login = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // server_login
            // 
            this.server_login.Location = new System.Drawing.Point(365, 87);
            this.server_login.Name = "server_login";
            this.server_login.Size = new System.Drawing.Size(194, 28);
            this.server_login.TabIndex = 0;
            // 
            // port_login
            // 
            this.port_login.Location = new System.Drawing.Point(365, 139);
            this.port_login.Name = "port_login";
            this.port_login.Size = new System.Drawing.Size(194, 28);
            this.port_login.TabIndex = 1;
            // 
            // passward_login
            // 
            this.passward_login.Location = new System.Drawing.Point(365, 227);
            this.passward_login.Name = "passward_login";
            this.passward_login.Size = new System.Drawing.Size(194, 28);
            this.passward_login.TabIndex = 2;
            // 
            // label1_login
            // 
            this.label1_login.AutoSize = true;
            this.label1_login.Location = new System.Drawing.Point(241, 90);
            this.label1_login.Name = "label1_login";
            this.label1_login.Size = new System.Drawing.Size(62, 18);
            this.label1_login.TabIndex = 3;
            this.label1_login.Text = "server";
            // 
            // label2_login
            // 
            this.label2_login.AutoSize = true;
            this.label2_login.Location = new System.Drawing.Point(241, 142);
            this.label2_login.Name = "label2_login";
            this.label2_login.Size = new System.Drawing.Size(44, 18);
            this.label2_login.TabIndex = 4;
            this.label2_login.Text = "port";
            // 
            // label3_login
            // 
            this.label3_login.AutoSize = true;
            this.label3_login.Location = new System.Drawing.Point(241, 237);
            this.label3_login.Name = "label3_login";
            this.label3_login.Size = new System.Drawing.Size(80, 18);
            this.label3_login.TabIndex = 5;
            this.label3_login.Text = "passward";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(241, 288);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(318, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label4_login
            // 
            this.label4_login.AutoSize = true;
            this.label4_login.Location = new System.Drawing.Point(241, 191);
            this.label4_login.Name = "label4_login";
            this.label4_login.Size = new System.Drawing.Size(80, 18);
            this.label4_login.TabIndex = 7;
            this.label4_login.Text = "username";
            // 
            // username_login
            // 
            this.username_login.Location = new System.Drawing.Point(365, 181);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(194, 28);
            this.username_login.TabIndex = 8;
            // 
            // Zhx_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.username_login);
            this.Controls.Add(this.label4_login);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label3_login);
            this.Controls.Add(this.label2_login);
            this.Controls.Add(this.label1_login);
            this.Controls.Add(this.passward_login);
            this.Controls.Add(this.port_login);
            this.Controls.Add(this.server_login);
            this.Name = "Zhx_login";
            this.Text = "Zhx_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox server_login;
        private System.Windows.Forms.TextBox port_login;
        private System.Windows.Forms.TextBox passward_login;
        private System.Windows.Forms.Label label1_login;
        private System.Windows.Forms.Label label2_login;
        private System.Windows.Forms.Label label3_login;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label4_login;
        private System.Windows.Forms.TextBox username_login;
    }
}