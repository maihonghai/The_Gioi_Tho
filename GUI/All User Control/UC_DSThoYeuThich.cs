using DAL;
using DTO;
using GUI.All_Tho_Control;
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

namespace GUI.All_User_Control
{
    public partial class UC_DSThoYeuThich : UserControl
    {
        private UC_BaiDang uC_BaiDang;
        public UC_DSThoYeuThich()
        {
            InitializeComponent();
            HienThiDanhSachThoYeuThich();
        }
        public void ThoYeuThichButton_Click(object sender, EventArgs e)
        {
            HienThiDanhSachThoYeuThich();
        }
        private void HienThiDanhSachThoYeuThich()
        {
            ThongTinTho.ThoYeuThichRepository repository = new ThongTinTho.ThoYeuThichRepository();
            List<ThongTinTho> danhSachThoYeuThich = repository.LayDanhSachThoYeuThich(BLL.LoginBLL.IDNguoiDung);

            // Xóa tất cả các control hiện có trong panel trước khi thêm mới
            pnlDanhSachTho.Controls.Clear();

            int x = 10; // Vị trí x của UserControl trong panel
            int y = 15; // Vị trí y của UserControl trong panel

            // Duyệt qua danh sách các thợ yêu thích và hiển thị thông tin trên giao diện
            foreach (ThongTinTho thongTinTho in danhSachThoYeuThich)
            {
                UC_ThoYeuThich uC_Tho = new UC_ThoYeuThich(thongTinTho);
               

                // Lấy nút Hủy yêu thích từ UserControl
                Guna2Button btnHuyYeuThich = uC_Tho.GetBtnHuyYeuThich();
        
                // Đăng ký sự kiện từ UC_ThoYeuThich
                uC_Tho.XemBaiDangClicked += UC_ThoXemBaiDangTheoIDThoClicked;
                // Gắn sự kiện click cho nút Hủy yêu thích
                btnHuyYeuThich.Click += (sender, e) =>
                {
                    HienThiDanhSachThoYeuThich();
                };
                // Thiết lập vị trí của UserControl
                uC_Tho.Location = new Point(x, y);
                uC_Tho.BackColor = Color.White;
                uC_Tho.SendToBack();
                uC_Tho.BorderStyle = BorderStyle.FixedSingle;
                pnlDanhSachTho.Controls.Add(uC_Tho);

                // Tăng vị trí y cho UserControl tiếp theo
                x += uC_Tho.Width + 20; // 10 là khoảng cách giữa các UserControl
                pnlDanhSachTho.AutoScrollMinSize = new Size(x, pnlDanhSachTho.Height);
            }
        }
        private void UC_ThoXemBaiDangTheoIDThoClicked(object sender, int IDTho)
        {
            // Ép kiểu sender về UC_BaiDang
            //UC_BaiDang uC_BaiDang = sender as UC_BaiDang;
            // Khởi tạo thể hiện của UC_BaiDang
            uC_BaiDang = new UC_BaiDang(IDTho);

            // Kiểm tra xem uC_BaiDang có khác null trước khi tiếp tục
            if (uC_BaiDang != null)
            {
                // Sử dụng thể hiện của UC_BaiDang để gọi phương thức LayDanhSachBaiDangTheoIDTho
                List<BaiDang> danhSachBaiDang = uC_BaiDang.LayDanhSachBaiDangTheoIDTho(IDTho);
                // Lấy tham chiếu đến nút Quay lại từ UC_BaiDang
                Guna2Button btnQuayLai = uC_BaiDang.GetQuayLaiButton();

                // Đặt thuộc tính Visible của nút Quay lại
                btnQuayLai.Visible = true;

                // Tiếp tục hiển thị danh sách bài đăng
                // Ví dụ:
                // Thêm UC_BaiDang vào panel của UserControl hiện tại:
                this.Controls.Add(uC_BaiDang);
                uC_BaiDang.Dock = DockStyle.Fill;
                uC_BaiDang.BringToFront();
            }
            else
            {
                //Console.WriteLine(sender);
                // Xử lý trường hợp khi uC_BaiDang là null
                MessageBox.Show("Không có bài dăng!");

            }
        }

