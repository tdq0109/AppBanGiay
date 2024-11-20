using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.IRepository
{
    internal interface ISanPhamCTRepos
    {
        int AddSPCT(Sanphamct spct);
        bool DeleteSPCT(int id);
        bool DeleteSPCT_M(int id);
        bool DeleteSPCT_CL(int id);
        bool DeleteSPCT_S(int id);
        int UpdateSPCT(int id, Sanphamct sp);
        IEnumerable<Sanphamct> GetAllSPCT();
        List<Sanphamct> GetSearch(string searchText);
    }
}
