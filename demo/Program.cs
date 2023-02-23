using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace demo
{
    class Program
    {
        static List<BoPhan> dsBophan = new List<BoPhan>();
        static List<NhanVien> dsNhanvien = new List<NhanVien>();
        static List<KhachHang> dsKhachhang = new List<KhachHang>();
        static List<ThucUong> dsThucuong = new List<ThucUong>();
        static List<CongViec> dsCongviec = new List<CongViec>();
        static List<HoaDon> dsHoadon = new List<HoaDon>();
        static List<NhanVien_KhachHang> dsNhanvien_Khachhang = new List<NhanVien_KhachHang>();
        static List<HoaDon_ThucUong> dsHoadon_thucuong = new List<HoaDon_ThucUong>();
        static List<CongViec_BoPhan> dsCongViec_BoPhan = new List<CongViec_BoPhan>();
        public static void TaoDSBoPhan()
        {
            dsBophan.Add(new BoPhan(0, "thu ngan"));
            dsBophan.Add(new BoPhan(1, "pha che"));
            dsBophan.Add(new BoPhan(2, "phuc vu"));
        }
        public static void TaoDSNhanVien()
        {
            dsNhanvien.Add(new NhanVien(0, "Hoang Van An", dsBophan[0]));
            dsNhanvien.Add(new NhanVien(1, "Trinh Ngoc Ha", dsBophan[0]));
            dsNhanvien.Add(new NhanVien(2, "Nguyen Thi Nhu Y", dsBophan[0]));
            dsNhanvien.Add(new NhanVien(3, "Ho Thanh Tam", dsBophan[1]));
            dsNhanvien.Add(new NhanVien(4, "Do Thu Thuy", dsBophan[1]));
            dsNhanvien.Add(new NhanVien(5, "Nguyen Thi Nhu Phuong", dsBophan[1]));
            dsNhanvien.Add(new NhanVien(6, "Nguyen Hong Ngoc", dsBophan[2]));
            dsNhanvien.Add(new NhanVien(7, "Phan Thi Huynh Tram", dsBophan[2]));
            dsNhanvien.Add(new NhanVien(8, "Nguyen Thanh Tam", dsBophan[2]));
            dsNhanvien.Add(new NhanVien(9, "Nguyen Trung Kien", dsBophan[2]));
            dsBophan[0].laptruongbophan(dsNhanvien[0]);
            dsBophan[1].laptruongbophan(dsNhanvien[4]);
            dsBophan[2].laptruongbophan(dsNhanvien[5]);
        }
        public static void TaoDSKhachHang()
        {
            dsKhachhang.Add(new KhachHang(0, "Le Trung Nghia", "0352180428"));
            dsKhachhang.Add(new KhachHang(1, "Le Trung Truc", "0352180465"));
            dsKhachhang.Add(new KhachHang(2, "Le Minh Tri", "0352180111"));
            dsKhachhang.Add(new KhachHang(3, "Do Minh Tan", "0352180123"));
        }
        public static void TaoDSHoaDon_KhachHang()
        {
            dsHoadon.Add(new HoaDon(0, "24/11/2022", 100000, dsKhachhang[0]));
            dsHoadon.Add(new HoaDon(1, "24/11/2022", 50000, dsKhachhang[0]));
            dsHoadon.Add(new HoaDon(2, "24/11/2022", 70000, dsKhachhang[1]));
            dsHoadon.Add(new HoaDon(3, "24/11/2022", 100000, dsKhachhang[1]));
            dsHoadon.Add(new HoaDon(4, "24/11/2022", 80000, dsKhachhang[2]));
            dsHoadon.Add(new HoaDon(5, "24/11/2022", 40000, dsKhachhang[2]));
            dsHoadon.Add(new HoaDon(6, "24/11/2022", 50000, dsKhachhang[2]));
            dsHoadon.Add(new HoaDon(7, "24/11/2022", 90000, dsKhachhang[3]));
            dsHoadon.Add(new HoaDon(8, "24/11/2022", 90000, dsKhachhang[3]));
        }
        public static void TaoDSCongViec()
        {
            dsCongviec.Add(new CongViec(0, "pha che", dsBophan[1]));
            dsCongviec.Add(new CongViec(1, "kiem tra thuc uong", dsBophan[1]));
            dsCongviec.Add(new CongViec(2, "in hoa don va thu tien", dsBophan[0]));
            dsCongviec.Add(new CongViec(3, "phuc vu", dsBophan[2]));
            dsCongviec.Add(new CongViec(4, "don dep", dsBophan[2]));
        }
        public static void TaoDSThucUong()
        {
            dsThucuong.Add(new ThucUong(0, "ca phe hat rang xay", 15000));
            dsThucuong.Add(new ThucUong(1, "Latte", 15000));
            dsThucuong.Add(new ThucUong(2, "Capuchino", 15000));
            dsThucuong.Add(new ThucUong(3, "Tra sua truyen thong", 15000));
            dsThucuong.Add(new ThucUong(4, "Matcha da xay", 15000));
            dsThucuong.Add(new ThucUong(5, "Tra sua chocolate", 15000));
            dsThucuong.Add(new ThucUong(6, "Tran chau duong den", 15000));
            dsThucuong.Add(new ThucUong(7, "Tran chau duong trang", 15000));
        }
        public static void TaoDSHoaDon_ThucUong()
        {
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[0], dsThucuong[0]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[0], dsThucuong[5]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[1], dsThucuong[5]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[2], dsThucuong[1]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[2], dsThucuong[3]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[2], dsThucuong[4]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[3], dsThucuong[6]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[3], dsThucuong[2]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[4], dsThucuong[7]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[5], dsThucuong[1]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[5], dsThucuong[7]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[6], dsThucuong[2]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[7], dsThucuong[2]));
            dsHoadon_thucuong.Add(new HoaDon_ThucUong(dsHoadon[8], dsThucuong[3]));
        }
        public static void TaoDSNhanVien_KhachHang()
        {
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[0], dsNhanvien[0]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[0], dsNhanvien[3]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[0], dsNhanvien[6]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[1], dsNhanvien[1]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[1], dsNhanvien[4]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[1], dsNhanvien[7]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[2], dsNhanvien[2]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[2], dsNhanvien[5]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[2], dsNhanvien[8]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[3], dsNhanvien[1]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[3], dsNhanvien[5]));
            dsNhanvien_Khachhang.Add(new NhanVien_KhachHang(dsKhachhang[3], dsNhanvien[9]));
        }
        public static void TaoDSCongViec_BoPhan()
        {
            dsCongViec_BoPhan.Add(new CongViec_BoPhan(dsCongviec[0], dsBophan[1]));
            dsCongViec_BoPhan.Add(new CongViec_BoPhan(dsCongviec[1], dsBophan[1]));
            dsCongViec_BoPhan.Add(new CongViec_BoPhan(dsCongviec[2], dsBophan[0]));
            dsCongViec_BoPhan.Add(new CongViec_BoPhan(dsCongviec[3], dsBophan[2]));
            dsCongViec_BoPhan.Add(new CongViec_BoPhan(dsCongviec[4], dsBophan[2]));
        }
        public static void Cau1()
        {
            var soHoaDon_ThucUong = from p in dsHoadon_thucuong
                                    group p by p.tu.tenthucuong into g
                                    select new { tenthucuong = g.Key, sohoadon = g.Count() };
            foreach (var thucuong in soHoaDon_ThucUong)
            {
                Console.WriteLine($"Thuc uong {thucuong.tenthucuong} co {thucuong.sohoadon} hoa don.");
            }
            var dsThucuong_HoaDon = from tu in soHoaDon_ThucUong where tu.sohoadon == soHoaDon_ThucUong.Max(shd => shd.sohoadon) select tu;
            Console.WriteLine("Thuc uong duoc goi nhieu nhat: ");
            foreach (var thucuong in dsThucuong_HoaDon)
            {
                Console.WriteLine($"Thuc uong {thucuong.tenthucuong} co {thucuong.sohoadon} hoa don.");
            }
        }
        public static void Cau2()
        {
            int cnt = dsNhanvien.Distinct().Count();
            Console.WriteLine($"Quan co {cnt} nhan vien");
        }
        public static void Cau3()
        {
            int cnt = dsNhanvien.Count(n => n.BOPHAN == dsBophan[0]);
            Console.WriteLine($"Co {cnt} nhan vien thuoc bo phan thu ngan");
            cnt = dsNhanvien.Count(n => n.BOPHAN == dsBophan[1]);
            Console.WriteLine($"Co {cnt} nhan vien thuoc bo phan pha che");
            cnt = dsNhanvien.Count(n => n.BOPHAN == dsBophan[2]);
            Console.WriteLine($"Co {cnt} nhan vien thuoc bo phan phuc vu");
        }
        public static void Cau4()
        {
            // nhom cac hoa don cung 1 khach hang va tinh tong gia tri hoa don
            var ds = from d in dsHoadon
                     group d by d.kh into g
                     select new { kh = g.Key, tongtien = g.Sum(n=>n.giatrihoadon) };
            // sap xep theo tong gia tri hoa don tu cao den thap (descending) || tang dan (asscending)
            var hoadon = from d in ds orderby d.tongtien descending select d;
            Console.WriteLine("Danh sach khach hang co tong gia tri cac hoa don tu cao den thap:");
            foreach (var d in hoadon)
            {
                Console.WriteLine($"{d.kh.tenkhachhang}     {d.tongtien}");
            }
        }
        public static void Cau5()
        {
            // nhom cac hoa don cung 1 khach hang va tinh tong gia tri hoa don
            var ds = from d in dsHoadon
                     group d by d.kh into g
                     select new { kh = g.Key, tongtien = g.Sum(n => n.giatrihoadon) };
            // sap xep theo tong gia tri hoa don tu cao den thap (descending) || tang dan (asscending)
            var hoadon = from d in ds orderby d.tongtien descending select d;
            var kh = from d in hoadon select new { tenkhachhang = d.kh.tenkhachhang, type = d.tongtien > 150000 ? "VIP" : "normal" };
            Console.WriteLine("Phan loai cac khach hang da mua tai quan: ");
            foreach (var d in kh)
            {
                Console.WriteLine($"Khach hang: {d.tenkhachhang}    type: {d.type}");
            }
        }
        public static void Cau6()
        {
            var nvphache = from d in dsNhanvien_Khachhang where (d.kh == dsKhachhang[0] && d.nv.BOPHAN == dsBophan[1]) select d;
            var nvphucvu = from d in dsNhanvien_Khachhang where (d.kh == dsKhachhang[0] && d.nv.BOPHAN == dsBophan[2]) select d;
            var nvthungan = from d in dsNhanvien_Khachhang where (d.kh == dsKhachhang[0] && d.nv.BOPHAN == dsBophan[0]) select d;
            var phache_phucvu=(nvphache.Concat(nvphucvu)).Concat(nvthungan);
            Console.WriteLine("Cac nhan vien da phuc vu khach hang: Le Trung Nghia");
            foreach (var d in phache_phucvu)
            {
                Console.WriteLine(d.nv.tennhanvien);
            }

        }
        public static void Cau7()
        {
            Console.WriteLine("Sap xep cac nhan vien cua quan theo ten: ");
            var nhanvien = from p in dsNhanvien orderby p.tennhanvien ascending select p;
            foreach(var d in nhanvien)
            {
                Console.WriteLine(d.tennhanvien);
            }
        }
        public static void Cau8()
        {
            var orders =
                from c in dsHoadon
                where c.giatrihoadon >= 70000
                select new { c.kh.tenkhachhang, c.mahoadon, c.giatrihoadon, c.ngayinhoadon};
            Console.WriteLine("Thong tin cac hoa don co gia tri lon hon 70000: ");
            foreach (var d in orders)
            {
                Console.WriteLine($"Ten khach hang: {d.tenkhachhang}    " +
                    $"Ma hoa don: {d.mahoadon}    " +
                    $"Gia tri hoa don: {d.giatrihoadon}     Ngay in hoa don: {d.ngayinhoadon}");
            }
        }
        public static void Cau9()
        {
            //thong ke so luong thuc uong da ban
            var ds = from p in dsHoadon_thucuong group p by p.tu.tenthucuong into g select new { tenthucuong = g.Key, soluong = g.Count() };
            var ThucuongMin = from p in ds where p.soluong==ds.Min(n=>n.soluong) select p;
            Console.WriteLine("Thuc uong it luot mua nhat: ");
            foreach (var p in ThucuongMin)
            {
                Console.WriteLine(p.tenthucuong);
            }

        }
        public static void Cau10()
        {
            var khachhang = (from p in dsHoadon select p.kh).Distinct();
            foreach (var p in khachhang)
            {
                Console.WriteLine(p.tenkhachhang);
            }
        }
        static void Main(string[] args)
        {
            TaoDSBoPhan();
            TaoDSNhanVien();
            TaoDSKhachHang();
            TaoDSHoaDon_KhachHang();
            TaoDSCongViec();
            TaoDSThucUong();
            TaoDSHoaDon_ThucUong();
            TaoDSNhanVien_KhachHang();
            //cho biet thuc uong duoc mua nhieu nhat (Grouping Operators)
            //Cau1();
            //so luong nhan vien cua quan (Aggregate Operators)
            //Cau2();
            //so luong nhan vien cua tung bo phan (Aggregate Operators)
            //Cau3();
            //sap xep danh sach cac khach hang theo so tien khach hang da mua tang/giam dan (Conversion Operators)
            //Cau4();
            //cho biet cac khach hang co thuoc dang VIP hay khong (tong gia tri mua hang >150000 : VIP) (Generation Operators)
            //Cau5();
            //cho biet cac nhan vien da phuc vu khach hang Le Trung Nghia (Miscellaneous Operators)
            //Cau6();
            //sap xep cac nhan vien theo ten (Ordering Operators)
            //Cau7();
            //cho biet thong tin cac hoa don co gia tri lon hon 70000 (Projection Operators)
            //Cau8();
            //cho biet thuc uong duoc mua it nhat(Restriction Operators)
            //Cau9();
            //danh sach cac khach hang da mua tai quan (Set Operator)
            Cau10();
            Console.ReadKey();
        }
    }
}
