using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySqlConnector;

namespace Data
{
    public static class DataBase
    {
        private static string connectionString = "server=localhost;uid=root;pwd=;database=fitness";
        public static MySqlConnection GetConnection()
        {
            return new MySqlConnection(connectionString);
        }
    }
}
