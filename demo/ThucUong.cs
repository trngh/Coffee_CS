using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class ThucUong
    {
        public int mathucuong { get; set; }
        public string tenthucuong { get; set; }
        public int giatien { get; set; }
        public ThucUong(int mathucuong, string tenthucuong, int giatien)
        {
            this.mathucuong = mathucuong;
            this.tenthucuong = tenthucuong;
            this.giatien = giatien;
        }
        public ThucUong(ThucUong tu)
        {
            this.mathucuong = tu.mathucuong;
            this.tenthucuong = tu.tenthucuong;
            this.giatien = tu.giatien;
        }
    }
}
