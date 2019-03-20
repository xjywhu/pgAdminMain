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
    public partial class Createtab : Form
    {
        string dbname;
        MainForm f;
        TreeNode t;
        public Createtab(string dbname,MainForm f,TreeNode t)
        {
            InitializeComponent();
            this.f = f;
            this.dbname = dbname;
            this.t = t;
        }

        private bool isInt(string s)
        {
            bool flag = true;
            for (int i = 0; i < s.Length; i++)
                if (!char.IsNumber(s, i))
                    flag = false;
            return flag;

        }

        private void Save_Click(object sender, EventArgs e)
        {
            /*存储列名和数据类型的字典*/
            Dictionary<string, string> dicTab = new Dictionary<string, string>();
            string[] s = new string[this.dataGridView1.RowCount];
            List<string> pkey = new List<string>();
            int count = 0;

            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                if ((bool)item.Cells[4].EditedFormattedValue)
                {
                    count++;
                    pkey.Add(item.Cells[0].Value.ToString());
                }
            }


            if (text_box_tablename.Text.ToString() == "")
            {
                MessageBox.Show("The table name can't be empty");
                return;
            }
            //var con1 = new NpgsqlConnection(MainForm.connString + ";DataBase = " + f.treeView1.SelectedNode.Text.ToString());
            //var cmd = new NpgsqlCommand("select tablename from pg_tables where schemaname='public'", con1);
            //NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            //DataTable dt = new DataTable();
            //da.Fill(dt);

            //for (int j = 0; j < dt.Rows.Count; j++)
            //{

            //    if (dt.Rows[j]["tablename"].ToString() ==text_box_tablename.Text)
            //    {
            //        MessageBox.Show("The table "+ text_box_tablename.Text + "has been created");
            //        return;
            //    }
            //}

                foreach (DataGridViewRow item in this.dataGridView1.Rows)
                {
                string svalue;
                if (item.Cells[0].Value == null)
                {
                    MessageBox.Show("The column name can't be empty");
                    return;
                }
                else
                {

            

                    if (item.Cells[1].Value ==null)
                    {
                        MessageBox.Show("The datatype can't be empty");
                        return;
                    }
                    if (item.Cells[1].Value.ToString() == "character varying[]")
                    {
                        if (item.Cells[2].Value == null)
                        {
                            MessageBox.Show("The length can't be empty");
                            return;
                        }
                        svalue = "VarChar(" + item.Cells[2].Value.ToString()+")";
                    }
                    else
                        svalue = item.Cells[1].Value.ToString();
                    if ((bool)item.Cells[3].EditedFormattedValue)
                        svalue += " not null";
                    if ((bool)item.Cells[4].EditedFormattedValue && count == 1)
                        svalue += " primary key";
                    try{
                        dicTab.Add(item.Cells[0].Value.ToString(), svalue);
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Column name cannot be repeated");
                        return;
                    }

                    
                }

           }

           
                foreach (DataGridViewRow item in this.dataGridView1.Rows)
                {
                if (!item.Cells[2].ReadOnly)
                {
                    if (item.Cells[2].Value == null)
                    {
                        MessageBox.Show("The length can't be empty");
                        return;
                    }
                    if (!isInt(item.Cells[2].Value.ToString()))
                    {
                        MessageBox.Show("Length must be an integer");
                    }
                }
             }

            //for(int j = 0; j < this.dataGridView1.RowCount; j++)
            //{
            //    s[j]= this.dataGridView1.Rows[j].Cells[0].Value.ToString();
            //}
            //if (s.Distinct().Count() != s.Length) {
            //    MessageBox.Show("Column name cannot be repeated ");
            //    return;
            //}



            /*连接数据库，在数据库中创建表*/
            var con = new NpgsqlConnection(MainForm.connString + ";DataBase = " + dbname);
            con.Open();
            /*判断表是否已经存在*/
            var cmd = new NpgsqlCommand("select tablename from pg_tables where schemaname='public'", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int k = 0; k < dt.Rows.Count; k++)
            {
                if (dt.Rows[k]["tablename"].ToString() == text_box_tablename.Text)
                {
                    MessageBox.Show("The table " + text_box_tablename.Text + " has been created");
                    return;
                }
            }
            string cmdstring;
            if (this.dataGridView1.Rows.Count == 0)
            {
                cmdstring = "CREATE TABLE " + text_box_tablename.Text.ToString() + "();";
                var cmdtab = new NpgsqlCommand(cmdstring, con);
                cmdtab.ExecuteNonQuery();
                var tabnd = new TreeNode();
                tabnd.Text = text_box_tablename.Text.ToString();
                tabnd.ImageIndex = 5;
                tabnd.SelectedImageIndex = 5;
                tabnd.ContextMenuStrip = f.contextMenuStriptab2;
                t.Nodes.Add(tabnd);
            }
            else
            {
                 cmdstring = "CREATE TABLE " + text_box_tablename.Text.ToString() + "(";
                int i;
                List<string> keys = new List<string>(dicTab.Keys);
                for (i = 0; i < keys.Count - 1; i++)
                {
                    cmdstring += keys[i] + " " + dicTab[keys[i]] + ",";
                }
                cmdstring += keys[i] + " " + dicTab[keys[i]];

                if (count > 1)
                {
                    cmdstring += ",primary key (";
                    for (i = 0; i < pkey.Count - 1; i++)
                    {
                        cmdstring += pkey[i] + ",";
                    }

                    cmdstring += pkey[i] + "));";

                }
                else
                    cmdstring += ");";

     

                var cmdtab = new NpgsqlCommand(cmdstring, con);
                cmdtab.ExecuteNonQuery();
                // }
                ////catch (Npgsql.PostgresException)
                ////{
                ////    MessageBox.Show("The table " + text_box_tablename.Text + " has been created");
                ////}

                /*add Treenode*/
                /*add table node*/
                var tabnd = new TreeNode();
                tabnd.Text = text_box_tablename.Text.ToString();
                tabnd.ImageIndex = 5;
                tabnd.SelectedImageIndex = 5;
                tabnd.ContextMenuStrip = f.contextMenuStriptab2;
                t.Nodes.Add(tabnd);
                /*add column node*/
                //TreeNode tnd = f.Find(f.treeView1, text_box_tablename.Text.ToString());
                foreach (string key in dicTab.Keys)
                {
                    var cond = new TreeNode();
                    cond.Text = key;
                    cond.ImageIndex = 6;
                    cond.SelectedImageIndex = 6;
                    cond.ContextMenuStrip = f.contextMenuStripco;
                    tabnd.Nodes.Add(cond);
                }
            }

    
            f.Refresh();
            this.Close();
        }

        /*删除行按钮事件*/
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex==5)
            {
                DialogResult drTemp = MessageBox.Show("Detele the Row?", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                if (drTemp == DialogResult.OK)
                {

                    this.dataGridView1.Rows.Remove(this.dataGridView1.CurrentRow);
                }
            }
        }

        private void button_addrows_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            this.dataGridView1.Rows.Add(row);
        }


 
        /*combox的下拉事件*/
        public void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            //这里比较重要
            combox.Leave += new EventHandler(combox_Leave);
            try
            {
                //在这里就可以做值是否改变判断
                if (combox.SelectedItem != null)
                {
                    if (combox.SelectedItem.ToString() == "character varying[]")
                        dataGridView1.CurrentRow.Cells[2].ReadOnly = false;
                    else
                    {
                        dataGridView1.CurrentRow.Cells[2].ReadOnly = true;
                        dataGridView1.CurrentRow.Cells[2].Value = "";
                    }

                }

                //  Thread.Sleep(100);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void combox_Leave(object sender, EventArgs e)
        {
            ComboBox combox = sender as ComboBox;
            //做完处理，须撤销动态事件
            combox.SelectedIndexChanged -= new EventHandler(ComboBox_SelectedIndexChanged);
        }

        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            this.dataGridView1 = sender as DataGridView;
            //判断相应的列
            if (dataGridView1.CurrentCell.GetType().Name == "DataGridViewComboBoxCell" && dataGridView1.CurrentCell.RowIndex != -1)
            {
                //给这个DataGridViewComboBoxCell加上下拉事件
                (e.Control as ComboBox).SelectedIndexChanged += new EventHandler(ComboBox_SelectedIndexChanged);
            }
        }
    }
}
