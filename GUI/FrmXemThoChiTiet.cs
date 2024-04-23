using DTO;
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

namespace GUI
{
    public partial class FrmXemThoChiTiet : Form
    {
        private BaiDang thongtin;
        private SaoDanhGia saoDanhGia;
        public int IDBaiDang { get; set; }

        public FrmXemThoChiTiet()
        {
            InitializeComponent();
        }
        // Thêm phương thức để nhận dữ liệu từ UC_XemDanhGia
    
        public FrmXemThoChiTiet(int iDBaiDang)
        {
            InitializeComponent();
            //uC_XemDanhGiaChiTiet1.Visible = false;
            thongtin = new BaiDang();
            thongtin.BaiDangTho(iDBaiDang);

            IDBaiDang = iDBaiDang;


            saoDanhGia = new SaoDanhGia();
            // Gọi phương thức GetSaoDanhGia để lấy kết quả
            (int soBai, double saoTB) = saoDanhGia.GetSaoDanhGia(thongtin.IDTho);  

            txtTen.Text = thongtin.HoTen;
            txtSoDienThoai.Text = thongtin.SoDienThoai;
            txtDiaChi.Text = thongtin.DiaChi;
            txtSoNamKinhNghiem.Text = thongtin.SoNamKinhNghiem.ToString();
            txtMota.Text = thongtin.MoTa;
            lblThoiGianLamViec.Text = thongtin.ThoiGianThucHien.ToString() + " Tiếng";
            lblGiaTien.Text = "Giá: " + thongtin.GiaTien;
            lblSaotb.Text = saoTB.ToString("0.0");
            lblSoBaiDanhGia.Text = "(" + soBai.ToString() + " Bài viết)";
            rtSosaotb.Value = Convert.ToInt32(saoTB);
        }

        private void FrmXemThoChiTiet_Load(object sender, EventArgs e)
        {

        }
        private void btnDatLichNgay_Click_1(object sender, EventArgs e)
        {
            Calendar_User frm = new Calendar_User(IDBaiDang);
            frm.ShowDialog();
        }

        private void btnXemChiTietDanhGia_Click(object sender, EventArgs e)
        {
            // Khởi tạo UC_XemDanhGiaChiTiet với IDTho và thêm vào form
            UC_XemDanhGiaChiTiet uC_XemDanhGiaChiTiet1 = new UC_XemDanhGiaChiTiet(thongtin.IDTho);
           // uC_XemDanhGiaChiTiet1.Location = new Point(10, 10); // Thiết lập vị trí của UC trên form
            pnlBang.Controls.Add(uC_XemDanhGiaChiTiet1);
            uC_XemDanhGiaChiTiet1.BringToFront(); // Đưa UC lên phía trước
        }
    }
   }

