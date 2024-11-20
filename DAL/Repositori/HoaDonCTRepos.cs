using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositori
{
    internal interface HoaDonCTRepos
    {
        IEnumerable<Hoadonct> GetRepos();
        int AddHoaDonCT(Hoadonct hoadonct);
        int UpdateHoaDonCT(int id, Hoadonct hoadonct);
        bool UpdateHoaDonCT1(int id, string trangthai);
        bool Delete(int id);
        bool Delete1(int id);
    }
}
