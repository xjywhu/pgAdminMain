using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;

namespace pgAdminMain
{
    /*树形视图控制器*/
    public class TreeviewController
    {
        private TreeView tv;
        public TreeviewController(TreeView tv)
        {
            this.tv = tv;
        }
        /*查询树形视图节点*/
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
        /*根据选中的数据库节点建立数据库连接*/
        public NpgsqlConnection EsConOnDataBase(TreeNode table)
        {
            Control.connection.SqlConn = new NpgsqlConnection(MainForm.connString + ";DataBase = " + table.Text.ToString());
            Control.connection.SqlConn.Open();
            return Control.connection.SqlConn;
        }
        /*根据选中的schema节点建立数据库连接*/
        public NpgsqlConnection EsConOnSchemas(TreeNode table)
        {
            Control.connection.SqlConn = new NpgsqlConnection(MainForm.connString + ";DataBase = " + table.Parent.Text.ToString());
            Control.connection.SqlConn.Open();
            return Control.connection.SqlConn;
        }
        /*根据选中的table节点建立数据库连接*/
        public NpgsqlConnection EsConOnTable1(TreeNode table)
        {
            Control.connection.SqlConn = new NpgsqlConnection(MainForm.connString + ";DataBase = " + table.Parent.Parent.Text.ToString());
            Control.connection.SqlConn.Open();
            return Control.connection.SqlConn;
        }
        /*根据选中的表名节点建立数据库连接*/

        public NpgsqlConnection EsConOnTable2(TreeNode table)
        {
            Control.connection.SqlConn = new NpgsqlConnection(MainForm.connString + ";DataBase = " + table.Parent.Parent.Parent.Text.ToString());
            Control.connection.SqlConn.Open();
            return Control.connection.SqlConn;
        }
        /*根据选中的列名节点建立数据库连接*/

        public NpgsqlConnection EsConOnColumn(TreeNode table)
        {
            Control.connection.SqlConn = new NpgsqlConnection(MainForm.connString + ";DataBase = " + table.Parent.Parent.Parent.Parent.Text.ToString());
            Control.connection.SqlConn.Open();
            return Control.connection.SqlConn;
        }

        public TreeNode Find(TreeView tv, string name)
        {

            TreeNode tn = null;
            foreach (TreeNode t in tv.Nodes)
            {
                tn = FindNode(t, name);
                if (tn != null) break;
            }
            return tn;

        }
       

    }
}
