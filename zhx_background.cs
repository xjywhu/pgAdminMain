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
    public partial class zhx_background : UserControl
    {
        private String tableName;
        public zhx_background()
        {
            InitializeComponent();
        }

        private static String GetCommand(String str)
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

        private static String GetTableName(String Com_type,String str)
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
            else
            {
                index_1 = 0;
            }
            
            //find next space
        
            while (str[index_1] == ' ') { index_1 += 1; }
            int index_2 = str.IndexOf(' ', index_1 + 1);
            if (index_2 == -1)
            {
                return str.Substring(index_1);
            }
            else
                return str.Substring(index_1, index_2-index_1);
        }

        private void zhx_submit_Click_1(object sender, EventArgs e)
        {
            NpgsqlCommand command = new NpgsqlCommand(richTextBox1.Text, Control.connection.SqlConn);
            //   Control.connection.SqlConn.Open();
            try
            {
                String Com_type = GetCommand(richTextBox1.Text);
                if (Com_type.Equals("insert", StringComparison.OrdinalIgnoreCase))
                {
                    //command.
                }
                command.ExecuteNonQuery();

                string str = GetTableName(Com_type, richTextBox1.Text);
                this.tableName = str;
                string str_show;
                if (Com_type.Equals("select", StringComparison.OrdinalIgnoreCase))
                {
                    str_show = richTextBox1.Text;
                }
                else
                {
                    str_show = "Select * from " + str;
                }
                NpgsqlDataAdapter npgsql = new NpgsqlDataAdapter(str_show, Control.connection.SqlConn);
                Control.connection.ds = new DataSet();
                npgsql.Fill(Control.connection.ds);
                //Control.connection.SqlConn.Close();

                this.dataGridView1.DataSource = null;
                this.dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
                this.dataGridView1.DataSource = Control.connection.ds;
                this.dataGridView1.DataMember = Control.connection.ds.Tables[0].TableName;

            }
            catch (Exception ee) {
                MessageBox.Show("请检查您的指令！\ntips:"+ee.Message);
            }
        }

        private String reviseStr(String str,Type type )
        {
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
                    return "'"+str+"'";
                default:
                    return null;
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {

            // reviseStr(null,Control.connection.ds.Tables[0].Columns[e.ColumnIndex].DataType);
            string strcolumn = dataGridView1.Columns[e.ColumnIndex].HeaderText;//获取列标题
            string strrow = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();//获取焦点触发行的第一个值
            string value = dataGridView1.CurrentCell.Value.ToString();//获取当前点击的活动单元格的值
          //  String tableName = Control.connection.ds.Tables[0].TableName;
            // Control.connection.ds.Tables[0].Columns[0].DataType;
            // dataGridView1.ColumnCount
            String strcomm = "update " +this.tableName+" set " + strcolumn + "=" + reviseStr(value, Control.connection.ds.Tables[0].Columns[e.ColumnIndex].DataType);
            bool first = true;
            for (int i=0; i<dataGridView1.ColumnCount;i++)
            {
                
                if (i == e.ColumnIndex)
                {

                }
                else {
                    string strcol_name = dataGridView1.Columns[i].HeaderText;
                    string strrow_value= dataGridView1.Rows[e.RowIndex].Cells[i].Value.ToString();
                    if (first)
                    {
                        strcomm = strcomm+ " where " + strcol_name + " = " + reviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[i].DataType);
                        first = false;
                    }
                    else
                        strcomm = strcomm + " and " + strcol_name + " = " + reviseStr(strrow_value, Control.connection.ds.Tables[0].Columns[i].DataType);
                }
            }

            NpgsqlCommand comm = new NpgsqlCommand(strcomm,Control.connection.SqlConn);
            comm.ExecuteNonQuery();
        }
    }
}
