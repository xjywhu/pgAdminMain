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
    public partial class Createcon : MaterialForm   
    {
        TreeNode selecttn;
        NpgsqlConnection con;
        MainForm f;
        private readonly MaterialSkinManager materialSkinManager;
        public Createcon(NpgsqlConnection con, TreeNode selecttn, MainForm f)
        {
            this.selecttn = selecttn;
            this.con = con;
            this.f = f;
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }



        /*判断用户输入的数值是否和选中的数据类型匹配*/
        public bool judgeType(string type, string content, int length)
        {
            JudgeType jt = new JudgeType();
            bool flag = true;
            switch (type)
            {
                case "Int":
                    flag = jt.isInt(content);
                    break;
                case "character varying[]":
                    flag = (content.Length <= length);
                    break;
                case "date":
                    flag = jt.IsDate(content);
                    break;
                case "smallint":
                    flag = jt.isSmallint(content);
                    break;
                case "char":
                    flag = (content.Length <= length);
                    break;
                default:
                    flag = true;
                    break;
            }
            return flag;
        }

        private void cancle_Click(object sender, EventArgs e)
        {
            
        }

        private void save_Click(object sender, EventArgs e)
        {
           
        }
        /*当用户选中character varying[]和char的时候可以对长度进行编辑*/
        private void comboBox_datatype_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox_datatype.SelectedItem.ToString() == "character varying[]"|| comboBox_datatype.SelectedItem.ToString() == "char")
                this.textBox_length.Enabled = true;
            else
            {
                this.textBox_length.Enabled = false;
                this.textBox_length.Clear();
            }
            if (comboBox_datatype.SelectedItem.ToString() == "date")
                this.label6.Visible = true;
            else
                this.label6.Visible = false;

        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void save_Click_1(object sender, EventArgs e)
        {
            /*判断创建列的约束条件：列名不为空且符合命名规则，列名不能在表中已经存在，列名的数据类型和用户输入的默认值必须匹配
           当选中char和varchar选项时可以编辑长度，但是长度不为空且必须是整数 
          */
            JudgeType jt = new JudgeType();
            if (textBox_name.Text.ToString() == "")
            {
                MessageBox.Show("Column name cann't be empty");
                return;

            }
            if (comboBox_datatype.SelectedItem == null)
            {
                MessageBox.Show("Column datatype cann't be empty");
                return;
            }
            if (comboBox_datatype.SelectedItem.ToString() == "character varying[]"|| comboBox_datatype.SelectedItem.ToString() == "char")
            {
                if (textBox_length.Text.ToString() == "")
                {
                    MessageBox.Show("The length of character varying[] cann't be empty");
                    return;
                }
                else if (!jt.isNoSignInt(textBox_length.Text.ToString()) || int.Parse(textBox_length.Text) == 0)
                {
                    MessageBox.Show("Length must be a positive integer");
                    return;
                }
            }

            var cmd = new NpgsqlCommand("select column_name from information_schema.columns where table_schema='public' and table_name= '" + selecttn.Text + "'", con);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            try
            {
                da.Fill(dt);
            }
            catch (Npgsql.NpgsqlException)
            {
                MessageBox.Show("请选中正确的节点后，再进行创建列操作");
                return;

            }
            
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
            else if (comboBox_datatype.SelectedItem.ToString() == "char")
                s = "VarChar(" + textBox_length.Text.ToString() + ")";
            else
                s = comboBox_datatype.SelectedItem.ToString();
            if (checkBox_notnull.Checked)
            {
                s += " not null";
            }
            //default
            if (textBox_default.Text != "")
            {
                int length = 0;
                if (jt.isChinese(textBox_default.Text) || jt.IsDate(textBox_default.Text))
                    s += " default('" + textBox_default.Text + "')";
                else
                    s += " default(" + textBox_default.Text + ")";
                if (!(textBox_length.Text.ToString() == ""))
                    length = int.Parse(textBox_length.Text);
                if (!judgeType(comboBox_datatype.Text, textBox_default.Text, length))
                {
                    MessageBox.Show("The data type and the default doesn't match");
                    return;
                }
            }

            var cmdcreate = new NpgsqlCommand("ALTER TABLE " + selecttn.Text.ToString() + " ADD " + textBox_name.Text + " " + s + ";", con);
            try
            {
                cmdcreate.ExecuteNonQuery();
            }
            catch (Npgsql.PostgresException)
            {
                MessageBox.Show("The name of the column doesn't follow the standard variable naming rule");
                return;
            }
            /*add con node*/
            var cond = new TreeNode();
            cond.Text = textBox_name.Text;
            cond.ImageIndex = 6;
            cond.SelectedImageIndex = 6;
            cond.ContextMenuStrip = f.contextMenuStripco;
            cond.NodeFont = new Font("华文新魏", 9, FontStyle.Bold);
            f.treeView1.SelectedNode.Nodes.Add(cond);
            f.Refresh();
            this.Close();
        }
    }
}
