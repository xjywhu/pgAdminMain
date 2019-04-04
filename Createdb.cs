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
using MaterialSkin.Controls;
using MaterialSkin;

namespace pgAdminMain
{
    public partial class Createdb : MaterialForm
    {
        NpgsqlConnection con;
        MainForm f;
        private readonly MaterialSkinManager materialSkinManager;
        public Createdb(NpgsqlConnection con,MainForm f)
        {
            InitializeComponent();
            this.con = con;
            this.f = f;
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Save_Click(object sender, EventArgs e)
        {
            string name = dbname.Text;
            var con1 = new NpgsqlConnection(MainForm.connString);
            /*未输入数据库名，提示用户*/
            if (name == "")
            {
                MessageBox.Show("The database's name cann't be empty");

            }
            else
            {
                try

                {
                    con1.Open();
                    var cmdcreate = new NpgsqlCommand("create database " + name + ";", Control.connection.SqlConn);
                    cmdcreate.ExecuteNonQuery();
                    TreeNode tn = null;
                    /*创建新的数据库后，更新相应节点*/
                    foreach (TreeNode t in f.treeView1.Nodes)
                    {
                        tn = f.tvc.FindNode(t, "DataBases");
                        if (tn != null) break;

                    }
                    /*database node*/
                    var dtnd = new TreeNode();
                    dtnd.Name = name;
                    dtnd.Text = name;
                    dtnd.ContextMenuStrip = f.contextMenuStripdb2;
                    dtnd.ImageIndex = 2;
                    dtnd.SelectedImageIndex = 2;
                    dtnd.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
                    tn.Nodes.Add(dtnd);

                    TreeNode t1 = f.tvc.Find(f.treeView1, name);
                    /*sche node*/
                    var sche = new TreeNode();
                    sche.Name = "Schemas";
                    sche.Text = "Schemas";
                    sche.ContextMenuStrip = f.contextMenuStripsche;
                    sche.ImageIndex = 3;
                    sche.SelectedImageIndex = 3;
                    sche.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
                    t1.Nodes.Add(sche);
                    /*table node*/
                    var tab = new TreeNode();
                    tab.Name = "Table";
                    tab.Text = "Table";
                    tab.ContextMenuStrip = f.contextMenuStriptab;
                    tab.ImageIndex = 4;
                    tab.SelectedImageIndex = 4;
                    tab.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
                    t1.Nodes[0].Nodes.Add(tab);
                    f.Refresh();
                    this.Close();
                }
                catch (Npgsql.PostgresException)
                {   /*数据库已经存在，则捕获异常*/
                    MessageBox.Show("The database " + dbname.Text + " has been created");
                }
                finally
                {
                    con1.Close();
                }

            }
        }
    }
}
