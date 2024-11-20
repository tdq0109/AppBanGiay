using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SHOE.Controller.IService
{
    public interface INhanvienService
    {
        public string Add(Nhanvien nv);
        public string Remove(Nhanvien nv);

        public string Update(Nhanvien nv);


        public List<Chucvu> GetChucvus();

        public List<Nhanvien> GetAll(string search);
    }
}
