using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class NVketoan:NhanVien
    {

        
        public NVketoan() { }
        public NVketoan(string sNvname, string sDay, int sDayNghi, int sSoNgayTangCa, long sLuongcoban)
        {
            Nvname = sNvname;
            Day = sDay;
            DayNghi = sDayNghi;
            SoNgayTangCa = sSoNgayTangCa;
            Luongcoban = sLuongcoban;

        }

        public override void nhap()
        {
            Console.WriteLine("nhập mã kế toán: ");
            this.sMaNV = Console.ReadLine();
            Console.Write("Tên Kế toán : ");
            this.sname = Console.ReadLine();
            Console.Write("Tuổi Kế toán: ");
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
            Console.WriteLine("mã số kế toán: " + this.sMaNV);
            Console.WriteLine("Tên kế toán: " + sname);
            Console.WriteLine("Năm sinh : " + sNamsinh);
            Console.WriteLine("Số ngày nghỉ : " + sDayNghi);
            Console.WriteLine("Số ngày tăng ca: " + sTangca);
            Console.WriteLine("Lương : " + sLuong);
        }
    }
}
