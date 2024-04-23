using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;



namespace GUI.All_Login_Control
{
    public partial class UC_DangNhap : UserControl
    {
        public event EventHandler QuenMKClicked;
        public event EventHandler DangKyClicked;

        public UC_DangNhap()
        {
            InitializeComponent();
        }

        // Hiển thị mật khẩu khi đăng nhập 
        private void cbOpenMK_CheckedChanged_1(object sender, EventArgs e)
        {
            if (txtMK.PasswordChar == '*')
            {
                txtMK.PasswordChar = '\0';
            }
            else
            {
                txtMK.PasswordChar = '*';
            }
        }

        private void UC_DangNhap_Load(object sender, EventArgs e)
        {
            // Load user settings
            txttenTK.Text = GUI.Properties.Settings.Default.TenTK;
            txtMK.Text = GUI.Properties.Settings.Default.MatKhau;
            if (GUI.Properties.Settings.Default.TenTK != "")
            {
                cbLuumk.Checked = true;
            }
        }

        private void btnDangnhap_Click(object sender, EventArgs e)
        {
            string tentk = txttenTK.Text;
            string mk = txtMK.Text;
            if (tentk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            else if (mk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên mật khẩu!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            else if (rbtnTho.Checked == false && rbtNguoidung.Checked == false) { MessageBox.Show("Vui lòng chọn Vai trò của bạn!", "LỖI", MessageBoxButtons.OK, MessageBoxIcon.Stop); return; }
            else
            {
                // Xử lý đăng nhập ở tầng BLL
                int result = BLL.LoginBLL.ValidateLogin(tentk, mk, rbtNguoidung.Checked);
                if (result != -1)
                {
                    // Hiển thị thông báo và đóng form
                    MessageBox.Show("Đăng Nhập Thành Công!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form parentForm = this.FindForm();
                    parentForm?.Hide(); 
                    if (rbtNguoidung.Checked)
                    {
                        Dashboard User = new Dashboard();
                        User.ShowDialog();
                    }
                    else if (rbtnTho.Checked)
                    {
                        FrmTHO User = new FrmTHO();
                        User.ShowDialog();
                    }
                    parentForm?.Close();
                }
                else
                {
                    MessageBox.Show("Tên tài khoản hoặc mật khẩu không chính xác!", "Thông báo ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            DangKyClicked?.Invoke(this, EventArgs.Empty);
        }

        private void lblQuenMK_Click(object sender, EventArgs e)
        {
            QuenMKClicked?.Invoke(this, EventArgs.Empty);
        }

        private void cbLuumk_CheckedChanged(object sender, EventArgs e)
        {
            if (txttenTK.Text != "" && txtMK.Text != "")
            {
                if (cbLuumk.Checked == true)
                {
                    string mk = txtMK.Text;
                    string tentk = txttenTK.Text;
                    GUI.Properties.Settings.Default.MatKhau = mk;
                    GUI.Properties.Settings.Default.TenTK = tentk;
                    GUI.Properties.Settings.Default.Save();
                }
                else
                {
                    GUI.Properties.Settings.Default.Reset();
                }
            }
        }
    }
}
