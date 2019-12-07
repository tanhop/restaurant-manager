using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class Daubep:NhanVien
    {
        private string sname;
        private string sNamsinh;
        private int sDayNghi;
        private int sTangca;
        private double sLuong;
       
       

       
        public string Nvname { get => sname; set => sname = value; }
        public string Day { get => sNamsinh; set => sNamsinh = value; }
        public int DayNghi { get => sDayNghi; set => sDayNghi = value; }
        public int SoNgayTangCa { get => sTangca; set => sTangca = value; }
        public double Luongcoban { get => sLuong; set => sLuong = value; }


        public Daubep() { }
        public Daubep(string sNvname, string sDay, int sDayNghi, int sSoNgayTangCa, long sLuongcoban)
        {
            Nvname =sNvname;
            Day = sDay;
            DayNghi = sDayNghi;
            SoNgayTangCa = sSoNgayTangCa;
            Luongcoban = sLuongcoban;
            
        }
        
        public override void nhap()
        { /*
            Console.Write("Tên đầu bếp : ");
            this.tenDaubep = Console.ReadLine();
            Console.Write("Tuổi đầu bếp: ");
            this.tuoiDaubep = Console.ReadLine();
            Console.Write("Số ngày nghỉ : ");
            this.soNgayNghi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số ngày tăng ca : ");
            this.soNgayTangca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lương : ");
            this.luongDaubep= Convert.ToInt32(Console.ReadLine());  */
        }

        public override double LuongNV()
        {
            return sLuong;
        }

        public override void xuat()
        {
            
            Console.WriteLine("Tên đầu bếp : "+ this.sname);
            Console.WriteLine("Tuổi : "+ this.sNamsinh);
            Console.WriteLine("Số ngày nghỉ : " + this.sDayNghi);
            Console.WriteLine("Số ngày tăng ca: " + this.sTangca);
            Console.WriteLine("Lương : " + this.sLuong);
        }
    }
}
