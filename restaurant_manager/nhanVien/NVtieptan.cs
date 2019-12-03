using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{ 
    class NVtieptan: NhanVien
    {
        public NVtieptan()
        {

        }
        public NVtieptan(int SoNgayTangCa)
        {
            this.sTangca = SoNgayTangCa;
        }
        ~NVtieptan()
        {

        }

        public override void nhap()
        {
            Console.WriteLine("Ten nv tiep tan:");
            this.sname = Console.ReadLine();
            Console.WriteLine("So ngay tang ca: ");
            this.sTangca = Convert.ToInt32(Console.ReadLine());

        }
        public override void xuat()
        {
            Console.Write("Ten nv tiep tan: " + sname);
            base.xuat();
        }
    }
}
