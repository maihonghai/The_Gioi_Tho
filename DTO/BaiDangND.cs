using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace DTO
{
    public class BaiDangND
    {
        // Thuộc tính của bài đăng
        public int IDBaiDangND { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public DateTime LichThoDen { get; set; }
        public string MoTa { get; set; }
        public string CongViec { get; set; }
        public Byte[] HinhAnhMoTa { get; set; }

        public string Gio { get; set; }
        public int IDNguoiDung { get; set; }
        public string TieuDe { get; set; }

        public BaiDangND()
        {

        }
        public void BaiDangNDung(int iDBaiDang)
        {
            // Thực hiện truy vấn SQL để lấy thông tin của Thợ từ cơ sở dữ liệu
           // string connectionString = "Data Source=LAPTOP-QTEB4KQ5;Initial Catalog=TheGioiTho_BK;Integrated Security=True";
            string query = "SELECT * FROM BaiDangND WHERE IDBaiDangND = @IDBaiDang";
            using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@IDBaiDang", iDBaiDang);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    // Gán thông tin của Thợ từ kết quả truy vấn vào các thuộc tính của đối tượng ThongTinCaNhan
                    HoTen = reader["HoTen"].ToString();
                    SoDienThoai = reader["SoDienThoai"].ToString();
                    DiaChi = reader["DiaChi"].ToString();
                    SoDienThoai = reader["SoDienThoai"].ToString();
                    Gio = reader["Gio"].ToString();
                    CongViec = reader["CongViec"].ToString();
                    MoTa = reader["MoTa"].ToString();
                    LichThoDen = Convert.ToDateTime(reader["LichThoDen"]);
                    HinhAnhMoTa = (byte[])reader["HinhAnhMoTa"];
                    IDNguoiDung = Convert.ToInt32(reader["IDNguoiDung"]);
                }

                reader.Close();
            }

        }

        public BaiDangND(int iDBaiDangND, string hoTen, string diaChi, string soDienThoai, DateTime lichThoDen, string moTa, string congViec, Byte[] hinhAnhMoTa, string gio, int iDNguoiDung, string tieuDe)
        {
            IDBaiDangND = iDBaiDangND;
            HoTen = hoTen;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            LichThoDen = lichThoDen;
            MoTa = moTa;
            CongViec = congViec;
            HinhAnhMoTa = hinhAnhMoTa;
            Gio = gio;
            IDNguoiDung = iDNguoiDung;
            TieuDe = tieuDe;
        }

        public class BaiDangNDRepository
        {
            //private string connectionString = "Data Source=LAPTOP-QTEB4KQ5;Initial Catalog=TheGioiTho_BK;Integrated Security=True";
            public List<BaiDangND> LayDanhSachBaiDangND()
            {
                List<BaiDangND> danhSachBaiDang = new List<BaiDangND>();

                using (SqlConnection connection = ConnectionDTO.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT * FROM BaiDangND";

                    SqlCommand command = new SqlCommand(query, connection);
                    SqlDataReader reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        BaiDangND baiDang = new BaiDangND();
                        baiDang.IDBaiDangND = Convert.ToInt32(reader["IDBaiDangND"]);
                        baiDang.HoTen = reader["HoTen"].ToString();
                        baiDang.DiaChi = reader["DiaChi"].ToString();
                        baiDang.SoDienThoai = reader["SoDienThoai"].ToString();
                        baiDang.LichThoDen = Convert.ToDateTime(reader["LichThoDen"]);
                        baiDang.MoTa = reader["MoTa"].ToString();
                        baiDang.CongViec = reader["CongViec"].ToString();
                        baiDang.Gio = reader["Gio"].ToString();
                        baiDang.TieuDe = reader["TieuDe"].ToString();
                        // Lấy dữ liệu hình ảnh từ cơ sở dữ liệu dưới dạng byte[]
                        baiDang.HinhAnhMoTa = (byte[])reader["HinhAnhMoTa"];

                        // Chuyển đổi byte[] thành Image và gán vào thuộc tính HinhAnh
                        // baiDang.HinhAnhMoTa = ByteArrayToImage(imageData);

                        baiDang.IDNguoiDung = Convert.ToInt32(reader["IDNguoiDung"]);

                        danhSachBaiDang.Add(baiDang);
                    }

                    reader.Close();
                }


                return danhSachBaiDang;
            }

        }
    }
}
