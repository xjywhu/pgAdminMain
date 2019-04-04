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

    public partial class Createtab : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        string dbname;
        MainForm f;
        TreeNode t;
        public Createtab(string dbname,MainForm f,TreeNode t)
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            this.f = f;
            this.dbname = dbname;
            this.t = t;
        }


        private void Save_Click(object sender, EventArgs e)
        {
            /*存储列名和数据类型的字典*/
            Dictionary<string, string> dicTab = new Dictionary<string, string>();
            JudgeType jt = new JudgeType();
            string[] s = new string[this.dataGridView1.RowCount];
            List<string> pkey = new List<string>();
            int count = 0;
            /*计算主键个数*/
            foreach (DataGridViewRow item in this.dataGridView1.Rows)
            {
                if ((bool)item.Cells[4].EditedFormattedValue)
                {
                    count++;
                    pkey.Add(item.Cells[0].Value.ToString());
                }
            }

            /*判断创建表的约束条件：表名列名不为空且符合命名规则，列名不能重复，列名的数据类型和用户输入的默认值必须匹配
             当选中char和varchar选项时可以编辑长度，但是长度不为空且必须是整数 ，表名不能和数据库中已经存在的表名重复
             */
            if (text_box_tablename.Text.ToString() == "")
            {
                MessageBox.Show("The table name can't be empty");
                return;
            }

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
                    if (item.Cells[1].Value.ToString() == "character varying[]"|| item.Cells[1].Value.ToString() == "char")
                    {
                        if (item.Cells[2].Value == null)
                        {
                            MessageBox.Show("The length can't be empty");
                            return;
                        }
                        if (!jt.isNoSignInt(item.Cells[2].Value.ToString())|| int.Parse(item.Cells[2].Value.ToString()) == 0)
                        {
                            MessageBox.Show("Length must be a positive integer");
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
                    if (item.Cells[5].Value!=null)
                    {
                        int length = 0;
                        if (item.Cells[2].Value.ToString()!="")
                            length = int.Parse(item.Cells[2].Value.ToString());
                        if (!jt.judgeType(item.Cells[1].Value.ToString(), item.Cells[5].Value.ToString(), length)){

                            MessageBox.Show("The data type and the default doesn't match");
                            return;
                        }
                        if (jt.isChinese(item.Cells[5].Value.ToString()) || jt.IsDate(item.Cells[5].Value.ToString())|| item.Cells[1].Value.ToString() == "character varying[]" || item.Cells[1].Value.ToString() == "char")
                        svalue += " default('"+ item.Cells[5].Value.ToString()+"')";
                        else
                        svalue += " default(" + item.Cells[5].Value.ToString() + ")";
                    }
                       
                    try
                    {
                        dicTab.Add(item.Cells[0].Value.ToString(), svalue);
                    }
                    catch (System.ArgumentException)
                    {
                        MessageBox.Show("Column name cannot be repeated");
                        return;
                    }
                }

           }


  

            /*连接数据库，在数据库中创建表*/
            var con = new NpgsqlConnection(MainForm.connString + ";DataBase = " + dbname);
            try
            {
                con.Open();
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("请选中正确的节点后，再进行创建表操作");
                return;

            }
           
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
            {/*创建没有列的空表*/
                cmdstring = "CREATE TABLE " + text_box_tablename.Text.ToString() + "();";
                var cmdtab = new NpgsqlCommand(cmdstring, con);
                try
                {

                    cmdtab.ExecuteNonQuery();
                }
                catch (Npgsql.NpgsqlException ee)
                {

                    MessageBox.Show("The table cann't be created\n"+ee.Message);
                    return;
                }
                catch (Exception) {
                    MessageBox.Show("The name of table doesn't follow the standard variable naming rule");
                    return;
                }
              
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
                try
                {
                    cmdtab.ExecuteNonQuery();
                }
                catch (Npgsql.PostgresException)
                {
                    MessageBox.Show("The name of the column or table doesn't follow the standard variable naming rule");
                    return;
                }

                /*add Treenode*/
                /*add table node*/
                var tabnd = new TreeNode();
                tabnd.Text = text_box_tablename.Text.ToString();
                tabnd.ImageIndex = 5;
                tabnd.SelectedImageIndex = 5;
                tabnd.ContextMenuStrip = f.contextMenuStriptab2;
                tabnd.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
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
            if (e.ColumnIndex==6)
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
                    if(combox.SelectedItem.ToString() == "date")
                    {

                    }
                    if (combox.SelectedItem.ToString() == "character varying[]"|| combox.SelectedItem.ToString() == "char")
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

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
