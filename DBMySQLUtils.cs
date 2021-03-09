using System;
using System.Collections.Generic;
using System.Text;

// 
using MySql.Data.MySqlClient;

namespace PR4
{
    class DBMySQLUtils
    {
        public static MySqlConnection
            GetDBConnection(string host, int port, string database, string username, string password)
        {
            String connString = "Server=" + host + "; Database = " + database + "; port=" + port + "; user=" + username + "; password=" + password;
            MySqlConnection conn = new MySqlConnection(connString);
            return conn;
        }
    }
}
