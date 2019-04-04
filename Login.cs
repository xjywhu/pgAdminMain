using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;

namespace pgAdminMain
{
    public partial class Login : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public Login()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            String server, port, username, password;
            //为用户提供默认值
            if (string.IsNullOrWhiteSpace(this.server_login.Text))
            {
                server = "localhost";
            }
            else
                server = this.server_login.Text;
            if (string.IsNullOrWhiteSpace(this.port_login.Text))
            {
                port = "5432";
            }
            else
                port = this.port_login.Text;
            if (string.IsNullOrWhiteSpace(this.username_login.Text))
            {
                username = "postgres";
            }
            else
                username = this.username_login.Text;
            if (string.IsNullOrWhiteSpace(this.passward_login.Text))
            {
                password = "";
            }
            else
                password = this.passward_login.Text;
            try
            {
                Control.connection = new Connection_zhx(server, port, password, username);
            }
            catch
            {
                Login_fail fail = new Login_fail();
                fail.ShowDialog();
            }
            if (Control.connection != null)
            {
                //try
                //
                    Control.login = this;
                    MainForm form = new MainForm();
                    this.Hide();
                    Control.login = this;
                    form.ShowDialog();
                //
               //atch (Exception) {
                 // MessageBox.Show("请勿再调整窗体大小！");
               //
            }
        }

        private void server_login_MouseClick(object sender, MouseEventArgs e)
        {
            this.label1.Visible = false;
            this.label1.Enabled = false;
        }

        private void server_login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.server_login.Text)) {
                this.label1.Visible = true;
                this.label1.Enabled = false;
            }
        }


        //以下函数均为为用户控制默认输入值的显示和隐藏所用
        private void port_login_MouseClick(object sender, MouseEventArgs e)
        {
            this.label2.Visible = false;
            this.label2.Enabled = false;
        }

        private void port_login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.port_login.Text))
            {
                this.label2.Visible = true;
                this.label2.Enabled = false;
            }
        }

        private void username_login_MouseClick(object sender, MouseEventArgs e)
        {
            this.label3.Visible = false;
            this.label3.Enabled = false;
        }

        private void username_login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.username_login.Text))
            {
                this.label3.Visible = true;
                this.label3.Enabled = false;
            }
        }

        private void passward_login_MouseClick(object sender, MouseEventArgs e)
        {
            this.label4.Visible = false;
            this.label4.Enabled = false;
        }

        private void passward_login_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.passward_login.Text))
            {
                this.label4.Visible = true;
                this.label4.Enabled = false;
            }
        }
    }
}
