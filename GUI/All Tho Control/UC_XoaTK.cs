using DAL;
using BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_Tho_Control
{
    public partial class UC_XoaTK : UserControl
    {
        private TaiKhoanThoDAL tk;
        public UC_XoaTK()
        {
            InitializeComponent();
        }

        private void btnXoaTK_Click(object sender, EventArgs e)
        {
            tk = new TaiKhoanThoDAL();
            string matkhaucu = tk.GetByMatKhau(LoginBLL.IDTho);
            if (txtMatKhau.Text == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu của bạn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (txtMatKhau.Text != matkhaucu)
            {
                MessageBox.Show("Mật khẩu không chính xác!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Bạn có chắc chắn muốn xóa tài khoản không?", "Nhắc Nhở", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    ChinhSuaThoDAL xoatk = new ChinhSuaThoDAL();
                    xoatk.XoaTaiKhoan(LoginBLL.IDTho);
                    if (MessageBox.Show("Xóa tài khoản thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information) == DialogResult.OK)
                    {
                        Form parent = FindForm();
                        parent?.Hide();
                        FrmDangNhap frmDangNhap = new FrmDangNhap();
                        frmDangNhap.ShowDialog();
                        parent?.Close();
                    }
                }
            }

        }


    }
}
