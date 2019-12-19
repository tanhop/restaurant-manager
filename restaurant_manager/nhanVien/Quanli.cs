using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace restaurant_manager
{
    static class Quanli
    {
        private static List<Daubep> Daubep;
        private static List<Phucvu> Phucvu;
        private static List<NVketoan> Ketoan;
        private static List<NVtieptan> Tieptan;
        private static List<NhanVien> nhanviens;
        private static string NameNhaHang;

        public static List<Daubep> ListDauBep { get => Daubep; set => Daubep = value; }
        public static List<Phucvu> ListPhucvu { get => Phucvu; set => Phucvu = value; }
        public static List<NVketoan> ListKeToan { get => Ketoan; set => Ketoan = value; }
        public static List<NVtieptan> ListTieptan { get => Tieptan; set => Tieptan = value; }
        public static List<NhanVien> ListNhanvien { get => nhanviens; set => nhanviens = value; }

        
                     
        
        public static void xuat()
        {
            Console.Write("Name nhà hàng: HH Restaurant ");
            Console.WriteLine("\n----------------------------\n");

            Console.WriteLine("===== List Đầu bếp =====\n \n");
            {
                foreach (var x in Daubep)
                    x.xuat();
            }
            Console.WriteLine("\n \n");
            Console.WriteLine("===== List NV kế toán =====\n \n");
            {
                foreach (var x in Ketoan)
                    x.xuat();
            }
            Console.WriteLine("\n \n");
            Console.WriteLine("===== List NV tiếp tân =====\n \n");
            {
                foreach (var x in Tieptan)
                    x.xuat();
            }
            Console.WriteLine("\n \n");
            Console.WriteLine("===== List NV Phục vụ =====\n \n");
            {
                foreach (var x in Phucvu)
                    x.xuat();            
            }
        }
        public static void KhoiTaoListNV()
        {
            Daubep = new List<Daubep>();
            Phucvu = new List<Phucvu>();
            Ketoan = new List<NVketoan>();
            Tieptan = new List<NVtieptan>();
            nhanviens = new List<NhanVien>();

            // tao dau bep
            Daubep db1 = new Daubep();
            db1.maNV = "db1";
            db1.Nvname = "Nguyễn Văn A";
            db1.Day = "1990";
            db1.DayNghi = 0;
            db1.SoNgayTangCa = 2;
            db1.Luongcoban = 8000000;
            Daubep.Add(db1);
            ListNhanvien.Add(db1);

            Daubep db2 = new Daubep();
            db2.maNV = "db2";
            db2.Nvname = "Nguyễn Văn B";
            db2.Day = "1991";
            db2.DayNghi = 0;
            db2.SoNgayTangCa = 3;
            db2.Luongcoban = 8000000;
            Daubep.Add(db2);
            ListNhanvien.Add(db2);

            Daubep db3 = new Daubep();
            db3.maNV = "db3";
            db3.Nvname = "Nguyễn Văn C";
            db3.Day = "1990";
            db3.DayNghi = 0;
            db3.SoNgayTangCa = 1;
            db3.Luongcoban = 7000000;
            Daubep.Add(db3);
            nhanviens.Add(db3);

            Daubep db4 = new Daubep();
            db4.maNV = "db4";
            db4.Nvname = "Nguyễn Văn D";
            db4.Day = "1988";
            db4.DayNghi = 0;
            db4.SoNgayTangCa = 3;
            db4.Luongcoban = 9000000;
            Daubep.Add(db4);
            nhanviens.Add(db4);

            Daubep db5 = new Daubep();
            db5.maNV = "db5";
            db5.Nvname = "Nguyễn Vân H";
            db5.Day = "1985";
            db5.DayNghi = 1;
            db5.SoNgayTangCa = 4;
            db5.Luongcoban = 13000000;
            Daubep.Add(db5);
            nhanviens.Add(db5);

            //tao ke toan

            NVketoan kt1 = new NVketoan();
            kt1.maNV = "kt1";
            kt1.Nvname = "Nguyễn Thị A";
            kt1.Day = "1995";
            kt1.DayNghi = 0;
            kt1.SoNgayTangCa = 1;
            kt1.Luongcoban = 7000000;
            Ketoan.Add(kt1);
            nhanviens.Add(kt1);

            NVketoan kt2 = new NVketoan();
            kt2.maNV = "kt2";
            kt2.Nvname = "Nguyễn Thị B";
            kt2.Day = "1993";
            kt2.DayNghi = 0;
            kt2.SoNgayTangCa = 3;
            kt2.Luongcoban = 9000000;
            Ketoan.Add(kt2);
            nhanviens.Add(kt2);

            NVketoan kt3 = new NVketoan();
            kt3.maNV = "kt3";
            kt3.Nvname = "Nguyễn Thị C";
            kt3.Day = "1990";
            kt3.DayNghi = 1;
            kt3.SoNgayTangCa = 1;
            kt3.Luongcoban = 8000000;
            Ketoan.Add(kt3);
            nhanviens.Add(kt3);

            //tao tiep tan

            NVtieptan tt1 = new NVtieptan();
            tt1.maNV = "tt1";
            tt1.Nvname = "Nguyễn Thành A";
            tt1.Day = "1998";
            tt1.DayNghi = 0;
            tt1.SoNgayTangCa = 2;
            tt1.Luongcoban = 7000000;
            Tieptan.Add(tt1);
            nhanviens.Add(tt1);

            NVtieptan tt2 = new NVtieptan();
            tt2.maNV = "tt2";
            tt2.Nvname = "Nguyễn Thành B";
            tt2.Day = "1997";
            tt2.DayNghi = 1;
            tt2.SoNgayTangCa = 3;
            tt2.Luongcoban = 8000000;
            Tieptan.Add(tt2);
            nhanviens.Add(tt2);

            NVtieptan tt3 = new NVtieptan();
            tt3.maNV = "tt3";
            tt3.Nvname = "Nguyễn Thành C";
            tt3.Day = "1993";
            tt3.DayNghi = 0;
            tt3.SoNgayTangCa = 3;
            tt3.Luongcoban = 9000000;
            Tieptan.Add(tt3);
            nhanviens.Add(tt3);

            NVtieptan tt4 = new NVtieptan();
            tt4.maNV = "tt4";
            tt4.Nvname = "Nguyễn Thành D";
            tt4.Day = "2000";
            tt4.DayNghi = 0;
            tt4.SoNgayTangCa = 2;
            tt4.Luongcoban = 7000000;
            Tieptan.Add(tt4);
            nhanviens.Add(tt4);

            // tao phuc vu

            Phucvu pv1 = new Phucvu();
            pv1.maNV = "pv1";
            pv1.Nvname = "Phạm Văn A";
            pv1.Day = "2000";
            pv1.DayNghi = 0;
            pv1.SoNgayTangCa = 2;
            pv1.Luongcoban = 6000000;
            Phucvu.Add(pv1);
            nhanviens.Add(pv1);


            Phucvu pv2 = new Phucvu();
            pv2.maNV = "pv2";
            pv2.Nvname = "Phạm Văn B";
            pv2.Day = "1999";
            pv2.DayNghi = 0;
            pv2.SoNgayTangCa = 2;
            pv2.Luongcoban = 6500000;
            Phucvu.Add(pv2);
            nhanviens.Add(pv2);

            Phucvu pv3 = new Phucvu();
            pv3.maNV = "pv3";
            pv3.Nvname = "Phạm Văn C";
            pv3.Day = "1997";
            pv3.DayNghi = 1;
            pv3.SoNgayTangCa = 1;
            pv3.Luongcoban = 7000000;
            Phucvu.Add(pv3);
            nhanviens.Add(pv3);

            Phucvu pv4 = new Phucvu();
            pv4.maNV = "pv4";
            pv4.Nvname = "Phạm Văn D";
            pv4.Day = "1994";
            pv4.DayNghi = 2;
            pv4.SoNgayTangCa = 4;
            pv4.Luongcoban = 6300000;
            Phucvu.Add(pv4);
            nhanviens.Add(pv4);

            Phucvu pv5 = new Phucvu();
            pv5.maNV = "pv5";
            pv5.Nvname = "Phạm Văn H";
            pv5.Day = "2001";
            pv5.DayNghi = 0;
            pv5.SoNgayTangCa = 2;
            pv5.Luongcoban = 6500000;
            Phucvu.Add(pv5);
            nhanviens.Add(pv5);

        }
        public static  void AddListNV()
        {
            nhanviens = new List<NhanVien>();
            foreach (var man in Daubep)
            {
                nhanviens.Add(man);
            }
            foreach (var man in Phucvu)
            {
                nhanviens.Add(man);
            }
            foreach (var man in Ketoan)
            {
                nhanviens.Add(man);
            }
            foreach (var man in Tieptan)
            {
                nhanviens.Add(man);
            }
        }

        public static void Findmax()
        {
            NhanVien max = new Daubep();
            max = nhanviens[0];
            for (int i = 1; i < nhanviens.Count; i++)
            {
                if (nhanviens[i].LuongNV() > max.LuongNV())
                    max = nhanviens[i];
            }
            Console.WriteLine("\n \n ------------------ \n \n");
            Console.WriteLine("NV luong cao nhat : ");
            max.xuat();
        }

        public static void xuatNV()
        {
            Console.WriteLine("\n \n ------------------ \n \n");
            Console.WriteLine("Tên nhà hàng: HH restaurant") ;
            Console.WriteLine("Danh sách nhân viên: ");
            foreach (NhanVien man in nhanviens)
                man.xuat();
        }
        public static void sapxep()
        {
            for (int i = 0; i < nhanviens.Count; i++)
                for (int j = i+1; j < nhanviens.Count; j++)
                {
                    if (nhanviens[i].LuongNV() < nhanviens[j].LuongNV())
                    {
                        NhanVien temp = new Daubep();
                        temp = nhanviens[i];
                        nhanviens[i] = nhanviens[j];
                        nhanviens[j] = temp;
                    }
                }
        }
        public static void xoaNV()
        {
            Console.WriteLine("nhập mã số nhân viên muốn xóa: ");
            var maSo = Console.ReadLine();
            var nv = Quanli.ListNhanvien.SingleOrDefault(r => r.maNV == maSo);
            if (nv != null)
            {
                Quanli.ListNhanvien.Remove(nv);
                Console.WriteLine("xóa thành công");
            }
            else
                Console.WriteLine("Không có nhân viên nào có mã số này");
        }

        public static void soSanhLuong()
        {
            Console.Write("nhập mã nhân viên 1: ");
            var ma1 = Console.ReadLine();
            Console.Write("nhập mã nhân viên 2: ");
            var ma2 = Console.ReadLine();
            var nhanVien1 = ListNhanvien.SingleOrDefault(x => x.maNV == ma1);
            var nhanVien2 = ListNhanvien.SingleOrDefault(x => x.maNV == ma2);
            if (nhanVien1 != null && nhanVien2 != null)
            {
                Console.WriteLine($"lương nhân viên: {nhanVien1.Nvname} > lương nhân viên {nhanVien2.Nvname} ? " + (nhanVien1 > nhanVien2));
            }
            else
                Console.WriteLine("Có mã nhân viên không hợp lệ");
        }

        
        /*
        }
        public static void docDataDauBep()       //doc data tu file daubep.txt
        {
            Daubep = new List<Daubep>();
            StreamReader sr = new StreamReader("daubep.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Daubep a = new Daubep();
                a.sTenDauBep = sr.ReadLine();
                a.sTuoiDaubep = sr.ReadLine();
                a.sDayNghi = Convert.ToInt32(sr.ReadLine());
                a.sDayTangca = Convert.ToInt32(sr.ReadLine());
                a.sLuongDB = Convert.ToInt64(sr.ReadLine());
                Daubep.Add(a);
            }
            sr.Close();
        }

        public static void docDataNVKetoan()       //doc data tu file ketoan.txt
        {
            Ketoan = new List<NVketoan>();
            StreamReader sr = new StreamReader("ketoan.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                NVketoan a = new NVketoan();
                a.sTenKT = sr.ReadLine();
                a.sTuoiKT = sr.ReadLine();
                a.sDayNghi = Convert.ToInt32(sr.ReadLine());
                a.sDayTangca = Convert.ToInt32(sr.ReadLine());
                a.sLuongKT = Convert.ToInt64(sr.ReadLine());
                Ketoan.Add(a);
            }
            sr.Close();
        }
        public static void docDataNVtieptan()       //doc data tu file tieptan.txt
        {
            Tieptan = new List<NVtieptan>();
            StreamReader sr = new StreamReader("tieptan.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                NVtieptan a = new NVtieptan();
                a.sTenTieptan = sr.ReadLine();
                a.sTuoiTieptan = sr.ReadLine();
                a.sDayNghi = Convert.ToInt32(sr.ReadLine());
                a.sDayTangca = Convert.ToInt32(sr.ReadLine());
                a.sLuongTT = Convert.ToInt64(sr.ReadLine());

                Tieptan.Add(a);
            }
            sr.Close();
        }
        public static void docDataPhucvu()       //doc data tu file phucvu.txt
        {
            Phucvu = new List<Phucvu>();
            StreamReader sr = new StreamReader("daubep.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                Phucvu a = new Phucvu();
                a.sTenPhucvu = sr.ReadLine();
                a.sTuoiPhucvu = sr.ReadLine();
                a.sDayNghi = Convert.ToInt32(sr.ReadLine());
                a.sDayTangca = Convert.ToInt32(sr.ReadLine());
                a.sLuongPV = Convert.ToInt64(sr.ReadLine());
                Phucvu.Add(a);
            }
            sr.Close();
        }
        */
    }
}
