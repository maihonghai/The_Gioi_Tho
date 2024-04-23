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

namespace GUI.All_Tho_Control
{
    public partial class UC_XemDanhGiaChiTiet : UserControl
    {
        //private BaiDang thongtin;
        private SaoDanhGia saoDanhGia;
        public UC_XemDanhGiaChiTiet()
        {
            InitializeComponent();
        }
        public UC_XemDanhGiaChiTiet(int iDTho)
        {
            InitializeComponent();
            //thongtin = new BaiDang();
            //thongtin.BaiDangTho(iDBaiDang);

            saoDanhGia = new SaoDanhGia();
            // Gọi phương thức GetSaoDanhGia để lấy kết quả
            (int soBai, double saoTB) = saoDanhGia.GetSaoDanhGia(iDTho);

            LoadReviewsForWorker(iDTho);
            lblSaotb.Text = saoTB.ToString("0.0");
            lblSoBaiDanhGia.Text = "(" + soBai.ToString() + " Bài viết)";
            rtSosaotb.Value = Convert.ToInt32(saoTB);
        }
        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void LoadReviewsForWorker(int iDTho)
        {
            try
            {
                // Xóa tất cả các control hiện có trong panel1 trước khi thêm mới
                panel1.Controls.Clear();
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

    }
}
