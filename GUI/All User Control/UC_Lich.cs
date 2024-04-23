using BLL;
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

namespace GUI.All_User_Control
{
    public partial class UC_Lich : UserControl
    {
        private LichHen _lichHen; // Đối tượng LichHen được truyền vào UserControl

        // Khai báo các phương thức hoặc thuộc tính để truy cập từ bên ngoài
        public Guna2Button GetBtnHuyLichHen() { return btnHuyLichHen; }
        public Guna2Button GetBtnYeuCauDoiLich() { return btnYeuCauDoiLich; }

        public Guna2Button GetBtnChapNhan() { return btnChapNhan; }

        public Guna2Button GetBtnDanhGia() { return btnDanhGia; }
        public Guna2Button GetBtnYeuThich() { return btnYeuThich; }
        public Guna2Button GetBtnDaYeuThich() { return btnDaYeuThich; }

        public UC_Lich()
        {
            InitializeComponent();
        }

        // Constructor với tham số để truyền dữ liệu từ UC_HoatDong
        public UC_Lich(LichHen lichHen)
        {
            InitializeComponent();

            

            _lichHen = lichHen; // Lưu đối tượng LichHen được truyền vào

            UpdateData();
        }
        // Phương thức cập nhật dữ liệu hiển thị trên giao diện từ đối tượng LichHen
        private void UpdateData()
        {
            txtLinhVuc.Text = _lichHen.LinhVuc;
            txtTenTho.Text = _lichHen.Ten;
            txtSDTTho.Text = _lichHen.SDT;
            txtLichThoDen.Text = _lichHen.LichHenDen.ToString("dd/MM/yyyy");
            txtGio.Text = _lichHen.Gio;
            txtMoTaChiTiet.Text = _lichHen.MoTaChiTiet;
            txtGhiChu.Text = _lichHen.GhiChu;
            txtGiaTien.Text = _lichHen.GiaTien.ToString();

        }
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

        private void btnHuyLichHen_Click(object sender, EventArgs e)
        {

            UpdateDatabase(_lichHen.IDLichHen, "Đã hủy", "Đã hủy");
            // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
            this.Dispose();
            MessageBox.Show("Đã hủy lịch hẹn!");
        }

        private void btnYeuCauDoiLich_Click(object sender, EventArgs e)
        {
            // Tạo một thể hiện của form thay đổi ngày và giờ
            FormThayDoiNgayGio formThayDoiNgayGio = new FormThayDoiNgayGio(_lichHen.IDLichHen);

            // Hiển thị form
            formThayDoiNgayGio.ShowDialog();

            // Kiểm tra xem form có đóng hay không
            if (formThayDoiNgayGio.DialogResult == DialogResult.OK)
            {

                UpdateDatabase(_lichHen.IDLichHen, "Đang chờ thợ xác nhận", "Chưa xử lý");


                this.Dispose();
                // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
                MessageBox.Show("Đã yêu cầu dời lịch hẹn!");
            }

            
        }

        private void btnChapNhan_Click(object sender, EventArgs e)
        {
            UpdateDatabase(_lichHen.IDLichHen, "Đã xác nhận", "Đã chấp nhận");
            this.Dispose();
            // Hiển thị thông báo hoặc thực hiện các hành động khác tùy thuộc vào logic của ứng dụng
            MessageBox.Show("Đã chấp nhận công việc!");
        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            Form formDanhGia = new FormDanhGia(_lichHen.IDLichHen);
            formDanhGia.ShowDialog();
        }

        private void txtGhiChu_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnYeuThich_Click(object sender, EventArgs e)
        {
            // Gọi phương thức để thêm dữ liệu vào bảng ThoYeuThich
            AddToFavorites(LoginBLL.IDNguoiDung, _lichHen.IDTho);
        }
        private void AddToFavorites(int idNguoiDung, int idTho)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    // Câu lệnh SQL để thêm dữ liệu vào bảng ThoYeuThich
                    string query = "INSERT INTO ThoYeuThich (IDNguoiDung, IDTho) VALUES (@IDNguoiDung, @IDTho)";

                    // Tạo và cấu hình SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@IDNguoiDung", idNguoiDung);
                        command.Parameters.AddWithValue("@IDTho", idTho);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bao nhiêu dòng dữ liệu đã được ảnh hưởng
                        if (rowsAffected > 0)
                        {
                            // Thay đổi màu sắc và văn bản của nút btnYeuThich
                            btnYeuThich.Visible = false;
                            btnDaYeuThich.Visible = true;
                            MessageBox.Show("Đã thêm vào danh sách yêu thích!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể thêm vào danh sách yêu thích!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi thêm vào danh sách yêu thích: " + ex.Message);
            }
        }
        private void RemoveFromFavorites(int idNguoiDung, int idTho)
        {
            try
            {
                // Mở kết nối đến cơ sở dữ liệu
                using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
                {
                    connection.Open();

                    // Câu lệnh SQL để xóa dữ liệu từ bảng ThoYeuThich
                    string query = "DELETE FROM ThoYeuThich WHERE IDNguoiDung = @IDNguoiDung AND IDTho = @IDTho";

                    // Tạo và cấu hình SqlCommand
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Thêm các tham số vào câu lệnh SQL
                        command.Parameters.AddWithValue("@IDNguoiDung", idNguoiDung);
                        command.Parameters.AddWithValue("@IDTho", idTho);

                        // Thực thi câu lệnh SQL
                        int rowsAffected = command.ExecuteNonQuery();

                        // Kiểm tra xem có bao nhiêu dòng dữ liệu đã được ảnh hưởng
                        if (rowsAffected > 0)
                        {
                            // Thay đổi màu sắc và văn bản của nút btnDaYeuThich
                            btnDaYeuThich.Visible = false;
                            btnYeuThich.Visible = true;
                            MessageBox.Show("Đã xóa khỏi danh sách yêu thích!");
                        }
                        else
                        {
                            MessageBox.Show("Không thể xóa khỏi danh sách yêu thích!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi xóa khỏi danh sách yêu thích: " + ex.Message);
            }
        }

        private void btnDaYeuThich_Click(object sender, EventArgs e)
        {
            RemoveFromFavorites(LoginBLL.IDNguoiDung, _lichHen.IDTho);
        }
    }
}
