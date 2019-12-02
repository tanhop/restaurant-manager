using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    enum eLoaiMon { khai_vi, goi, cuon, bun_mi_nuoc, bun_mi_kho, pho_mien, mam, com_xoi, rau_nam_dau_hu, lau }
    class MonAn
    {
        private int iMaMonAn;
        private string sTenMonAn;
        private double dGiaMon;
        private eLoaiMon loaiMon;

        public int maMonAn { get => iMaMonAn; set => iMaMonAn = value; }
        public string tenMonAn { get => sTenMonAn; set => sTenMonAn = value; }
        public double giaMonAn { get => dGiaMon; set => dGiaMon = value; }
        public eLoaiMon loaiMonAn { get => loaiMon; set => loaiMon = value; }
        public MonAn() { }
        public MonAn(int maMon, string tenMon, double giaMon)
        {
            iMaMonAn = maMon;
            sTenMonAn = tenMon;
            dGiaMon = giaMon;
            
        }

        public void nhap()
        {
            Console.WriteLine("nhap ma mon an: ");
            iMaMonAn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap loai mon an: ");
            var demLoaiMon = Enum.GetNames(typeof(eLoaiMon)).Length;
            for (int i = 0; i < demLoaiMon; i++)
                Console.WriteLine(i + "/ " + Enum.GetName(typeof(eLoaiMon), i));
            loaiMonAn = (eLoaiMon)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten mon an: ");
            sTenMonAn = Console.ReadLine();
            Console.WriteLine("nhap gia mon an: ");
            dGiaMon = Convert.ToDouble(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("ma mon an: ", iMaMonAn);
            Console.WriteLine("ten mon an: ", sTenMonAn);
            Console.WriteLine("gia mon an: ", dGiaMon);
        }


    }
}
