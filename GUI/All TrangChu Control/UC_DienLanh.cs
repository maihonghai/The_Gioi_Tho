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
    public partial class UC_DienLanh : UserControl
    {
        public event EventHandler<string> ButtonDanhMucConClick;
        public event EventHandler ChuyenSangBaiDang;


        public UC_DienLanh()
        {
            InitializeComponent();
        }



        private void UC_DienLanh_Load(object sender, EventArgs e)
        {

        }

        public void btnDieuHoa_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;

            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);

            // Kích hoạt sự kiện để chuyển sang UC_TrangChu và chuyển sang UC_BaiDang
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        public void btnBinhNongLanh_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender; ;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);
        }

        public void btnMayTamNuocNong_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        public void btnTuLanh_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        public void btnMayGiat_Click(object sender, EventArgs e)
        {
            Guna2Button button = (Guna2Button)sender;
            string tenDanhMucCon = button.Text;
            ButtonDanhMucConClick?.Invoke(this, tenDanhMucCon);
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }
    }
}
