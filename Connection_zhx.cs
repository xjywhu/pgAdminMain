using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace pgAdminMain
{
    class Connection_zhx
    {
        private String server;
        private String port;
        private String password;
        private String username;

        public NpgsqlConnection SqlConn;

        public Connection_zhx(String server,String port, String password, String username)
        {
            this.password = password;
            this.server = server;
            this.port = port;
            this.username = username;
            try
            {
                String Constr = @"PORT=" + this.port + ";HOST=" + this.server + ";PASSWORD=" + this.password + ";USER ID=" + this.username;
                this.SqlConn = new NpgsqlConnection(Constr);
                this.SqlConn.Open();
            }
            finally { }
        }

        public String getSever() { return this.server; }
        public String getPort() { return this.port; }
        public String getPassword() { return this.password; }
        public String getUsername() { return this.username; }

    }
}
