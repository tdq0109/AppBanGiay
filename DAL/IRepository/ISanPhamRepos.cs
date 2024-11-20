using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    public interface ISanPhamRepos
    {
        int AddSP(Sanpham kh);
        bool DeleteSP(int id);
        int UpdateSP(int id, Sanpham sp);
        IEnumerable<Sanpham> GetAllSP();
        List<Sanpham> GetSearch(string searchText); 
    }
}
