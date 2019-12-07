using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace restaurant_manager
{
    static class Menu
    {
        private static List<MonAn> lMonAn;
        private static List<ThucUong> lThucUong;

        public static List<MonAn> dsMonAn { get => lMonAn; set => lMonAn = value; }
        public static List<ThucUong> dsThucUong { get => lThucUong; set => lThucUong = value; }


        public static void xuat()
        {
            Console.WriteLine("=====MENU MÓN ĂN=====\n \n");
            foreach ( eLoaiMon loai in Enum.GetValues(typeof(eLoaiMon)))
            {
                Console.WriteLine(loai + "\n");
                for (int i = 0; i < lMonAn.Count; i++)
                    if (lMonAn[i].loaiMonAn == loai)
                        lMonAn[i].xuat(loai);
                    
                Console.WriteLine();
            }
            Console.WriteLine();

            Console.WriteLine("=====MENU THỨC UỐNG===== \n \n");
            foreach (eLoaiNuoc loai in Enum.GetValues(typeof(eLoaiNuoc)))
            {
                Console.WriteLine(loai + "\n");
                for (int i = 0; i < lThucUong.Count; i++)
                    if (lThucUong[i].loai == loai)
                        lThucUong[i].xuat(loai);
                Console.WriteLine();
            }
        }
        public static void docDataMonAn()       //doc data tu file MonAn.txt
        {
            lMonAn = new List<MonAn>();
            StreamReader sr = new StreamReader("MonAn.txt");
            string line;
            while ((line = sr.ReadLine())!= null)
            {
                MonAn a = new MonAn();
                a.iMa = Convert.ToInt32(line);
                a.loaiMonAn = (eLoaiMon)Enum.Parse(typeof(eLoaiMon), sr.ReadLine());
                a.sTen = sr.ReadLine();
                a.Gia = Convert.ToInt64(sr.ReadLine());
                lMonAn.Add(a);
            }
            sr.Close();
        }

        public static void docDataThucUong()        //doc data tu file ThucUong.txt
        {
            lThucUong = new List<ThucUong>();
            StreamReader sr = new StreamReader("ThucUong.txt");
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                ThucUong a = new ThucUong();
                a.iMa = Convert.ToInt32(line);
                a.loai = (eLoaiNuoc)Enum.Parse(typeof(eLoaiNuoc), sr.ReadLine());
                a.sTen = sr.ReadLine();
                a.Gia = Convert.ToInt64(sr.ReadLine());
                lThucUong.Add(a);
            }
            sr.Close();
        }

        public static void them()
        {
            Console.WriteLine("1. thêm món ăn");
            Console.WriteLine("2. thêm thức uống");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                MonAn a = new MonAn();
                a.nhap();
                Menu.lMonAn.Add(a);
            }
            if (n == 2)
            {
                ThucUong b = new ThucUong();
                b.nhap();
                Menu.lThucUong.Add(b);
            }
        }

        public static void xoa()
        {
            Console.WriteLine("1. xóa món ăn");
            Console.WriteLine("2. xóa thức uống");
            int n = int.Parse(Console.ReadLine());
            if (n == 1)
            {
                Console.WriteLine("nhập mã món cần xóa: ");
                int idMon = int.Parse(Console.ReadLine());
                var mon = Menu.lMonAn.SingleOrDefault(x => x.iMa == idMon);
                if (mon != null)
                    Menu.lMonAn.Remove(mon);
                else
                    Console.WriteLine("Không có món có mã số này");
            }
            if (n == 2)
            {
                Console.WriteLine("nhập mã thức uống cần xóa: ");
                int idThucUong = int.Parse(Console.ReadLine());
                var thucUong = Menu.lThucUong.SingleOrDefault(x => x.iMa == idThucUong);
                if (thucUong != null)
                    Menu.lThucUong.Remove(thucUong);
                else
                    Console.WriteLine("Không có thức uống có mã số này");
            }

        }
    }
}
