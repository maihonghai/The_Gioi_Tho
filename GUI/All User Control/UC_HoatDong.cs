using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using GUI.All_Tho_Control;
using DAL;

namespace GUI.All_User_Control
{
    public partial class UC_HoatDong : UserControl
    {
        public UC_HoatDong()
        {
            InitializeComponent();
            InitializeDataGridView();
        }

        private void InitializeDataGridView()
        {

            // Thêm dữ liệu mẫu
            //AddSampleDataToDataGridView();
            // Lấy danh sách các lịch hẹn đang chờ thợ xác nhận từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Đang chờ thợ xác nhận", BLL.LoginBLL.IDNguoiDung);

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

  
        private List<LichHen> GetDanhSachLichHenTheoTrangThai(string trangThai, int idNguoiDung)
        {
            List<LichHen> danhSachLichHen = new List<LichHen>();

            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    // Câu truy vấn SQL để lấy thông tin từ các bảng liên quan
                    string query = @"SELECT cv.IDCongViec, cv.LinhVuc, cv.LichThoDen, cv.Gio, cv.MoTaChiTiet, cv.GhiChu, cv.GiaTien,cv.IDTho,
                             tk.HoTen AS TenTho, tk.SoDienThoai AS SDTTho, cv.TrangThaiCongViecTho, cv.TrangThaiCongViecNguoiDung
                             FROM CongViec cv
                             INNER JOIN TaiKhoanTho tk ON cv.IDTho = tk.IDTho
                             WHERE cv.TrangThaiCongViecNguoiDung = @TrangThai AND cv.IDNguoiDat = @idNguoiDung";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TrangThai", trangThai);
                        command.Parameters.AddWithValue("@idNguoiDung", idNguoiDung);

                        SqlDataReader reader = command.ExecuteReader();

                        while (reader.Read())
                        {
                            // Đọc dữ liệu từ kết quả truy vấn và chuyển đổi sang đối tượng LichHen
                            LichHen lichHen = new LichHen
                            {
                                IDLichHen = reader.GetInt32(reader.GetOrdinal("IDCongViec")),
                                LinhVuc = reader["LinhVuc"].ToString(),
                                Ten = reader["TenTho"].ToString(),
                                SDT = reader["SDTTho"].ToString(),
                                LichHenDen = Convert.ToDateTime(reader["LichThoDen"]),
                                Gio = reader["Gio"].ToString(),
                                MoTaChiTiet = reader["MoTaChiTiet"].ToString(),
                                GhiChu = reader["GhiChu"].ToString(),
                                GiaTien = Convert.ToDecimal(reader["GiaTien"]),
                                TrangThaiCongViecTho = reader["TrangThaiCongViecTho"].ToString(),
                                TrangThaiCongViecNguoiDung = reader["TrangThaiCongViecNguoiDung"].ToString(),
                                IDTho = Convert.ToInt32(reader["IDTho"])
                            };

                            danhSachLichHen.Add(lichHen);
                        }

                        reader.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ nếu có
                Console.WriteLine("Error: " + ex.Message);
            }

            return danhSachLichHen;
        }

        private void HienThiDanhSachLichHen(List<LichHen> danhSachLichHen)
        {
            // Xóa tất cả các lịch hẹn đang hiển thị trên giao diện
            pnlXemLichHen.Controls.Clear();

            // Duyệt qua danh sách lịch hẹn và hiển thị lên giao diện
            foreach (LichHen lichHen in danhSachLichHen)
            {


                UC_Lich ucLich = new UC_Lich(lichHen); // Khởi tạo UC_Lich với dữ liệu tương ứng

                // ẩn các nút theo các mục
                if (lichHen.TrangThaiCongViecNguoiDung == "Đã hủy")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                }

                else if (lichHen.TrangThaiCongViecNguoiDung == "Hoàn tất")
                {
                    ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                    ucLich.GetBtnDanhGia().Visible = true;
                    ucLich.GetBtnYeuThich().Visible = true;
                    // Kiểm tra xem lịch hẹn có đánh giá hay không
                    if (KiemTraDanhGia(lichHen.IDLichHen))
                    {
                        ucLich.GetBtnDanhGia().Visible = false; // Nếu có đánh giá, ẩn nút btnDanhGia
                    }
                    // Ẩn/hiển thị nút yêu thích và nút đã yêu thích dựa trên trạng thái của thợ trong danh sách yêu thích của người dùng
                    if (KiemTraThoYeuThich(lichHen.IDTho, BLL.LoginBLL.IDNguoiDung))
                    {
                        ucLich.GetBtnYeuThich().Visible = false;
                        ucLich.GetBtnDaYeuThich().Visible = true;
                    }
                }

               else  if (lichHen.TrangThaiCongViecNguoiDung == "Đã xác nhận")
                {
                    //ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                }

               else if (lichHen.TrangThaiCongViecNguoiDung == "Yêu cầu dời lịch")
                {
                    //ucLich.GetBtnHuyLichHen().Visible = false;
                    ucLich.GetBtnYeuCauDoiLich().Visible = false;
                    ucLich.GetBtnChapNhan().Visible = true;
                }

                ucLich.Dock = DockStyle.Top; // Đặt DockStyle của UC_Lich thành Top để chúng được thêm vào pnlLichHen từ trên xuống
                pnlXemLichHen.Controls.Add(ucLich); // Thêm UC_Lich vào pnlLichHen

                // Kiểm tra trạng thái của lịch hẹn và ẩn/hiển thị các nút tương ứng

            }
        }
        private bool KiemTraThoYeuThich(int idTho, int idNguoiDung)
        {
            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM ThoYeuThich WHERE IDNguoiDung = @IDNguoiDung AND IDTho = @IDTho";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDNguoiDung", idNguoiDung);
                        command.Parameters.AddWithValue("@IDTho", idTho);
                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        private bool KiemTraDanhGia(int idLichHen)
        {
            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM DanhGia WHERE IDCongViec = @IDLichHen";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@IDLichHen", idLichHen);
                        int count = (int)command.ExecuteScalar();

                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
                return false;
            }
        }
        private void btnDangChoThoXacNhan_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn đang chờ thợ xác nhận từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Đang chờ thợ xác nhận", BLL.LoginBLL.IDNguoiDung);

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnYeuCauDoiLich_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Yêu cầu dời lịch", BLL.LoginBLL.IDNguoiDung);

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnDaXacNhan_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Đã xác nhận", BLL.LoginBLL.IDNguoiDung);

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Hoàn tất", BLL.LoginBLL.IDNguoiDung);

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }

        private void btnDaHuy_Click(object sender, EventArgs e)
        {
            // Lấy danh sách các lịch hẹn yêu cầu dời lịch từ cơ sở dữ liệu
            List<LichHen> danhSachLichHen = GetDanhSachLichHenTheoTrangThai("Đã hủy", BLL.LoginBLL.IDNguoiDung);

            // Sắp xếp danh sách các lịch hẹn theo thời gian (tăng dần)
            //danhSachLichHen = danhSachLichHen.OrderBy(lichHen => lichHen.LichHenDen).ToList();

            // Hiển thị danh sách lịch hẹn trên giao diện
            HienThiDanhSachLichHen(danhSachLichHen);
        }


    }
}
