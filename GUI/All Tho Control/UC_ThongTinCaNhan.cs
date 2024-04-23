using BLL;
using DAL;
using GUI.All_Login_Control;
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
    public partial class UC_ThongTinCaNhan : UserControl
    {
        private UC_ChinhSuaHoSo ucChinhSuaHoSo;
        private ThongTinTho thongTin;
        public UC_ThongTinCaNhan()
        {
            InitializeComponent();
            // Đăng ký sự kiện ThongTinDaCapNhat của UC_ThongTinTho

            LoadData();
        }
        public void LoadData()
        {
            // Tạo một instance mới của lớp ThongTinCaNhan
            thongTin = new ThongTinTho(LoginBLL.IDTho);

            // Hiển thị thông tin cá nhân của Thợ trên giao diện
            lblHoTen.Text = thongTin.HoTen;
            lblDiaChi.Text = thongTin.DiaChi;
            lblDienThoai.Text = thongTin.SoDienThoai;
            //lblTaiKhoanID.Text = thongTin.TaiKhoanID.ToString();
            lblEmail.Text = thongTin.Email;
            lblGioiTinh.Text = thongTin.GioiTinh;

            //lblSoNamKN.Text = baiDang.SoNamKinhNghiem.ToString();
        }
        private void UC_ThongTinCaNhan_Load(object sender, EventArgs e)
        {
            // uC_ChinhSuaHoSo1.BackClicked += UC_Thongtin_BackClicked;
            uC_ChinhSuaHoSo1.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnChinhSuaHoSo_Click(object sender, EventArgs e)
        {
            // uC_ChinhSuaHoSo1.Visible = true;
            ucChinhSuaHoSo = new UC_ChinhSuaHoSo(this); // Truyền tham chiếu của UC_ThongTinCaNhan vào UC_ChinhSuaHoSo
            // Hiển thị UC_ChinhSuaHoSo trên form hoặc panel
            this.Controls.Add(ucChinhSuaHoSo);
            ucChinhSuaHoSo.BringToFront();
        }
        private void UC_Thongtin_BackClicked(object sender, EventArgs e)
        {
            uC_ChinhSuaHoSo1.Visible = false;
            // uC_DangNhap1.BringToFront();
        }

        private void UcThongTinTho1_ThongTinDaCapNhat(object sender, EventArgs e)
        {
            //LoadData();
            this.Invoke(new Action(() =>
            {
                // Thực hiện các thay đổi trên giao diện tại đây
                // Ví dụ:
                LoadData();
            }));
        }
    }
}
