using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;

namespace PhongKham.DAL
{
    public static class DBConnection
    {
        private static readonly string _connStr =
            ConfigurationManager.ConnectionStrings["PhongKhamDB"].ConnectionString;

        // Hàm duy nhất tạo kết nối — dùng trong using() block
        public static SqlConnection GetConnection()
        {
            var conn = new SqlConnection(_connStr);
            conn.Open();
            return conn;
        }

        // Kiểm tra kết nối khi khởi động app
        public static bool TestConnection()
        {
            try
            {
                using (var conn = GetConnection())
                    return conn.State == System.Data.ConnectionState.Open;
            }
            catch { return false; }
        }
    }
}
