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
    public partial class Createdb : Form
    {
        NpgsqlConnection con;
        MainForm f;
        public Createdb(NpgsqlConnection con,MainForm f)
        {
            InitializeComponent();
            this.con = con;
            this.f = f;
                       
        }


        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name = dbname.Text;
            if (name == "")
            {
                MessageBox.Show("The database's name cann't be empty");

            }
            else
            {
                try
                {
                    var cmdcreate = new NpgsqlCommand("create database " + name + ";", con);
                    cmdcreate.ExecuteNonQuery();
                    TreeNode tn = null;
                   foreach(TreeNode t in f.treeView1.Nodes)
                    {
                        tn = f.FindNode(t, "DataBases");
                        if (tn!= null) break;

                    }
                    var dtnd = new TreeNode();
                    dtnd.Name = name;
                    dtnd.Text = name;
                    dtnd.ContextMenuStrip = f.contextMenuStripdb2;
                    dtnd.ImageIndex = 2;
                    dtnd.SelectedImageIndex = 2;
                    tn.Nodes.Add(dtnd);

                    TreeNode t1 = f.Find(f.treeView1, name);

                    var sche = new TreeNode();
                    sche.Name = "Schemas";
                    sche.Text = "Schemas";
                    sche.ContextMenuStrip = f.contextMenuStripsche;
                    sche.ImageIndex = 3;
                    sche.SelectedImageIndex = 3;
                    t1.Nodes.Add(sche);

                    var tab = new TreeNode();
                    tab.Name = "Table";
                    tab.Text = "Table";
                    tab.ContextMenuStrip = f.contextMenuStriptab;
                    tab.ImageIndex = 4;
                    tab.SelectedImageIndex = 4;
                    t1.Nodes[0].Nodes.Add(tab);
                    f.Refresh();
                    this.Close();
                }
                catch (Npgsql.PostgresException)
                {
                    MessageBox.Show("The database "+dbname.Text+" has been created");
                }

            }
        }
    }
}
