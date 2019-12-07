using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class NVketoan:NhanVien
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
        { /*
            Console.Write("Tên Kế toán : ");
            this.tenKetoan = Console.ReadLine();
            Console.Write("Tuổi Kế toán: ");
            this.tuoiKetoan = Console.ReadLine();
            Console.Write("Số ngày nghỉ : ");
            this.soNgayNghi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Số ngày tăng ca : ");
            this.soNgayTangca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lương : ");
            this.luongKetoan = Convert.ToInt32(Console.ReadLine());              */
        }
        public override double LuongNV()
        {
            return sLuong;
        }

        public override void xuat()
        {
            Console.WriteLine("Tên kế toán: " + sname);
            Console.WriteLine("Tuổi : " + sNamsinh);
            Console.WriteLine("Số ngày nghỉ : " + sDayNghi);
            Console.WriteLine("Số ngày tăng ca: " + sTangca);
            Console.WriteLine("Lương : " + sLuong);
        }
    }
}
