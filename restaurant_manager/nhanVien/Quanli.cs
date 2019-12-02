using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class Quanli:NhanVien
    {
        private double sPhucap;

        public double Phucap { get => sPhucap; set => sPhucap = value; }

        public Quanli()
        {

        }
        public Quanli(int SoNgayTangCa, double Phucap)
        {
            this.sTangca = SoNgayTangCa;
            this.sPhucap = Phucap;
        }
        public Quanli(int SoNgayTangCa)
        {
            this.sTangca = SoNgayTangCa;
            
        }
        ~Quanli()
        {

        }

        public override void nhap()
        {
            Console.Write("Ten quanli :");
            this.sname = Console.ReadLine();
            Console.Write("So ngay tang ca: ");
            this.sTangca = Convert.ToInt32(Console.ReadLine());
            Console.Write("Phu cap: ");
            this.sPhucap = Convert.ToInt32(Console.ReadLine());

        }
        public override void xuat()
        {
            Console.Write("Ten quan li: " + sname);
            base.xuat();
        }
    }
}
