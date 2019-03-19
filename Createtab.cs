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
        public Createtab(string dbname,MainForm f)
        {
            InitializeComponent();
            this.f = f;
            this.dbname = dbname;
        }

        private void Save_Click(object sender, EventArgs e)
        {
            /*连接数据库，在数据库中创建表*/
            //var con = new NpgsqlConnection(MainForm.connString + ";DataBase = " + dbname);
            //con.Open();
            //var con = f.Establishconnection("sc");
 
            //var cmdtab = new NpgsqlCommand("CREATE TABLE weather(city varchar(80),temp_lo int,temp_hi int,prcp real,date date);", con);
            //cmdtab.ExecuteNonQuery();
            //this.Close();
        }


        

    }
}
