using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace pgAdminMain
{
    public partial class QueryBackground : UserControl
    {
        public String tableName;
        private int former_num_col;//之前的列数目，用以更新列时刷新所用
        public QueryBackground()
        {
            InitializeComponent();
            Control.background = this;
        }

        private static String GetCommand(String str)//获取sql语句的指令名ex select,delete,insert等
        {
            int index = -1;
            if ((index = str.IndexOf(" ", StringComparison.OrdinalIgnoreCase)) < 0)
            {
                return null;
            }
            //find next space
            int index_1 = 0;
            while (str[index_1] == ' ') { index_1 += 1; }//正常情况下应该是0
            int index_2 = str.IndexOf(' ', index_1 + 1);
            if (index_2 == -1)
            {
                return null;
            }
            else
                return str.Substring(index_1, index_2 - index_1);
        }

        private static String GetTableName(String Com_type,String str)//获取在SQL指令中的table名
        {
            int index = 0;
            int index_1;
            if (Com_type.Equals("select", StringComparison.OrdinalIgnoreCase))
            {
                if ((index = str.IndexOf("from", StringComparison.OrdinalIgnoreCase)) < 0)
                {
                    return null;
                }
                index_1 = index + 4;
            }
            else if (Com_type.Equals("delete", StringComparison.OrdinalIgnoreCase))
            {
                if ((index = str.IndexOf("from", StringComparison.OrdinalIgnoreCase)) < 0)
                {
                    return null;
                }
                index_1 = index + 4;
            }
            else if (Com_type.Equals("update", StringComparison.OrdinalIgnoreCase))
            {
                if ((index = str.IndexOf("update", StringComparison.OrdinalIgnoreCase)) < 0)
                {
                    return null;
                }
                index_1 = index + 6;
            }
            else if (Com_type.Equals("insert", StringComparison.OrdinalIgnoreCase))
            {
                if ((index = str.IndexOf("into", StringComparison.OrdinalIgnoreCase)) < 0)
                {
                    return null;
                }
                index_1 = index + 4;
            }
            else if (Com_type.Equals("alter", StringComparison.OrdinalIgnoreCase))
            {
                if ((index = str.IndexOf("table", StringComparison.OrdinalIgnoreCase)) < 0)
                {
                    return null;
                }
                index_1 = index + 5;
            }
            else
            {
                index_1 = 0;
            }
            
            //find next space
        
            while (str[index_1] == ' ') { index_1 += 1; }
            int index_2 = str.IndexOf(' ', index_1 + 1);
            if (index_2 == -1)
            {
                int indexCon = str.IndexOf(';');
                if (indexCon == -1)
                    return str.Substring(index_1);
                else
                    return str.Substring(index_1, indexCon - index_1);
            }
            else
                return str.Substring(index_1, index_2-index_1);
        }

                
        private String ReviseStr(String str,Type type )//在构建SQL指令时使用，依据Type参数 返回 is null 字符串， 或者加上单引号，或者不变
        {
            if (str =="") { return " is null"; }
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
                    return  "="+str;
                case "system.datetime":
                case "system.string":
                case "system.byte[]":
                case "system.guid":
                case "system.object":
                    return "='"+str+"'";
                default:
                    return " is null";
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)//在DataGridView上直接修改数据
        {
            if (e.RowIndex == -1) {
                if (this.dataGridView1.ColumnCount > this.former_num_col)
                {
                    this.former_num_col = this.dataGridView1.ColumnCount;//更新当前列的数目
                }
                return;
            }
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText.Substring(0,dataGridView1.Columns[e.ColumnIndex].HeaderText.IndexOf('\n'));//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
         
            String strcomm = "update " +this.tableName+" set " + strcolumn + ReviseStr(value, Control.connection.ds.Tables[0].Columns[e.ColumnIndex].DataType);
            bool first = true;
            for (int i=0; i<dataGridView1.ColumnCount;i++)
            {
                //构建update语句
                if (i == e.ColumnIndex)//不需要修改的值在这里出现
                {
                    continue;
                }
                else {
                    string strcol_name = dataGridView1.Columns[i].HeaderText.Substring(0, dataGridView1.Columns[i].HeaderText.IndexOf('\n'));
                    string strrow_value= dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                    if (first)
                    {
                        strcomm = strcomm+ " where " + strcol_name + ReviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[i].DataType);
                        first = false;
                    }
                    else
                        strcomm = strcomm + " and " + strcol_name  + ReviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[i].DataType);
                }
            }
            try
            {
                NpgsqlCommand comm = new NpgsqlCommand(strcomm, Control.connection.SqlConn);
                comm.ExecuteNonQuery();
            }
            catch (Exception ee) {
                MessageBox.Show("无法完成修改\n" + ee.Message);
            }
            
        }

        public DataGridView GetDataGridView()//获得datagridview的引用
        {
            return this.dataGridView1;
        }

        public int GetFormerNum() {
            return this.former_num_col;
        }

        public void SetFormerNum(int i)
        {
            this.former_num_col = i ;
        }

        public void FullFilDataGrid()//刷新DataGridView用
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            this.dataGridView1.DataSource = Control.connection.ds;
            this.dataGridView1.DataMember = Control.connection.ds.Tables[0].TableName;

            var cmd = new NpgsqlCommand("select data_type,column_name, character_maximum_length from information_schema.columns where table_schema='public' and table_name= '" + this.tableName + "'", Control.connection.SqlConn);
            NpgsqlDataAdapter da = new NpgsqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                //dataGridView1.Columns[i].HeaderText = dataGridView1.Columns[i].HeaderText + "\ntype:" + Control.connection.ds.Tables[0].Columns[i].DataType.ToString().Substring(Control.connection.ds.Tables[0].Columns[i].DataType.ToString().IndexOf('.') + 1);
                for (int k = 0; k < dt.Rows.Count; k++)
                {
                    if (dataGridView1.Columns[i].HeaderText != dt.Rows[k]["column_name"].ToString())
                    {
                        continue;
                    }
                    else
                    {
                        dataGridView1.Columns[i].HeaderText = dataGridView1.Columns[i].HeaderText + "\ntype:" + dt.Rows[k]["data_type"].ToString();
                        if (dt.Rows[k]["data_type"].ToString() == "character" || dt.Rows[k]["data_type"].ToString() == "character varying")
                        {
                            dataGridView1.Columns[i].HeaderText = dataGridView1.Columns[i].HeaderText + "[" + dt.Rows[k]["character_maximum_length"].ToString() + "]";
                        }
                    }
                }
            }
        }

        private void ExexuteButton1_Click(object sender, EventArgs e)//执行用户给的SQL代码
        {
            this.former_num_col = this.dataGridView1.ColumnCount;
            NpgsqlCommand command = new NpgsqlCommand(richTextBox2.Text, Control.connection.SqlConn);
            try
            {
                String Com_type = GetCommand(richTextBox2.Text);

                command.ExecuteNonQuery();

                //完成自动刷新功能
                string str = GetTableName(Com_type, richTextBox2.Text);
                this.tableName = str;
                string str_show;
                if (Com_type.Equals("select", StringComparison.OrdinalIgnoreCase))
                {
                    str_show = richTextBox2.Text;
                }
                else
                {
                    str_show = "Select * from " + str;
                }
                NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(str_show, Control.connection.SqlConn);
                Control.connection.ds = new DataSet();
                npgsql.Fill(Control.connection.ds);
                //Control.connection.SqlConn.Close();

                FullFilDataGrid();
            }
            catch (Exception ee)
            {
                MessageBox.Show("请检查您的指令！\ntips:" + ee.Message);
            }
        }

        private void DeleteButton2_Click(object sender, EventArgs e)//删除按键功能
        {
            string strcomm = "delete from " + this.tableName;
            bool first = true;
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {

                string strcol_name = dataGridView1.Columns[i].HeaderText.Substring(0, dataGridView1.Columns[i].HeaderText.IndexOf('\n'));
                string strrow_value = dataGridView1.SelectedRows[0].Cells[i].Value.ToString();
                if (first)
                {
                    strcomm = strcomm + " where " + strcol_name + ReviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[i].DataType);
                    first = false;
                }
                else
                    strcomm = strcomm + " and " + strcol_name + ReviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[i].DataType);
            }
            NpgsqlCommand command = new NpgsqlCommand(strcomm, Control.connection.SqlConn);
            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("删除成功！");
            }
            catch (NpgsqlException ee)
            {
                MessageBox.Show("Can not delete\n" + ee.Message);
            }

            String sel_table = "select * from " + Control.background.tableName;
            NpgsqlCommand command22 = new NpgsqlCommand(sel_table, Control.connection.SqlConn);
            //   Control.connection.SqlConn.Open();
            try
            {
                command22.ExecuteNonQuery();
                NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(sel_table, Control.connection.SqlConn);
                Control.connection.ds = new DataSet();
                npgsql.Fill(Control.connection.ds);
                //Control.connection.SqlConn.Close();

                Control.background.GetDataGridView().EnableHeadersVisualStyles = false;
                Control.background.GetDataGridView().ColumnHeadersDefaultCellStyle.Font = new Font("隶书", 9, FontStyle.Italic);
                Control.background.GetDataGridView().ColumnHeadersDefaultCellStyle.ForeColor = Color.Purple;
                FullFilDataGrid();
            }
            catch (Exception ee)
            {
                MessageBox.Show("未能刷新！\ntips:" + ee.Message);
            }
        }

        private void InsertButton3_Click(object sender, EventArgs e)//弹出新窗口来实现插入数据功能
        {
            InsertValue insert = new InsertValue();
            insert.Show();
        }
    }
}
