using DTO;
using GUI.All_User_Control;
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
    public partial class UC_DanhSachBaiDang : UserControl
    {
        private UC_BaiDang uC_BaiDang1;
        private BaiDangRepository baiDangRepository;

        public int IDTho;
        public UC_DanhSachBaiDang()
        {
            InitializeComponent();
        }
        public UC_DanhSachBaiDang(int iDTho)
        {
            InitializeComponent();
            lblIDTho.Text = iDTho.ToString();
            IDTho = iDTho;

            baiDangRepository = new BaiDangRepository();
            pnlDanhSachIDTho.Controls.Clear();
            List<BaiDang> danhSachBaiDang = new List<BaiDang>();

            // Hiển thị danh sách bài đăng đã lấy được
            HienThiDanhSachBaiDang(danhSachBaiDang);
        }

        private void HienThiDanhSachBaiDang(List<BaiDang> danhSachBaiDang)
        {
            baiDangRepository = new BaiDangRepository();
            pnlDanhSachIDTho.Controls.Clear();
            danhSachBaiDang = baiDangRepository.LayBaiDangTheoIDTho(IDTho);

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

                Guna2Button btnXoa = uC_BaiDangTho.GetXoaButton();
                Guna2Button btnChinhSua = uC_BaiDangTho.GetChinhSuaButton();

                btnXoa.Visible = true;
                btnChinhSua.Visible = true;

                btnXoa.Click += (sender, e) =>
                {
                    HienThiDanhSachBaiDang(danhSachBaiDang);
                };
                // Thiết lập vị trí của UserControl
                uC_BaiDangTho.Location = new Point(x, y);

                // Thêm UserControl vào panel pnlDanhSachBaiDang
                pnlDanhSachIDTho.Controls.Add(uC_BaiDangTho);

                // Tăng vị trí y cho UserControl tiếp theo
                x += uC_BaiDangTho.Width + 20; // 10 là khoảng cách giữa các UserControl
                k++;
                if (k == 2)
                {
                    y += uC_BaiDangTho.Height + 10; // 10 là khoảng cách giữa các UserControl
                    x = 15;
                    k = 0;
                }
            }
        }

        private void gunaControlBox1_Click(object sender, EventArgs e)
        {

        }

        private void ptbBack_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
