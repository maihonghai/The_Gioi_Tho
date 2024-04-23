using GUI.All_Tho_Control;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_Login_Control
{
    public partial class UC_Vi : UserControl
    {
        public UC_Vi()
        {
            InitializeComponent();
        }
        private void UC_Vi_Load(object sender, EventArgs e)
        {
            uC_NapTien1.BackClicked += UC_vi_BackClicked;
            uC_NapTien1.Visible = false;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            uC_NapTien1.Visible = true;
        }

        private void UC_vi_BackClicked(object sender, EventArgs e)
        {
            uC_NapTien1.Visible = false;
            // uC_DangNhap1.BringToFront();
        }


    }
}
