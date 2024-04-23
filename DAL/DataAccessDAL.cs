using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    internal class DataAccessDAL
    {
        public static int LayIDNguoiDung(string tenTaiKhoan, string matKhau)
        {
            int idNguoiDung = 0;

            // Chuỗi kết nối đến cơ sở dữ liệu
            SqlConnection connection = ConnectionDAL.GetSqlConnection();

            // Truy vấn SQL để lấy ID người dùng dựa trên tên tài khoản và mật khẩu
            string query = "SELECT IDNguoiDung FROM TaiKhoan WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau";

            // Tạo và mở kết nối đến cơ sở dữ liệu
            using (connection)
            {
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số vào câu truy vấn để tránh tấn công SQL Injection
                    command.Parameters.AddWithValue("@TenTaiKhoan", tenTaiKhoan);
                    command.Parameters.AddWithValue("@MatKhau", matKhau);

                    try
                    {
                        // Mở kết nối
                        connection.Open();

                        // Thực thi truy vấn và lấy kết quả
                        object result = command.ExecuteScalar();

                        // Kiểm tra xem kết quả có null không và có phải kiểu int không
                        if (result != null && result != DBNull.Value)
                        {
                            idNguoiDung = Convert.ToInt32(result);
                        }
                    }
                    catch (Exception ex)
                    {
                        // Xử lý lỗi nếu có
                        Console.WriteLine("Lỗi khi thực hiện truy vấn: " + ex.Message);
                    }
                }
            }

            // Trả về ID của người dùng
            return idNguoiDung;
        }
    }
}
