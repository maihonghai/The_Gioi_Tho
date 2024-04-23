using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaiDang
    {
        // Thuộc tính của bài đăng
        public int IDBaiDang { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public int SoNamKinhNghiem { get; set; }
        public string MoTa { get; set; }
        public string LinhVuc { get; set; }
        public int ThoiGianThucHien { get; set; }
        public decimal GiaTien { get; set; }

        public int IDTho { get; set; }

        // Constructor mặc định
        public BaiDang()
        {
        }

        public void BaiDangTho(int iDBaiDang)
        {
            // Thực hiện truy vấn SQL để lấy thông tin của Thợ từ cơ sở dữ liệu
            //string connectionString = "Data Source=LAPTOP-QTEB4KQ5;Initial Catalog=TheGioiTho_BK;Integrated Security=True";
            string query = "SELECT * FROM BaiDang WHERE IDBaiDang = @IDBaiDang";
            using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDBaiDang", iDBaiDang);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Gán thông tin của Thợ từ kết quả truy vấn vào các thuộc tính của đối tượng ThongTinCaNhan
                    HoTen = reader["HoVaTen"].ToString();
                    DiaChi = reader["DiaChi"].ToString();
                    SoDienThoai = reader["SoDienThoai"].ToString();
                    SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]);
                    LinhVuc = reader["LinhVuc"].ToString();
                    GiaTien = Convert.ToDecimal(reader["GiaTien"]);
                    MoTa = reader["MoTa"].ToString();
                    ThoiGianThucHien = Convert.ToInt32(reader["ThoiGianThucHien"]);
                    IDTho = Convert.ToInt32(reader["IDTho"]);
                }

                reader.Close();
            }

        }

        // Constructor với tham số
        public BaiDang(int id, string hoTen, string diaChi, string soDienThoai, int soNamKinhNghiem, string moTa, string linhVuc, int thoiGianThucHien, decimal giaTien, int iDTho)
        {
            IDBaiDang = id;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            SoNamKinhNghiem = soNamKinhNghiem;
            MoTa = moTa;
            LinhVuc = linhVuc;
            ThoiGianThucHien = thoiGianThucHien;
            GiaTien = giaTien;
            IDTho = iDTho;
        }

        public class BaiDangRepository
        {
            public bool XoaBaiDang(int IDBaiDang)
            {
                try
                {
                    using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
                    {
                        connection.Open();
                        string query = "DELETE FROM BaiDang WHERE IDBaiDang = @IDBaiDang";

                        SqlCommand command = new SqlCommand(query, connection);
                        command.Parameters.AddWithValue("@IDBaiDang", IDBaiDang);

                        // Thực thi truy vấn xóa và trả về số hàng bị ảnh hưởng (số bản ghi đã bị xóa)
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bản ghi nào đã bị xóa hay không
                        if (rowsAffected > 0)
                        {
                            // Nếu có, trả về true để chỉ ra rằng việc xóa bài đăng thành công
                            return true;
                        }
                        else
                        {
                            // Nếu không có bản ghi nào bị xóa, trả về false
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Xử lý ngoại lệ nếu có lỗi xảy ra trong quá trình xóa bài đăng
                    Console.WriteLine("Lỗi khi xóa bài đăng: " + ex.Message);
                    return false; // Trả về false để thông báo rằng việc xóa bài đăng không thành công
                }
            }
                public List<BaiDang> LayDanhSachBaiDang()
            {
                List<BaiDang> danhSachBaiDang = new List<BaiDang>();

                using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT IDBaiDang, HoVaTen, DiaChi, SoDienThoai, SoNamKinhNghiem, MoTa, LinhVuc, ThoiGianThucHien, GiaTien FROM BaiDang";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BaiDang baiDang = new BaiDang();
                        baiDang.IDBaiDang = Convert.ToInt32(reader["IDBaiDang"]);
                        baiDang.HoTen = reader["HoVaTen"].ToString();
                        baiDang.DiaChi = reader["DiaChi"].ToString();
                        baiDang.SoDienThoai = reader["SoDienThoai"].ToString();
                        baiDang.SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]);
                        baiDang.MoTa = reader["MoTa"].ToString();
                        baiDang.LinhVuc = reader["LinhVuc"].ToString();
                        baiDang.ThoiGianThucHien = Convert.ToInt32(reader["ThoiGianThucHien"]);
                        baiDang.GiaTien = Convert.ToDecimal(reader["GiaTien"]);

                        danhSachBaiDang.Add(baiDang);
                    }

                    reader.Close();
                }

                return danhSachBaiDang;
            }

            public List<BaiDang> LayBaiDangTheoLinhVuc(string tenLinhVuc)
            {
                List<BaiDang> danhSachBaiDang = new List<BaiDang>();

                using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT IDBaiDang, HoVaTen, DiaChi, SoDienThoai, SoNamKinhNghiem, MoTa, LinhVuc, ThoiGianThucHien, GiaTien FROM BaiDang WHERE LinhVuc = @TenLinhVuc";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TenLinhVuc", tenLinhVuc);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BaiDang baiDang = new BaiDang();
                        baiDang.IDBaiDang = Convert.ToInt32(reader["IDBaiDang"]);
                        baiDang.HoTen = reader["HoVaTen"].ToString();
                        baiDang.DiaChi = reader["DiaChi"].ToString();
                        baiDang.SoDienThoai = reader["SoDienThoai"].ToString();
                        baiDang.SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]);
                        baiDang.MoTa = reader["MoTa"].ToString();
                        baiDang.LinhVuc = tenLinhVuc.Trim();
                        baiDang.ThoiGianThucHien = Convert.ToInt32(reader["ThoiGianThucHien"]);
                        baiDang.GiaTien = Convert.ToDecimal(reader["GiaTien"]);

                        danhSachBaiDang.Add(baiDang);
                    }

                    reader.Close();
                }

                return danhSachBaiDang;
            }
            public List<BaiDang> LayBaiDangTheoIDTho(int IDTho)
            {
                List<BaiDang> danhSachBaiDang = new List<BaiDang>();

                using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT IDBaiDang, HoVaTen, DiaChi, SoDienThoai, SoNamKinhNghiem, MoTa, LinhVuc, ThoiGianThucHien, GiaTien FROM BaiDang WHERE IDTho = @IDTho";

                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDTho", IDTho);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BaiDang baiDang = new BaiDang();
                        baiDang.IDBaiDang = Convert.ToInt32(reader["IDBaiDang"]);
                        baiDang.HoTen = reader["HoVaTen"].ToString();
                        baiDang.DiaChi = reader["DiaChi"].ToString();
                        baiDang.SoDienThoai = reader["SoDienThoai"].ToString();
                        baiDang.SoNamKinhNghiem = Convert.ToInt32(reader["SoNamKinhNghiem"]);
                        baiDang.MoTa = reader["MoTa"].ToString();
                        baiDang.LinhVuc = reader["LinhVuc"].ToString();
                        baiDang.ThoiGianThucHien = Convert.ToInt32(reader["ThoiGianThucHien"]);
                        baiDang.GiaTien = Convert.ToDecimal(reader["GiaTien"]);

                        danhSachBaiDang.Add(baiDang);
                    }

                    reader.Close();
                }

                return danhSachBaiDang;
            }

        }
    }

}
