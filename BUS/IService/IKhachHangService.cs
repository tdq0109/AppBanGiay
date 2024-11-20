
using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SHOE.Controller.IService
{
    internal interface IKhachHangService
    {
        public string Add(Khachhang kh);
        public string Remove(Khachhang kh);

        public string Update(Khachhang kh);

        public List<Khachhang> GetAll(string search);

    }
}
