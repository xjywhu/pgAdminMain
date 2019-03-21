using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace pgAdminMain
{
    public partial class Createcon : Form
    {
        TreeNode selecttn;
        NpgsqlConnection con;
        MainForm f;
        public Createcon(NpgsqlConnection con,TreeNode selecttn,MainForm f)
        {
            this.selecttn = selecttn;
            this.con = con;
            this.f = f;
            InitializeComponent();
        }

        private bool isInt(string s)
        {
            bool flag = true;
            for(int i = 0; i < s.Length; i++)
                if (!char.IsNumber(s, i))
                    flag = false;
            return flag;
        
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click(object sender, EventArgs e)
        {
          if(textBox_name.Text.ToString()== "")
            {
                MessageBox.Show("Column name cann't be empty");
                return;

            }
            if (comboBox_datatype.SelectedItem==null)
            {
                MessageBox.Show("Column datatype cann't be empty");
                return;
            }
            if (comboBox_datatype.SelectedItem.ToString()== "character varying[]" && textBox_length.Text.ToString() == "")
            {
                MessageBox.Show("The length of character varying[] cann't be empty");
                return;
            }
            if (!isInt(textBox_length.Text.ToString()))
            {
                MessageBox.Show("Length must be an integer");
                return;
            }
            var cmd = new NpgsqlCommand("select column_name from information_schema.columns where table_schema='public' and table_name= '" + selecttn.Text + "'", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                if (dt.Rows[k]["column_name"].ToString() == textBox_name.Text)
                {
                    MessageBox.Show("The column " + textBox_name.Text + " has been created");
                    return;
                }
            }

           string s;
            if (comboBox_datatype.SelectedItem.ToString() == "character varying[]")
                s = "VarChar(" + textBox_length.Text.ToString() + ")";
            else
                s = comboBox_datatype.SelectedItem.ToString();
            if (checkBox_notnull.Checked)
            {
                s += " not null";
            }
            //default
            //if (textBox_default.Text!= "")
            //{
            //    s += " default()";
            //}
            
            var cmdcreate = new NpgsqlCommand("ALTER TABLE " + selecttn.Text.ToString() + " ADD " + textBox_name.Text + " " + s + ";", con);
            cmdcreate.ExecuteNonQuery();


            /*add con node*/
            var cond = new TreeNode();
            cond.Text = textBox_name.Text;
            cond.ImageIndex = 6;
            cond.SelectedImageIndex = 6;
            cond.ContextMenuStrip = f.contextMenuStripco;
            f.treeView1.SelectedNode.Nodes.Add(cond);
            f.Refresh();
            this.Close();
 

        }

        private void comboBox_datatype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_datatype.SelectedItem.ToString() == "character varying[]")
                this.textBox_length.Enabled = true;
            else
                this.textBox_length.Enabled = false;

        }


    }
}
