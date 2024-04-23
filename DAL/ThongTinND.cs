using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongTinND
    {
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public ThongTinND(int nDID)
        {
            // Thực hiện truy vấn SQL để lấy thông tin của Thợ từ cơ sở dữ liệu
            SqlConnection connection = ConnectionDAL.GetSqlConnection();
            string query = "SELECT TenTaiKhoan, MatKhau, Email,HoTen,SoDienThoai,DiaChi FROM TaiKhoan WHERE IDTaiKhoan = @nDID";
            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@nDID", nDID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Gán thông tin của Thợ từ kết quả truy vấn vào các thuộc tính của đối tượng ThongTinCaNhan
                    TenTaiKhoan = reader["TenTaiKhoan"].ToString();
                    MatKhau = reader["MatKhau"].ToString();
                    HoTen = reader["HoTen"].ToString();
                    DiaChi = reader["DiaChi"].ToString();
                    SoDienThoai = reader["SoDienThoai"].ToString();
                    Email = reader["Email"].ToString();
                }

                reader.Close();
            }
        }
        public ThongTinND(string tenTaiKhoan, string matKhau, string hoTen, string diaChi, string soDienThoai, string email)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            Email = email;
        }
    }
   
}
