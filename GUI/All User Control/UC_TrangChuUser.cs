using DAL;
using BLL;
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

namespace GUI.All_User_Control
{
    public partial class uC_TrangChuUser : UserControl
    {
        private ThongTinND thongtinND;
        public uC_TrangChuUser()
        {
            InitializeComponent();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();

            // Thiết lập các thuộc tính cho dialog
            openFileDialog.Title = "Chọn ảnh";
            openFileDialog.Filter = "File ảnh (*.jpg, *.jpeg, *.png) | *.jpg; *.jpeg; *.png";
            openFileDialog.Multiselect = false; // Chỉ cho phép chọn một tệp

            // Hiển thị dialog và kiểm tra nếu người dùng đã chọn tệp
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Lấy đường dẫn của tệp đã chọn
                string filePath = openFileDialog.FileName;

                // Kiểm tra kích thước của ảnh
                FileInfo fileInfo = new FileInfo(filePath);
                long fileSize = fileInfo.Length; // Kích thước ảnh trong byte
                long maxSizeInBytes = 1 * 1024 * 1024; // Giả sử kích thước tối đa là 10MB (có thể thay đổi theo yêu cầu)

                if (fileSize > maxSizeInBytes)
                {
                    MessageBox.Show("Kích thước ảnh vượt quá kích thước tối đa cho phép (1MB). Vui lòng chọn ảnh khác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; // Dừng lại và không thực hiện các thao tác tiếp theo
                }

                // Hiển thị đường dẫn hoặc thực hiện các thao tác khác với tệp ảnh tại đây
                // Ví dụ: hiển thị ảnh trên một control PictureBox
                pbAnh.Image = Image.FromFile(filePath);
            }
        }

        private void txtTieuDe_TextChanged(object sender, EventArgs e)
        {
            Guna.UI2.WinForms.Guna2TextBox textBox = (Guna.UI2.WinForms.Guna2TextBox)sender;
            textBox.Text = textBox.Text.ToUpper();
            textBox.SelectionStart = textBox.Text.Length; // Di chuyển con trỏ đến cuối văn bản
        }
     
        private void btnDangBai_Click(object sender, EventArgs e)
        {
            thongtinND = new ThongTinND(LoginBLL.IDNguoiDung);
            // Lấy dữ liệu từ các TextBox và convert hình ảnh sang byte[]
            //string hoTen = txtTen.Text;
            //string soDienThoai = txtSoDienThoai.Text;
            //string diaChi = txtDiaChi.Text;
            string congViec = cbLinhVuc.Text;
            DateTime lichThoDen = dtpLichThoDen.Value;
            string gio = cbGio.Text;
            string moTa = txtMoTaChiTiet.Text;
            byte[] hinhAnhMoTa;// Đọc hình ảnh và convert thành byte[]
            int idNguoiDung = LoginBLL.IDNguoiDung; // Giả sử ID người dùng là một số nguyên
            string tieuDe = txtTieuDe.Text;

            // Chuyển đổi hình ảnh từ PictureBox sang mảng byte
            using (MemoryStream ms = new MemoryStream())
            {
                pbAnh.Image.Save(ms, pbAnh.Image.RawFormat);
                hinhAnhMoTa = ms.ToArray();
            }

            // Tạo kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

                // Chuẩn bị câu lệnh SQL để chèn dữ liệu vào bảng BaiDangND
                string sql = "INSERT INTO BaiDangND (HoTen, SoDienThoai, DiaChi, CongViec, LichThoDen, Gio, MoTa, HinhAnhMoTa, IDNguoiDung,TieuDe) VALUES (@HoTen, @SoDienThoai, @DiaChi, @CongViec, @LichThoDen, @Gio, @MoTa, @HinhAnhMoTa, @IDNguoiDung,@TieuDe)";

                // Tạo đối tượng SqlCommand
                using (SqlCommand command = new SqlCommand(sql, connection))
                {
                    // Thêm các tham số vào câu lệnh SQL
                    command.Parameters.AddWithValue("@HoTen", thongtinND.HoTen);
                    command.Parameters.AddWithValue("@SoDienThoai", thongtinND.SoDienThoai);
                    command.Parameters.AddWithValue("@DiaChi", thongtinND.DiaChi);
                    command.Parameters.AddWithValue("@CongViec", congViec);
                    command.Parameters.AddWithValue("@LichThoDen", lichThoDen);
                    command.Parameters.AddWithValue("@Gio", gio);
                    command.Parameters.AddWithValue("@MoTa", moTa);
                    command.Parameters.AddWithValue("@HinhAnhMoTa", hinhAnhMoTa);
                    command.Parameters.AddWithValue("@IDNguoiDung", idNguoiDung);
                    command.Parameters.AddWithValue("@TieuDe", tieuDe);

                    // Thực thi câu lệnh SQL
                    int rowsAffected = command.ExecuteNonQuery();

                    // Kiểm tra xem dữ liệu đã được thêm thành công hay không
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Bài đăng mới đã được thêm thành công!");
                        // Gọi phương thức để xóa các dữ liệu đã nhập
                        ClearInputData();
                    }
                    else
                    {
                        MessageBox.Show("Không thể thêm bài đăng mới!");
                    }
                }
            }

        }
        private void ClearInputData()
        {
            // Xóa hoặc đặt lại nội dung của các trường nhập liệu
            cbLinhVuc.SelectedIndex = -1; // Đặt lại lựa chọn cho ComboBox
            dtpLichThoDen.Value = DateTime.Now; // Đặt lại giá trị cho DateTimePicker
            cbGio.SelectedIndex = -1; // Đặt lại lựa chọn cho ComboBox
            txtMoTaChiTiet.Text = ""; // Xóa nội dung của TextBox
            pbAnh.Image = null; // Xóa hình ảnh trong PictureBox
            txtTieuDe.Text = ""; // Xóa nội dung của TextBox
        }
    }
}
