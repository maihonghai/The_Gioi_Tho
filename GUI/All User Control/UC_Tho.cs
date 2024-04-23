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
    public partial class UC_Tho : UserControl
    {
        public UC_Tho()
        {
            InitializeComponent();
            InitializeDataGridView();
            AddSampleDataToDataGridView();
        }

        private void Tho_Load(object sender, EventArgs e)
        {

        }

        private void dgvDanhSachTho_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void InitializeDataGridView()
        {
            // Thiết lập cấu trúc cột cho DataGridView
            dgvDanhSachTho.ColumnCount = 6;
            dgvDanhSachTho.Columns[0].Name = "ID";
            dgvDanhSachTho.Columns[1].Name = "Ten";
            dgvDanhSachTho.Columns[2].Name = "DiaChi";
            dgvDanhSachTho.Columns[3].Name = "LinhVuc";
            dgvDanhSachTho.Columns[4].Name = "SoDienThoai";



            

        }

        private void AddSampleDataToDataGridView()
        {
            

            // Thêm dữ liệu mẫu vào DataGridView
            dgvDanhSachTho.Rows.Add(new object[] { 1, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Điện Máy", "0123456789"});
            dgvDanhSachTho.Rows.Add(new object[] { 2, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Điện Lạnh", "0987654321" });
            dgvDanhSachTho.Rows.Add(new object[] { 3, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Điện Tử Gia Dụng", "0123456789" });
            dgvDanhSachTho.Rows.Add(new object[] { 4, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Hệ Thống Nước", "0987654321" });
            dgvDanhSachTho.Rows.Add(new object[] { 5, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Xây Dựng - Kiến Trúc", "0123456789" });
            dgvDanhSachTho.Rows.Add(new object[] { 6, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Thông Nghẹt", "0987654321" });
            dgvDanhSachTho.Rows.Add(new object[] { 7, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Điện Máy", "0123456789" });
            dgvDanhSachTho.Rows.Add(new object[] { 8, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Điện Lạnh", "0987654321" });
            dgvDanhSachTho.Rows.Add(new object[] { 9, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Điện Tử Gia Dụng", "0123456789" });
            dgvDanhSachTho.Rows.Add(new object[] { 10, "Nguyễn Văn A", "Thủ Đức, TpHCM", "Hệ Thống Nước", "0987654321" });
        }

        private void dgvDanhSachTho_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
