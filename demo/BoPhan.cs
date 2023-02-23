using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    public class BoPhan
    {
        public int mabophan { get; set; }
        public string tenbophan { get; set; }
        public NhanVien truongbophan { get; set; }
        public BoPhan(int mabophan, string tenbophan, NhanVien truongbophan=null)
        {
            this.mabophan = mabophan;
            this.tenbophan = tenbophan;
            this.truongbophan = truongbophan;
        }
        public BoPhan(BoPhan bp)
        {
            mabophan = bp.mabophan;
            tenbophan = bp.tenbophan;
            truongbophan = bp.truongbophan;
        }
        public void laptruongbophan(NhanVien truongbophan)
        {
            this.truongbophan = truongbophan;
        }
    }
}
