using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    enum status { trống, đã_đặt_món, chờ_tính_tiền }
    class BanAn
    {
        private int soBan;
        private status trangThai;
        private Order donHang;

    
        public int so { get => soBan; set => soBan = value; }
        public status stt { get => trangThai; set => trangThai = value; }
        public Order donhang { get => donHang; set => donHang = value; }

        public BanAn()
        {
            donHang = new Order();
        }
        public void xuat()
        {
            Console.WriteLine("số bàn: " + soBan);
            Console.WriteLine("trạng thái: " + stt);
            if (stt != status.trống)
            {
                Console.WriteLine("đơn hàng: ");
                donHang.xuat();
            }
        }
        public void xuatHoaDon()
        {
            Console.WriteLine("số bàn: " + soBan);
            donHang.xuat();
            stt = status.chờ_tính_tiền;
        }
        public void daTinhTien()
        {
            stt = status.trống;
        }
        public void datMon()
        {
            donHang.nhap();
            stt = status.đã_đặt_món;
        }

    }
}