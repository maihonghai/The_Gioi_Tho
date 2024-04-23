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

namespace GUI.All_TrangChu_Control
{
    public partial class UC_ThongNghet : UserControl
    {
        public event EventHandler<string> ButtonDanhMucConClick;
        public event EventHandler ChuyenSangBaiDang;

        public UC_ThongNghet()
        {
            InitializeComponent();
        }

        private void UC_ThongNghet_Load(object sender, EventArgs e)
        {

        }

        public void btnCong_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        public void btnBonCau_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        public void btnDuongOngNuoc_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }
    }
}
