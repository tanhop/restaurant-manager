using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class Daubep:NhanVien
    {


        private double sPhucap;

        public double Phucap { get => sPhucap; set => sPhucap = value; }

        public Daubep()
        {

        }
        public Daubep(int SoNgayTangCa, double Phucap)
        {
            this.sTangca = SoNgayTangCa;
            this.sPhucap = Phucap;
        }

        public Daubep(int SoNgayTangCa)
        {
            this.sTangca = SoNgayTangCa;
        }
        ~Daubep()
        {

        }

        public override void nhap()
        {
            Console.Write("Ten dau bep:");
            this.sname = Console.ReadLine();
            Console.Write("So ngay tang ca: ");
            this.sTangca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phu cap: ");
            this.sPhucap = Convert.ToInt32(Console.ReadLine());

        }
        public override void xuat()
        {
            Console.Write("Ten dau bep : " + sname);
            base.xuat();
        }
       // public override double luong()
        
                
       
    }
}
