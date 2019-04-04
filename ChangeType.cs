using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Npgsql;
namespace pgAdminMain
{
    public partial class ChangeType : MaterialForm
    {
        public NpgsqlConnection connection;
        private String col_name;
        private String table_name;
        private readonly MaterialSkinManager materialSkinManager;
        public ChangeType()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            String type = this.comboBox_datatype.Text;
            if (type == "")
            {
                return;
            }
            else {
                string s;
                if (comboBox_datatype.SelectedItem.ToString() == "character varying[]")
                    s = "VarChar(" + textBox_length.Text.ToString() + ")";
                else if (comboBox_datatype.SelectedItem.ToString() == "char")
                    s = "VarChar(" + textBox_length.Text.ToString() + ")";
                else
                    s = comboBox_datatype.SelectedItem.ToString();
                String com = "ALTER TABLE " + this.table_name + " ALTER COLUMN " + this.col_name + " TYPE " + s + ";";
                NpgsqlCommand command = new NpgsqlCommand(com, this.connection);
                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("修改成功！");
                }
                catch (Exception ee) {
                    MessageBox.Show("修改失败，\n+tips" + ee.Message);
                }
            }
        }

        public void setTableName(String tableName) {
            this.table_name = tableName;
        }
        public void setColName(String columnName) {
            this.col_name = columnName;
        }

        private void comboBox_datatype_SelectedIndexChanged(object sender, EventArgs e)
        {
            //当用户选择为字符串数据类型时显示字数
            if (comboBox_datatype.SelectedItem.ToString() == "character varying[]")
            {
                this.skinLabel3.Visible = true;
                this.textBox_length.Visible = true;
                this.textBox_length.Enabled = true;
            }
            else if (comboBox_datatype.SelectedItem.ToString() == "char")
            {
                this.skinLabel3.Visible = true;
                this.textBox_length.Visible = true;
                this.textBox_length.Enabled = true;
            }
            else
            {
                this.skinLabel3.Visible = false;
                this.textBox_length.Visible = false;
                this.textBox_length.Enabled = false;
            }
        }
    }
}
