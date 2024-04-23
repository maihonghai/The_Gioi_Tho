using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data.SqlClient;

namespace BLL
{
    public class LoginBLL
    {
        // biến lưu id người dùng
        public static int IDNguoiDung { get; set; }
        // biến lưu id thợ
        public static int IDTho { get; set; }

        public static int ValidateLogin(string tentk, string mk, bool isNguoiDung)
        {
            ModifyDAL modify = new ModifyDAL();
            string tableName = isNguoiDung ? "TaiKhoan" : "TaiKhoanTho";
            string idColumn = isNguoiDung ? "IDTaiKhoan" : "IDTho";
            string query = $"SELECT {idColumn} FROM {tableName} WHERE TenTaiKhoan = @TenTaiKhoan AND MatKhau = @MatKhau";

            // Thực hiện truy vấn SQL để lấy ID
            object idObject = modify.ExecuteScalar(query, new SqlParameter("@TenTaiKhoan", tentk), new SqlParameter("@MatKhau", mk));

            // Kiểm tra kết quả trả về
            if (idObject != null && int.TryParse(idObject.ToString(), out int id))
            {
                if (isNguoiDung)
                {
                    IDNguoiDung = id;
                }
                else
                {
                    IDTho = id;
                }
                // Đăng nhập thành công, trả về ID
                return id;
            }
            else
            {
                // Đăng nhập thất bại, trả về giá trị âm hoặc mã lỗi khác (tùy thuộc vào yêu cầu của bạn)
                return -1; // Hoặc một giá trị khác để chỉ ra đăng nhập thất bại
            }
        }

    }
}
