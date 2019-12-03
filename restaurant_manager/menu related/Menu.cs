using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    static class Menu
    {
        private static List<MonAn> lMonAn;
        private static List<ThucUong> lThucUong;

        public static List<MonAn> dsMonAn { get => lMonAn; set => lMonAn = value; }
        public static List<ThucUong> dsThucUong { get => lThucUong; set => lThucUong = value; }


        public static void nhap() 
        {
            lMonAn = new List<MonAn>();
            lThucUong = new List<ThucUong>();
            Console.WriteLine("nhap so mon an trong menu: ");
            int nThucAn = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < nThucAn; i++)
            {
                MonAn mon = new MonAn();
                mon.nhap();
                lMonAn.Add(mon);
            }


            Console.WriteLine("nhap so thuc uong trong menu: ");
            int nThucUong = Convert.ToInt32(Console.ReadLine());
            for (int i =0;i<nThucUong;i++)
            {
                ThucUong uong = new ThucUong();
                uong.nhap();
                lThucUong.Add(uong);
            }
        }
        public static void xuat()
        {
            foreach ( eLoaiMon loai in Enum.GetValues(typeof(eLoaiMon)))
            {
                for (int i = 0; i < lMonAn.Count; i++)
                    if (lMonAn[i].loaiMonAn == loai)
                        lMonAn[i].xuat(loai);
            }

            foreach (eLoaiNuoc loai in Enum.GetValues(typeof(eLoaiNuoc)))
            {
                for (int i = 0; i < lThucUong.Count; i++)
                    if (lThucUong[i].loai == loai)
                        lThucUong[i].xuat(loai);
            }
        }
        
    }
}
