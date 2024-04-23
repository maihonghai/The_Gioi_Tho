using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BaiDangBLL
    {
        private BaiDangDAL baiDangDAL = new BaiDangDAL();

        public bool DangBai(string hoVaTen, string diaChi, string soDienThoai, int soNamKinhNghiem, string moTa, string linhVuc, int thoiGianThucHien, decimal giaTien, int idTho)
        {
            try
            {
                // Gọi phương thức từ Data Access Layer để thêm bài đăng vào cơ sở dữ liệu
                return baiDangDAL.DangBai(hoVaTen, diaChi, soDienThoai, soNamKinhNghiem, moTa, linhVuc, thoiGianThucHien, giaTien, idTho);
            }
            catch (Exception ex)
            {
                // Xử lý ngoại lệ (nếu cần)
                Console.WriteLine("Lỗi: " + ex.Message);
                return false;
            }
        }
    }
}
