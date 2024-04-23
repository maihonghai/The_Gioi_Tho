using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaiDangDAL
    {
        public bool ChinhSuaBaiDang(int idBaiDang, string moTa, int thoiGianThucHien, decimal giaTien)
        {
            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();
                    string query = "UPDATE BaiDang SET MoTa = @MoTa, ThoiGianThucHien = @ThoiGianThucHien, GiaTien = @GiaTien WHERE IDBaiDang = @IDBaiDang";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@MoTa", moTa);
                    command.Parameters.AddWithValue("@ThoiGianThucHien", thoiGianThucHien);
                    command.Parameters.AddWithValue("@GiaTien", giaTien);
                    command.Parameters.AddWithValue("@IDBaiDang", idBaiDang);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool DangBai(string hoVaTen, string diaChi, string soDienThoai, int soNamKinhNghiem, string moTa, string linhVuc, int thoiGianThucHien, decimal giaTien, int idTho)
        {
            string query = "INSERT INTO BaiDang (HoVaTen, DiaChi, SoDienThoai, SoNamKinhNghiem, MoTa, LinhVuc, ThoiGianThucHien, GiaTien, IDTho) " +
                           "VALUES (@HoVaTen, @DiaChi, @SoDienThoai, @SoNamKinhNghiem, @MoTa, @LinhVuc, @ThoiGianThucHien, @GiaTien, @IDTho)";

            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@HoVaTen", hoVaTen);
                        command.Parameters.AddWithValue("@DiaChi", diaChi);
                        command.Parameters.AddWithValue("@SoDienThoai", soDienThoai);
                        command.Parameters.AddWithValue("@SoNamKinhNghiem", soNamKinhNghiem);
                        command.Parameters.AddWithValue("@MoTa", moTa);
                        command.Parameters.AddWithValue("@LinhVuc", linhVuc);
                        command.Parameters.AddWithValue("@ThoiGianThucHien", thoiGianThucHien);
                        command.Parameters.AddWithValue("@GiaTien", giaTien);
                        command.Parameters.AddWithValue("@IDTho", idTho);

                        connection.Open();
                        command.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu cần)
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
