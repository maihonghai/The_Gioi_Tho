using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class LichHenTho
    {
        //thuoc tinh cua lich hen cua tho
        public int IDLichHen { get; set; }
        public string LinhVuc { get; set; }
        public string Ten { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public DateTime LichHenDen { get; set; }
        public string Gio { get; set; }
        public string MoTaChiTiet { get; set; }
        public string GhiChu { get; set; }
        public decimal GiaTien { get; set; }
        public string TrangThaiCongViecTho { get; set; }
        public string TrangThaiCongViecNguoiDung { get; set; }
        //public string IDTho { get; set; }
       // public int ThoiGianThucHien { get; set; }
    }
   }
