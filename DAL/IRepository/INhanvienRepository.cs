using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SHOE.Controller.IRepository
{
    internal interface INhanvienRepository
    {

        public bool AddNV(Nhanvien nv);
        public bool RemoveNV(Nhanvien nv);
        public bool UpdateNV(Nhanvien nv);

        public List<Chucvu> GetChucvus();
        public List<Nhanvien> GetAllNV();
    }
}
