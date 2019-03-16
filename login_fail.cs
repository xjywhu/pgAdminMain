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
    public partial class login_fail : Form
    {
        public login_fail()
        {
            InitializeComponent();
        }

        private void Confirm_fail_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
