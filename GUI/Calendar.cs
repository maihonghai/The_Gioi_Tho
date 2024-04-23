using GUI.All_Calendar_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using System.Data.SqlClient;
using BLL;

namespace GUI
{
    public partial class Calendar : Form
    {
        public static int _year, _month;

        //danh sach cac ngay nghi sẽ xoa khi tho bỏ chọn
        private List<DateTime> offDays = new List<DateTime>();

        public Calendar()
        {
            InitializeComponent();
        }

        private void Calendar_Load(object sender, EventArgs e)
        {
            showDays(DateTime.Now.Month, DateTime.Now.Year);
            MarkOffDays();

            // Xóa các ngày nghỉ trong quá khứ
            DeletePastOffDays();

            // Gán event handler UC_Day_OffDayStateChanged cho tất cả các UserControl UC_Day
            foreach (UC_Day ucDay in flowLayoutPanel1.Controls.OfType<UC_Day>())
            {
                ucDay.OffDayStateChanged += UC_Day_OffDayStateChanged;
            }
        }

        private void DeletePastOffDays()
        {
            using (SqlConnection connection = DAL.ConnectionDAL.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    // Xóa các ngày nghỉ trong quá khứ từ cơ sở dữ liệu
                    string deletePastQuery = "DELETE FROM Tho_NgayNghi WHERE IDTho = @IDTho AND NgayNghi < @CurrentDate";
                    SqlCommand deletePastCommand = new SqlCommand(deletePastQuery, connection);
                    deletePastCommand.Parameters.AddWithValue("@IDTho", BLL.LoginBLL.IDTho);
                    deletePastCommand.Parameters.AddWithValue("@CurrentDate", DateTime.Today);
                    deletePastCommand.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa các ngày nghỉ trong quá khứ: " + ex.Message);
                }
            }
        }


        private void MarkOffDays()
        {
            using (SqlConnection connection = DAL.ConnectionDAL.GetSqlConnection())
            {
                try
                {
                    connection.Open();
                    string query = "SELECT NgayNghi FROM Tho_NgayNghi WHERE IDTho = @IDTho";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@IDTho", BLL.LoginBLL.IDTho);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        DateTime offDay = reader.GetDateTime(0);
                        MarkDayAsOff(offDay.Day, offDay.Month, offDay.Year);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Không thể chọn ngày trống. Vui lòng chọn lại!");
                }
            }
        }

        private void MarkDayAsOff(int day, int month, int year)
        {
            foreach (UC_Day ucDay in flowLayoutPanel1.Controls.OfType<UC_Day>())
            {
                if (ucDay.DayText == day.ToString() && _month == month && _year == year)
                {
                    ucDay.MarkAsOffDay();
                    break; // Đánh dấu xong thì thoát vòng lặp
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }



        private void btnNext_Click(object sender, EventArgs e)
        {
            _month += 1;
            if(_month > 12)
            {
                _month = 1;
                _year += 1;
            }
            showDays(_month, _year);
            MarkOffDays();
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
            MarkOffDays();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            // Truy xuất và cập nhật cơ sở dữ liệu
            UpdateOffDaysToDatabase();
        }

        private void UpdateOffDaysToDatabase()
        {
            using (SqlConnection connection = DAL.ConnectionDAL.GetSqlConnection())
            {
                try
                {
                    connection.Open();

                    // Xóa tất cả các ngày nghỉ cho thợ đó trong tháng và năm hiện tại
                    string deleteAllQuery = "DELETE FROM Tho_NgayNghi WHERE IDTho = @IDTho AND YEAR(NgayNghi) = @Year AND MONTH(NgayNghi) = @Month";
                    SqlCommand deleteAllCommand = new SqlCommand(deleteAllQuery, connection);
                    deleteAllCommand.Parameters.AddWithValue("@IDTho", BLL.LoginBLL.IDTho);
                    deleteAllCommand.Parameters.AddWithValue("@Year", _year);
                    deleteAllCommand.Parameters.AddWithValue("@Month", _month);
                    deleteAllCommand.ExecuteNonQuery();

                    // Thêm mới các ngày nghỉ đã đánh dấu trong tháng và năm hiện tại
                    foreach (UC_Day dayControl in flowLayoutPanel1.Controls.OfType<UC_Day>().Where(uc => uc.IsOffDay))
                    {
                        DateTime offDay = new DateTime(_year, _month, int.Parse(dayControl.DayText));
                        string insertQuery = "INSERT INTO Tho_NgayNghi (IDTho, NgayNghi) VALUES (@IDTho, @NgayNghi)";
                        SqlCommand insertCommand = new SqlCommand(insertQuery, connection);
                        insertCommand.Parameters.AddWithValue("@IDTho", BLL.LoginBLL.IDTho);
                        insertCommand.Parameters.AddWithValue("@NgayNghi", offDay);
                        insertCommand.ExecuteNonQuery();
                    }

                    MessageBox.Show("Cập nhật lịch nghỉ thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi cập nhật lịch nghỉ: " + ex.Message);
                }
            }
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
            int week = (int)startodTheMonth.DayOfWeek; // Sửa thành ngày đầu tiên của tháng

            

            // Bắt đầu vòng lặp từ 0 để hiển thị ngày đầu tiên của tháng
            for (int i = 0; i < week; i++)
            {
                UC_Day uc = new UC_Day("");
                flowLayoutPanel1.Controls.Add(uc);
            }

            for (int i = 1; i <= day; i++) // Sửa điều kiện vòng lặp để bao gồm cả ngày cuối cùng của tháng
            {
                UC_Day uc = new UC_Day(i.ToString());
                uc.Year = _year;
                uc.Month = _month;
                flowLayoutPanel1.Controls.Add(uc);
            }

        }

        private void UC_Day_OffDayStateChanged(object sender, EventArgs e)
        {
            UC_Day ucDay = sender as UC_Day;
            if (ucDay != null)
            {
                if (ucDay.IsOffDay)
                {
                    // Nếu ngày nghỉ đã được chọn, thêm vào danh sách offDays
                    DateTime offDay = new DateTime(_year, _month, int.Parse(ucDay.DayText));
                    if (!offDays.Contains(offDay))
                    {
                        offDays.Add(offDay);
                    }
                }
                else
                {
                    // Nếu ngày nghỉ đã được bỏ chọn, xóa khỏi danh sách offDays
                    DateTime offDay = new DateTime(_year, _month, int.Parse(ucDay.DayText));
                    offDays.Remove(offDay);
                }
            }
        }


    }
}
