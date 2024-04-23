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
            // Gọi lại các phương thức tạo biểu đồ để cập nhật dữ liệu mới
            CreateChartCot();
            CreateChartTron();
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
            // Tạo biểu đồ cột
            Chart chartColumn = new Chart();
            chartColumn.Size = new Size(400, 400); // Kích thước của biểu đồ cột
            chartColumn.BackColor = Color.Transparent; // Màu nền của biểu đồ

            // Tạo khu vực biểu đồ và cấu hình các thuộc tính
            ChartArea chartAreaColumn = new ChartArea();
            chartColumn.ChartAreas.Add(chartAreaColumn);
            chartAreaColumn.BackColor = Color.White; // Màu nền của khu vực biểu đồ
            chartAreaColumn.AxisX.MajorGrid.Enabled = false; // Màu của đường lưới trên trục X
            chartAreaColumn.AxisY.MajorGrid.Enabled = false; // Màu của đường lưới trên trục Y
            chartAreaColumn.AxisX.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular); // Font chữ và kích thước của nhãn trục X
            chartAreaColumn.AxisY.LabelStyle.Font = new Font("Arial", 10, FontStyle.Regular); // Font chữ và kích thước của nhãn trục Y
            //chartAreaColumn.AxisX.Title = "Trạng thái lịch hẹn"; // Tiêu đề trục X
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

            // Tùy chỉnh màu chữ của tiêu đề
            chartColumn.Titles.Add("Biểu đồ thống kê trạng thái lịch hẹn").ForeColor = Color.Red; // Tiêu đề của biểu đồ
            chartColumn.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold); // Tăng kích thước và cấu hình font chữ của tiêu đề

            // Tùy chỉnh màu của từng cột
            foreach (DataPoint point in seriesColumn.Points)
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
            }

            // Thêm biểu đồ cột vào form hoặc panel
            this.Controls.Add(chartColumn); // Thêm vào form
            pnCot.Controls.Add(chartColumn); // Thêm vào panel


        }

        private void CreateChartTron()
        {
            // Xóa biểu đồ cũ (nếu có)
            pnTron.Controls.Clear();
            // Tạo biểu đồ tròn
            Chart chartPie = new Chart();
            chartPie.Size = new Size(400, 300); // Kích thước của biểu đồ tròn
            chartPie.BackColor = Color.Transparent; // Màu nền của biểu đồ
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
            chartPie.Titles.Add("Biểu đồ tròn thống kê trạng thái lịch hẹn").ForeColor = Color.Red; // Tiêu đề của biểu đồ
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

        private void pnCot_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pnTron_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
