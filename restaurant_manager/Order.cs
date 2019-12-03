using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class Order
    {
        private List<MonAn> lMon;
        private List<ThucUong> lNuoc;
        private int soNguoi;
        private double giaTien;
      
        public int nguoi { get => soNguoi; set => soNguoi = value; }
        public List<MonAn> mon { get => lMon; set => lMon = value; }
        public List<ThucUong> nuoc { get => lNuoc; set => lNuoc = value; }
        public double tien { get => giaTien; set => giaTien = value; }

        public Order()
        {
            lMon = new List<MonAn>();
            lNuoc = new List<ThucUong>();
        }
        public void nhap()
        {
            Console.WriteLine("nhap so nguoi: ");
            soNguoi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap so mon can dat: ");
            int nMon = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i<nMon;i++)
            {
                MonAn a = new MonAn();
                Console.WriteLine("nhap ma mon: ");
                int ma = Convert.ToInt32(Console.ReadLine());
                foreach(MonAn m in Menu.dsMonAn)
                {
                    if (m.iMa == ma)
                        a = m;
                }
                Console.WriteLine("nhap so luong: ");
                a.luong = Convert.ToInt32(Console.ReadLine());
                lMon.Add(a);
            }


            Console.WriteLine("nhap so thuc uong can dat: ");
            int nNuoc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nNuoc; i++)
            {
                ThucUong b = new ThucUong();
                Console.WriteLine("nhap ma thuc uong: ");
                int ma = Convert.ToInt32(Console.ReadLine());
                foreach (ThucUong n in Menu.dsThucUong)
                {
                    if (n.iMa == ma)
                        b = n;
                }
                Console.WriteLine("nhap so luong: ");
                b.luong = Convert.ToInt32(Console.ReadLine());
                lNuoc.Add(b);
            }
        }
        public double tinhTien()
        {
            double tien = 0;
            for (int i = 0; i < lMon.Count; i++)
                tien += lMon[i].dGia * lMon[i].luong;
            for (int i = 0; i < lNuoc.Count; i++)
                tien += lNuoc[i].dGia * lNuoc[i].luong;
            return tien;
        }
        public void xuat()
        {
            foreach (MonAn a in lMon)
                Console.WriteLine("Mat hang: " + a.sTen + "    Don Gia: " + a.dGia + "   So luong: " + a.luong + "   Thanh tien: " + a.dGia * a.luong);
            foreach (ThucUong b in lNuoc)
                Console.WriteLine("Mat hang: "+b.sTen + "    Don Gia: " + b.dGia + "   So luong: " + b.luong + "   Thanh tien: " + b.dGia * b.luong);
            Console.WriteLine("tong tien: " + tinhTien());
        }
    }
}
