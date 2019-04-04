using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pgAdminMain
{
    public partial class Info_schema : UserControl
    {
        public Info_schema()
        {
            InitializeComponent();
            Control.background2 = this;
        }

        public DataGridView GetDataGridView1() {
            return this.skinDataGridView1;
        }

        public DataGridView GetDataGridView2()
        {
            return this.skinDataGridView2;
        }
    }
}