        private void btnTopTho_Click(object sender, EventArgs e)
        {
            // Gọi phương thức để lấy danh sách các thơ được yêu thích nhiều nhất từ cơ sở dữ liệu
            List<ThongTinTho> danhSachTopTho = LayDanhSachTopThoYeuThich();

            // Hiển thị danh sách các thơ được yêu thích nhiều nhất lên panel
            HienThiDanhSachTho(danhSachTopTho);
        }
        private List<ThongTinTho> LayDanhSachTopThoYeuThich()
        {
            // Gọi phương thức từ repository để lấy danh sách các thơ được yêu thích nhiều nhất
            ThongTinTho.ThoYeuThichRepository repository = new ThongTinTho.ThoYeuThichRepository();
            List<ThongTinTho> danhSachTopTho = repository.LayDanhSachTopThoYeuThich();

            return danhSachTopTho;
        }

        private void HienThiDanhSachTho(List<ThongTinTho> danhSachTho)
        {
            // Xóa tất cả các control hiện có trong panel trước khi thêm mới
            pnlDanhSachTho.Controls.Clear();

            int x = 10; // Vị trí x của UserControl trong panel
            int y = 15; // Vị trí y của UserControl trong panel

            // Duyệt qua danh sách các thợ yêu thích và hiển thị thông tin trên giao diện
            foreach (ThongTinTho thongTinTho in danhSachTho)
            {
                UC_ThoYeuThich uC_Tho = new UC_ThoYeuThich(thongTinTho);

                // Lấy nút Hủy yêu thích từ UserControl
                Guna2Button btnHuyYeuThich = uC_Tho.GetBtnHuyYeuThich();
                btnHuyYeuThich.Visible = false;
                //lblSoLuot

                Guna2HtmlLabel lblYeuThich = uC_Tho.GetSoLuotYeuThich();
                lblYeuThich.Visible = true;

                // Đăng ký sự kiện từ UC_ThoYeuThich
                uC_Tho.XemBaiDangClicked += UC_ThoXemBaiDangTheoIDThoClicked;

                // Gắn sự kiện click cho nút Hủy yêu thích
               /* btnHuyYeuThich.Click += (sender, e) =>
                {
                    // Sau khi hủy yêu thích, cập nhật lại danh sách top thơ yêu thích
                    btnTopTho_Click(sender, e);
                };*/

                // Thiết lập vị trí của UserControl
                uC_Tho.Location = new Point(x, y);
                uC_Tho.BackColor = Color.White;
                uC_Tho.SendToBack();
                uC_Tho.BorderStyle = BorderStyle.FixedSingle;
                pnlDanhSachTho.Controls.Add(uC_Tho);
                // Tăng vị trí y cho UserControl tiếp theo
                x += uC_Tho.Width + 20; // 10 là khoảng cách giữa các UserControl
                pnlDanhSachTho.AutoScrollMinSize = new Size(x, pnlDanhSachTho.Height);
            }
        }

        private void btnThoBiHuy_Click(object sender, EventArgs e)
        {
            // Gọi phương thức để lấy danh sách các thợ bị hủy xét từ cơ sở dữ liệu
            List<ThongTinTho> danhSachThoBiHuy = LayDanhSachThoBiHuy();

            // Hiển thị danh sách các thợ bị hủy xét lên panel
            HienThiDanhSachTho(danhSachThoBiHuy);
        }
        private List<ThongTinTho> LayDanhSachThoBiHuy()
        {
            // Gọi phương thức từ repository để lấy danh sách các thợ bị hủy xét
            ThongTinTho.ThoYeuThichRepository repository = new ThongTinTho.ThoYeuThichRepository();
            List<ThongTinTho> danhSachThoBiHuy = repository.LayDanhSachThoBiHuy();

            return danhSachThoBiHuy;
        }
    }
}
