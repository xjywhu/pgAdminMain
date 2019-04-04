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
using MaterialSkin;
using MaterialSkin.Controls;
namespace pgAdminMain
{
    public partial class MainForm : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        public static string connString = "Host=" + Control.connection.getSever() + ";Port=" + Control.connection.getPort() + ";Username=" + Control.connection.getUsername() + ";Password=" + Control.connection.getPassword();
        NpgsqlConnection con = Control.connection.SqlConn;
        public TreeviewController tvc;
        /*存储数据库名和表名的字典*/
        public  Dictionary<string, List<string>> dbDic;
        public MainForm(){
            dbDic = new Dictionary<string, List<string>>();
            InitializeComponent();

            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);

            tvc = new TreeviewController(this.treeView1);
            //con.Open();
            ZBindNode();
            Control.mainform = this;
        }
       
        private void dataBaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Createdb cdb = new Createdb(con,this);
            cdb.Show();
        }
        /*绑定树形试图节点，显示数据库树形结构*/
        private void ZBindNode()
        {

            var cmd = new NpgsqlCommand("select pg_database.datname from pg_database", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                if (dt.Rows[i]["datname"].ToString() != "template0" && dt.Rows[i]["datname"].ToString() != "template1")
                {
                    List<string> tabname = new List<string>();
                    /*database node*/
                    var dtnd = new TreeNode();
                    dtnd.Text = dt.Rows[i]["datname"].ToString();
                    dtnd.ContextMenuStrip = contextMenuStripdb2;
                    dtnd.ImageIndex = 2;
                    dtnd.SelectedImageIndex = 2;
                    dtnd.Name = "db";
                    dtnd.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
                    /*schema node*/
                    var sche = new TreeNode();
                    sche.Name = "sc";
                    sche.Text = "Schemas";
                    sche.ImageIndex = 3;
                    sche.SelectedImageIndex = 3;
                    sche.ContextMenuStrip = contextMenuStripsche;
                    sche.NodeFont= new Font("华文新魏", 9, FontStyle.Bold);
                    /*table node*/
                    var tab = new TreeNode();
                    tab.Name = dt.Rows[i]["datname"].ToString();
                    tab.Text = "Table";
                    tab.ImageIndex = 4;
                    tab.SelectedImageIndex = 4;
                    tab.ContextMenuStrip = contextMenuStriptab;
                    tab.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
                    string name = "DataBases";
                    /* add database node*/
                    TreeNode tndb1 = tvc.Find(treeView1, name);
                    tndb1.Nodes.Add(dtnd);

                    /*add schema node*/
                    TreeNode tndb2 = tvc.Find(treeView1, dt.Rows[i]["datname"].ToString());
                    tndb2.Nodes.Add(sche);

                    /*add table node*/
                    tndb2.Nodes[0].Nodes.Add(tab);
                    /*通过dataset遍历数据库，同时绑定table和column节点*/
                    if (dt.Rows[i]["datname"].ToString() != "template0" && dt.Rows[i]["datname"].ToString() != "template1")
                    {
                        
                        var con1 = new NpgsqlConnection(connString + ";DataBase = " + dt.Rows[i]["datname"].ToString());
                        var cmd1 = new NpgsqlCommand("select tablename from pg_tables where schemaname='public'", con1);
                        NpgsqlDataAdapter da1 = new NpgsqlDataAdapter(cmd1);
                        DataTable dt1 = new DataTable();
                        da1.Fill(dt1);

                        for (int j = 0; j < dt1.Rows.Count; j++)
                        {
                            var tabnd = new TreeNode();
                            tabnd.Text = dt1.Rows[j]["tablename"].ToString();
                            tabnd.Name = "tb";
                            tabname.Add(tabnd.Text);
                            tabnd.ImageIndex = 5;
                            tabnd.SelectedImageIndex = 5;
                            tabnd.ContextMenuStrip = contextMenuStriptab2;
                            tabnd.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
                            tndb2.Nodes[0].Nodes[0].Nodes.Add(tabnd);
                            var cmd2 = new NpgsqlCommand("select column_name from information_schema.columns where table_schema='public' and table_name= '" + dt1.Rows[j]["tablename"].ToString() + "'", con1);
                            NpgsqlDataAdapter da2 = new NpgsqlDataAdapter(cmd2);
                            DataTable dt2 = new DataTable();
                            da2.Fill(dt2);
                            for (int k = 0; k < dt2.Rows.Count; k++)
                            {
                                var cond = new TreeNode();
                                cond.Text = dt2.Rows[k]["column_name"].ToString();
                                cond.Name = "con";
                                cond.ImageIndex = 6;
                                cond.SelectedImageIndex = 6;
                                cond.ContextMenuStrip = contextMenuStripco;
                                cond.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
                                tndb2.Nodes[0].Nodes[0].Nodes[j].Nodes.Add(cond);

                            }
                        }
                    }
                    /*add db-tab Relation in the dic*/
                    dbDic.Add(dt.Rows[i]["datname"].ToString(), tabname);
                }

            }
        }
        /*删除数据库事件*/
        private void deleteDropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Control.connection.SqlConn.Close();
            var con1 = new NpgsqlConnection(connString);
           DialogResult dr=MessageBox.Show("Are you sure you want to drop database " + treeView1.SelectedNode.Text,"DROP Database?",MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {

                con1.Open();
                /*bug 如果没有con.open,当刚进入删除数据库会异常（con没开）
                 * ，如果创建了一个新的数据库，在未关闭MainForm的时候删除会异常（con已经开了）*/
                var cmd = new NpgsqlCommand("drop database " + treeView1.SelectedNode.Text + ";", con1);
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Npgsql.NpgsqlException)
                {
                    MessageBox.Show("You cann't delete the database because other user is using the database");
                    return;
                }
                finally
                {

                    con1.Close();
                }
               
                treeView1.SelectedNode.Remove();
                this.Refresh();

            }
            else if (dr == DialogResult.Cancel) {}

        }
        /*创建表响应事件*/
        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            string dbname = this.treeView1.SelectedNode.Name;
      
            Createtab createtab = new Createtab(dbname,this,this.treeView1.SelectedNode);
            createtab.Show();
        }
        /*创建列响应事件*/
        private void columnToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                var con = new NpgsqlConnection(connString + ";DataBase = " + this.treeView1.SelectedNode.Parent.Parent.Parent.Text.ToString());
                con.Open();
            }
            catch (System.NullReferenceException)
            {
                MessageBox.Show("请选中正确的节点再进行创建列操作");
                return;
            }
            catch (Npgsql.NpgsqlException)
            {
                MessageBox.Show("请选中正确的节点再进行创建列操作");
                return;
            }
            Createcon createcon = new Createcon(con,treeView1.SelectedNode,this);
            createcon.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            TreeviewController tvc = new TreeviewController(this.treeView1);

            if (this.treeView1.SelectedNode.Name == "db")
            {
                Control.connection.SqlConn.Close();
                Control.connection.SqlConn = tvc.EsConOnDataBase(this.treeView1.SelectedNode);

            }
            if (this.treeView1.SelectedNode.Name == "sc")
            {
                Control.connection.SqlConn.Close();
                Control.connection.SqlConn = tvc.EsConOnSchemas(this.treeView1.SelectedNode);

                String sel_table = "select * from information_schema.tables;";
               // Control.background.tableName = this.treeView1.SelectedNode.Text;
                NpgsqlCommand command = new NpgsqlCommand(sel_table, Control.connection.SqlConn);
                //   Control.connection.SqlConn.Open();
                try
                {
                    command.ExecuteNonQuery();
                    NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(sel_table, Control.connection.SqlConn);
                    Control.connection.ds = new DataSet();
                    npgsql.Fill(Control.connection.ds);
                    //Control.connection.SqlConn.Close();

                    Control.background2.GetDataGridView1().DataSource = null;
                    Control.background2.GetDataGridView1().EditMode = DataGridViewEditMode.EditOnEnter;
                    Control.background2.GetDataGridView1().DataSource = Control.connection.ds;

                    Control.background2.GetDataGridView1().DataMember = Control.connection.ds.Tables[0].TableName;

                    Control.background2.GetDataGridView1().EnableHeadersVisualStyles = false;
                    Control.background2.GetDataGridView1().ColumnHeadersDefaultCellStyle.Font = new Font("隶书", 9, FontStyle.Italic);
                    Control.background2.GetDataGridView1().ColumnHeadersDefaultCellStyle.ForeColor = Color.Purple;
                    //Control.background2.SetFormerNum(Control.background2.GetDataGridView1().ColumnCount);


                }
                catch (Exception ee)
                {
                    MessageBox.Show("请检查您的指令！\ntips:" + ee.Message);
                }

                String sel_table2 = "select * from information_schema.columns;";
                // Control.background.tableName = this.treeView1.SelectedNode.Text;
                NpgsqlCommand command2 = new NpgsqlCommand(sel_table2, Control.connection.SqlConn);
                //   Control.connection.SqlConn.Open();
                try
                {
                    command2.ExecuteNonQuery();
                    NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(sel_table2, Control.connection.SqlConn);
                    Control.connection.ds = new DataSet();
                    npgsql.Fill(Control.connection.ds);
                    //Control.connection.SqlConn.Close();

                    Control.background2.GetDataGridView2().DataSource = null;
                    Control.background2.GetDataGridView2().EditMode = DataGridViewEditMode.EditOnEnter;
                    Control.background2.GetDataGridView2().DataSource = Control.connection.ds;

                    Control.background2.GetDataGridView2().DataMember = Control.connection.ds.Tables[0].TableName;

                    Control.background2.GetDataGridView2().EnableHeadersVisualStyles = false;//这样就可以使用当前的主题的样式了，这句话十分关键！
                    Control.background2.GetDataGridView2().ColumnHeadersDefaultCellStyle.Font = new Font("隶书", 9, FontStyle.Italic);
                    Control.background2.GetDataGridView2().ColumnHeadersDefaultCellStyle.ForeColor = Color.Purple;
                    //Control.background2.SetFormerNum(Control.background2.GetDataGridView1().ColumnCount);

                }
                catch (Exception ee)
                {
                    MessageBox.Show("请检查您的指令！\ntips:" + ee.Message);
                }


            }
            if (this.treeView1.SelectedNode.Text == "Table")
            {
                Control.connection.SqlConn.Close();
                Control.connection.SqlConn = tvc.EsConOnTable1(this.treeView1.SelectedNode);
                //
               
                //
            }
            if (this.treeView1.SelectedNode.Name == "tb")
            {
                Control.connection.SqlConn.Close();
                Control.connection.SqlConn = tvc.EsConOnTable2(this.treeView1.SelectedNode);

                String sel_table = "select * from " + this.treeView1.SelectedNode.Text;
                Control.background.tableName= this.treeView1.SelectedNode.Text;
                NpgsqlCommand command = new NpgsqlCommand(sel_table, Control.connection.SqlConn);
                //   Control.connection.SqlConn.Open();
                try
                {
                    command.ExecuteNonQuery();
                    NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(sel_table, Control.connection.SqlConn);
                    Control.connection.ds = new DataSet();
                    npgsql.Fill(Control.connection.ds);
                    //Control.connection.SqlConn.Close();

                    Control.background.FullFilDataGrid();

                    //Control.background.GetDataGridView().DataMember = Control.connection.ds.Tables[0].TableName;

                    Control.background.GetDataGridView().EnableHeadersVisualStyles = false;//这样就可以使用当前的主题的样式了，这句话十分关键！
                    Control.background.GetDataGridView().ColumnHeadersDefaultCellStyle.Font = new Font("隶书", 9, FontStyle.Italic);
                    Control.background.GetDataGridView().ColumnHeadersDefaultCellStyle.ForeColor = Color.Purple;
                    Control.background.SetFormerNum(Control.background.GetDataGridView().ColumnCount);
                }
                catch (Exception ee)
                {
                    MessageBox.Show("请检查您的指令！\ntips:" + ee.Message);
                }
            }

            if (this.treeView1.SelectedNode.Name == "con")
            {
                Control.connection.SqlConn.Close();
                Control.connection.SqlConn = tvc.EsConOnColumn(this.treeView1.SelectedNode);
            }
        }

        /*delete table*/
        private void deleteDropToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure you want to drop table " + treeView1.SelectedNode.Text, "DROP Table?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                var cmd = new NpgsqlCommand("drop table " + treeView1.SelectedNode.Text + ";", tvc.EsConOnTable2(treeView1.SelectedNode));
                cmd.ExecuteNonQuery();
                treeView1.SelectedNode.Remove();
                this.Refresh();
            }
            else if (dr == DialogResult.Cancel) { }
        }
        /*delete column*/
        private void deleteDropToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            //var con1 = new NpgsqlConnection();
            var con1 = new NpgsqlConnection(connString + ";DataBase = " + this.treeView1.SelectedNode.Parent.Parent.Parent.Parent.Text.ToString());
            con1.Open();
            DialogResult dr = MessageBox.Show("Are you sure you want to drop column " + treeView1.SelectedNode.Text, "DROP Table?", MessageBoxButtons.OKCancel);
            if (dr == DialogResult.OK)
            {
                var cmd = new NpgsqlCommand("alter table "+treeView1.SelectedNode.Parent.Text.ToString()+" drop column " + treeView1.SelectedNode.Text + ";", con1);
                cmd.ExecuteNonQuery();
                treeView1.SelectedNode.Remove();
                this.Refresh();
            }
            else if (dr == DialogResult.Cancel) { }
        }

        private void refreshToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            this.Refresh();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Control.login.Show();
            Control.connection.SqlConn.Close();
        }
        //>>>>>>> master

        public void MyRefresh()
        {
            dbDic = new Dictionary<string, List<string>>();
            tvc = new TreeviewController(this.treeView1);
           
            ZBindNode(); this.Refresh();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void alterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //修改数据类型
            var con1 = new NpgsqlConnection(connString + ";DataBase = " + this.treeView1.SelectedNode.Parent.Parent.Parent.Parent.Text.ToString());
            con1.Open();
            ChangeType change = new ChangeType();
            change.Show();
            change.connection = con1;
            change.setColName(this.treeView1.SelectedNode.Text);
            change.setTableName(this.treeView1.SelectedNode.Parent.Text);
        }

        private void createToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }
    }
}
