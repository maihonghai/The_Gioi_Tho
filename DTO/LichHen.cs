using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichHen
    {

        public int IDLichHen { get; set; }
        public string LinhVuc { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public DateTime LichHenDen { get; set; }
        public string Gio { get; set; }
        public string MoTaChiTiet { get; set; }
        public string GhiChu { get; set; }
        public decimal GiaTien { get; set; }

        public string TrangThaiCongViecTho { get; set; }
        public string TrangThaiCongViecNguoiDung { get; set; }

        public int IDTho { get; set; }
       // public int ThoiGianThucHien { get; set; }

    }

}
