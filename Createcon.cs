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
          if (textBox_name.Text.ToString()== null)
            {
                MessageBox.Show("Column name cann't be empty");

            }
            else if(comboBox_datatype.SelectedItem.ToString()== "character varying[]" && textBox_length.Text == null)
            {
                MessageBox.Show("The length of character varying[] cann't be empty");

            }
            else if (!isInt(textBox_length.Text.ToString()))
            {
                MessageBox.Show("Length must be an integer");
            }
            else
            {
                try
                {
                    //var cmdcreate = new NpgsqlCommand("ALTER TABLE test04 ADD gid1_type integer;"; ", con);
                    var cmdcreate = new NpgsqlCommand("ALTER TABLE " + selecttn.Text.ToString() + " ADD " + textBox_name.Text + " " + textBox_name.Text + ";", con);
                    cmdcreate.ExecuteNonQuery();
                    TreeNode tn = null;
                    foreach (TreeNode t in f.treeView1.Nodes)
                    {
                        tn = f.FindNode(t, selecttn.Text);
                        if (tn != null) break;

                    }

                    /*add con node*/

                    var cond = new TreeNode();
                    cond.Text = textBox_name.Text;
                    cond.ImageIndex = 6;
                    cond.SelectedImageIndex = 6;
                    cond.ContextMenuStrip = f.contextMenuStripco;
                    tn.Nodes.Add(cond);
                    f.Refresh();
                    this.Close();
                }
                catch (Npgsql.PostgresException)
                {
                    //MessageBox.Show("The database " + dbname.Text + " has been created");
                }
            }
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
