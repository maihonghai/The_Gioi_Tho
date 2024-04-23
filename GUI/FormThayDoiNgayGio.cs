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

namespace GUI
{
    public partial class FormThayDoiNgayGio : Form
    {
        private int idCongViec;
        public FormThayDoiNgayGio(int idCongViec)
        {
            InitializeComponent();
            this.idCongViec = idCongViec;
        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        SqlConnection connection = ConnectionDAL.GetSqlConnection();
        private void btnOK_Click(object sender, EventArgs e)
        {
            // Lấy ngày và giờ mới từ các điều khiển trong form
            DateTime ngayMoi = dtpLichThoDen.Value.Date;
            string gioMoi = cbGio.SelectedItem.ToString();

            // Thực hiện cập nhật trong Cơ sở dữ liệu
            try
            {
                using (connection)
                {
                    connection.Open();

                    // Chuẩn bị câu truy vấn UPDATE
                    string query = "UPDATE CongViec SET LichThoDen = @NgayMoi, Gio = @GioMoi WHERE IDCongViec = @CongViecID";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Truyền các tham số vào câu truy vấn
                        command.Parameters.AddWithValue("@NgayMoi", ngayMoi);
                        command.Parameters.AddWithValue("@GioMoi", gioMoi);
                        command.Parameters.AddWithValue("@CongViecID", idCongViec); // idCongViec là ID của công việc cần cập nhật

                        // Thực thi câu truy vấn UPDATE
                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Cập nhật ngày và giờ thành công!");
                            this.DialogResult = DialogResult.OK; // Đặt DialogResult thành OK để biết rằng cập nhật thành công
                        }
                        else
                        {
                            MessageBox.Show("Không thể cập nhật ngày và giờ!");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            // Thiết lập DialogResult thành OK khi nút OK được nhấn
            this.DialogResult = DialogResult.OK;
            // Đóng form
            this.Close();
        }

        private void FormThayDoiNgayGio_Load(object sender, EventArgs e)
        {

        }
    }
}
