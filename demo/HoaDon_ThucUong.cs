using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class HoaDon_ThucUong
    {
        public HoaDon hd { get; set; }
        public ThucUong tu { get; set; }
        public HoaDon_ThucUong(HoaDon hd, ThucUong tu)
        {
            this.hd = hd;
            this.tu = tu;
        }
    }
}
