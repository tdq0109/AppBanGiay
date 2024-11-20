using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_SHOE.Controller.IRepository
{
    internal interface IKhachHangRepository
    {

        public bool AddKH(Khachhang kh);
        public bool RemoveKH(Khachhang kh);
        public bool UpdateKH(Khachhang kh);
        public List<Khachhang> GetAllKH();
    }
}
