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

namespace GUI.All_User_Control
{
    public partial class UC_DanhMuc : UserControl
    {
        UC_DienLanh uC_DienLanh1 = new UC_DienLanh();
        UC_DienTuGiaDung uC_DienTuGiaDung = new UC_DienTuGiaDung();

        public UC_DanhMuc()
        {
            InitializeComponent();
        }

        private void btnDienLanh_Click(object sender, EventArgs e)
        {
            uC_DienLanh1.Visible = true;
            uC_DienLanh1.BringToFront();
        }

        private void btnDienTuGiaDung_Click(object sender, EventArgs e)
        {
            uC_DienTuGiaDung.Visible = true;
            uC_DienTuGiaDung.BringToFront();
        }

        private void UC_DanhMuc_Load(object sender, EventArgs e)
        {

        }
    }
}
