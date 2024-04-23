using GUI.All_TrangChu_Control;
using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;

namespace GUI.All_User_Control
{
    public partial class UC_TrangChu : UserControl
    {
        public event EventHandler<string> ButtonDanhMucConClick;
        public event EventHandler ChuyenSangBaiDang;
        public event EventHandler<string> LinhVucSelected;

        private void UC_TrangChu_Load(object sender, EventArgs e)
        {
            HideAllUC();
            listDanhMuc.Visible = false;
        }

        public UC_TrangChu()
        {

            InitializeComponent();
            uC_DienLanh1.ButtonDanhMucConClick += UC_DienLanh_ButtonDanhMucConClick;
            uC_DienLanh1.ChuyenSangBaiDang += UC_DienLanh_ChuyenSangBaiDang;

            uC_DienMay1.ButtonDanhMucConClick += UC_DienMay_ButtonDanhMucConClick;
            uC_DienMay1.ChuyenSangBaiDang += UC_DienMay_ChuyenSangBaiDang;

            uC_DienTuGiaDung1.ButtonDanhMucConClick += UC_DienTuGiaDung_ButtonDanhMucConClick;
            uC_DienTuGiaDung1.ChuyenSangBaiDang += UC_DienTuGiaDung_ChuyenSangBaiDang;

            uC_HeThongNuoc1.ButtonDanhMucConClick += UC_HeThongNuoc_ButtonDanhMucConClick;
            uC_HeThongNuoc1.ChuyenSangBaiDang += UC_HeThongNuoc_ChuyenSangBaiDang;

            uC_ThongNghet1.ButtonDanhMucConClick += UC_ThongNghet_ButtonDanhMucConClick;
            uC_ThongNghet1.ChuyenSangBaiDang += UC_ThongNghet_ChuyenSangBaiDang;

            uC_XayDungKienTruc1.ButtonDanhMucConClick += UC_XayDungKienTruc_ButtonDanhMucConClick;
            uC_XayDungKienTruc1.ChuyenSangBaiDang += UC_XayDungKienTruc_ChuyenSangBaiDang;
        }

        private void UC_DienLanh_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

            MessageBox.Show("Danh mục đang chọn: " + tenDanhMucCon);
            this.Visible = false;
//--------
            LinhVucSelected?.Invoke(this, tenDanhMucCon);

        }


        private void UC_DienLanh_ChuyenSangBaiDang(object sender, EventArgs e)
        {
            // Chuyển từ UC_DienLanh sang UC_BaiDang khi button Điều Hòa được nhấn
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);

        }

        private void UC_DienMay_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

            MessageBox.Show("Danh mục đang chọn: " + tenDanhMucCon);
            this.Visible = false;
