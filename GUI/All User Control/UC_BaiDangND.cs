using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI.All_User_Control
{
    public partial class UC_BaiDangND : UserControl
    {
        public int IDBaiDangND { get; set; }
        public UC_BaiDangND(BaiDangND baiDang)
        {
            InitializeComponent();
            lblIDBaiDang.Text = baiDang.IDBaiDangND.ToString();
            //txtTenKhachHang.Text = baiDang.HoTen;
            txtDiaChi.Text = baiDang.DiaChi;
            //txtSoDienThoai.Text = baiDang.SoDienThoai;
            txtLinhVuc.Text = baiDang.CongViec;
            //txtLichThoDen.Text = baiDang.LichThoDen.ToString("dd/MM/yyyy");
            txtmota.Text = baiDang.MoTa;
            lblTieuDE.Text = baiDang.TieuDe;
            //txtGio.Text = baiDang.Gio;
            Image hinhanhmota = ByteArrayToImage(baiDang.HinhAnhMoTa);
            pbAnh.Image = hinhanhmota;

            IDBaiDangND = int.Parse(lblIDBaiDang.Text);
        }
        // Hàm để chuyển đổi mảng byte thành hình ảnh
        public Image ByteArrayToImage(byte[] byteArrayIn)
        {
            using (MemoryStream ms = new MemoryStream(byteArrayIn))
            {
                Image image = Image.FromStream(ms);
                return image;
            }
        }

        private void pnThongTin_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmXemKhachHang form = new FrmXemKhachHang(IDBaiDangND);
            form.ShowDialog();
        }
    }
}
