using System;
using System.Windows.Forms;
using BLL; // Import Business Logic Layer
using DAL; // Import Data Access Layer

namespace GUI.All_Login_Control
{
    public partial class UC_DangKy : UserControl
    {
        private readonly BusinessLogicLayer bll; // Business Logic Layer
        private readonly TaiKhoanDAL taiKhoanDal; // Data Access Layer for TaiKhoan
        private readonly TaiKhoanThoDAL taiKhoanThoDal; // Data Access Layer for TaiKhoanTho

        public event EventHandler BackClicked;
        public UC_DangKy()
        {
            InitializeComponent();
            uC_DangKyND1.Visible = false;
            uC_DangKyTho1.Visible = false;
            bll = new BusinessLogicLayer();
            taiKhoanDal = new TaiKhoanDAL();
            taiKhoanThoDal = new TaiKhoanThoDAL();
        }

        private void btnDangky_Click(object sender, EventArgs e)
        {
            string tentk = txttenTK.Text;
            string mk = txtMK.Text;
            string xnmk = txtXacnhan.Text;
            string email = txtEmail.Text;

            if (!bll.CheckAccount(tentk))
            {
                MessageBox.Show("Vui lòng nhập tên tài khoản với các ký tự chữ và số, chữ hoa và chữ thường!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bll.CheckAccount(mk))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu nhiều hơn 3 kí tự với các ký tự là chữ và số, chữ hoa và chữ thường!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (xnmk != mk)
            {
                MessageBox.Show("Vui lòng xác nhận mật khẩu chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            if (!bll.CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (taiKhoanDal.GetByTenTaiKhoan(tentk) != null || taiKhoanThoDal.GetByTenTaiKhoan(tentk) != null)
            {
                MessageBox.Show("Tên tài khoản này đã được đăng ký, vui lòng đăng ký tên tài khoản khác! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (taiKhoanDal.GetByEmail(email) != null || taiKhoanThoDal.GetByEmail(email) != null)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbphanQuyen.Text == "")
            {
                MessageBox.Show("Vui lòng chọn vai trò của bạn để đăng ký!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (cbphanQuyen.Text == "Thợ")
            {
                uC_DangKyTho1.Visible = true;
            }
            else
            {

                uC_DangKyND1.Visible = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            BackClicked?.Invoke(this, EventArgs.Empty);
        }

        private void UC_DangKy_Load(object sender, EventArgs e)
        {
            uC_DangKyTho1.BackClicked += UC_DangKy_BackClicked;
            uC_DangKyTho1.XacNhanClicked += UC_DangKy_XacNhanClicked;
            uC_DangKyND1.BackClicked += UC_DangKy_BackClicked;
            uC_DangKyND1.XacNhanClicked += UC_DangKy_XacNhanClicked;
        }

        private void UC_DangKy_BackClicked(object sender, EventArgs e)
        {
            uC_DangKyTho1.Visible = false;
            uC_DangKyND1.Visible = false;
        }

        private void UC_DangKy_XacNhanClicked(object sender, EventArgs e)
        {
            string tentk = txttenTK.Text;
            string mk = txtMK.Text;
            string xnmk = txtXacnhan.Text;
            string email = txtEmail.Text;
            if (cbphanQuyen.Text == "Thợ")
            {
                string hoten = uC_DangKyTho1.HovaTenText;
                string gioitinh = uC_DangKyTho1.GioiTinhText;
                string sodt = uC_DangKyTho1.SoDTText;
                string sonamknText = uC_DangKyTho1.SoNamKNText;
                string diachi = uC_DangKyTho1.DiaChiText;
                if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(gioitinh) || string.IsNullOrEmpty(sodt) || string.IsNullOrEmpty(diachi)|| string.IsNullOrEmpty(sonamknText))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                int sonamkn;
                // Kiểm tra xem trường số năm kinh nghiệm có thể được chuyển đổi thành số nguyên không
                if (!int.TryParse(sonamknText, out sonamkn))
                {
                    MessageBox.Show("Số năm kinh nghiệm không hợp lệ!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    taiKhoanThoDal.Insert(tentk, mk, email, hoten, gioitinh, sodt, sonamkn, diachi);
                    MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    UC_DangNhap dangnhap = new UC_DangNhap();
                    this.Controls.Add(dangnhap);
                    dangnhap.Visible = true;
                    dangnhap.BringToFront();
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký!");
                }
            }
            else
            {
                string hoten = uC_DangKyND1.HovaTenText;
                string sodt = uC_DangKyND1.SoDTText;
                string diachi = uC_DangKyND1.DiaChiText;
                if (string.IsNullOrEmpty(hoten) || string.IsNullOrEmpty(sodt) || string.IsNullOrEmpty(diachi))
                {
                    MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                try
                {
                    taiKhoanDal.Insert(tentk, mk, email, hoten, sodt, diachi);
                    MessageBox.Show("Đăng ký thành công! Bạn có muốn đăng nhập không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    UC_DangNhap dangnhap = new UC_DangNhap();
                    this.Controls.Add(dangnhap);
                    dangnhap.Visible = true;
                    dangnhap.BringToFront();
                }
                catch
                {
                    MessageBox.Show("Tên tài khoản này đã được đăng ký!");
                }
            }
        }

        private void uC_DangKyTho1_Load(object sender, EventArgs e)
        {

        }
    }
}
