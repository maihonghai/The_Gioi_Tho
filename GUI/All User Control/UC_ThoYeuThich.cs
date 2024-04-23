using DAL;
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
using static DAL.ThongTinTho;

namespace GUI.All_User_Control
{
    public partial class UC_ThoYeuThich : UserControl
    {
        public int IDTho; // Chuyển IDTho thành biến instance để sử dụng trong phương thức btnHuyYeuThich_Click
        public event EventHandler<int> XemBaiDangClicked;
        public UC_ThoYeuThich(ThongTinTho tho)
        {
            InitializeComponent();
            txtHoVaTen.Text = tho.HoTen;
            txtSoDienThoai.Text = tho.SoDienThoai;
            txtDiaChi.Text = tho.DiaChi;
            txtSoNamKinhNghiem.Text = tho.SoNamKinhNghiem.ToString();
            IDTho = tho.IDTho;
            if(tho.GioiTinh == "Nữ")
            {
                ptbNu.Visible = true;
            }
            lblIDTho.Text = IDTho.ToString();
        }
        public Guna2Button GetBtnHuyYeuThich()
        {
            return btnHuyYeuThich;
        }
        private void btnXemBaiDang_Click(object sender, EventArgs e)
        {
            // Khi người dùng nhấn nút XemBaiDang, gửi sự kiện với IDTho tới form cha
            XemBaiDangClicked?.Invoke(this, IDTho);
        }
       
        private void btnHuyYeuThich_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn hủy yêu thích thợ này?", "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                try
                {
                    ThoYeuThichRepository repository = new ThoYeuThichRepository();
                    repository.XoaThoYeuThich(BLL.LoginBLL.IDNguoiDung, IDTho); // Sử dụng IDTho từ biến instance
                    MessageBox.Show("Đã xóa thông tin thợ yêu thích thành công!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xóa thông tin thợ yêu thích: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
