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
using static DTO.BaiDang;

namespace GUI.All_User_Control
{
    public partial class UC_BaiDang : UserControl
    {
        private bool isUCTrangChuVisible = false;
        public Guna2Button GetQuayLaiButton() { return btnQuayLai; }

        private BaiDangRepository baiDangRepository;

        UC_TrangChu uC_TrangChu1 = new UC_TrangChu();

        public UC_BaiDang()
        {
            InitializeComponent();

            uC_TrangChu1.Dock = DockStyle.Fill; // Đặt UC_TrangChu để lấp đầy phần tử cha (UC_BaiDang)
            this.Controls.Add(uC_TrangChu1);

            baiDangRepository = new BaiDangRepository();

            // Đăng ký sự kiện LinhVucSelected từ UC_TrangChu
            uC_TrangChu1.LinhVucSelected += UC_TrangChu_LinhVucSelected;
            List<BaiDang> danhSachBaiDang = baiDangRepository.LayDanhSachBaiDang();
            HienThiDanhSachBaiDang(danhSachBaiDang);

        }

        public UC_BaiDang(int iDTho)
        {
            InitializeComponent();
            baiDangRepository = new BaiDangRepository();
            pnlDanhSachBaiDang.Controls.Clear();

            UC_ThoXemBaiDangTheoIDThoClicked(iDTho);
        }
        // Thêm phương thức để hiển thị danh sách bài đăng theo ID vào UC_BaiDang:
        private void UC_ThoXemBaiDangTheoIDThoClicked(int iDTho)
        {
            pnlDanhSachBaiDang.Controls.Clear();

            // Lấy danh sách bài đăng theo IDTho
            List<BaiDang> danhSachBaiDang = LayDanhSachBaiDangTheoIDTho(iDTho);

            // Hiển thị danh sách bài đăng đã lấy được
            HienThiDanhSachBaiDang(danhSachBaiDang);
        }

        // Thêm phương thức để lấy danh sách bài đăng theo IDTho trong UC_BaiDang:
        public List<BaiDang> LayDanhSachBaiDangTheoIDTho(int IDTho)
        {
            // Gọi phương thức từ Repository hoặc truy vấn CSDL để lấy danh sách bài đăng theo IDTho
            return baiDangRepository.LayBaiDangTheoIDTho(IDTho);
        }

        // Phương thức tải danh sách bài đăng theo IDTho
        private void UC_TrangChu_LinhVucSelected(object sender, string tenLinhVuc)
        {
            pnlDanhSachBaiDang.Controls.Clear();

            // Lấy danh sách bài đăng theo Lĩnh Vực đã chọn
            List<BaiDang> danhSachBaiDang = baiDangRepository.LayBaiDangTheoLinhVuc(tenLinhVuc);

            // Hiển thị danh sách bài đăng đã lọc
            HienThiDanhSachBaiDang(danhSachBaiDang);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UC_BaiDang_Load(object sender, EventArgs e)
        {

            Guna.UI.Lib.ScrollBar.PanelScrollHelper flowpan = new Guna.UI.Lib.ScrollBar.PanelScrollHelper(pnlDanhSachBaiDang, gunaVScrollBar1, true);
            uC_TrangChu1.Visible = false;

            uC_TrangChu1.ButtonDanhMucConClick += UC_TrangChu1_ButtonDanhMucConClick;
           

        }

        private void HienThiDanhSachBaiDang(List<BaiDang> danhSachBaiDang)
        {
            // Xóa các bài đăng hiện có trong panel
//            pnlDanhSachBaiDang.Controls.Clear();

            // Lấy danh sách bài đăng từ cơ sở dữ liệu
            //List<BaiDang> danhSachBaiDang = baiDangRepository.LayDanhSachBaiDang();

            int x = 15; // Vị trí x của UserControl trong panel
            int y = 25; // Vị trí y của UserControl trong panel
            int k = 0;

            // Hiển thị thông tin của từng bài đăng trên giao diện
            foreach (BaiDang baiDang in danhSachBaiDang)
            {
                // Tạo một UserControl mới để hiển thị thông tin của bài đăng
                UC_BaiDangTho uC_BaiDangTho = new UC_BaiDangTho(baiDang);

                // Thiết lập vị trí của UserControl
                uC_BaiDangTho.Location = new Point(x, y);

                // Thêm UserControl vào panel pnlDanhSachBaiDang
                pnlDanhSachBaiDang.Controls.Add(uC_BaiDangTho);

                // Tăng vị trí y cho UserControl tiếp theo
                x += uC_BaiDangTho.Width + 20; // 10 là khoảng cách giữa các UserControl
                k++;
                if(k == 2)
                {
                    y += uC_BaiDangTho.Height + 10; // 10 là khoảng cách giữa các UserControl
                    x = 15;
                    k = 0;
                }
            }
        }

        private void UC_TrangChu1_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

        }

        private void gunaVScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void btnLocTheoDanhMuc_Click(object sender, EventArgs e)
        {
            if (!isUCTrangChuVisible)
            {
                // Hiển thị UC_TrangChu
                uC_TrangChu1.Visible = true;
                uC_TrangChu1.BringToFront();
                isUCTrangChuVisible = true;
            }
            else
            {
                // Ẩn UC_TrangChu
                uC_TrangChu1.Visible = false;
                isUCTrangChuVisible = false;
            }
        }

        private void btnQuayLai_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
