namespace pgAdminMain
{
    partial class Login
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
            this.label1_login = new System.Windows.Forms.Label();
            this.server_login = new System.Windows.Forms.TextBox();
            this.label2_login = new System.Windows.Forms.Label();
            this.port_login = new System.Windows.Forms.TextBox();
            this.label4_login = new System.Windows.Forms.Label();
            this.username_login = new System.Windows.Forms.TextBox();
            this.label3_login = new System.Windows.Forms.Label();
            this.passward_login = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1_login
            // 
            this.label1_login.AutoSize = true;
            this.label1_login.Location = new System.Drawing.Point(177, 101);
            this.label1_login.Name = "label1_login";
            this.label1_login.Size = new System.Drawing.Size(55, 15);
            this.label1_login.TabIndex = 4;
            this.label1_login.Text = "server";
            // 
            // server_login
            // 
            this.server_login.Location = new System.Drawing.Point(313, 101);
            this.server_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.server_login.Name = "server_login";
            this.server_login.Size = new System.Drawing.Size(173, 25);
            this.server_login.TabIndex = 5;
            // 
            // label2_login
            // 
            this.label2_login.AutoSize = true;
            this.label2_login.Location = new System.Drawing.Point(177, 160);
            this.label2_login.Name = "label2_login";
            this.label2_login.Size = new System.Drawing.Size(39, 15);
            this.label2_login.TabIndex = 6;
            this.label2_login.Text = "port";
            // 
            // port_login
            // 
            this.port_login.Location = new System.Drawing.Point(313, 160);
            this.port_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.port_login.Name = "port_login";
            this.port_login.Size = new System.Drawing.Size(173, 25);
            this.port_login.TabIndex = 7;
            // 
            // label4_login
            // 
            this.label4_login.AutoSize = true;
            this.label4_login.Location = new System.Drawing.Point(177, 216);
            this.label4_login.Name = "label4_login";
            this.label4_login.Size = new System.Drawing.Size(71, 15);
            this.label4_login.TabIndex = 8;
            this.label4_login.Text = "username";
            // 
            // username_login
            // 
            this.username_login.Location = new System.Drawing.Point(314, 213);
            this.username_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(173, 25);
            this.username_login.TabIndex = 9;
            // 
            // label3_login
            // 
            this.label3_login.AutoSize = true;
            this.label3_login.Location = new System.Drawing.Point(177, 269);
            this.label3_login.Name = "label3_login";
            this.label3_login.Size = new System.Drawing.Size(71, 15);
            this.label3_login.TabIndex = 10;
            this.label3_login.Text = "passward";
            // 
            // passward_login
            // 
            this.passward_login.Location = new System.Drawing.Point(313, 266);
            this.passward_login.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.passward_login.Name = "passward_login";
            this.passward_login.PasswordChar = '*';
            this.passward_login.Size = new System.Drawing.Size(173, 25);
            this.passward_login.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(203, 323);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(283, 24);
            this.button1.TabIndex = 12;
            this.button1.Text = "log in";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.passward_login);
            this.Controls.Add(this.label3_login);
            this.Controls.Add(this.username_login);
            this.Controls.Add(this.label4_login);
            this.Controls.Add(this.port_login);
            this.Controls.Add(this.label2_login);
            this.Controls.Add(this.server_login);
            this.Controls.Add(this.label1_login);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1_login;
        private System.Windows.Forms.TextBox server_login;
        private System.Windows.Forms.Label label2_login;
        private System.Windows.Forms.TextBox port_login;
        private System.Windows.Forms.Label label4_login;
        private System.Windows.Forms.TextBox username_login;
        private System.Windows.Forms.Label label3_login;
        private System.Windows.Forms.TextBox passward_login;
        private System.Windows.Forms.Button button1;
    }
}