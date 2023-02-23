using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class HoaDon
    {
        public int mahoadon { get; set; }
        public string ngayinhoadon { get; set; }
        public int giatrihoadon { get; set; }
        public KhachHang kh { get; set; }
        public HoaDon(int mahoadon, string ngayinhoadon, int giatrihoadon, KhachHang kh)
        {
            this.mahoadon = mahoadon;
            this.ngayinhoadon = ngayinhoadon;
            this.giatrihoadon = giatrihoadon;
            this.kh = kh;
        }
        public HoaDon(HoaDon hd)
        {
            this.mahoadon = hd.mahoadon;
            this.ngayinhoadon = hd.ngayinhoadon;
            this.giatrihoadon = hd.giatrihoadon;
            this.kh=hd.kh;
        }
    }
}
