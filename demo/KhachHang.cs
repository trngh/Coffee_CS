using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class KhachHang
    {
        public int makhachhang { get; set; }
        public string tenkhachhang { get; set; }
        public string sdt { get; set; }
        public KhachHang(int makhachhang, string tenkhachhang, string sdt)
        {
            this.makhachhang = makhachhang;
            this.tenkhachhang = tenkhachhang;
            this.sdt = sdt;
        }
        public KhachHang(KhachHang kh)
        {
            this.makhachhang = kh.makhachhang;
            this.tenkhachhang = kh.tenkhachhang;
            this.sdt = kh.sdt;
        }
    }
}
