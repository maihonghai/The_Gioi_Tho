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
using DAL;
using Guna.UI2.WinForms;

namespace GUI.All_Tho_Control
{
    public partial class UC_DangBai : UserControl
    {
        private ThongTinTho thongtin;
        private ModifyDAL modify = new ModifyDAL();

        private BaiDangBLL baiDangBLL = new BaiDangBLL();

        public UC_DangBai()
        {
            InitializeComponent();
            thongtin = new ThongTinTho(LoginBLL.IDTho);
            txtHoVaTen.Text = thongtin.HoTen;
            txtDiaChi.Text = thongtin.DiaChi;
            txtSoDienThoai.Text = thongtin.SoDienThoai;
            txtSoNamKinhNghiem.Text = thongtin.SoNamKinhNghiem.ToString();

        }
        private void lbllichsu_MouseEnter(object sender, EventArgs e)
        {
            lbllichsu.ForeColor = Color.Red; // Thay đổi màu chữ thành màu đỏ khi con chuột đi vào
        }

        private void lbllichsu_MouseLeave(object sender, EventArgs e)
        {
            lbllichsu.ForeColor = Color.FromArgb(128, 128, 255);
            // Khôi phục màu chữ ban đầu khi con chuột rời khỏi
        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bại có chắc chắn đăng bài không?", "Thông Báo", MessageBoxButtons.YesNo);
            
        }



        private void UC_DangBai_Load(object sender, EventArgs e)
        {
           
        }

        private void btnLinhVuc_Click_1(object sender, EventArgs e)
        {
           
        }

        private bool KiemTraDaDangBai(int idTho, string linhVuc)
        {
            bool daDang = false;

            // Kết nối đến cơ sở dữ liệu
            using (SqlConnection connection = ConnectionDAL.GetSqlConnection())
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn SELECT để đếm số bài đăng cho thợ trong lĩnh vực đã chọn
                string query = "SELECT COUNT(*) FROM BaiDang WHERE IDTho = @IDTho AND LinhVuc = @LinhVuc";

                // Tạo đối tượng SqlCommand và truyền vào câu truy vấn và kết nối
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    // Thêm tham số vào câu truy vấn
                    command.Parameters.AddWithValue("@IDTho", idTho);
                    command.Parameters.AddWithValue("@LinhVuc", linhVuc);

                    // Thực thi truy vấn và lấy kết quả
                    int count = (int)command.ExecuteScalar();

                    // Kiểm tra số lượng bài đăng
                    if (count > 0)
                    {
                        daDang = true; // Thợ đã đăng bài cho lĩnh vực này
                    }
                }
            }

            return daDang;
        }


        private void btnDangBai_Click_1(object sender, EventArgs e)
        {
            // Kiểm tra và xử lý giá tiền
            decimal giaTien;
            // Kiểm tra và xử lý các trường bắt buộc
            if (string.IsNullOrEmpty(txtMoTa.Text) || cbLinhVuc.SelectedItem == null || string.IsNullOrEmpty(cbThoiGianThucHien.Text) || string.IsNullOrEmpty(txtGiaTien.Text))
            {
                //MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                lblThongBao.ForeColor = Color.Red;
                lblThongBao.Text = "*Vui lòng điền đầy đủ thông tin!";
                return; // hoặc thực hiện các xử lý phù hợp
            }
            if (!decimal.TryParse(txtGiaTien.Text, out giaTien))
            {
                txtGiaTien.Text = "";
                txtGiaTien.PlaceholderText = "*Giá tiền không hợp lệ!";
                return; // hoặc thực hiện các xử lý phù hợp
            }
                // Lấy dữ liệu từ giao diện
            string hoVaTen = txtHoVaTen.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSoDienThoai.Text;
            int soNamKinhNghiem = int.Parse(txtSoNamKinhNghiem.Text);
            string moTa = txtMoTa.Text;
            string linhVuc = cbLinhVuc.SelectedItem.ToString();
            int thoiGianThucHien = int.Parse(cbThoiGianThucHien.Text);
            giaTien = decimal.Parse(txtGiaTien.Text);
            int idTho = LoginBLL.IDTho;

            if (KiemTraDaDangBai(idTho, linhVuc))
            {
                MessageBox.Show("Bạn đã đăng bài cho công việc này rồi!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            // Gọi phương thức xử lý từ Business Logic Layer
            bool result = baiDangBLL.DangBai(hoVaTen, diaChi, soDienThoai, soNamKinhNghiem, moTa, linhVuc, thoiGianThucHien, giaTien, idTho);

            // Hiển thị kết quả
            if (result)
            {
                MessageBox.Show("Đăng bài thành công!", "Thông Báo", MessageBoxButtons.OK);

                //Reset các trường thông tin sau khi đăng bài thành công
                lblThongBao.ForeColor = Color.Black;
                lblThongBao.Text = "*Vui lòng nhập thông tin cần thiết";
                txtGiaTien.PlaceholderText = "";
                txtMoTa.Text = "";
                cbLinhVuc.SelectedIndex = -1; // Chọn lại index mặc định (-1) cho ComboBox
                cbThoiGianThucHien.SelectedIndex = -1;
                txtGiaTien.Text = "";
            }
            else
            {
                MessageBox.Show("Đăng bài thất bại!", "Thông Báo", MessageBoxButtons.OK);
            }
        }

        private void uC_TrangChu1_Load(object sender, EventArgs e)
        {

        }

            private void lbllichsu_Click(object sender, EventArgs e)
            {
                UC_DanhSachBaiDang uC_DanhSachBaiDang1 = new UC_DanhSachBaiDang(LoginBLL.IDTho);
                this.Controls.Add(uC_DanhSachBaiDang1);
                uC_DanhSachBaiDang1.Dock = DockStyle.Fill;
                uC_DanhSachBaiDang1.BringToFront();
            //uC_DanhSachBaiDang1.Visible = true;
        }

       
        private void uC_DanhSachBaiDang1_Load(object sender, EventArgs e)
        {

        }
    }
}
