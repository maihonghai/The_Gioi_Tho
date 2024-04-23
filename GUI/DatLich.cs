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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GUI
{
    public partial class DatLich : Form
    {
        public int IDBaiDang { get; set; }
        private ThongTinND thongtinND;
        private BaiDang baiDangTho;
        private DateTime selectedDate;

        public DatLich(int iDBaiDang)
        {
            InitializeComponent();
            // Thiết lập StartPosition để hiển thị form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;
            IDBaiDang = iDBaiDang;
            lblIDBaiDang.Text = iDBaiDang.ToString();
            thongtinND = new ThongTinND(BLL.LoginBLL.IDNguoiDung);
            baiDangTho = new BaiDang();
            baiDangTho.BaiDangTho(IDBaiDang);
            txtGiaTien.Text = baiDangTho.LinhVuc;
        }

        public DatLich()
        {
            InitializeComponent();
            /*// Thiết lập StartPosition để hiển thị form ở giữa màn hình
            this.StartPosition = FormStartPosition.CenterScreen;

            this.cbGio.DrawItem += cbGio_DrawItem;*/


        }


        private void DatLich_Load(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDatLichNgay_Click(object sender, EventArgs e)
        {
            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Tạo truy vấn SQL INSERT
                string query = "INSERT INTO CongViec (IDNguoiDat, Ten, SDT, DiaChi, LichThoDen, Gio, MoTaChiTiet, GhiChu, TrangThaiCongViecTho, TrangThaiCongViecNguoiDung,GiaTien,LinhVuc,IDTho) " +
                               "VALUES (@IDNguoiDat, @Ten, @SDT, @DiaChi, @LichThoDen, @Gio, @MoTaChiTiet, @GhiChu, @TrangThaiCongViecTho, @TrangThaiCongViecNguoiDung,@GiaTien,@LinhVuc,@IDTho)";

                // Tạo và mở kết nối
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();

                    // Đặt các tham số cho truy vấn
                    command.Parameters.AddWithValue("@IDNguoiDat", BLL.LoginBLL.IDNguoiDung); // Thay thế idNguoiDat bằng ID của người đặt công việc
                    command.Parameters.AddWithValue("@Ten", thongtinND.HoTen);
                    command.Parameters.AddWithValue("@SDT", thongtinND.SoDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", thongtinND.DiaChi);
                    command.Parameters.AddWithValue("@LichThoDen", dtpLichThoDen.Value);
                    command.Parameters.AddWithValue("@Gio", cbGio.Text);
                    command.Parameters.AddWithValue("@MoTaChiTiet", txtMoTaChiTiet.Text);
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    //command.Parameters.AddWithValue("@IDBaiDang", IDBaiDang); // Thay thế idBaiDang bằng ID của bài đăng tương ứng
                    command.Parameters.AddWithValue("@TrangThaiCongViecTho", "Chưa xử lý"); // Mặc định trạng thái cho thợ là "Chờ xác nhận"
                    command.Parameters.AddWithValue("@TrangThaiCongViecNguoiDung", "Đang chờ thợ xác nhận"); // Mặc định trạng thái cho người dùng là "Chờ xác nhận"
                    command.Parameters.AddWithValue("@GiaTien", baiDangTho.GiaTien);
                    command.Parameters.AddWithValue("@LinhVuc", baiDangTho.LinhVuc);
                    command.Parameters.AddWithValue("@IDTho",baiDangTho.IDTho);
                    // Thực thi truy vấn
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem có dữ liệu được chèn thành công hay không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Đã đặt lịch thành công!");
                    }
                    else
                    {
                        MessageBox.Show("Đặt lịch thất bại. Vui lòng thử lại sau!");
                    }
                }
            }

        }

        private void guna2TextBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpLichThoDen_ValueChanged(object sender, EventArgs e)
        {
            /*selectedDate = dtpLichThoDen.Value;
            LoadAvailableHours(dtpLichThoDen.Value);*/
        }



        private void LoadAvailableHours(DateTime selectedDate)
        {
            // TODO: Tải danh sách giờ có sẵn dựa trên ngày đã chọn và giờ đã đặt của thợ

            // Ví dụ tạm thời:

            List<string> availableHours = new List<string>();
            availableHours.Add("7:00 AM");
            availableHours.Add("7:30 AM");
            availableHours.Add("8:00 AM");
            availableHours.Add("8:30 AM");
            availableHours.Add("9:00 AM");
            availableHours.Add("9:30 AM");
            availableHours.Add("10:00 AM");
            availableHours.Add("10:30 AM");
            availableHours.Add("11:00 AM");
            availableHours.Add("11:30 AM");
            availableHours.Add("12:00 PM");
            availableHours.Add("12:30 PM");
            availableHours.Add("1:00 PM");
            availableHours.Add("1:30 PM");
            availableHours.Add("2:00 PM");
            availableHours.Add("2:30 PM");
            availableHours.Add("3:00 PM");
            availableHours.Add("3:30 PM");
            availableHours.Add("4:00 PM");
            availableHours.Add("4:30 PM");
            availableHours.Add("5:00 PM");
            availableHours.Add("5:30 PM");
            availableHours.Add("6:00 PM");
            availableHours.Add("6:30 PM");
            availableHours.Add("7:00 PM");
            availableHours.Add("7:30 PM");
            availableHours.Add("8:00 PM");
            availableHours.Add("8:30 PM");
            availableHours.Add("9:00 PM");
            // Tạo danh sách màu cho từng mục trong ComboBox
            Color[] itemColors = new Color[availableHours.Count];

            for (int i = 0; i < availableHours.Count; i++)
            {
                string hour = availableHours[i];
                if (IsHourUnavailable(selectedDate, hour))
                {
                    // Nếu giờ không khả dụng, đặt màu đỏ
                    itemColors[i] = Color.Red;
                }
                else
                {
                    // Nếu giờ khả dụng, đặt màu mặc định
                    itemColors[i] = cbGio.ForeColor; // Màu văn bản mặc định của ComboBox
                }
            }

            // Gán danh sách giờ và màu vào ComboBox
            cbGio.DataSource = availableHours;
            cbGio.Tag = itemColors; // Lưu trữ danh sách màu trong Tag của ComboBox
        }

        private void cbGio_DrawItem(object sender, DrawItemEventArgs e)
        {
            /*if (e.Index >= 0)
            {
                string hour = cbGio.Items[e.Index].ToString();
                if (IsHourUnavailable(selectedDate, hour))
                {
                    e.Graphics.FillRectangle(Brushes.Red, e.Bounds);
                    e.Graphics.DrawString(hour, cbGio.Font, Brushes.White, e.Bounds);
                    e.DrawFocusRectangle();
                }
                else
                {
                    e.DrawBackground();
                    e.DrawFocusRectangle();
                    e.Graphics.DrawString(hour, cbGio.Font, Brushes.Black, e.Bounds);
                }
            }*/
        }

        private bool IsHourUnavailable(DateTime selectedDate, string hour)
        {
            bool isUnavailable = false;

            // Chuyển đổi chuỗi giờ thành đối tượng DateTime để so sánh với ngày đã chọn
            DateTime selectedDateTime = selectedDate.Date + TimeSpan.Parse(hour);

            // Thực hiện truy vấn để lấy danh sách các ngày và giờ đã bận của thợ
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                connection.Open();
                string query = @"
            SELECT cv.IDTho, cv.LichThoDen, cv.Gio
            FROM CongViec cv
            WHERE cv.IDTho = @IDTho"; // Thay thế 1 bằng ID của thợ tương ứng


                using (SqlCommand command = new SqlCommand(query, connection))
                {


                    SqlDataReader reader = command.ExecuteReader();
                    command.Parameters.AddWithValue("@IDTho", LoginBLL.IDTho);
                    while (reader.Read())
                    {
                        DateTime busyDateTime = reader.GetDateTime(1).Date + reader.GetTimeSpan(2);

                        // Chuyển đổi giờ đã bận từ định dạng AM/PM sang 24 giờ
                        string busyHour = busyDateTime.ToString("HH:mm");

                        // So sánh giờ đã chọn với giờ đã bận
                        if (busyHour == hour)
                        {
                            isUnavailable = true; // Nếu giờ đã bận trùng với giờ đã chọn, đặt biến kiểm tra thành true
                            break; // Kết thúc vòng lặp ngay khi tìm thấy một giờ đã bận
                        }
                    }
                }
            }

            return isUnavailable;
        }


        private void cbGio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
