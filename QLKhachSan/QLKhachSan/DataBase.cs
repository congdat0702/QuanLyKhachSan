using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace QLKhachSan
{
    class DataBase
    {
        private static string connectionString = connection.getConnectString();
        private static SqlConnection conn;
        public static bool Connect()
        {
            try
            {
                conn = new SqlConnection(connectionString);
                conn.Open();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static SqlConnection GetConnection()
        {
            if (conn == null)
                Connect();
            return conn;
        }

        public static void Disconect()
        {
            if (conn != null && conn.State == System.Data.ConnectionState.Open)
                conn.Close();
        }
    }
}
