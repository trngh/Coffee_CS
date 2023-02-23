using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class CongViec
    {
        public int macongviec { get; set; }
        public string noidungcongviec { get; set; }
        public BoPhan bophan { get; set; }
        public CongViec(int macongviec, string noidungcongviec, BoPhan bophan)
        {
            this.macongviec = macongviec;
            this.noidungcongviec = noidungcongviec;
            this.bophan = bophan;
        }
    }
}
