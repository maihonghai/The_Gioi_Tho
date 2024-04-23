using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using DAL;
using DTO;
using GUI.All_Calendar_Control;

namespace GUI
{
    public partial class Calendar_User : Form
    {
        public static int _year, _month;

        private DateTime _selectedDate;
        private string _selectedHour;
        private ThongTinND thongtinND;
        private BaiDang baiDangTho;

        public int IDBaiDang { get; set; }

        //public int IDTho;

        public Calendar_User(int idBaiDang)
        {
            InitializeComponent();
            IDBaiDang = idBaiDang;
            //IDTho = GetThoID(idBaiDang);
            thongtinND = new ThongTinND(BLL.LoginBLL.IDNguoiDung);
            baiDangTho = new BaiDang();
            baiDangTho.BaiDangTho(IDBaiDang);
        }

        private void Calendar_User_Load(object sender, EventArgs e)
        {
            // Load ngày hiện tại khi form được mở
            showDays(DateTime.Now.Month, DateTime.Now.Year);
        }

        private void showDays(int month, int year)
        {
            flowLayoutPanel1.Controls.Clear();
            _year = year;
            _month = month;

            string monthName = new DateTimeFormatInfo().GetMonthName(month);
            lblMonth.Text = monthName.ToUpper() + " " + year;
            DateTime startodTheMonth = new DateTime(year, month, 1);
            int day = DateTime.DaysInMonth(year, month);
            int week = Convert.ToInt32(startodTheMonth.DayOfWeek.ToString("d"));
            for (int i = 1; i < week; i++)
            {
                UC_DayUser uc = new UC_DayUser(flowLayoutPanel1, "");
                flowLayoutPanel1.Controls.Add(uc);
            }

            for (int i = 1; i <= day; i++)
            {
                 /*UC_DayUser uc = new UC_DayUser(flowLayoutPanel1, i.ToString());
                 uc.Year = _year;
                 uc.Month = _month;
                 uc.DaySelected += UC_DayUser_DaySelected;
                 flowLayoutPanel1.Controls.Add(uc);*/

                DateTime currentDate = new DateTime(year, month, i);
                bool isBusy = CheckIfDayIsBusy(currentDate);
                UC_DayUser uc = new UC_DayUser(flowLayoutPanel1, i.ToString(), isBusy);
                uc.Year = _year;
                uc.Month = _month;
                uc.DaySelected += UC_DayUser_DaySelected;

                DateTime checkDate = new DateTime(_year, _month, int.Parse(uc.DayText));
                uc.XuLyNgayTrongQuaKhu(checkDate);
                

                flowLayoutPanel1.Controls.Add(uc);
            }

        
        }

        private bool CheckIfDayIsBusy(DateTime date)
        {
            bool isBusy = false;

             using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
             {
                 // Mở kết nối
                 connection.Open();

                 // Chuẩn bị câu truy vấn
                 string query = "SELECT COUNT(*) FROM Tho_NgayNghi nn " +
                                "INNER JOIN BaiDang bd ON bd.IDTho = nn.IDTho " +
                                "WHERE bd.IDBaiDang = @IDBaiDang AND nn.NgayNghi = @NgayNghi";

                 // Tạo đối tượng SqlCommand
                 using (SqlCommand command = new SqlCommand(query, connection))
                 {
                     // Thêm tham số cho câu truy vấn
                     command.Parameters.AddWithValue("@IDBaiDang", IDBaiDang);
                     command.Parameters.AddWithValue("@NgayNghi", date);

                     // Thực thi câu truy vấn và lấy kết quả
                     int count = (int)command.ExecuteScalar();

                     // Nếu count > 0, tức là có lịch nghỉ trong ngày đó
                     if (count > 0)
                     {
                         isBusy = true;
                     }
                 }

                 // Đóng kết nối
                 connection.Close();
             }

             return isBusy;
        }

        private void UC_DayUser_DaySelected(object sender, DateTime e)
        {
            DateTime day = new DateTime(_year, _month, e.Day);

            _selectedDate = e;
            ShowHours(day);

            // Hiển thị ngày được chọn lên lblNgayThoDen
            lblNgayThoDen.Text = day.ToString("dd/MM/yyyy");
        }



        // Xử lý sự kiện khi giờ được chọn
        private void UC_Gio_GioSelected(object sender, string gio)
        {
            _selectedHour = gio;
            // Hiển thị giờ được chọn lên lblGioThoDen
            lblGioThoDen.Text = _selectedHour;
        }

