using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SHOE.Controller.IService
{
    internal interface IKhuyenMaiService
    {
        public string Add(Khuyenmai km);
        public string Update(Khuyenmai km);

        public string Delete(Khuyenmai km);

        public List<Khuyenmai> GetAll(string search);
    }
}
