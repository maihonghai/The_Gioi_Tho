using GUI.All_Tho_Control;
using GUI.All_TrangChu_Control;
using GUI.All_User_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Dashboard : Form
    {

        public Dashboard()
        {
            InitializeComponent();
            uC_TrangChu1.ChuyenSangBaiDang += UC_TrangChu_ChuyenSangBaiDang;

        }
        public event EventHandler BaiDangButtonClicked;

        private void btnBaiDang2_Click(object sender, EventArgs e)
        {
            BaiDangButtonClicked?.Invoke(this, EventArgs.Empty);
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            
            uC_TrangChu1.Visible = false;
            uC_BaiDang1.Visible = false;
            uC_HoatDong1.Visible = false;
            uC_DSThoYeuThich1.Visible = false;
            btnTrangChu.PerformClick();


        }

        private void btnBaiDang_Click(object sender, EventArgs e)
        {
            uC_BaiDang1.Visible = true;
            uC_BaiDang1.BringToFront();
        }

        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            //uC_TrangChu1.Visible = true;
            //uC_TrangChu1.BringToFront();
            uC_TrangChuUser1.Visible = true;
            uC_TrangChuUser1.BringToFront();
        }

        private void btnHoatDong_Click(object sender, EventArgs e)
        {
           /* uC_HoatDong1.Visible = true;
            uC_HoatDong1.Visible = false;*/
            uC_HoatDong1.Visible = true;
            uC_HoatDong1.BringToFront();
        }

        private void UC_TrangChu_ChuyenSangBaiDang(object sender, EventArgs e)
        {
            // Chuyển từ UC_TrangChu sang UC_BaiDang khi button Điều Hòa được nhấn
            btnBaiDang.Checked = true;
            
            uC_BaiDang1.Visible = true;
            uC_HoatDong1.Visible = false;
            uC_HoatDong1.Visible = true;
            uC_BaiDang1.BringToFront();
        }

        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void uC_TrangChuUser1_Load(object sender, EventArgs e)
        {

        }

        private void btnTho_Click(object sender, EventArgs e)
        {
            uC_DSThoYeuThich1.Invoke(new Action(() =>
            {
                // Thực hiện các thay đổi trên giao diện tại đây
                // Ví dụ:
                uC_DSThoYeuThich1.ThoYeuThichButton_Click(sender, e);
            }));
            uC_DSThoYeuThich1.Visible = true;
            uC_DSThoYeuThich1.BringToFront();
        }
    }
}
