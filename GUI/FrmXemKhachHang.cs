using BLL;
using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FrmXemKhachHang : Form
    {
        public int IDBaiDangND { get; set; }
        private BaiDangND thongtinKhachHang;
        public FrmXemKhachHang(int iDBaiDangND)
        {
            InitializeComponent();
            thongtinKhachHang = new BaiDangND();
            thongtinKhachHang.BaiDangNDung(iDBaiDangND);
            txtTenKhachHang.Text = thongtinKhachHang.HoTen;
            txtDiaChi.Text = thongtinKhachHang.DiaChi;
            txtSoDienThoai.Text = thongtinKhachHang.SoDienThoai;
            txtLinhVuc.Text = thongtinKhachHang.CongViec;
            txtLichThoDen.Text = thongtinKhachHang.LichThoDen.ToString("dd/MM/yyyy");
            txtGhiChu.Text = thongtinKhachHang.MoTa;
            txtGio.Text = thongtinKhachHang.Gio;
            Image hinhanhmota = ByteArrayToImage(thongtinKhachHang.HinhAnhMoTa);
            pbAnh.Image = hinhanhmota;

            //IDBaiDangND = int.Parse(lblIDBaiDang.Text);
        }

        public FrmXemKhachHang()
        {
        }

        // Hàm để chuyển đổi mảng byte thành hình ảnh
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void btnDat_Click(object sender, EventArgs e)
        {
            Decimal giaTien;
            if (txtGiaTien.Text == "" || !decimal.TryParse(txtGiaTien.Text, out giaTien))
            {
                txtGiaTien.Text = "";
                txtGiaTien.PlaceholderForeColor = Color.Red;
                txtGiaTien.PlaceholderText = "*Giá tiền không hợp lệ!";
                return; // hoặc thực hiện các xử lý phù hợp
            }
            if(cbThoiGianThucHien.Text == "")
            {
                lblThoiGian.ForeColor = Color.Red;
                lblThoiGian.Text = "*Nhập thời gian làm việc!";
                 return;
            }
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Tạo truy vấn SQL INSERT
                string query = "INSERT INTO CongViec (IDNguoiDat, Ten, SDT, DiaChi, LichThoDen, Gio, MoTaChiTiet, GhiChu, TrangThaiCongViecTho, TrangThaiCongViecNguoiDung,GiaTien,LinhVuc,IDTho,ThoiGianThucHien) " +
                               "VALUES (@IDNguoiDat, @Ten, @SDT, @DiaChi, @LichThoDen, @Gio, @MoTaChiTiet, @GhiChu, @TrangThaiCongViecTho, @TrangThaiCongViecNguoiDung,@GiaTien,@LinhVuc,@IDTho,@ThoiGianThucHien)";

                // Tạo và mở kết nối
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Đặt các tham số cho truy vấn
                    command.Parameters.AddWithValue("@IDNguoiDat", thongtinKhachHang.IDNguoiDung); // Thay thế idNguoiDat bằng ID của người đặt công việc
                    command.Parameters.AddWithValue("@Ten", txtTenKhachHang.Text);
                    command.Parameters.AddWithValue("@SDT", txtSoDienThoai.Text);
                    command.Parameters.AddWithValue("@DiaChi", txtDiaChi.Text);
                    DateTime lichThoDen;
                    DateTime.TryParseExact(txtLichThoDen.Text, "dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture, System.Globalization.DateTimeStyles.None, out lichThoDen);
                    command.Parameters.AddWithValue("@LichThoDen", lichThoDen);
                    command.Parameters.AddWithValue("@Gio", txtGio.Text);
                    command.Parameters.AddWithValue("@MoTaChiTiet", txtGhiChu.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    //command.Parameters.AddWithValue("@IDBaiDang", IDBaiDang); // Thay thế idBaiDang bằng ID của bài đăng tương ứng
                    command.Parameters.AddWithValue("@TrangThaiCongViecTho", "Chưa xử lý"); // Mặc định trạng thái cho thợ là "Chờ xác nhận"
                    command.Parameters.AddWithValue("@TrangThaiCongViecNguoiDung", "Đang chờ thợ xác nhận"); // Mặc định trạng thái cho người dùng là "Chờ xác nhận"
                    command.Parameters.AddWithValue("@GiaTien", txtGiaTien.Text);
                    command.Parameters.AddWithValue("@LinhVuc", txtLinhVuc.Text);
                    command.Parameters.AddWithValue("@IDTho", LoginBLL.IDTho);
                    command.Parameters.AddWithValue("@ThoiGianThucHien", Convert.ToInt32(cbThoiGianThucHien.Text));
                    // Thực thi truy vấn
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có dữ liệu được chèn thành công hay không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã đặt lịch thành công!");
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Đặt lịch thất bại. Vui lòng thử lại sau!");
                    }
                }
            }
        }
    }
}
