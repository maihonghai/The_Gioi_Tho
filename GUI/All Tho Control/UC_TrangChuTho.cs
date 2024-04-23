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
using static DTO.BaiDang;
using static DTO.BaiDangND;

namespace GUI.All_User_Control
{
    public partial class UC_TrangChuTho : UserControl
    {
        private BaiDangNDRepository baiDangNDRepository;
        public UC_TrangChuTho()
        {
            InitializeComponent();
            baiDangNDRepository = new BaiDangNDRepository();
        }
        private void HienThiDanhSachBaiDang(List<BaiDangND> danhSachBaiDang)
        {
            // Xóa các bài đăng hiện có trong panel
            //            pnlDanhSachBaiDang.Controls.Clear();

            // Lấy danh sách bài đăng từ cơ sở dữ liệu
            //List<BaiDang> danhSachBaiDang = baiDangRepository.LayDanhSachBaiDang();

            int x = 10; // Vị trí x của UserControl trong panel
            int y = 10; // Vị trí y của UserControl trong panel

            // Hiển thị thông tin của từng bài đăng trên giao diện
            foreach (BaiDangND baiDang in danhSachBaiDang)
            {
                // Tạo một UserControl mới để hiển thị thông tin của bài đăng
                UC_BaiDangND uC_BaiDangND = new UC_BaiDangND(baiDang);
                uC_BaiDangND.BorderStyle = BorderStyle.FixedSingle;

                // Thiết lập vị trí của UserControl
                uC_BaiDangND.Location = new Point(x, y);

                // Thêm UserControl vào panel pnlDanhSachBaiDang
                pnlDanhSachBaiDang.Controls.Add(uC_BaiDangND);

                // Tăng vị trí y cho UserControl tiếp theo
                y += uC_BaiDangND.Height + 7; // 10 là khoảng cách giữa các UserControl

            }
        }

        private void UC_TrangChuTho_Load(object sender, EventArgs e)
        {
            List<BaiDangND> danhSachBaiDang = baiDangNDRepository.LayDanhSachBaiDangND();

            //Hiển thị tất cả bài đăng
            HienThiDanhSachBaiDang(danhSachBaiDang);
        }
    }
}
