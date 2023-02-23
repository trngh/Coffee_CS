using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class NhanVien_KhachHang
    {
        public KhachHang kh { get; set; }
        public NhanVien nv { get; set; }
        public NhanVien_KhachHang(KhachHang kh, NhanVien nv)
        {
            this.kh = kh;
            this.nv = nv;
        }
    }
}
