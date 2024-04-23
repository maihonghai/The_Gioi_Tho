using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace GUI.All_Tho_Control
{
    public partial class UC_DoiMK : UserControl
    {
        private ChinhSuaThoDAL doiMK;
        private TaiKhoanThoDAL ttkTho;
        public UC_DoiMK()
        {
            InitializeComponent();
        }

        private void UC_DoiMK_Load(object sender, EventArgs e)
        {

        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {
            doiMK = new ChinhSuaThoDAL();
            ttkTho = new TaiKhoanThoDAL();
            string matkhaucu = ttkTho.GetByMatKhau(LoginBLL.IDTho);
            if (txtMatKhauCu.Text == "" || txtMatKhauMoi.Text == "" || txtXacNhan.Text == "")
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin mật khâủ!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMatKhauMoi.Text != txtXacNhan.Text)
            {
                MessageBox.Show("Hãy xác nhận lại mật khẩu mới của bạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMatKhauCu.Text != matkhaucu)
            {
                MessageBox.Show("Mật khẩu cũ của bạn không chính xác. Vui lòng kiểm tra lại!!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                bool result = doiMK.DoiMK(LoginBLL.IDTho, txtMatKhauMoi.Text);
                if (result)
                {
                    MessageBox.Show("Cập nhật Mật Khẩu thợ thành công!");
                    // Cập nhật lại giao diện nếu cần
                }
                else
                {
                    MessageBox.Show("Cập nhật thất bại!");
                }

            }
        }
    }
}
