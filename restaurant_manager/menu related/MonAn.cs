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
        private long giaMonAn;
        private eLoaiMon loaiMon;
        private int soLuong;

        public int iMa { get => maMonAn; set => maMonAn = value; }
        public string sTen { get => tenMonAn; set => tenMonAn = value; }
        public long Gia { get => giaMonAn; set => giaMonAn = value; }
        public eLoaiMon loaiMonAn { get => loaiMon; set => loaiMon = value; }
        public int luong { get => soLuong; set => soLuong = value; }
        public MonAn() { }
        public MonAn(int maMon, eLoaiMon loai, string tenMon, long giaMon)
        {
            iMa = maMon;
            loaiMon = loai;
            sTen = tenMon;
            Gia = giaMon;
        }

        public void nhap()
        {
            Console.WriteLine("nhập mã món ăn: ");
            maMonAn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhập loại món ăn: ");
            var demLoaiMon = Enum.GetNames(typeof(eLoaiMon)).Length;
            for (int i = 0; i < demLoaiMon; i++)
                Console.WriteLine(i + "/ " + Enum.GetName(typeof(eLoaiMon), i));
            loaiMon = (eLoaiMon)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhập tên món ăn: ");
            tenMonAn = Console.ReadLine();
            Console.WriteLine("nhập giá món ăn: ");
            giaMonAn = Convert.ToInt64(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("mã món ăn: "+ maMonAn);
            Console.WriteLine("loại món ăn "+ loaiMon);
            Console.WriteLine("tên món ăn: "+ tenMonAn);
            Console.WriteLine("giá món ăn: "+ giaMonAn);
        }
        public void xuat(eLoaiMon loai)
        {
            if(loaiMon == loai)
            {
                Console.WriteLine("mã món ăn: "+ maMonAn);
                Console.WriteLine("tên món ăn: "+ tenMonAn);
                Console.WriteLine("giá món ăn: "+ giaMonAn);
            }
        }

    }
}
