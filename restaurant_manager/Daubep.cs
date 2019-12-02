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

        }
        public override void xuat()
        {
            Console.Write("Ten dau bep : " + sname);
            base.xuat();
        }
       // public override double luong()
        
                
       
    }
}