        private void ShowHours(DateTime selectedDate)
        {
            /*// Xóa tất cả các UC_Gio hiện có trong FlowLayoutPanel
            flowLayoutPanel_Gio.Controls.Clear();

            // Hiển thị các giờ của ngày được chọn
            for (int i = 7; i < 20; i++)
            {
                UC_Gio uc = new UC_Gio(flowLayoutPanel_Gio, i.ToString("00") + ":00");
                uc.GioText = i.ToString("00") + ":00";
                uc.IsBusy = CheckIfHourIsBusy(selectedDate, i);
                uc.GioSelected += UC_Gio_GioSelected; // Đăng ký sự kiện GioSelected
                flowLayoutPanel_Gio.Controls.Add(uc);
            }*/

            // Xóa tất cả các UC_Gio hiện có trong FlowLayoutPanel
            flowLayoutPanel_Gio.Controls.Clear();

            int _thoiGianLV = 1;

            // Hiển thị các giờ của ngày được chọn
            for (int i = 7; i < 20; i++)
            {
                // Kiểm tra xem giờ đó và các giờ tiếp theo có bận không
                bool isBusy = CheckIfHourIsBusy(selectedDate, i, ref _thoiGianLV);
                
                // Nếu giờ hoặc các giờ tiếp theo trong thời gian làm việc của công việc đó đã bận
                if (isBusy)
                {
                    // Đánh dấu giờ hiện tại và các giờ tiếp theo trong thời gian làm việc là giờ bận
                    for (int j = i; j < i + _thoiGianLV; j++)
                    {
                        UC_Gio uc = new UC_Gio(flowLayoutPanel_Gio, j.ToString("00") + ":00");
                        uc.GioText = j.ToString("00") + ":00";
                        uc.IsBusy = true;
                        uc.GioSelected += UC_Gio_GioSelected; // Đăng ký sự kiện GioSelected
                        flowLayoutPanel_Gio.Controls.Add(uc);
                    }
                    // Bỏ qua các giờ đã xét bận trong vòng lặp
                    i += _thoiGianLV - 1;
                }
                else
                {
                    // Nếu giờ không bận, hiển thị giờ đó là không bận
                    UC_Gio uc = new UC_Gio(flowLayoutPanel_Gio, i.ToString("00") + ":00");
                    uc.GioText = i.ToString("00") + ":00";
                    uc.IsBusy = false;
                    uc.GioSelected += UC_Gio_GioSelected; // Đăng ký sự kiện GioSelected
                    flowLayoutPanel_Gio.Controls.Add(uc);
                }
            }
        }

