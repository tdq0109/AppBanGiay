using DAL.Context;
using DAL.IRepository;
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositori
{
    public class HoaDonRepos : IHoaDonRepos
    {
        DBContext _Context = new DBContext();
        public HoaDonRepos()
        {

        }
        public HoaDonRepos(DBContext context)
        {
            _Context = context;
        }
        public bool AddHoaDon(Hoadon hoadon)
        {
            _Context.Hoadons.Add(hoadon);
            _Context.SaveChanges();
            return true;
        }
        public IEnumerable<Hoadon> GetALLHoadons()
        {
            return _Context.Hoadons.ToList();
        }
        public bool UpdateHoaDon(int id)
        {
            try
            {
                var exist = _Context.Hoadons.Find(id);
                exist.Trangthai = "hoá Đơn Chưa Có Sản Phẩm";
                _Context.Hoadons.Update(exist);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
        public bool DeleteHoaDon(int id)
        {
            try
            {
                var exist = _Context.Hoadons.Find(id);

                _Context.Hoadons.Remove(exist);
                _Context.SaveChanges();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
