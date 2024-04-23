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
    public partial class UC_HeThongNuoc : UserControl
    {
        public event EventHandler<string> ButtonDanhMucConClick;
        public event EventHandler ChuyenSangBaiDang;

        public UC_HeThongNuoc()
        {
            InitializeComponent();
        }

        private void UC_HeThongNuoc_Load(object sender, EventArgs e)
        {
      
        }

        public void btnBonNuoc_Click(object sender, EventArgs e)
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

        public void btnThietBi_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        public void btnMayBom_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        public void btnVoiNuoc_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);

        }

        public void btnDoNuocRoRi_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }
    }
}
