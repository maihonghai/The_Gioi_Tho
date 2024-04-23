using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class ConnectionDTO
    {
        private static string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\HocTapUTE\the-gioi-tho\GUI\The_Gioi_Tho.mdf;Integrated Security=True";
        public static SqlConnection GetSqlConnection()
        {
            return new SqlConnection(conn);
        }
    }
}
