using DTO;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static DTO.BaiDang;

namespace GUI.All_Tho_Control
{
    public partial class UC_BaiDangTho : UserControl
    {
        public int IDBaiDang { get; set; }
        public Guna2Button GetXoaButton() { return btnXoaBaiDang; }
        public Guna2Button GetChinhSuaButton() { return btnChinhSua; }

        public UC_BaiDangTho(BaiDang baiDang)
        {
            InitializeComponent();
            
            lblIDBaiDang.Text = baiDang.IDBaiDang.ToString();
            lblTen.Text = baiDang.HoTen;
            lblDiaChi.Text = baiDang.DiaChi;
            lblSoDienThoai.Text = baiDang.SoDienThoai;
            //lblSoNamKN.Text = baiDang.SoNamKinhNghiem.ToString();
            lblGia.Text = baiDang.GiaTien.ToString();
            btnLinhVuc.Text = baiDang.LinhVuc.ToString();

            IDBaiDang = int.Parse(lblIDBaiDang.Text);
        }

        private void btnDatLichNgay_Click(object sender, EventArgs e)
        {
            // Tạo và hiển thị form Đặt Lịch
            /* DatLich formDatLich = new DatLich(IDBaiDang);
             formDatLich.ShowDialog();  // Sử dụng ShowDialog để form hiển thị ở chế độ modal*/
            Calendar_User calendar_user = new Calendar_User(IDBaiDang);
            calendar_user.ShowDialog();
        }

        private void btnChiTiet_Click(object sender, EventArgs e)
        {
            FrmXemThoChiTiet frmXemThoChiTiet = new FrmXemThoChiTiet(IDBaiDang);
            frmXemThoChiTiet.ShowDialog();
        }

        private void UC_BaiDangTho_Load(object sender, EventArgs e)
        {

        }

        private void btnXoaBaiDang_Click(object sender, EventArgs e)
        {
            
            if (MessageBox.Show("Bạn muốn xóa bài đăng này không?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {// Gọi phương thức xóa bài đăng từ cơ sở dữ liệu
            bool xoaThanhCong = XoaBaiDang();
                if (xoaThanhCong)
                {
                    MessageBox.Show("Xóa bài đăng thành công!");

                }
                else
                {
                    MessageBox.Show("Xóa bài đăng không thành công!");
                }
            }
        }
        private bool XoaBaiDang()
        {
            try
            {
                // Khởi tạo một đối tượng BaiDangRepository
                BaiDangRepository baiDangRepository = new BaiDangRepository();

                // Gọi phương thức XoaBaiDang từ đối tượng baiDangRepository với IDBaiDang hiện tại
                bool xoaThanhCong = baiDangRepository.XoaBaiDang(IDBaiDang);

                // Trả về kết quả của phương thức XoaBaiDang
                return xoaThanhCong;
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ nếu có bất kỳ lỗi nào xảy ra trong quá trình xóa bài đăng
                Console.WriteLine("Lỗi khi xóa bài đăng: " + ex.Message);
                return false; // Trả về false để thông báo rằng việc xóa bài đăng không thành công
            }
        }

        private void btnChinhSua_Click(object sender, EventArgs e)
        {
            FrmChinhSua form = new FrmChinhSua(IDBaiDang);
            form.ShowDialog();
        }
    }
}
