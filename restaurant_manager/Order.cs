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
        private double giaTien;
        private int soNguoi;

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
            Console.WriteLine("nhập số người: ");
            soNguoi = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("nhập số món cần đặt: ");
            int nMon = Convert.ToInt32(Console.ReadLine());
            for(int i =0; i<nMon;i++)
            {
                MonAn a = new MonAn();
                Console.WriteLine("nhập mã món: ");
                int ma = Convert.ToInt32(Console.ReadLine());
                foreach(MonAn m in Menu.dsMonAn)
                {
                    if (m.iMa == ma)
                        a = m;
                }
                Console.WriteLine("nhập số lượng: ");
                a.luong = Convert.ToInt32(Console.ReadLine());
                lMon.Add(a);
            }


            Console.WriteLine("nhập số thức uống cần đặt: ");
            int nNuoc = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < nNuoc; i++)
            {
                ThucUong b = new ThucUong();
                Console.WriteLine("nhập mã thức uống: ");
                int ma = Convert.ToInt32(Console.ReadLine());
                foreach (ThucUong n in Menu.dsThucUong)
                {
                    if (n.iMa == ma)
                        b = n;
                }
                Console.WriteLine("nhập số lượng: ");
                b.luong = Convert.ToInt32(Console.ReadLine());
                lNuoc.Add(b);
            }
        }
        public double tinhTien()
        {
            double tien = 0;
            for (int i = 0; i < lMon.Count; i++)
                tien += lMon[i].Gia * lMon[i].luong;
            for (int i = 0; i < lNuoc.Count; i++)
                tien += lNuoc[i].Gia * lNuoc[i].luong;
            return tien;
        }
        public void xuat()
        {
            Console.WriteLine("số người: " + soNguoi);
            foreach (MonAn a in lMon)
                Console.WriteLine("Mặt hàng: " + a.sTen + "    Đơn giá: " + a.Gia + "   Số lượng: " + a.luong + "   Thành tiền: " + a.Gia * a.luong);
            foreach (ThucUong b in lNuoc)
                Console.WriteLine("Mặt hàng: "+b.sTen + "    Đơn giá: " + b.Gia + "   Số lượng: " + b.luong + "   Thành tiền: " + b.Gia * b.luong);
            Console.WriteLine("Tổng số tiền: " + tinhTien());
        }
    }
}
