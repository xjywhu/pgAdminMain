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
    public partial class InsertValue : MaterialForm
    {
        private readonly MaterialSkinManager materialSkinManager;
        private DataTable table;
        public InsertValue()
        {
            InitializeComponent();
            materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.BlueGrey800, Primary.BlueGrey900, Primary.BlueGrey500, Accent.LightBlue200, TextShade.WHITE);
            //依据所插入表的列数动态生成gridDataView
            this.table = Control.connection.ds.Tables[0];
            for (int i = 0; i < table.Columns.Count; i++) {
                DataGridViewTextBoxColumn col = new DataGridViewTextBoxColumn();
                col.Name = table.Columns[i].ColumnName;
                col.DataPropertyName = table.Columns[i].ColumnName;
                col.HeaderText = table.Columns[i].ColumnName;
                this.skinDataGridView1.Columns.Add(col);
            }
        }

        private String reviseStr(String str, Type type)
        {
            if (str == "") { return " is null"; }//该语句不可执行，不应该执行！
            string C_Type = type.ToString().ToLower();
            switch (C_Type)
            {
                case "system.boolean":
                case "system.byte":
                case "system.int16":
                case "system.int32":
                case "system.int64":
                case "system.decimal":
                case "system.double":
                case "system.single":
                    return  str;
                case "system.datetime":
                case "system.string":
                case "system.byte[]":
                case "system.guid":
                case "system.object":
                    return "'" + str + "'";
                default:
                    return " is null";//该语句不可执行，不应该执行！
            }
        }

        private void skinButton1_Click(object sender, EventArgs e)
        {
            bool success = true;
          
            for (int i = 0; i < this.skinDataGridView1.RowCount - 1; i++)
            {
                //用于分别构建insert语句中的属性list和值list
                string strcomm = "insert into " + Control.background.tableName;
                string col_sentence = " (";
                string values_sentence = " values(";
                
                //先遍历，找到最后一个不为空的值，否则在插入时无法确定合适终止
                int lastOne = 0;
                for (int end = 0; end < this.skinDataGridView1.ColumnCount - 1; end++)
                {
                    if (!(skinDataGridView1.Rows[i].Cells[end].Value == null))
                    {
                        lastOne = end;
                    }
                }

                for (int j = 0; j < this.skinDataGridView1.ColumnCount; j++)
                {
                    
                    if (!(skinDataGridView1.Rows[i].Cells[j].Value==null))
                    {
                        string strcol_name = this.skinDataGridView1.Columns[j].HeaderText;
                        string strrow_value = this.skinDataGridView1.Rows[i].Cells[j].Value.ToString();
                        if (j != lastOne)
                        {
                            col_sentence = col_sentence + strcol_name + ",";
                            values_sentence = values_sentence + reviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[j].DataType) + ",";
                            //strcomm = strcomm + strcol_name + reviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[j].DataType)+",";
                        }
                        else
                        {
                            col_sentence = col_sentence + strcol_name + ") ";
                            values_sentence = values_sentence + reviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[j].DataType) + ");";
                        }
                    }
                }
                strcomm = strcomm + col_sentence + values_sentence;
                try
                {
                    NpgsqlCommand comm = new NpgsqlCommand(strcomm, Control.connection.SqlConn);
                    comm.ExecuteNonQuery();
                }
                catch (Exception ee)
                {
                    success = false;
                    MessageBox.Show("无法完成修改\n" + ee.Message);
                }
            }
            if (success)
            {
                MessageBox.Show("修改成功！");
            }

            String sel_table = "select * from " + Control.background.tableName;
            NpgsqlCommand command = new NpgsqlCommand(sel_table, Control.connection.SqlConn);
            //   Control.connection.SqlConn.Open();
            try
            {
                command.ExecuteNonQuery();
                NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(sel_table, Control.connection.SqlConn);
                Control.connection.ds = new DataSet();
                npgsql.Fill(Control.connection.ds);
                //Control.connection.SqlConn.Close();

                //刷新gridview
                Control.background.GetDataGridView().DataSource = null;
                Control.background.GetDataGridView().EditMode = DataGridViewEditMode.EditOnEnter;
                Control.background.GetDataGridView().DataSource = Control.connection.ds;

                Control.background.GetDataGridView().DataMember = Control.connection.ds.Tables[0].TableName;

                Control.background.GetDataGridView().EnableHeadersVisualStyles = false;
                Control.background.GetDataGridView().ColumnHeadersDefaultCellStyle.Font = new Font("隶书", 9, FontStyle.Italic);
                Control.background.GetDataGridView().ColumnHeadersDefaultCellStyle.ForeColor = Color.Purple;
                Control.background.SetFormerNum(Control.background.GetDataGridView().ColumnCount);


                var cmd = new NpgsqlCommand("select data_type,column_name, character_maximum_length from information_schema.columns where table_schema='public' and table_name= '" + Control.background.tableName + "'", Control.connection.SqlConn);
                NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                da.Fill(dt);

                for (int i = 0; i < Control.background.GetDataGridView().ColumnCount; i++)
                {
                    //dataGridView1.Columns[i].HeaderText = dataGridView1.Columns[i].HeaderText + "\ntype:" + Control.connection.ds.Tables[0].Columns[i].DataType.ToString().Substring(Control.connection.ds.Tables[0].Columns[i].DataType.ToString().IndexOf('.') + 1);
                    for (int k = 0; k < dt.Rows.Count; k++)
                    {
                        if (Control.background.GetDataGridView().Columns[i].HeaderText != dt.Rows[k]["column_name"].ToString())
                        {
                            continue;
                        }
                        else
                        {
                            Control.background.GetDataGridView().Columns[i].HeaderText = Control.background.GetDataGridView().Columns[i].HeaderText + "\ntype:" + dt.Rows[k]["data_type"].ToString();
                            if (dt.Rows[k]["data_type"].ToString() == "character" || dt.Rows[k]["data_type"].ToString() == "character varying")
                            {
                                Control.background.GetDataGridView().Columns[i].HeaderText = Control.background.GetDataGridView().Columns[i].HeaderText + "[" + dt.Rows[k]["character_maximum_length"].ToString() + "]";
                            }
                        }
                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("未能刷新！\ntips:" + ee.Message);
            }
        }
    }
}
