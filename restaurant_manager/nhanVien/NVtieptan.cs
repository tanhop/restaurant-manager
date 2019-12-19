using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class NVtieptan : NhanVien
    {
        
        public NVtieptan() { }
        public NVtieptan(string sNvname, string sDay, int sDayNghi, int sSoNgayTangCa, long sLuongcoban)
        {
            Nvname = sNvname;
            Day = sDay;
            DayNghi = sDayNghi;
            SoNgayTangCa = sSoNgayTangCa;
            Luongcoban = sLuongcoban;

        }

        public override void nhap()
        {
            Console.WriteLine("nhập mã tiếp tân: ");
            this.sMaNV = Console.ReadLine();
            Console.Write("Tên tiếp tân : ");
            this.sname = Console.ReadLine();
            Console.Write("Tuổi tiếp tân: ");
            this.sNamsinh = Console.ReadLine();
            Console.Write("Số ngày nghỉ : ");
            this.sDayNghi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số ngày tăng ca : ");
            this.sTangca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lương : ");
            this.sLuong = Convert.ToDouble(Console.ReadLine());
        }
        public override double LuongNV()
        {
            return sLuong;
        }

        public override void xuat()
        {
            Console.WriteLine("mã số tiếp tân: " + this.sMaNV);
            Console.WriteLine("Tên tiếp tân : " + sname);
            Console.WriteLine("Năm sinh : " + sNamsinh);
            Console.WriteLine("Số ngày nghỉ : " + sDayNghi);
            Console.WriteLine("Số ngày tăng ca: " + sTangca);
            Console.WriteLine("Lương : " + sLuong);
        }
    }
}
