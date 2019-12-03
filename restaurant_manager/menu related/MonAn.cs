using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    enum eLoaiMon { Khai_vị, Gỏi, Cuốn, Bún_mì_nước, Bún_mì_khô, Miến_mì, Mâm, Cơm_xôi, Rau_nấm_đậu_hũ, Né , Tiềm , Lẩu }
    class MonAn : FoodnDrinks
    {
        private int maMonAn;
        private string tenMonAn;
        private double giaMonAn;
        private eLoaiMon loaiMon;
        private int soLuong;

        public int iMa { get => maMonAn; set => maMonAn = value; }
        public string sTen { get => tenMonAn; set => tenMonAn = value; }
        public double dGia { get => giaMonAn; set => giaMonAn = value; }
        public eLoaiMon loaiMonAn { get => loaiMon; set => loaiMon = value; }
        public int luong { get => soLuong; set => soLuong = value; }
        public MonAn() { }
        public MonAn(int maMon, eLoaiMon loai, string tenMon, double giaMon)
        {
            iMa = maMon;
            loaiMon = loai;
            sTen = tenMon;
            dGia = giaMon;
        }

        public void nhap()
        {
            Console.WriteLine("nhap ma mon an: ");
            maMonAn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap loai mon an: ");
            var demLoaiMon = Enum.GetNames(typeof(eLoaiMon)).Length;
            for (int i = 0; i < demLoaiMon; i++)
                Console.WriteLine(i + "/ " + Enum.GetName(typeof(eLoaiMon), i));
            loaiMon = (eLoaiMon)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten mon an: ");
            tenMonAn = Console.ReadLine();
            Console.WriteLine("nhap gia mon an: ");
            giaMonAn = Convert.ToDouble(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("ma mon an: "+ maMonAn);
            Console.WriteLine("loai mon an: "+ loaiMon);
            Console.WriteLine("ten mon an: "+ tenMonAn);
            Console.WriteLine("gia mon an: "+ giaMonAn);
        }
        public void xuat(eLoaiMon loai)
        {
            if(loaiMon == loai)
            {
                Console.WriteLine("ma mon an: "+ maMonAn);
                Console.WriteLine("ten mon an: "+ tenMonAn);
                Console.WriteLine("gia mon an: "+ giaMonAn);
            }
        }

    }
}
