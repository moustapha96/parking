using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace GestionParking
{
    class DBUtils
    {
        public static MySqlConnection GetDBConnection()
        {
            string host = "127.0.0.1";
            int port = 3306;
            string database = "parking_db";
            string username = "root";
            string password = "";

            return DBMySQLUtils.GetDBConnection(host, port, database, username, password);
        }
    }
}
