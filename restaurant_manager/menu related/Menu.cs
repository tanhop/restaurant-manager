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
                a.dGia = Convert.ToDouble(sr.ReadLine());
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
                a.dGia = Convert.ToDouble(sr.ReadLine());
                lThucUong.Add(a);
            }
            sr.Close();
        }
    }
}
