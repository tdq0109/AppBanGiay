using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmoder
{
    public class HoaDonCT
    {
        public int IdHoaDonCT { get; set; }
        public int IdSanphamct { get; set; }
        public string TenSanPham { get; set; }
        public string Mau { get; set; }
        public int? Size { get; set; }
        public string ChatLieu { get; set; }
        public int? SoLuong { get; set; }
        public double? GiaSanPham { get; set; }
        public string TrangThai { get; set; }
    }
}
