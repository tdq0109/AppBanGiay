using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SHOE.Controller.IRepository
{
    public interface IKhuyenMaiRepository
    {
        public bool AddKM(Khuyenmai khuyenmai);
        public bool RemoveKM(Khuyenmai khuyenmai);
        public bool UpdateKM(Khuyenmai khuyenmai);
        public List<Khuyenmai> GetAllKM();
    }
}
