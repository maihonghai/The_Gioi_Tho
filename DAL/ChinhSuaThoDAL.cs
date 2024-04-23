using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChinhSuaThoDAL
    {
        SqlConnection connection = ConnectionDAL.GetSqlConnection();
        public bool UpdateTho(int idTho, string hoTen, string soDienThoai, string diaChi, string email, string gioiTinh)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "UPDATE TaiKhoanTho SET HoTen = @HoTen, SoDienThoai = @SoDienThoai, DiaChi = @DiaChi, Email = @Email, GioiTinh = @GioiTinh WHERE IDTho = @IDTho";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@HoTen", hoTen);
                    command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", diaChi);
                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@GioiTinh", gioiTinh);
                    command.Parameters.AddWithValue("@IDTho", idTho);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        public bool DoiMK(int idTho, string mk)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    string query = "UPDATE TaiKhoanTho SET MatKhau = @MatKhau WHERE IDTho = @IDTho";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MatKhau", mk);
                    command.Parameters.AddWithValue("@IDTho", idTho);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }

        public void XoaTaiKhoan(int idTho)
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    //Xoa cac cong viec lien quan bai dang
                    string deleteCongViecQuery = "DELETE FROM CongViec WHERE IDBaiDang IN (SELECT IDBaiDang FROM BaiDang WHERE IDTho = @IDTho)";
                    SqlCommand deleteCongViecCommand = new SqlCommand(deleteCongViecQuery, connection);
                    deleteCongViecCommand.Parameters.AddWithValue("@IDTho", idTho);
                    deleteCongViecCommand.ExecuteNonQuery();

                    // Xóa các bài đăng liên quan đến thợ
                    string deleteBaiDangQuery = "DELETE FROM BaiDang WHERE IDTho = @IDTho";
                    SqlCommand deleteBaiDangCommand = new SqlCommand(deleteBaiDangQuery, connection);
                    deleteBaiDangCommand.Parameters.AddWithValue("@IDTho", idTho);
                    deleteBaiDangCommand.ExecuteNonQuery();

                    // Xóa tài khoản thợ
                    string deleteThoQuery = "DELETE FROM TaiKhoanTho WHERE IDTho = @IDTho";
                    SqlCommand deleteThoCommand = new SqlCommand(deleteThoQuery, connection);
                    deleteThoCommand.Parameters.AddWithValue("@IDTho", idTho);
                    deleteThoCommand.ExecuteNonQuery();

                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);

            }
        }

    }
}