//--------
            LinhVucSelected?.Invoke(this, tenDanhMucCon);

        }


        private void UC_DienMay_ChuyenSangBaiDang(object sender, EventArgs e)
        {
            // Chuyển từ UC_DienLanh sang UC_BaiDang khi button Điều Hòa được nhấn
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void UC_DienTuGiaDung_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

            MessageBox.Show("Danh mục đang chọn: " + tenDanhMucCon);
            this.Visible = false;

            LinhVucSelected?.Invoke(this, tenDanhMucCon);
        }


        private void UC_DienTuGiaDung_ChuyenSangBaiDang(object sender, EventArgs e)
        {
            // Chuyển từ UC_DienLanh sang UC_BaiDang khi button Điều Hòa được nhấn
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void UC_HeThongNuoc_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

            MessageBox.Show("Danh mục đang chọn: " + tenDanhMucCon);
            this.Visible = false;

            LinhVucSelected?.Invoke(this, tenDanhMucCon);
        }


        private void UC_HeThongNuoc_ChuyenSangBaiDang(object sender, EventArgs e)
        {
            // Chuyển từ UC_DienLanh sang UC_BaiDang khi button Điều Hòa được nhấn
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void UC_ThongNghet_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

            MessageBox.Show("Danh mục đang chọn: " + tenDanhMucCon);
            this.Visible = false;

            LinhVucSelected?.Invoke(this, tenDanhMucCon);
        }


        private void UC_ThongNghet_ChuyenSangBaiDang(object sender, EventArgs e)
        {
            // Chuyển từ UC_DienLanh sang UC_BaiDang khi button Điều Hòa được nhấn
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void UC_XayDungKienTruc_ButtonDanhMucConClick(object sender, string tenDanhMucCon)
        {

            MessageBox.Show("Danh mục đang chọn: " + tenDanhMucCon);
            this.Visible = false;

            LinhVucSelected?.Invoke(this, tenDanhMucCon);
        }


        private void UC_XayDungKienTruc_ChuyenSangBaiDang(object sender, EventArgs e)
        {
            // Chuyển từ UC_DienLanh sang UC_BaiDang khi button Điều Hòa được nhấn
            ChuyenSangBaiDang?.Invoke(this, EventArgs.Empty);
        }

        private void btnDienLanh_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_DienLanh1.Visible = true;
            uC_DienLanh1.BringToFront();
        }



        private void btnDienTuGiaDung_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_DienTuGiaDung1.Visible = true;
            uC_DienTuGiaDung1.BringToFront();
        }

        private void btnDienMay_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_DienMay1.Visible = true;
            uC_DienMay1.BringToFront();
        }

        private void btnHeThongNuoc_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_HeThongNuoc1.Visible = true;
            uC_HeThongNuoc1.BringToFront();
        }

        private void btnXayDungKienTruc_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_XayDungKienTruc1.Visible = true;
            uC_XayDungKienTruc1.BringToFront();
        }

        private void btnThongNghet_Click(object sender, EventArgs e)
        {
            HideAllUC();
            uC_ThongNghet1.Visible = true;
            uC_ThongNghet1.BringToFront();
        }

        // Tạo một phương thức ẩn tất cả các UC
        private void HideAllUC()
        {
            uC_DienLanh1.Visible = false;
            uC_DienTuGiaDung1.Visible = false;
            uC_DienMay1.Visible = false;
            uC_HeThongNuoc1.Visible = false;
            uC_XayDungKienTruc1.Visible = false;
            uC_ThongNghet1.Visible = false;
        }

        private void uC_ThongNghet1_Load(object sender, EventArgs e)
        {

        }



        private void listDanhMuc_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            // Kiểm tra xem có mục nào được chọn không
            if (listDanhMuc.SelectedItem != null)
            {
                string tenDanhMucCon = listDanhMuc.SelectedItem.ToString();
                // Gọi phương thức từ tầng DAL để lấy dữ liệu
                DataTable danhSachDanhMuc = DanhMucDAL.LayDanhMucConTheoTuKhoa(tenDanhMucCon);
/*
                // Xử lý dữ liệu từ DataTable
                foreach (DataRow row in danhSachDanhMuc.Rows)
                {
                    // Lấy dữ liệu từ cơ sở dữ liệu
                    string tenDanhMuc = row["TenDanhMuc"].ToString();
                    // Tiến hành xử lý dữ liệu
                    // Ví dụ: Hiển thị dữ liệu lên giao diện người dùng
                    MessageBox.Show("Danh mục: " + tenDanhMuc);
                }*/

            }
        }

        private void txtTimKiem_TextChanged_1(object sender, EventArgs e)
        {
            string tuKhoa = txtTimKiem.Text.Trim();
            if (!string.IsNullOrEmpty(tuKhoa))
            {
                // Gọi phương thức từ tầng DAL để lấy dữ liệu
                DataTable danhSachDanhMuc = DanhMucDAL.LayDanhMucConTheoTuKhoa(tuKhoa);

                // Xử lý dữ liệu từ DataTable
                listDanhMuc.Items.Clear();
                foreach (DataRow row in danhSachDanhMuc.Rows)
                {
                    // Lấy dữ liệu từ cơ sở dữ liệu
                    string tenDanhMucCon = row["TenDanhMucCon"].ToString();
                    // Hiển thị dữ liệu lên danh sách
                    listDanhMuc.Items.Add(tenDanhMucCon);
                }
                listDanhMuc.Visible = true;
            }
            else
            {
                listDanhMuc.Visible = false;
            }

            
        }
    }
}
