using BLL;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_Tho_Control
{
    public partial class UC_ChinhSuaHoSo : UserControl
    {
        public event EventHandler BackClicked;

        private ChinhSuaThoDAL thoDAL;
        private readonly BusinessLogicLayer bll;
        private ThongTinTho tho;
        private readonly TaiKhoanDAL taiKhoanDal; // Data Access Layer for TaiKhoan
        private readonly TaiKhoanThoDAL taiKhoanThoDal;

        // Khai báo sự kiện để thông báo rằng thông tin thợ đã được cập nhật
        private UC_ThongTinCaNhan ucThongTinCaNhan;
        public UC_ChinhSuaHoSo(UC_ThongTinCaNhan thongTinCaNhan)
        {
            InitializeComponent();

            ucThongTinCaNhan = thongTinCaNhan; // Gán tham chiếu của UC_ThongTinCaNhan từ form chứa UC

            tho = new ThongTinTho(LoginBLL.IDTho);
            bll = new BusinessLogicLayer();
            taiKhoanDal = new TaiKhoanDAL();
            taiKhoanThoDal = new TaiKhoanThoDAL();

            txtHoTen.Text = tho.HoTen;
            txtDiaChi.Text = tho.DiaChi;
            txtEmail.Text = tho.Email;
            txtSoDienThoai.Text = tho.SoDienThoai;
            cmbGioiTinh.Text = tho.GioiTinh;
        }
        public UC_ChinhSuaHoSo()
        {
            InitializeComponent();
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
           // thoDAL = new ChinhSuaThoDAL();
            //int idTho = LoginBLL.IDTho; // Hàm này để lấy ID của thợ đang được chọn trong giao diện
            string hoTen = txtHoTen.Text;
            string soDienThoai = txtSoDienThoai.Text;
            string diaChi = txtDiaChi.Text;
            string email = txtEmail.Text;
            string gioiTinh = cmbGioiTinh.Text;

            // Kiểm tra xem các trường dữ liệu không được để trống
            if (string.IsNullOrEmpty(hoTen) || string.IsNullOrEmpty(soDienThoai) || string.IsNullOrEmpty(diaChi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(gioiTinh))
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!bll.CheckEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng email!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if ((taiKhoanDal.GetByEmail(email) != null || taiKhoanThoDal.GetByEmail(email) != null) && email != tho.Email)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác! ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            thoDAL = new ChinhSuaThoDAL();
                int idTho = LoginBLL.IDTho; // Hàm này để lấy ID của thợ đang được chọn trong giao diện

                // Tiến hành cập nhật thông tin thợ
                bool result = thoDAL.UpdateTho(idTho, hoTen, soDienThoai, diaChi, email, gioiTinh);
                if (result)
                {
                    MessageBox.Show("Cập nhật thông tin thợ thành công!");
                    // Cập nhật lại giao diện nếu cần
                }
                else
                {
                    MessageBox.Show("Cập nhật thông tin thợ không thành công!");
                }
                // Sau khi cập nhật xong, gọi phương thức cập nhật trên UC_ThongTinCaNhan
                ucThongTinCaNhan.LoadData();
                this.Visible = false;
            
        }


        private void ptbBack_Click(object sender, EventArgs e)
        {
            this.Dispose();
            //BackClicked?.Invoke(this, EventArgs.Empty);
        }


    }
}
