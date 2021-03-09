using System;
using System.Collections.Generic;
using System.Text;
using MySql.Data.MySqlClient;

namespace PR4
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "localhost";
            int port = 3306;
            string database = "items_uch";
            string username = "root";
            string password = "foxy";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
