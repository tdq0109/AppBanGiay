using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SHOE.Controller.IRepository
{
    internal interface IThongKeRepository
    {
        public bool AddHD(Hoadonct hdct_2);
        public bool RemoveHD(Hoadonct hdct_2);
        public bool UpdateHD(Hoadonct hdct_2);
        public List<Hoadonct> GetAllHDct();
    }
}
