using GUI.All_Tho_Control;
using GUI.All_User_Control;
using Guna.UI2.WinForms;
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
    public partial class FrmTHO : Form
    {
        public FrmTHO()
        {
            InitializeComponent();
        }

        private void HideAllUC()
        {
            uC_TaiKhoan1.Visible = false;
            uC_DangBai1.Visible = false;
            uC_LichHen1.Visible = false;
            uC_ThongKe1.Visible = false;
            uC_XemDanhGia1.Visible = false;
            uC_TrangChuTho1.Visible = false;
        }

        private void FrmTHO_Load(object sender, EventArgs e)
        {
            // uC_TrangChu1.Visible = false;
            HideAllUC();
            btnTrangChu.PerformClick();
        }

        private void btnLichHen_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_LichHen1.Visible = true;

        }

        private void btnDangBai_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_DangBai1.Visible = true;

        }

        private void btnThongKe_Click(object sender, EventArgs e)
        {
            /* HideAllUC();
             uC_ThongKe1.Update();
             uC_ThongKe1.Visible = true;*/
            // Khi nút "Thống Kê" được nhấn, kiểm tra xem sự kiện đã được kích hoạt chưa
            // Nếu có, gọi nó và truyền dữ liệu cần thiết
            // ThongKeButtonClicked?.Invoke(this, EventArgs.Empty);
            uC_ThongKe1.Invoke(new Action(() =>
            {
                // Thực hiện các thay đổi trên giao diện tại đây
                // Ví dụ:
                uC_ThongKe1.ThongKeButton_Click(sender, e);
            }));
            HideAllUC();
            uC_ThongKe1.Visible = true;

        }


        private void btnTaiKhoan_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_TaiKhoan1.Visible = true;
        }

        private void uC_LichHen1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void uC_ThongKe1_Load(object sender, EventArgs e)
        {

        }

        private void btnDanhGia_Click(object sender, EventArgs e)
        {
            HideAllUC();
           uC_XemDanhGia1.Visible = true;
        }
        private void btnTrangChu_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_TrangChuTho1.Visible = true;
        }
    }
}
