using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmoder
{
    public class HoaDon
    {
        public int IdHoaDon {  get; set; }
        public DateOnly? NgayTao {  get; set; }
        public double? TongTien {  get; set; }
        public string TenKhachHang { get; set; }
        public string SoDienThoai { get; set; }
        public string DiaChi { get; set; }
        public string IdKhuyenMai { get; set; }
        public string TrangThai { get; set; }
        public virtual Khuyenmai IdKhuyenMaiNavigation { get; set; } = null!;
        public virtual Khachhang IdKhachHangNavigation { get; set; } = null!;
    }
}
