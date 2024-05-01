using DAL;
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
using System.Windows.Forms.DataVisualization.Charting;
using static Guna.UI2.Native.WinApi;

namespace GUI.All_Tho_Control
{
    public partial class UC_ThongKe : UserControl
    {
        //private string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";

        public UC_ThongKe()
        {
            InitializeComponent();
            // LoadThongKe();
            // CreateChartCot();
            //CreateChartTron();
        }
        public void ThongKeButton_Click(object sender, EventArgs e)
        {
            /*// Gọi lại các phương thức tạo biểu đồ để cập nhật dữ liệu mới
            CreateChartCot();
            Dictionary<string, decimal> doanhThuTheoThang = LayDoanhThuCacThangGanDay(3);

            CreateChartDuong(doanhThuTheoThang);*/
            btnXemDoanhThu.PerformClick();

        }

        private decimal LayDoanhThuTheoThang(int month, int year)
        {
            decimal doanhThu = 0;

            // Truy vấn cơ sở dữ liệu
            string query = "SELECT SUM(GiaTien) AS DoanhThu " +
                           "FROM CongViec " +
                           "WHERE MONTH(LichThoDen) = @Thang AND YEAR(LichThoDen) = @Nam AND TrangThaiCongViecTho = @TrangThai AND IDTho = @idTho ";

            // Thực hiện truy vấn và xử lý dữ liệu
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                connection.Open();
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Thang", month);
                    command.Parameters.AddWithValue("@Nam", year);
                    command.Parameters.AddWithValue("@TrangThai", "Đã hoàn thành");
                    command.Parameters.AddWithValue("@idTho", BLL.LoginBLL.IDTho);
                    object result = command.ExecuteScalar();
                    if (result != null && result != DBNull.Value)
                    {
                        doanhThu = Convert.ToDecimal(result);
                    }
                }
            }

