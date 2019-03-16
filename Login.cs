using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pgAdminMain
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String server, port, username, password;
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
                login_fail fail = new login_fail();
                fail.ShowDialog();
            }
            if (Control.connection != null)
            {
                Control.login = this;
                MainForm form = new MainForm();
                this.Hide();
                form.ShowDialog();

            }
        }
    }
}
