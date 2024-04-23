using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class TaiKhoanBLL
    {
        private TaiKhoanDAL taiKhoanDAL = new TaiKhoanDAL();

        public string LayMatKhauBangEmail(string email)
        {
            return taiKhoanDAL.LayMatKhauBangEmail(email);
        }
    }
}
