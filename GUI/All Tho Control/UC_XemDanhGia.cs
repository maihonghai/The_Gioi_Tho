using BLL;
using DAL;
using DTO;
using GUI.All_User_Control;
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


namespace GUI.All_Tho_Control
{
    public partial class UC_XemDanhGia : UserControl
    {
        private SaoDanhGia saoDanhGia;
        public UC_XemDanhGia()
        {
            InitializeComponent();
            LoadData();

        }
        private int DemSoSao(int sao)
        {
            int count = 0;
            try
            {
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();
                    string query = "SELECT COUNT(*) FROM DanhGia INNER JOIN CongViec ON DanhGia.IDCongViec = CongViec.IDCongViec WHERE CEILING(CAST(DanhGia.SoSao AS FLOAT)) = @Sao AND CongViec.IDTho = @IDTho";
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@Sao", sao);
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

        private void CreateChartSao()
        {
            // Xóa biểu đồ cũ (nếu có)
            pnlThongKe.Controls.Clear();
            // Tạo biểu đồ cột
            Chart chartColumn = new Chart();
            chartColumn.Size = new Size(400,250); // Kích thước của biểu đồ cột
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
                                                                                              //chartAreaColumn.AxisY.Title = "Số lượng"; // Tiêu đề trục Y

            // Tạo loạt dữ liệu cho biểu đồ cột và cấu hình màu sắc
            Series seriesColumn = new Series();
            seriesColumn.ChartType = SeriesChartType.Bar; // Sử dụng biểu đồ cột ngang
            seriesColumn.Color = Color.Yellow; // Màu của cột
           // seriesColumn.CustomProperties = "PointRadius = 10"; // Đặt độ rộng của cột thành 1 để tạo đầu cột tròn
            seriesColumn.Points.AddXY("1", DemSoSao(1));
            seriesColumn.Points.AddXY("2", DemSoSao(2));
            seriesColumn.Points.AddXY("3", DemSoSao(3));
            seriesColumn.Points.AddXY("4", DemSoSao(4));
            seriesColumn.Points.AddXY("5", DemSoSao(5));

            // Tùy chỉnh đầu cột tròn
            foreach (DataPoint point in seriesColumn.Points)
            {
                point.MarkerStyle = MarkerStyle.Circle; // Đặt hình dạng đầu cột thành hình tròn
                point.MarkerSize = 25; // Đặt kích thước của đầu cột
            }

            chartColumn.Series.Add(seriesColumn);

            // Tùy chỉnh màu chữ của tiêu đề
            //chartColumn.Titles.Add("Biểu đồ thống kê trạng thái lịch hẹn").ForeColor = Color.Red; // Tiêu đề của biểu đồ
            //chartColumn.Titles[0].Font = new Font("Arial", 12, FontStyle.Bold); // Tăng kích thước và cấu hình font chữ của tiêu đề

            // Thêm biểu đồ cột vào form hoặc panel
            this.Controls.Add(chartColumn); // Thêm vào form
            pnlThongKe.Controls.Add(chartColumn); // Thêm vào panel
        }

        private void LoadData()
        {
            saoDanhGia = new SaoDanhGia();
            // Gọi phương thức GetSaoDanhGia để lấy kết quả
            (int soBai, double saoTB) = saoDanhGia.GetSaoDanhGia(LoginBLL.IDTho);

            CreateChartSao();

            lblSaotb.Text = saoTB.ToString("0.0");
            lblSoBaiDanhGia.Text = soBai.ToString() + " Bài Đánh Giá";
            rtSosaotb.Value = Convert.ToInt32(saoTB);
           
        }

        private void UC_XemDanhGia_Load(object sender, EventArgs e)
        {
            LoadReviewsForWorker(LoginBLL.IDTho);
       
       
        }

        // Trong UC_XemDanhGia
        private void LoadReviewsForWorker(int iDTho)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = DAL.ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    // Câu lệnh SQL để lấy thông tin đánh giá cho một thợ cụ thể
                    string query = @"
            SELECT DISTINCT dg.IDDanhGia, cv.Ten, dg.SoSao, dg.NoiDung, dgha.ImageData
            FROM DanhGia dg
            INNER JOIN DanhGiaHinhAnh dgha ON dg.IDDanhGia = dgha.IDDanhGia
            INNER JOIN CongViec cv ON dg.IDCongViec = cv.IDCongViec
            WHERE cv.IDTho = @IDTho";

                    // Tạo và cấu hình SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho WorkerID vào câu lệnh SQL
                        command.Parameters.AddWithValue("@IDTho", iDTho);

                        // Thực thi câu lệnh SQL và đọc dữ liệu
                        SqlDataReader reader = command.ExecuteReader();

                        // Khởi tạo danh sách lưu trữ dữ liệu hình ảnh
                        List<byte[]> imageDataList = new List<byte[]>();

                        // Duyệt qua tất cả các đánh giá và tạo UC_DanhGia tương ứng
                        int previousIDDanhGia = -1; // Biến lưu trữ IDDanhGia của bản ghi trước đó
                        UC_DanhGia ucDanhGia = null;

                        while (reader.Read())
                        {
                            int currentIDDanhGia = Convert.ToInt32(reader["IDDanhGia"]);


                            // Nếu là bản ghi đầu tiên hoặc IDDanhGia thay đổi
                            if (previousIDDanhGia == -1 || currentIDDanhGia != previousIDDanhGia)
                            {
                                // Tạo UC_DanhGia mới nếu là bản ghi đầu tiên hoặc IDDanhGia thay đổi
                                if (ucDanhGia != null)
                                {
                                    // Thêm UC_DanhGia vào panel trước khi tạo một cái mới
                                    ucDanhGia.Dock = DockStyle.Top;
                                    panel1.Controls.Add(ucDanhGia);
                           
                                }

                                // Tạo danh sách hình ảnh mới cho bài đánh giá
                                imageDataList = new List<byte[]>();

                                // Thêm hình ảnh vào danh sách
                                byte[] imageData = reader["ImageData"] as byte[];
                                if (imageData != null && imageData.Length > 0)
                                {
                                    imageDataList.Add(imageData);
                                }

                                // Tạo UC_DanhGia từ thông tin đã thu thập
                                ucDanhGia = new UC_DanhGia(
                                    reader["Ten"].ToString(),
                                    Convert.ToSingle(reader["SoSao"]),
                                    reader["NoiDung"].ToString(),
                                    imageDataList
                                );
                            }
                            else // Nếu là cùng một nhóm IDDanhGia, chỉ cập nhật danh sách hình ảnh của UC_DanhGia cuối cùng
                            {
                                // Thêm hình ảnh vào danh sách
                                byte[] imageData = reader["ImageData"] as byte[];
                                if (imageData != null && imageData.Length > 0)
                                {
                                    imageDataList.Add(imageData);
                                }
                            }

                            // Cập nhật giá trị IDDanhGia của bản ghi trước đó
                            previousIDDanhGia = currentIDDanhGia;
                        }

                        // Thêm UC_DanhGia cuối cùng vào panel
                        if (ucDanhGia != null)
                        {
                            ucDanhGia.Dock = DockStyle.Top;
                            panel1.Controls.Add(ucDanhGia);
                          
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải đánh giá: " + ex.Message);
            }

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
