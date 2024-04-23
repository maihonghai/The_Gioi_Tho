using DAL;
using DTO;
using Guna.UI2.WinForms;
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
    public partial class UC_Lich : UserControl
    {
        private LichHenTho _lichHenTho; // Đối tượng LichHen được truyền vào UserControl

        // Khai báo các phương thức hoặc thuộc tính để truy cập từ bên ngoài
        public Guna2Button GetBtnHuyLichHen() { return btnTuChoi; }
        public Guna2Button GetBtnYeuCauDoiLich() { return btnYeuCauDoiLich; }
        public Guna2Button GetBtnChapNhan() { return btnChapNhan; }

        public Guna2Button GetBtnHoanThanh() { return btnHoanTat; }

        public Guna2Button GetBtnXemDanhGia() {return btnXemDanhGia;}

        public UC_Lich()
        {
            InitializeComponent();
        }
        // Constructor với tham số để truyền dữ liệu từ UC_HoatDong
        public UC_Lich(LichHenTho lichHenTho)
        {
            _lichHenTho = lichHenTho; // Lưu đối tượng LichHen được truyền vào
            InitializeComponent();

            // Thực hiện gán dữ liệu từ lichHen vào các control trong UserControl
            lblID.Text = lichHenTho.IDLichHen.ToString();
            txtLinhVuc.Text = lichHenTho.LinhVuc;
            txtTenKhachHang.Text = lichHenTho.Ten;
            txtSoDienThoai.Text = lichHenTho.SDT;
            txtLichThoDen.Text = lichHenTho.LichHenDen.ToString("dd/MM/yyyy");
            txtGio.Text = lichHenTho.Gio;
            txtDiaChi.Text = lichHenTho.DiaChi;
            txtGhiChu.Text = lichHenTho.GhiChu;
            txtGia.Text = lichHenTho.GiaTien.ToString();
        }

       // private string connectionString = "Data Source=LAPTOP-DTKDJMOS\\SQLEXPRESS;Initial Catalog=TheGioiTho;Integrated Security=True";
        private void UpdateDatabase(int lichHenID, string trangThaiCongViecNguoiDung, string trangThaiCongViecTho)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    // Câu lệnh SQL để cập nhật giá trị của hai thuộc tính trong bảng Công việc
                    string query = "UPDATE CongViec SET TrangThaiCongViecTho = @TrangThaiTho, TrangThaiCongViecNguoiDung = @TrangThaiNguoiDung WHERE IDCongViec = @IDLichHen";

                    // Tạo và cấu hình SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@TrangThaiTho", trangThaiCongViecTho); // Đặt giá trị mới cho hai thuộc tính
                        command.Parameters.AddWithValue("@TrangThaiNguoiDung", trangThaiCongViecNguoiDung);
                        command.Parameters.AddWithValue("@IDLichHen", lichHenID);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bao nhiêu dòng dữ liệu đã được ảnh hưởng
                        if (rowsAffected > 0)
                        {
                            //MessageBox.Show("Đã cập nhật thành công trong cơ sở dữ liệu!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật dữ liệu trong cơ sở dữ liệu!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi cập nhật dữ liệu trong cơ sở dữ liệu: " + ex.Message);
            }
        }

        private void UC_Lich_Load(object sender, EventArgs e)
        {

        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            UpdateDatabase(_lichHenTho.IDLichHen, "Đã xác nhận", "Đã chấp nhận");
            this.Dispose();
            // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
            MessageBox.Show("Đã nhận công việc!");
        }

        private void btnTuChoi_Click(object sender, EventArgs e)
        {
            UpdateDatabase(_lichHenTho.IDLichHen, "Đã hủy", "Từ chối");
            this.Dispose();
            // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
            MessageBox.Show("Đã hủy lịch hẹn!");
        }

        private void btnYeuCauDoiLich_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form thay đổi ngày và giờ
            FormThayDoiNgayGio formThayDoiNgayGio = new FormThayDoiNgayGio(_lichHenTho.IDLichHen);

            // Hiển thị form
            formThayDoiNgayGio.ShowDialog();

            // Kiểm tra xem form có đóng hay không
            if (formThayDoiNgayGio.DialogResult == DialogResult.OK)
            {

                UpdateDatabase(_lichHenTho.IDLichHen, "Yêu cầu dời lịch", "Chưa xử lý");

                this.Dispose();

                // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
                MessageBox.Show("Đã yêu cầu dời lịch hẹn!");
            }
        }

        private void btnHoanTat_Click(object sender, EventArgs e)
        {
            UpdateDatabase(_lichHenTho.IDLichHen, "Hoàn tất", "Đã hoàn thành");
            this.Dispose();
            // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
            MessageBox.Show("Cập nhật thành công!");
        }



        private void btnXemDanhGia_Click(object sender, EventArgs e)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    // Câu lệnh SQL để lấy thông tin đánh giá và các hình ảnh tương ứng
                    string query = @"
                SELECT cv.Ten, dg.SoSao, dg.NoiDung, dgha.ImageData
                FROM DanhGia dg
                INNER JOIN CongViec cv ON dg.IDCongViec = cv.IDCongViec
                LEFT JOIN DanhGiaHinhAnh dgha ON dg.IDDanhGia = dgha.IDDanhGia
                WHERE dg.IDCongViec = @IDLichHen";

                    // Tạo và cấu hình SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm tham số cho IDLichHen vào câu lệnh SQL
                        command.Parameters.AddWithValue("@IDLichHen", _lichHenTho.IDLichHen);

                        // Thực thi câu lệnh SQL và đọc dữ liệu
                        SqlDataReader reader = command.ExecuteReader();

                        // Khởi tạo danh sách lưu trữ dữ liệu hình ảnh
                        List<byte[]> imageDataList = new List<byte[]>();

                        // Đọc dữ liệu từ SqlDataReader
                        string tenNguoiDung = null;
                        float soSao = 0;
                        string noiDung = null;

                        while (reader.Read()) // Duyệt qua tất cả các hàng dữ liệu trả về
                        {
                            // Đọc thông tin cơ bản từ đánh giá
                            if (tenNguoiDung == null) // Đọc chỉ một lần cho mỗi đánh giá
                            {
                                tenNguoiDung = reader["Ten"].ToString();
                                soSao = Convert.ToSingle(reader["SoSao"]);
                                noiDung = reader["NoiDung"].ToString();
                            }

                            // Đọc dữ liệu hình ảnh và thêm vào danh sách
                            byte[] imageData = reader["ImageData"] as byte[];
                            if (imageData != null && imageData.Length > 0)
                            {
                                imageDataList.Add(imageData);
                            }
                        }

                        // Kiểm tra xem có dữ liệu trả về không
                        if (tenNguoiDung != null)
                        {
                            // Tạo một thể hiện của FormXemDanhGia và truyền dữ liệu vào
                            FormXemDanhGia formXemDanhGia = new FormXemDanhGia(tenNguoiDung, soSao, noiDung, imageDataList);

                            // Hiển thị form
                            formXemDanhGia.ShowDialog();
                        }
                        else
                        {
                            MessageBox.Show("Không có đánh giá nào cho lịch hẹn này!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi lấy thông tin đánh giá từ cơ sở dữ liệu: " + ex.Message);
            }
        }

    }
}
