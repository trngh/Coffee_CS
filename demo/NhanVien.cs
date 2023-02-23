using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class NhanVien
    {
        public int manhanvien { get; set; }
        public string tennhanvien { get; set; }
        public BoPhan BOPHAN { get; set; }
        public NhanVien(int manhanvien, string tennhanvien, BoPhan bOPHAN)
        {
            this.manhanvien = manhanvien;
            this.tennhanvien = tennhanvien;
            BOPHAN = bOPHAN;
        }
        public NhanVien(NhanVien nv)
        {
            if (nv != null)
            {
                manhanvien = nv.manhanvien;
                tennhanvien = nv.tennhanvien;
                BOPHAN = nv.BOPHAN;
            }
        }
    }
}
