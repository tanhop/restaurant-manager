using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    enum eLoaiNuoc { tra, thuc_uong_viet_nam, nuoc_ep, sinh_to, thuc_uong_khac}
    class ThucUong
    {
        private int iMaThucUong;
        private eLoaiNuoc loaiNuoc;
        private string sTenThucUong;
        private double dGia;

        public int maThucUong { get => iMaThucUong; set => iMaThucUong = value; }
        public eLoaiNuoc loai { get => loaiNuoc; set => loaiNuoc = value; }
        public string tenThucUong { get => sTenThucUong; set => sTenThucUong = value; }
        public double gia { get => dGia; set => dGia = value; }

        public ThucUong() { }

        ~ThucUong() { }

        public void nhap()
        {
            Console.WriteLine("nhap ma thuc uong: ");
            iMaThucUong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap loai nuoc: ");
            var loaiNuocCount = Enum.GetNames(typeof(eLoaiNuoc)).Length;
            for (int i = 0; i < loaiNuocCount; i++)
                Console.WriteLine(i + "/ " + Enum.GetName(typeof(eLoaiNuoc),i));
            loaiNuoc = (eLoaiNuoc)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten thuc uong: ");
            sTenThucUong = Console.ReadLine();
            Console.WriteLine("nhap gia thuc uong: ");
            dGia = Convert.ToDouble(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("ma thuc uong: " + iMaThucUong);
            Console.WriteLine("ten thuc uong: " + sTenThucUong);
            Console.WriteLine("loai thuc uong: " + loai);
            Console.WriteLine("gia thuc uong: " + dGia);
        }
    }
}
