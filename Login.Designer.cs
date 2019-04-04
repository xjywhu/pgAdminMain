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
            this.components = new System.ComponentModel.Container();
            this.server_login = new System.Windows.Forms.TextBox();
            this.port_login = new System.Windows.Forms.TextBox();
            this.username_login = new System.Windows.Forms.TextBox();
            this.passward_login = new System.Windows.Forms.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // server_login
            // 
            this.server_login.Location = new System.Drawing.Point(304, 128);
            this.server_login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.server_login.Name = "server_login";
            this.server_login.Size = new System.Drawing.Size(207, 26);
            this.server_login.TabIndex = 5;
            this.server_login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.server_login_MouseClick);
            this.server_login.Leave += new System.EventHandler(this.server_login_Leave);
            // 
            // port_login
            // 
            this.port_login.Location = new System.Drawing.Point(304, 193);
            this.port_login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.port_login.Name = "port_login";
            this.port_login.Size = new System.Drawing.Size(207, 26);
            this.port_login.TabIndex = 7;
            this.port_login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.port_login_MouseClick);
            this.port_login.Leave += new System.EventHandler(this.port_login_Leave);
            // 
            // username_login
            // 
            this.username_login.Location = new System.Drawing.Point(305, 257);
            this.username_login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.username_login.Name = "username_login";
            this.username_login.Size = new System.Drawing.Size(207, 26);
            this.username_login.TabIndex = 9;
            this.username_login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.username_login_MouseClick);
            this.username_login.Leave += new System.EventHandler(this.username_login_Leave);
            // 
            // passward_login
            // 
            this.passward_login.Location = new System.Drawing.Point(304, 320);
            this.passward_login.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.passward_login.Name = "passward_login";
            this.passward_login.PasswordChar = '*';
            this.passward_login.Size = new System.Drawing.Size(207, 26);
            this.passward_login.TabIndex = 11;
            this.passward_login.MouseClick += new System.Windows.Forms.MouseEventHandler(this.passward_login_MouseClick);
            this.passward_login.Leave += new System.EventHandler(this.passward_login_Leave);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.Black;
            this.skinLabel1.Location = new System.Drawing.Point(187, 126);
            this.skinLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(83, 25);
            this.skinLabel1.TabIndex = 13;
            this.skinLabel1.Text = "Server";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.Black;
            this.skinLabel2.Location = new System.Drawing.Point(207, 197);
            this.skinLabel2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(60, 25);
            this.skinLabel2.TabIndex = 14;
            this.skinLabel2.Text = "Port";
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.Black;
            this.skinLabel3.Location = new System.Drawing.Point(152, 257);
            this.skinLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(124, 25);
            this.skinLabel3.TabIndex = 15;
            this.skinLabel3.Text = "Username";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.Black;
            this.skinLabel4.Location = new System.Drawing.Point(152, 324);
            this.skinLabel4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(118, 25);
            this.skinLabel4.TabIndex = 16;
            this.skinLabel4.Text = "Password";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.skinButton1.BorderColor = System.Drawing.Color.Black;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.DownBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.skinButton1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold);
            this.skinButton1.ForeColor = System.Drawing.Color.Black;
            this.skinButton1.Location = new System.Drawing.Point(305, 398);
            this.skinButton1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.skinButton1.MouseBack = null;
            this.skinButton1.MouseBaseColor = System.Drawing.Color.White;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Radius = 40;
            this.skinButton1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinButton1.Size = new System.Drawing.Size(208, 36);
            this.skinButton1.TabIndex = 17;
            this.skinButton1.Text = "LogIn";
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.skinButton1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Enabled = false;
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(317, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 18);
            this.label1.TabIndex = 18;
            this.label1.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Enabled = false;
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(317, 197);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 19;
            this.label2.Text = "5432";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Enabled = false;
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(317, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 18);
            this.label3.TabIndex = 20;
            this.label3.Text = "postgres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Enabled = false;
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(317, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 18);
            this.label4.TabIndex = 21;
            this.label4.Text = "请输入密码\r\n";
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(770, 506);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.skinButton1);
            this.Controls.Add(this.skinLabel4);
            this.Controls.Add(this.skinLabel3);
            this.Controls.Add(this.skinLabel2);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.passward_login);
            this.Controls.Add(this.username_login);
            this.Controls.Add(this.port_login);
            this.Controls.Add(this.server_login);
            this.Font = new System.Drawing.Font("华文新魏", 8.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.White;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Login";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox server_login;
        private System.Windows.Forms.TextBox port_login;
        private System.Windows.Forms.TextBox username_login;
        private System.Windows.Forms.TextBox passward_login;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}