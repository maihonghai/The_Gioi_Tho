using BLL;
using DAL;
using GUI.All_TrangChu_Control;
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
    public partial class UC_TaiKhoan : UserControl
    {
        private ThongTinTho thongtin;
        public UC_TaiKhoan()
        {
            InitializeComponent();
            thongtin = new ThongTinTho(LoginBLL.IDTho);
            lblTenTho.Text = thongtin.HoTen;
        }

        private void UC_TaiKhoan_Load(object sender, EventArgs e)
        {
            HideAllUC();
            btnThongTin.PerformClick();
        }


        private void HideAllUC()
        {
            uC_ThongTinCaNhan1.Visible = false;
            uC_TaiKhoanNganHang1.Visible = false;
            uC_DoiMK1.Visible = false;
            uC_XoaTK1.Visible = false;
        }


        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_TaiKhoanNganHang1.Visible = true;
        }

        private void btnThongTin_Click_1(object sender, EventArgs e)
        {
            HideAllUC();
            uC_ThongTinCaNhan1.Visible = true;
        }

        private void btnDoiMatKhau_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_DoiMK1.Visible = true;
        }

        private void btnXoaTaiKhoan_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_XoaTK1.Visible = true;
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn có muốn đăng xuất không?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                Form parent = FindForm();
                parent?.Hide();
                FrmDangNhap frmDangNhap = new FrmDangNhap();
                frmDangNhap.ShowDialog();
                parent?.Close();
            }
        }

        private void uC_DoiMK1_Load(object sender, EventArgs e)
        {

        }

        private void btnSetUpNgayNghi_Click(object sender, EventArgs e)
        {
            Calendar calendar = new Calendar();
            calendar.Show();
        }
    }
}
