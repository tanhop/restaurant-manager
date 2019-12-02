using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class Phucvu: NhanVien
    {
        public Phucvu()
        {

        }
        public Phucvu(int SoNgayTangCa)
        {
            this.sTangca = SoNgayTangCa;
        }
        ~Phucvu()
        {

        }

        public override void nhap()
        {
            Console.WriteLine("Ten phuc vu:");
            this.sname = Console.ReadLine();
            Console.WriteLine("So ngay tang ca: ");
            this.sTangca = Convert.ToInt32(Console.ReadLine());

        }
        public override void xuat()
        {
            Console.Write("Ten phuc vu : " + sname);
            base.xuat();
        }
    }
}