            return doanhThu;
        }
        private Dictionary<string, decimal> LayDoanhThuCacThangGanDay(int soThang)
        {
            Dictionary<string, decimal> doanhThuTheoThang = new Dictionary<string, decimal>();

            // Lấy tháng và năm hiện tại
            int thangHienTai = DateTime.Now.Month;
            int namHienTai = DateTime.Now.Year;

            // Bắt đầu từ ba tháng trước
            DateTime ngayBatDau = DateTime.Now.AddMonths(-soThang + 1); // Điều chỉnh để đếm bao gồm cả tháng hiện tại

            // Lặp qua số tháng yêu cầu
            for (int i = 0; i < soThang; i++)
            {
                // Lấy tháng và năm của vòng lặp hiện tại
                int thang = ngayBatDau.Month;
                int nam = ngayBatDau.Year;

                // Tạo chuỗi khóa cho kết hợp tháng-năm
                string khoa = $"{thang}/{nam}";

                // Lấy doanh thu cho tháng hiện tại
                decimal doanhThu = LayDoanhThuTheoThang(thang, nam);

                // Thêm doanh thu vào từ điển
                doanhThuTheoThang[khoa] = doanhThu;

                // Chuyển sang tháng tiếp theo (tăng thêm một tháng)
                ngayBatDau = ngayBatDau.AddMonths(1);
            }

            return doanhThuTheoThang;
        }
        private int DemSoLichHen(string trangThai)
        {
            int count = 0;
            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM CongViec WHERE TrangThaiCongViecTho = @TrangThai AND CongViec.IDTho = @idTho";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@TrangThai", trangThai);
                    command.Parameters.AddWithValue("@idTho", BLL.LoginBLL.IDTho);
                    count = (int)command.ExecuteScalar();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            return count;
        }

        private void CreateChartCot()
        {
            // Xóa biểu đồ cũ (nếu có)
            pnCot.Controls.Clear();

            // Tạo biểu đồ cột mới
            Chart chartColumn = new Chart();
            chartColumn.Size = new Size(pnCot.Width,pnCot.Height); // Kích thước của biểu đồ cột
            chartColumn.BackColor = Color.WhiteSmoke; // Màu nền của biểu đồ
            chartColumn.Titles.Add("Biểu đồ thống kê trạng thái lịch hẹn"); // Tiêu đề của biểu đồ
            chartColumn.Titles[0].ForeColor = Color.FromArgb(44, 62, 80); // Màu chữ của tiêu đề
            chartColumn.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold); // Font chữ và kích thước của tiêu đề

            // Tạo khu vực biểu đồ và cấu hình các thuộc tính
            ChartArea chartAreaColumn = new ChartArea();
            chartColumn.ChartAreas.Add(chartAreaColumn);
            chartAreaColumn.BackColor = Color.White; // Màu nền của khu vực biểu đồ
            chartAreaColumn.AxisX.MajorGrid.Enabled = false; // Ẩn đường lưới trên trục X
            chartAreaColumn.AxisY.MajorGrid.Enabled = false; // Ẩn đường lưới trên trục Y
            chartAreaColumn.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular); // Font chữ và kích thước của nhãn trục X
            chartAreaColumn.AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular); // Font chữ và kích thước của nhãn trục Y
            chartAreaColumn.AxisY.Title = "Số lượng"; // Tiêu đề trục Y

            // Tạo loạt dữ liệu cho biểu đồ cột và cấu hình màu sắc
            Series seriesColumn = new Series();
            seriesColumn.ChartType = SeriesChartType.Column;
            seriesColumn.Color = Color.Blue; // Màu của cột
            seriesColumn.Points.AddXY("Chưa xử lí", DemSoLichHen("Chưa xử lý"));
            seriesColumn.Points.AddXY("Đã chấp nhận", DemSoLichHen("Đã chấp nhận"));
            seriesColumn.Points.AddXY("Đã hoàn thành", DemSoLichHen("Đã hoàn thành"));
            seriesColumn.Points.AddXY("Từ chối", DemSoLichHen("Từ chối"));
            seriesColumn.Points.AddXY("Đã hủy", DemSoLichHen("Đã hủy"));
            chartColumn.Series.Add(seriesColumn);

            // Tùy chỉnh màu của từng cột
            foreach (DataPoint point in seriesColumn.Points)
            {
                switch (point.AxisLabel)
                {
                    case "Chưa xử lí":
                        point.Color = Color.Lime;
                        break;
                    case "Đã chấp nhận":
                        point.Color = Color.Cyan;
                        break;
                    case "Đã hoàn thành":
                        point.Color = Color.Magenta;
                        break;
                    case "Từ chối":
                        point.Color = Color.Yellow;
                        break;
                    case "Đã hủy":
                        point.Color = Color.Gray;
                        break;
                }
            }

            // Thêm biểu đồ cột vào panel
            pnCot.Controls.Add(chartColumn);
        }

        private void CreateChartTron()
        {
            // Xóa biểu đồ cũ (nếu có)
            pnTron.Controls.Clear();
            // Tạo biểu đồ tròn
            Chart chartPie = new Chart();
            chartPie.Size = new Size(pnTron.Width,pnTron.Height); // Kích thước của biểu đồ tròn
            chartPie.BackColor = Color.WhiteSmoke; // Màu nền của biểu đồ
            ChartArea chartAreaPie = new ChartArea();
            chartPie.ChartAreas.Add(chartAreaPie);
            chartAreaPie.BackColor = Color.Transparent; // Màu nền của khu vực biểu đồ
            chartAreaPie.AxisX.MajorGrid.Enabled = false; // Tắt đường lưới trên trục X
            chartAreaPie.AxisY.MajorGrid.Enabled = false; // Tắt đường lưới trên trục Y
            Series seriesPie = new Series();
            seriesPie.ChartType = SeriesChartType.Pie;
            seriesPie.Points.AddXY("Chưa xử lí", DemSoLichHen("Chưa xử lý"));
            seriesPie.Points.AddXY("Đã chấp nhận", DemSoLichHen("Đã chấp nhận"));
            seriesPie.Points.AddXY("Đã hoàn thành", DemSoLichHen("Đã hoàn thành"));
            seriesPie.Points.AddXY("Từ chối", DemSoLichHen("Từ chối"));
            seriesPie.Points.AddXY("Đã hủy", DemSoLichHen("Đã hủy"));
            chartPie.Series.Add(seriesPie);
            chartPie.Titles.Add("Biểu đồ tròn thống kê trạng thái lịch hẹn").ForeColor = Color.FromArgb(44, 62, 80); // Tiêu đề của biểu đồ
            chartPie.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold);

            foreach (DataPoint point in seriesPie.Points)
            {
                if (point.AxisLabel == "Chưa xử lí")
                    point.Color = Color.Lime;
                else if (point.AxisLabel == "Đã chấp nhận")
                    point.Color = Color.Cyan;
                else if (point.AxisLabel == "Đã hoàn thành")
                    point.Color = Color.Magenta;
                else if (point.AxisLabel == "Từ chối")
                    point.Color = Color.Yellow;
                else if (point.AxisLabel == "Đã hủy")
                    point.Color = Color.Gray;


                // Tính phần trăm và thiết lập nhãn cho mỗi DataPoint
                double percentage = (point.YValues[0] / seriesPie.Points.Sum(x => x.YValues[0])) * 100;
                point.Label = $"{percentage:#.##}%"; // Chỉ hiển thị phần trăm
                point.LabelForeColor = Color.Black; // Đặt màu cho nhãn là màu của nền
                point.Font = new Font("Arial", 10, FontStyle.Regular); // Cấu hình font chữ cho nhãn


                // Ẩn đi tên trạng thái trên biểu đồ tròn
                //point.SetCustomProperty("PieLabelStyle", "Disabled");
            }


            // Thêm biểu đồ tròn vào form hoặc panel
            this.Controls.Add(chartPie); // Thêm vào form
            pnTron.Controls.Add(chartPie); // Thêm vào panel
        }
        private void CreateChartDuong(Dictionary<string, decimal> data)
        {
            pnThongKe.Controls.Clear();

            // Create a line chart
            Chart chartLine = new Chart();
            chartLine.Size = new Size(pnThongKe.Width,pnThongKe.Height); // Increase chart size for better visibility
            chartLine.BackColor = Color.WhiteSmoke; // Set background color

            // Create chart area and configure its properties
            ChartArea chartAreaLine = new ChartArea();
            chartLine.ChartAreas.Add(chartAreaLine);
            chartAreaLine.BackColor = Color.White;
            chartAreaLine.AxisX.MajorGrid.LineColor = Color.LightGray; // Adjust grid line color
            chartAreaLine.AxisX.LineColor = Color.Black; // Adjust axis line color
            chartAreaLine.AxisY.MajorGrid.LineColor = Color.LightGray;
            chartAreaLine.AxisY.LineColor = Color.Black;
            chartAreaLine.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            chartAreaLine.AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular);
            chartAreaLine.AxisY.Title = "Doanh Thu";
            chartAreaLine.AxisX.Interval = 1; // Ensure labels are displayed for each data point

            // Create series for the line chart and configure its properties
            Series seriesLine = new Series();
            seriesLine.ChartType = SeriesChartType.Line;
            seriesLine.Color = Color.FromArgb(52, 152, 219); // Set line color
            seriesLine.BorderWidth = 2; // Increase line thickness for better visibility

            // Loop through the data and add points to the series
            foreach (var item in data)
            {
                DataPoint point = new DataPoint();
                point.SetValueXY(item.Key, item.Value);
                point.Label = String.Format("{0:N0} $", item.Value);
                point.LabelForeColor = Color.Black;
                point.Font = new Font("Arial", 10, FontStyle.Regular);
                seriesLine.Points.Add(point);
            }

            chartLine.Series.Add(seriesLine);

            // Customize title color
            chartLine.Titles.Add("Biểu đồ thống kê doanh thu các tháng gần đây");
            chartLine.Titles[0].ForeColor = Color.FromArgb(44, 62, 80); // Set title color
            chartLine.Titles[0].Font = new Font("Arial", 16, FontStyle.Bold); // Increase title font size

            // Add the chart to the panel
            pnThongKe.Controls.Add(chartLine);
        }

        private void btnXemDoangThu_Click(object sender, EventArgs e)
        {
            Dictionary<string, decimal> doanhThuTheoThang = LayDoanhThuCacThangGanDay(3);

            CreateChartDuong(doanhThuTheoThang);
        }

        private void btnCongViec_Click(object sender, EventArgs e)
        {
            pnThongKe.Controls.Clear();
            pnThongKe.Controls.Add(pnCot);
            pnThongKe.Controls.Add(pnTron);
            pnThongKe.Controls.Add(pnChuThich);
            CreateChartCot();
            CreateChartTron();
        }

       
    } 
    
}
