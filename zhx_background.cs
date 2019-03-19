using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace pgAdminMain
{
    public partial class zhx_background : UserControl
    {
        public zhx_background()
        {
            InitializeComponent();
        }

        private static String GetTableName(String str)
        {
            int index = 0;
            if ((index = str.IndexOf("from", StringComparison.OrdinalIgnoreCase)) < 0)
            {
                return null;
            }
            //find next space
            int index_1 = index + 4;
            while (str[index_1] == ' ') { index_1 += 1; }
            int index_2 = str.IndexOf(' ', index_1 + 1);
            if (index_2 == -1)
            {
                return str.Substring(index_1);
            }
            else
                return str.Substring(index_1, index_2-index_1);
        }

        private void zhx_submit_Click_1(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand(richTextBox1.Text, Control.connection.SqlConn);
            //   Control.connection.SqlConn.Open();
            try
            {
                command.ExecuteNonQuery();
                string str = GetTableName(richTextBox1.Text);
                string str_show = "Select * from " + str;
                NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(str_show, Control.connection.SqlConn);
                Control.connection.ds = new DataSet();
                npgsql.Fill(Control.connection.ds);
                //Control.connection.SqlConn.Close();

                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = Control.connection.ds;
                this.dataGridView1.DataMember = Control.connection.ds.Tables[0].TableName;
            }
            catch{
                MessageBox.Show("请检查您的指令！");
            }
        }
    }
}