        private void gunaLabel1_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDatLichNgay_Click(object sender, EventArgs e)
        {
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
                    command.Parameters.AddWithValue("@IDNguoiDat", BLL.LoginBLL.IDNguoiDung); // Thay thế idNguoiDat bằng ID của người đặt công việc
                    command.Parameters.AddWithValue("@Ten", thongtinND.HoTen);
                    command.Parameters.AddWithValue("@SDT", thongtinND.SoDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", thongtinND.DiaChi);
                    command.Parameters.AddWithValue("@LichThoDen", new DateTime(_year, _month, _selectedDate.Day));
                    command.Parameters.AddWithValue("@Gio", _selectedHour); // Thay thế lblGio.Text bằng _selectedHour
                    command.Parameters.AddWithValue("@MoTaChiTiet", "okhihi");
                    command.Parameters.AddWithValue("@GhiChu", txtGhiChu.Text);
                    //command.Parameters.AddWithValue("@IDBaiDang", IDBaiDang); // Thay thế idBaiDang bằng ID của bài đăng tương ứng
                    command.Parameters.AddWithValue("@TrangThaiCongViecTho", "Chưa xử lý"); // Mặc định trạng thái cho thợ là "Chờ xác nhận"
                    command.Parameters.AddWithValue("@TrangThaiCongViecNguoiDung", "Đang chờ thợ xác nhận"); // Mặc định trạng thái cho người dùng là "Chờ xác nhận"
                    command.Parameters.AddWithValue("@GiaTien", baiDangTho.GiaTien);
                    command.Parameters.AddWithValue("@LinhVuc", baiDangTho.LinhVuc);
                    command.Parameters.AddWithValue("@IDTho", baiDangTho.IDTho);
                    command.Parameters.AddWithValue("@ThoiGianThucHien", baiDangTho.ThoiGianThucHien);
                    // Thực thi truy vấn
                    int rowsAffected = command.ExecuteNonQuery();

                    this.Close();

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

        private bool CheckIfHourIsBusy(DateTime date, int hour, ref int thoiGianLamViec)
        {
            /*bool isBusy = false;

            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

            // Chuẩn bị câu truy vấn
            string query = "SELECT COUNT(*) FROM CongViec cv " +
                           "INNER JOIN BaiDang bd ON cv.IDBaiDang = bd.IDBaiDang " +
                           "WHERE bd.IDTho = @IDTho AND cv.LichThoDen = @Ngay AND cv.Gio = @Gio";

            // Tạo đối tượng SqlCommand
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                // Thêm tham số cho câu truy vấn
                command.Parameters.AddWithValue("@IDTho", IDTho); // Thay thế IDTho bằng ID của thợ
                command.Parameters.AddWithValue("@Ngay", date.Date); // Đảm bảo định dạng ngày tháng chính xác
                command.Parameters.AddWithValue("@Gio", hour.ToString("00") + ":00"); // Đảm bảo định dạng giờ thích hợp

                // Thực thi câu truy vấn và lấy kết quả
                int count = (int)command.ExecuteScalar();

                // Nếu count > 0, tức là thợ bận vào thời gian đó
                if (count > 0)
                {
                    isBusy = true;
                }
            }

            

                // Đóng kết nối
                connection.Close();
            }

            return isBusy;
*/
            bool isBusy = false;
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị câu truy vấn
                string query = "SELECT COUNT(*) FROM CongViec cv " +
                               //"INNER JOIN BaiDang bd ON cv.IDBaiDang = bd.IDBaiDang " +
                               "WHERE cv.IDTho = @IDTho AND cv.LichThoDen = @Ngay AND cv.Gio = @Gio AND cv.TrangThaiCongViecTho NOT IN (@TrangThai1, @TrangThai2, @TrangThai3)";
                
                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@IDTho", baiDangTho.IDTho); // Thay thế IDTho bằng ID của thợ
                    command.Parameters.AddWithValue("@Ngay", date.Date); // Đảm bảo định dạng ngày tháng chính xác
                    command.Parameters.AddWithValue("@Gio", hour.ToString("00") + ":00"); // Đảm bảo định dạng giờ thích hợp
                    command.Parameters.AddWithValue("@TrangThai1", "Đã hủy");
                    command.Parameters.AddWithValue("@TrangThai2", "Từ chối");
                    command.Parameters.AddWithValue("@TrangThai3", "Đã hoàn thành");
                    // Thực thi câu truy vấn và lấy kết quả
                    int count = (int)command.ExecuteScalar();

                    // Nếu count > 0, tức là thợ bận vào thời gian đó
                    if (count > 0)
                    {
                        // Lấy thời gian thực hiện công việc
                        thoiGianLamViec = GetThoiGianThucHien(baiDangTho.IDTho, date.Date, hour);
                        isBusy = true;
                    }
                }

                // Đóng kết nối
                connection.Close();
            }

            return isBusy;
        }

        private int GetThoiGianThucHien(int IDTho, DateTime Ngay, int Gio)
        {
            int thoiGianThucHien = 0;

            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị câu truy vấn
                string query = "SELECT cv.ThoiGianThuchien FROM CongViec cv " +
                               //"INNER JOIN CongViec cv ON bd.IDBaiDang = cv.IDBaiDang " +
                               "WHERE cv.IDTho = @IDTho AND cv.LichThoDen = @Ngay AND cv.Gio = @Gio";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@IDTho", IDTho);
                    command.Parameters.AddWithValue("@Ngay", Ngay);
                    command.Parameters.AddWithValue("@Gio", Gio.ToString("00") + ":00");

                    // Thực thi câu truy vấn và lấy kết quả
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem kết quả có tồn tại hay không
                    if (result != null && result != DBNull.Value)
                    {
                        thoiGianThucHien = Convert.ToInt32(result);
                    }
                }

                // Đóng kết nối
                connection.Close();
            }

            return thoiGianThucHien;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _month += 1;
            if (_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);

        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            _month -= 1;
            if (_month < 1)
            {
                _month = 1;
                _year -= 1;
            }
            showDays(_month, _year);

        }

        private void lblNgayThoDen_Click(object sender, EventArgs e)
        {

        }

        /*private int GetThoID(int IDBaiDang)
        {
            int thoID = -1; // Giá trị mặc định nếu không tìm thấy ID thợ

            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị câu truy vấn
                string query = "SELECT IDTho FROM BaiDang WHERE IDBaiDang = @IDBaiDang";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số cho câu truy vấn
                    command.Parameters.AddWithValue("@IDBaiDang", IDBaiDang);

                    // Thực thi câu truy vấn và lấy kết quả
                    object result = command.ExecuteScalar();

                    // Kiểm tra xem kết quả có tồn tại hay không
                    if (result != null)
                    {
                        thoID = Convert.ToInt32(result);
                    }
                }

                // Đóng kết nối
                connection.Close();
            }

            return thoID;
        }*/

    }
}
