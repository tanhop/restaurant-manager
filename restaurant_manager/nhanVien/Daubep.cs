using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class Daubep:NhanVien
    {
        
        public Daubep() 
        {
        }
        public Daubep(string sNvname, string sDay, int sDayNghi, int sSoNgayTangCa, long sLuongcoban)
        {
            Nvname =sNvname;
            Day = sDay;
            DayNghi = sDayNghi;
            SoNgayTangCa = sSoNgayTangCa;
            Luongcoban = sLuongcoban;
            
        }
        
        public override void nhap()
        {
            Console.WriteLine("nhập mã đầu bếp: ");
            this.sMaNV = Console.ReadLine();
            Console.Write("Tên đầu bếp : ");
            this.sname = Console.ReadLine();
            Console.Write("Năm sinh: ");
            this.sNamsinh = Console.ReadLine();
            Console.Write("Số ngày nghỉ : ");
            this.sDayNghi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số ngày tăng ca : ");
            this.sTangca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lương : ");
            this.sLuong= Convert.ToDouble(Console.ReadLine());  
        }

        public override double LuongNV()
        {
            return sLuong;
        }

        public override void xuat()
        {
            Console.WriteLine("mã số đầu bếp: " +this.sMaNV);
            Console.WriteLine("Tên đầu bếp : "+ this.sname);
            Console.WriteLine("Năm sinh : "+ this.sNamsinh);
            Console.WriteLine("Số ngày nghỉ : " + this.sDayNghi);
            Console.WriteLine("Số ngày tăng ca: " + this.sTangca);
            Console.WriteLine("Lương : " + this.sLuong);
        }
 
    }
}
