using BUS.Viewmoder;
using DAL.IRepository;
using DAL.Models;
using DAL.Repositori;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Servicer
{
    public class HoaDonCTSer
    {
        IHoaDonCTRepos HoaDonCTRepos = new IHoaDonCTRepos();
        HoaDonRepos HoaDonRepos = new HoaDonRepos();
        SanPhamChiTietRepos SanPhamChiTietRepos = new SanPhamChiTietRepos();
        SanPhamRepos SanPhamRepos = new SanPhamRepos();
        public HoaDonCTSer()
        {

        }
        public HoaDonCTSer(IHoaDonCTRepos hoaDonCTRepos, HoaDonRepos hoaDonRepos, SanPhamChiTietRepos sanPhamChiTietRepos, SanPhamRepos sanPhamRepos)
        {
            HoaDonCTRepos = hoaDonCTRepos;
            HoaDonRepos = hoaDonRepos;
            SanPhamChiTietRepos = sanPhamChiTietRepos;
            SanPhamRepos = sanPhamRepos;
        }
        public string AddHoaDonCT(Hoadonct hoadonct)
        {
            if (HoaDonCTRepos.AddHoaDonCT(hoadonct) == 2)
            {
                return "Thêm Thành Công";
            }
            else if (HoaDonCTRepos.AddHoaDonCT(hoadonct) == 1)
            {
                return "Thêm Thất Bại";
            }
            else
            {
                return "Thêm Thất Bại";
            }
        }
        public bool Delete(int id)
        {
            return HoaDonCTRepos.Delete(id);
        }
        public bool Delete1(int id)
        {
            return HoaDonCTRepos.Delete1(id);
        }
        public IEnumerable<Hoadonct> GetRepos()
        {
            return HoaDonCTRepos.GetRepos().ToList();
        }
        public int UpdateHoaDonCT(int id, Hoadonct hoadonct)
        {
            return HoaDonCTRepos.UpdateHoaDonCT(id, hoadonct);
        }
        public bool UpdateHoaDonCT1(int id, string trangthai)
        {
            return HoaDonCTRepos.UpdateHoaDonCT1(id, trangthai);
        }
        public List<HoaDonCT> Getview()
        {
            var joinData = from Sanpham in SanPhamRepos.GetAllSP()
                           join Sanphamchitiet in SanPhamChiTietRepos.GetAllSPCT() on Sanpham.IdSanpham equals Sanphamchitiet.IdSanpham
                           join Mau in SanPhamChiTietRepos.GetAllSPCT_Mau() on Sanphamchitiet.IdMau equals Mau.IdMau
                           join Size in SanPhamChiTietRepos.GetAllSPCT_KichThuoc() on Sanphamchitiet.IdKichthuoc equals Size.IdKichthuoc
                           join Chatlieu in SanPhamChiTietRepos.GetAllSPCT_ChatLieu() on Sanphamchitiet.IdChatlieu equals Chatlieu.IdChatlieu
                           join Hoadonct in HoaDonCTRepos.GetRepos() on Sanphamchitiet.IdSanphamct equals Hoadonct.IdSanphamct
                           join HoaDon in HoaDonRepos.GetALLHoadons() on Hoadonct.IdHoadon equals HoaDon.IdHoadon
                           where (HoaDon.Trangthai == "1")
                           select new HoaDonCT
                           {
                               IdHoaDonCT = Hoadonct.IdHoadonct,
                               IdSanphamct = Sanphamchitiet.IdSanphamct,
                               TenSanPham = Sanpham.Tensanpham,
                               Mau = Mau.Tenmau,
                               Size = Size.Size,
                               ChatLieu = Chatlieu.Tenchatlieu,
                               SoLuong = Sanphamchitiet.Soluong,
                               GiaSanPham = Sanphamchitiet.Dongia,
                               TrangThai = Hoadonct.Trangthai,
                           };
            return joinData.ToList();
        }
    }
}
