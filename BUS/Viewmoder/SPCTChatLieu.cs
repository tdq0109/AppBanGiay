using DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Viewmoder
{
    public partial class SPCTChatLieu
    {
        public int Id { get; set; }
        public int IdChatlieu { get; set; }
        public int IdSanphamct { get; set; }

        public virtual Chatlieu IdhangNavigation { get; set; } = null!;
        public virtual Sanphamct IdsachctNavigation { get; set; } = null!;
    }
}
