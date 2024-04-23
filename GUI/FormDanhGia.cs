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
using System.IO;
using DAL;
using GUI.All_User_Control;
using GUI.All_Tho_Control;

namespace GUI
{
    public partial class FormDanhGia : Form
    {
        // Khai báo một biến để lưu trạng thái đánh giá
        public static bool DaDanhGia { get; private set; }
       



        // Danh sách đường dẫn của các hình ảnh được chọn
        private List<string> imagePaths = new List<string>();

        private int _IDLichHen; // Thuộc tính để lưu IDLichHen  

        public FormDanhGia(int iDLichHen)
        {
            InitializeComponent();
            _IDLichHen = iDLichHen;
           
            // Ban đầu, trạng thái đánh giá được đặt là false
            DaDanhGia = false;
        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpg, *.jpeg, *.png)|*.jpg;*.jpeg;*.png";
            openFileDialog.Multiselect = false;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                string imagePath = openFileDialog.FileName;
                imagePaths.Add(imagePath);

                // Hiển thị hình ảnh trong FlowLayoutPanel
                AddImageToFlowLayoutPanel(imagePath);
            }
        }

        private void AddImageToFlowLayoutPanel(string imagePath)
        {
            if (panel1.Controls.Count < 3)
            {
                // Tạo một PictureBox mới để hiển thị hình ảnh
                PictureBox pictureBox = new PictureBox();
                pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                pictureBox.ImageLocation = imagePath;
                pictureBox.Width = 100; // Đặt kích thước của PictureBox
                pictureBox.Height = 100;

                // Thiết lập Dock cho PictureBox để chúng tự động xếp chồng lên nhau từ trái sang phải
                pictureBox.Dock = DockStyle.Left;

                // Thêm sự kiện xóa hình ảnh khi người dùng nhấn đúp chuột
                pictureBox.DoubleClick += PictureBox_DoubleClick;

                // Thêm PictureBox vào FlowLayoutPanel
                panel1.Controls.Add(pictureBox);
            }
            else
            {
                MessageBox.Show("Chỉ được phép tối đa 3 hình ảnh.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void PictureBox_DoubleClick(object sender, EventArgs e)
        {
            // Xóa hình ảnh khi người dùng nhấn đúp chuột vào hình ảnh
            PictureBox pictureBox = sender as PictureBox;
            if (pictureBox != null)
            {
                panel1.Controls.Remove(pictureBox);
                pictureBox.Dispose();
            }
        }

        private void FormDanhGia_Load(object sender, EventArgs e)
        {

        }

        private void btnLuuDanhGia_Click(object sender, EventArgs e)
        {
            // Lấy giá trị đánh giá từ RatingStar và chuyển đổi thành kiểu int
            float ratingValue = (float)ratingStar1.Value;

            // Lấy nội dung đánh giá từ TextBox
            string noiDungDanhGia = txtNoiDungDanhGia.Text;

            // Lưu đánh giá và hình ảnh mô tả xuống cơ sở dữ liệu
            SaveDataToDatabase(ratingValue, noiDungDanhGia, imagePaths);

            // Thông báo lưu thành công
            MessageBox.Show("Lưu đánh giá thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Đóng Form Đánh giá sau khi lưu
            this.Close();
            DaDanhGia = true;

        }

        private void SaveDataToDatabase(float ratingValue, string noiDungDanhGia, List<string> imagePaths)
        {

            using (SqlConnection connection = DAL.ConnectionDAL.GetSqlConnection())
            {
                connection.Open();

                // Insert vào bảng DanhGia
                string insertDanhGiaQuery = "INSERT INTO DanhGia (IDCongViec, SoSao, NoiDung) VALUES (@IDCongViec, @SoSao, @NoiDung); SELECT SCOPE_IDENTITY();";
                int danhGiaID;
                using (SqlCommand command = new SqlCommand(insertDanhGiaQuery, connection))
                {
                    command.Parameters.AddWithValue("@IDCongViec", _IDLichHen); // Example value for IDCongViec
                    command.Parameters.AddWithValue("@SoSao", ratingValue);
                    command.Parameters.AddWithValue("@NoiDung", noiDungDanhGia);
                    danhGiaID = Convert.ToInt32(command.ExecuteScalar());
                }

                // Insert vào bảng DanhGiaHinhAnh
                foreach (string imagePath in imagePaths)
                {
                    byte[] imageBytes = File.ReadAllBytes(imagePath);
                    string insertImageQuery = "INSERT INTO DanhGiaHinhAnh (IDDanhGia, ImageData) VALUES (@IDDanhGia, @ImageData)";
                    using (SqlCommand command = new SqlCommand(insertImageQuery, connection))
                    {
                        command.Parameters.AddWithValue("@IDDanhGia", danhGiaID);
                        command.Parameters.AddWithValue("@ImageData", imageBytes);
                        command.ExecuteNonQuery();
                    }
                }
            }
        }
    }
}
