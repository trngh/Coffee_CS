using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class CongViec_BoPhan
    {
        public CongViec congViec { get; set; }
        public BoPhan boPhan { get; set; }
        public CongViec_BoPhan(CongViec congViec, BoPhan boPhan)
        {
            this.congViec = congViec;
            this.boPhan = boPhan;
        }
    }
}
