using DAL;
using DTO;
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

namespace GUI
{
    public partial class FrmChinhSua : Form
    {
        private BaiDang thongTin;
        private BaiDangDAL baiDang;
        public int IDBaiDang;
        public FrmChinhSua(int iDBaiDang)
        {
            InitializeComponent();
            thongTin = new BaiDang();
            thongTin.BaiDangTho(iDBaiDang);
            txtGiaTien.Text = thongTin.GiaTien.ToString();
            txtMoTa.Text = thongTin.MoTa;
            cbThoiGianThucHien.Text = thongTin.ThoiGianThucHien.ToString();

            IDBaiDang = iDBaiDang;
        }

        private void btnLuuLai_Click(object sender, EventArgs e)
        {
            try
            {
                // Lấy thông tin cần cập nhật từ các điều khiển trên form
                decimal giaTien = decimal.Parse(txtGiaTien.Text);
                string moTa = txtMoTa.Text;
                int thoiGianThucHien = int.Parse(cbThoiGianThucHien.Text);

                // Khởi tạo một đối tượng BaiDangRepository
                baiDang = new BaiDangDAL();
                bool capNhat = baiDang.ChinhSuaBaiDang(IDBaiDang, moTa, thoiGianThucHien, giaTien);
                if (capNhat)
                {
                    MessageBox.Show("Cập nhật thành công!");
                }
                else
                {
                    MessageBox.Show("Cập nhật không thành công!");
                }
            }
            catch (FormatException ex)
            {
                // Xử lý ngoại lệ FormatException khi nhập liệu không hợp lệ
                MessageBox.Show("Nhập liệu không hợp lệ! Vui lòng kiểm tra lại định dạng số.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Xử lý các ngoại lệ khác có thể xảy ra trong quá trình cập nhật
                MessageBox.Show("Đã xảy ra lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
