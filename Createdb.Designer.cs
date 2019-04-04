namespace pgAdminMain
{
    partial class Createdb
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
            this.dbname = new System.Windows.Forms.TextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.Cancel = new CCWin.SkinControl.SkinButton();
            this.Save = new CCWin.SkinControl.SkinButton();
            this.SuspendLayout();
            // 
            // dbname
            // 
            this.dbname.Location = new System.Drawing.Point(177, 114);
            this.dbname.Name = "dbname";
            this.dbname.Size = new System.Drawing.Size(295, 25);
            this.dbname.TabIndex = 1;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(63, 118);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(99, 21);
            this.skinLabel1.TabIndex = 4;
            this.skinLabel1.Text = "DataBase";
            // 
            // Cancel
            // 
            this.Cancel.BackColor = System.Drawing.Color.Transparent;
            this.Cancel.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.Cancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Cancel.DownBack = null;
            this.Cancel.Font = new System.Drawing.Font("华文新魏", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Cancel.Location = new System.Drawing.Point(67, 197);
            this.Cancel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cancel.MouseBack = null;
            this.Cancel.Name = "Cancel";
            this.Cancel.NormlBack = null;
            this.Cancel.Radius = 20;
            this.Cancel.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Cancel.Size = new System.Drawing.Size(106, 46);
            this.Cancel.TabIndex = 5;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = false;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // Save
            // 
            this.Save.BackColor = System.Drawing.Color.Transparent;
            this.Save.BaseColor = System.Drawing.SystemColors.ActiveCaption;
            this.Save.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.Save.DownBack = null;
            this.Save.Font = new System.Drawing.Font("华文新魏", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Save.Location = new System.Drawing.Point(356, 194);
            this.Save.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Save.MouseBack = null;
            this.Save.Name = "Save";
            this.Save.NormlBack = null;
            this.Save.Radius = 20;
            this.Save.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.Save.Size = new System.Drawing.Size(116, 49);
            this.Save.TabIndex = 6;
            this.Save.Text = "Save";
            this.Save.UseVisualStyleBackColor = false;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Createdb
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 297);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.skinLabel1);
            this.Controls.Add(this.dbname);
            this.Name = "Createdb";
            this.Text = "Createdb";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox dbname;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton Cancel;
        private CCWin.SkinControl.SkinButton Save;
    }
}