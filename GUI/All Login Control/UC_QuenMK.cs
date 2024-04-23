using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace GUI.All_Login_Control
{
    public partial class UC_QuenMK : UserControl
    {
        public event EventHandler BackClicked;
        public UC_QuenMK()
        {
            InitializeComponent();
            lblKetqua.Text = "";
        }

        ModifyDAL modify = new ModifyDAL();
        private TaiKhoanBLL taiKhoanBLL = new TaiKhoanBLL();

        private void btnQenMK_Click(object sender, EventArgs e)
        {
            lblKetqua.Visible = true;
            string email = txtEmail.Text.Trim();
            if (email == "")
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!");
            }
            else
            {
                // Gọi phương thức từ Business Logic Layer để kiểm tra và lấy mật khẩu
                string password = taiKhoanBLL.LayMatKhauBangEmail(email);
                if (password != null)
                {
                    lblKetqua.ForeColor = Color.Green;
                    lblKetqua.Text = "Mật khẩu: " + password;
                }
                else
                {
                    lblKetqua.ForeColor = Color.DarkRed;
                    lblKetqua.Text = "Email này chưa được đăng ký!";
                }
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UC_QuenMK_Load(object sender, EventArgs e)
        {

        }
    }
}
