using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ThongTinTho
    {
        // Thuộc tính của thong tin ca nhan
        public string TenTaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public int SoNamKinhNghiem { get; set; }
        public string Email { get; set; }
        public int IDTho { get; set; }

        public ThongTinTho()
        {

        }
        // Constructor mặc định
        public ThongTinTho(int thoID)
        {
            // Thực hiện truy vấn SQL để lấy thông tin của Thợ từ cơ sở dữ liệu
            SqlConnection connection = ConnectionDAL.GetSqlConnection();
            string query = "SELECT TenTaiKhoan, MatKhau, Email,HoTen,GioiTinh,SoDienThoai,SoNamKinhNghiem,DiaChi,IDTho FROM TaiKhoanTho WHERE IDTho = @ThoID";
            using (connection)
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ThoID", thoID);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Gán thông tin của Thợ từ kết quả truy vấn vào các thuộc tính của đối tượng ThongTinCaNhan
                    TenTaiKhoan = reader["TenTaiKhoan"].ToString();
                    MatKhau = reader["MatKhau"].ToString();
                    HoTen = reader["HoTen"].ToString();
                    GioiTinh = reader["GioiTinh"].ToString();
                    DiaChi = reader["DiaChi"].ToString();
                    SoDienThoai = reader["SoDienThoai"].ToString();
                    SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]);
                    Email = reader["Email"].ToString();
                   // IDTho = Convert.ToInt32(reader["IDTho"]);
                }

                reader.Close();
            }
        }

        public ThongTinTho(string tenTaiKhoan, string matKhau, string hoTen, string gioiTinh, string diaChi, string soDienThoai, int soNamKinhNghiem, string email, int iDTho)
        {
            TenTaiKhoan = tenTaiKhoan;
            MatKhau = matKhau;
            HoTen = hoTen;
            GioiTinh = gioiTinh;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            SoNamKinhNghiem = soNamKinhNghiem;
            Email = email;
            IDTho = iDTho;
        }

        public class ThoYeuThichRepository
        {
            public List<ThongTinTho> LayDanhSachThoYeuThich(int iDNguoiDung)
            {
                List<ThongTinTho> danhSachtho = new List<ThongTinTho>();

                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();
                    string query = "select tk.IDTho,tk.HoTen, tk.GioiTinh,tk.SoDienThoai,tk.SoNamKinhNghiem,tk.DiaChi " +
                        "from TaiKhoanTho tk inner join ThoYeuThich iu on tk.IDTho = iu.IDTho " +
                        "where iu.IDNguoiDung = @IDNguoiDung";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDNguoiDung", iDNguoiDung);

                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        ThongTinTho thongTin = new ThongTinTho
                        {
                            HoTen = reader["HoTen"].ToString(),
                            GioiTinh = reader["GioiTinh"].ToString(),
                            SoDienThoai = reader["SoDienThoai"].ToString(),
                            SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]),
                            DiaChi = reader["DiaChi"].ToString(),
                            IDTho = Convert.ToInt32(reader["IDTho"])
                        };

                        danhSachtho.Add(thongTin);
                    }

                    reader.Close();
                }


                return danhSachtho;
            }

            public void XoaThoYeuThich(int idNguoiDung, int idTho)
            {
                try
                {
                    using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                    {
                        connection.Open();
                        string query = "DELETE FROM ThoYeuThich WHERE IDNguoiDung = @IDNguoiDung AND IDTho = @IDTho";
                        using (SqlCommand command = new SqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@IDNguoiDung", idNguoiDung);
                            command.Parameters.AddWithValue("@IDTho", idTho);
                            int rowsAffected = command.ExecuteNonQuery();
                            if (rowsAffected > 0)
                            {
                                Console.WriteLine("Đã xóa thông tin thợ yêu thích từ cơ sở dữ liệu!");
                            }
                            else
                            {
                                Console.WriteLine("Không có thông tin thợ yêu thích nào được xóa!");
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    throw new Exception("Lỗi khi xóa thông tin thợ yêu thích từ cơ sở dữ liệu: " + ex.Message);
                }
            }
        }
    }
}
