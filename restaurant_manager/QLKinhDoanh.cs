using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace restaurant_manager
{
    static class QLKinhDoanh
    {
        private static List<BanAn> lBanAn;
        private static List<Order> lOrder;
        private static int soKhach;
        private static long tongThu;
        private static double doanhThuTB;
        public static List<BanAn> dsBanAn { get => lBanAn; set => lBanAn = value; }
        public static int luongKhach { get => soKhach; set => soKhach = value; }
        public static long TongDoanhThu { get => tongThu; set => tongThu = value; }
        public static double thuTB { get => doanhThuTB; set => doanhThuTB = value; }
        public static List<Order> dsOrder { get => lOrder; set => lOrder = value; }

        public static void khoiTao()
        {
            soKhach = 0;
            tongThu = 0;
            doanhThuTB = 0;
            lBanAn = new List<BanAn>();
            lOrder = new List<Order>();
            for(int i = 0; i < 20; i++)
            {
                BanAn a = new BanAn();
                a.so = i+1;
                a.stt = status.trống;
                lBanAn.Add(a);
            }
        }
        public static void xuatListBan()
        {
            for (int i = 0; i < 20; i++)
                lBanAn[i].xuat();
        }
        public static void xuatDoanhThu()
        {
            Console.WriteLine("tổng doanh thu: " + tongThu);
            Console.WriteLine("tổng lượng khách: " + soKhach);
            Console.WriteLine("doanh thu trung bình: " + thuTB + " đ/người");
        }
        public static void datMon()
        {
            Console.WriteLine("các bàn còn trống: ");
            for(int i = 0; i < 20; i++)
            {
                if (lBanAn[i].stt == status.trống)
                    Console.WriteLine(lBanAn[i].so);
            }
            Console.WriteLine("nhập bàn muốn đặt: ");
            int ban = Convert.ToInt32(Console.ReadLine());    // implement exeption handling nhập sai số bàn trống sau
            lBanAn[ban - 1].datMon();
        }
        public static void xuatHoaDon()
        {
            Console.WriteLine("các bàn đã đặt món: ");
            for(int i = 0; i < 20; i++)
            {
                if (lBanAn[i].stt == status.đã_đặt_món)
                    Console.WriteLine(lBanAn[i].so);
            }
            Console.WriteLine("nhập bàn muốn xuất hóa đơn: ");
            lBanAn[Convert.ToInt32(Console.ReadLine())-1].xuatHoaDon();
        }
        public static void daTinhTien()
        {
            Console.WriteLine("các bàn đang chờ tính: ");
            for (int i = 0; i < 20; i++)
            {
                if (lBanAn[i].stt == status.chờ_tính_tiền)
                    Console.WriteLine(lBanAn[i].so);
            }
            Console.WriteLine("nhập bàn đã tính tiền: ");
            int ban = Convert.ToInt32(Console.ReadLine());
            lBanAn[ban-1].daTinhTien();

            lOrder.Add(lBanAn[ban - 1].donhang);
            soKhach += lBanAn[ban - 1].donhang.nguoi;
            tongThu += lBanAn[ban - 1].donhang.tinhTien();
            thuTB = tongThu / soKhach;
        }   
        public static void xuatDSHoaDon()
        {
            Console.WriteLine("danh sách tất cả hóa đơn");
            foreach (Order hoaDon in lOrder)
                hoaDon.xuat();
        }
    }
}
