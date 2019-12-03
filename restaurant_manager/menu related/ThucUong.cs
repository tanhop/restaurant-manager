using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    enum eLoaiNuoc { tra, thuc_uong_viet_nam, nuoc_ep, sinh_to, thuc_uong_khac}
    class ThucUong: FoodnDrinks
    {
        private int maThucUong;
        private eLoaiNuoc loaiNuoc;
        private string tenThucUong;
        private double giaThucUong;

        public int iMa { get => maThucUong; set => maThucUong = value; }
        public eLoaiNuoc loai { get => loaiNuoc; set => loaiNuoc = value; }
        public string sTen { get => tenThucUong; set => tenThucUong = value; }
        public double dGia { get => giaThucUong; set => giaThucUong = value; }

        public ThucUong() { }

        ~ThucUong() { }

        public void nhap()
        {
            Console.WriteLine("nhap ma thuc uong: ");
            maThucUong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap loai nuoc: ");
            var loaiNuocCount = Enum.GetNames(typeof(eLoaiNuoc)).Length;
            for (int i = 0; i < loaiNuocCount; i++)
                Console.WriteLine(i + "/ " + Enum.GetName(typeof(eLoaiNuoc),i));
            loaiNuoc = (eLoaiNuoc)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten thuc uong: ");
            tenThucUong = Console.ReadLine();
            Console.WriteLine("nhap gia thuc uong: ");
            giaThucUong = Convert.ToDouble(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("ma thuc uong: " + maThucUong);
            Console.WriteLine("ten thuc uong: " + tenThucUong);
            Console.WriteLine("loai thuc uong: " + loai);
            Console.WriteLine("gia thuc uong: " + giaThucUong);
        }
    }
}
