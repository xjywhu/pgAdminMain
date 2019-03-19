﻿using System;
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
    public partial class MainForm : Form
    {
        public static string connString = "Host=" + Control.connection.getSever() + ";Port=" + Control.connection.getPort() + ";Username=" + Control.connection.getUsername() + ";Password=" + Control.connection.getPassword();
        NpgsqlConnection con = Control.connection.SqlConn;
        /*存储数据库名和表名的字典*/
        public static Dictionary<string, List<string>> dbDic = new Dictionary<string, List<string>>();
        public MainForm(){
            InitializeComponent();
            //con.Open();
            bindNode();
        }
        public TreeNode FindNode(TreeNode tnParent, string strValue)
        {
            if (tnParent == null) return null;
            if (tnParent.Text == strValue) return tnParent;

            TreeNode tnRet = null;
            foreach (TreeNode tn in tnParent.Nodes)
            {
                tnRet = FindNode(tn, strValue);
                if (tnRet != null) break;
            }
            return tnRet;
        }

        public TreeNode Find(TreeView tv, string name) {

            TreeNode tn = null;
            foreach (TreeNode t in treeView1.Nodes)
            {
                tn = FindNode(t, name);
                if (tn != null) break;
            }
            return tn;

        }
 
        /*根据选中的table节点，寻找数据库*/
        public NpgsqlConnection Establishconnection(TreeNode table)
        {
            Control.connection.SqlConn = new NpgsqlConnection(connString + ";DataBase = " + table.Parent.Parent.Parent.Text.ToString());
            Control.connection.SqlConn.Open();
            return con;
        }

        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Createdb cdb = new Createdb(con,this);
            cdb.Show();
        }

        private void bindNode()
        {
            var cmd = new NpgsqlCommand("select pg_database.datname from pg_database",con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++) {
                List<string> tabname = new List<string>();
                /*database node*/
                var dtnd = new TreeNode();
                dtnd.Text = dt.Rows[i]["datname"].ToString();
                dtnd.ContextMenuStrip = contextMenuStripdb2;
                dtnd.ImageIndex = 2;
                dtnd.SelectedImageIndex = 2;
                dtnd.Name = "db";
                /*schema node*/
                var sche = new TreeNode();
                sche.Name = "Schemas";
                sche.Text = "Schemas";
                sche.ImageIndex = 3;
                sche.SelectedImageIndex = 3;
                sche.ContextMenuStrip = contextMenuStripsche;
                /*table node*/
                var tab = new TreeNode();
                tab.Name = dt.Rows[i]["datname"].ToString();
                tab.Text = "Table";
                tab.ImageIndex = 4;
                tab.SelectedImageIndex = 4;
                tab.ContextMenuStrip = contextMenuStriptab;
                string name = "DataBases";
                /* add database node*/
                TreeNode tndb1 = Find(treeView1, name);
                tndb1.Nodes.Add(dtnd);
               
                /*add schema node*/
                TreeNode tndb2 = Find(treeView1, dt.Rows[i]["datname"].ToString());
                tndb2.Nodes.Add(sche);

                /*add table node*/
                tndb2.Nodes[0].Nodes.Add(tab);
                if (dt.Rows[i]["datname"].ToString() != "template0" && dt.Rows[i]["datname"].ToString() != "template1")
                {
                    //var con1 = new NpgsqlConnection("Host = localhost; Port = 5432; Username = postgres; Password = xjy19991012;DataBase = " + dt.Rows[i]["datname"].ToString());
                    var con1 = new NpgsqlConnection(connString + ";DataBase = " + dt.Rows[i]["datname"].ToString());
                    var cmd1 = new NpgsqlCommand("select tablename from pg_tables where schemaname='public'", con1);
                    NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(cmd1);
                    DataTable dt1 = new DataTable();
                    da1.Fill(dt1);
                  
                    for (int j = 0; j < dt1.Rows.Count; j++)
                    {
                        var tabnd = new TreeNode();
                        tabnd.Text = dt1.Rows[j]["tablename"].ToString();
                   
                      
                        tabname.Add(tabnd.Text);
                     
                        tabnd.ImageIndex = 5;
                        tabnd.SelectedImageIndex = 5;
                        tabnd.ContextMenuStrip = contextMenuStriptab2;
                        tndb2.Nodes[0].Nodes[0].Nodes.Add(tabnd);
                        var cmd2 = new NpgsqlCommand("select column_name from information_schema.columns where table_schema='public' and table_name= '"+ dt1.Rows[j]["tablename"].ToString() + "'", con1);
                        NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd2);
                        DataTable dt2 = new DataTable();
                        da2.Fill(dt2);
                        for(int k = 0; k < dt2.Rows.Count; k++)
                        {
                            var cond = new TreeNode();
                            cond.Text = dt2.Rows[k]["column_name"].ToString();
                            cond.ImageIndex = 6;
                            cond.SelectedImageIndex = 6;
                            cond.ContextMenuStrip = contextMenuStripco;
                            tndb2.Nodes[0].Nodes[0].Nodes[j].Nodes.Add(cond);

                        }
                    }
                }

                /*add db-tab Relation in the dic*/
                dbDic.Add(dt.Rows[i]["datname"].ToString(),tabname);

            }

     
        }



        private void deleteDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
           DialogResult dr=MessageBox.Show("Are you sure you want to drop database " + treeView1.SelectedNode.Text,"DROP Database?",MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                var cmd = new NpgsqlCommand("drop database " + treeView1.SelectedNode.Text + ";", con);
                cmd.ExecuteNonQuery();
                treeView1.SelectedNode.Remove();
                this.Refresh();

            }
            else if (dr == DialogResult.Cancel) {}

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string dbname = this.treeView1.SelectedNode.Name;
            Createtab createtab = new Createtab(dbname,this);
            createtab.Show();
        }

        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Createcon createcon = new Createcon(con,treeView1.SelectedNode,this);
            createcon.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (this.treeView1.SelectedNode.Name == "db")
            {
                Control.connection.SqlConn.Close();
                Control.connection.SqlConn = new NpgsqlConnection(connString + ";database="+this.treeView1.SelectedNode.Text.ToString());
                Control.connection.SqlConn.Open();
            }
        }
    }
}
