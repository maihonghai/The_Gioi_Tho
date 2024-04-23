using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class FormXemDanhGia : Form
    {
        private int danhGiaIndex = 0;
        private List<byte[]> danhSachHinhAnh;
        public FormXemDanhGia(string tenNguoiDung, float soSao, string noiDung, List<byte[]> hinhAnhData)
        {
            InitializeComponent();
            // Thiết lập thông tin đánh giá
            lblTenNguoiDung.Text = tenNguoiDung;
            ratingStar1.Value = soSao; // Thiết lập số sao
            lblSao.Text = soSao.ToString();
            txtDangGia.Text = noiDung;
            // Hiển thị hình ảnh mô tả
            /* foreach (byte[] imageData in hinhAnhData)
             {
                 AddImageToFlowLayoutPanel(imageData);
             }*/
            // Hiển thị hình ảnh mô tả
            danhSachHinhAnh = hinhAnhData;
            HienThiHinhAnh();
        }
        // Hiển thị hình ảnh tại vị trí danhGiaIndex
        private void HienThiHinhAnh()
        {
            if (danhSachHinhAnh.Count == 0)
            {
                // Không có hình ảnh
                MessageBox.Show("Không có ảnh đánh giá!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            byte[] imageData = danhSachHinhAnh[danhGiaIndex];

            try
            {
                MemoryStream ms = new MemoryStream(imageData);
                Image image = Image.FromStream(ms);
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;

                // Tính toán tỷ lệ chiều rộng hình ảnh so với chiều rộng của Panel
                double widthRatio = (double)image.Width / panel1.Width;

                // Đặt chiều rộng của hình ảnh bằng với chiều rộng của Panel
                int newImageWidth = panel1.Width;

                // Tính toán chiều cao của hình ảnh dựa trên tỷ lệ chiều rộng
                int newImageHeight = (int)(image.Height / widthRatio);

                // Đặt kích thước mới cho hình ảnh
                pictureBox.Width = newImageWidth;
                pictureBox.Height = newImageHeight;

                pictureBox.Image = image;
                panel1.Controls.Clear(); // Xóa tất cả các hình ảnh trước đó
                panel1.Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị hình ảnh: " + ex.Message);
            }
        }
        // Hiển thị hình ảnh tiếp theo
        private void HienThiHinhAnhTiepTheo()
        {
            danhGiaIndex++;
            if (danhGiaIndex >= danhSachHinhAnh.Count)
            {
                danhGiaIndex = 0; // Quay lại hình ảnh đầu tiên nếu đang ở hình cuối cùng
            }
            HienThiHinhAnh();
        }
        // Hiển thị hình ảnh trước đó
        private void HienThiHinhAnhTruocDo()
        {
            danhGiaIndex--;
            if (danhGiaIndex < 0)
            {
                danhGiaIndex = danhSachHinhAnh.Count - 1; // Đến hình cuối cùng nếu đang ở hình đầu tiên
            }
            HienThiHinhAnh();
        }
        // Phương thức để hiển thị hình ảnh mô tả
        /*private void AddImageToFlowLayoutPanel(byte[] imageData)
        {
            try
            {
                MemoryStream ms = new MemoryStream(imageData);
                Image image = Image.FromStream(ms);
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom ;

                // Tính toán tỷ lệ chiều rộng hình ảnh so với chiều rộng của Panel
                double widthRatio = (double)image.Width / panel1.Width;

                // Đặt chiều rộng của hình ảnh bằng với chiều rộng của Panel
                int newImageWidth = panel1.Width;

                // Tính toán chiều cao của hình ảnh dựa trên tỷ lệ chiều rộng
                int newImageHeight = 150 ;

                // Đặt kích thước mới cho hình ảnh
                pictureBox.Width = newImageWidth;
                pictureBox.Height = newImageHeight;

                pictureBox.Image = image;
                panel1.Controls.Add(pictureBox);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi hiển thị hình ảnh: " + ex.Message);
            }


        }*/

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void FormXemDanhGia_Load(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ptbTrai_Click(object sender, EventArgs e)
        {
            HienThiHinhAnhTiepTheo();
        }

        private void ptbPhai_Click(object sender, EventArgs e)
        {
            HienThiHinhAnhTruocDo();
        }
    }
}
