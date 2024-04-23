using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhMucDAL
    {
        public static DataTable LayDanhMucConTheoTuKhoa(string tuKhoa)
        {
            DataTable danhSachDanhMuc = new DataTable();

            string query = "SELECT * FROM DanhMucCon WHERE TenDanhMucCon LIKE @TuKhoa";

            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@TuKhoa", "%" + tuKhoa + "%");

                connection.Open();
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(danhSachDanhMuc);
            }

            return danhSachDanhMuc;
        }
    }
}
