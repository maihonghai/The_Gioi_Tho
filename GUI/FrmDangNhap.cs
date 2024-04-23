using GUI.All_Login_Control;
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
    public partial class FrmDangNhap : Form
    {
        public FrmDangNhap()
        {
            InitializeComponent();
        }

        

        private void FrmDangNhap_Load(object sender, EventArgs e)
        {
            // Subscribe to the event
            uC_DangNhap1.QuenMKClicked += UC_DangNhap1_QuenMKClicked;
            uC_DangNhap1.DangKyClicked += UC_DangNhap1_DangKyCliked;
            uC_QuenMK1.BackClicked += UC_DangNhap1_BackClicked;
            uC_DangKy1.BackClicked += UC_DangNhap1_BackClicked;
            uC_DangNhap1.Visible = true;
            uC_QuenMK1.Visible = false;
            uC_DangKy1.Visible = false;
        }
        private void UC_DangNhap1_QuenMKClicked(object sender, EventArgs e)
        {
            // Handle the event and show the other user control
            uC_QuenMK1.Visible = true;
            uC_QuenMK1.BringToFront();
        }

        private void UC_DangNhap1_DangKyCliked(object sender, EventArgs e)
        {
            uC_DangKy1.Visible = true;
            uC_DangKy1.BringToFront();
        }
        private void UC_DangNhap1_BackClicked(object sender, EventArgs e)
        {
            uC_DangNhap1.Visible = true;
            uC_DangNhap1.BringToFront();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void uC_DangKy1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
