using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class NVketoan:NhanVien
    {
        public NVketoan()
        {

        }
        public NVketoan(int SoNgayTangCa)
        {
            this.sTangca = SoNgayTangCa;
        }
        ~NVketoan()
        {

        }

        public override void nhap()
        {
            Console.WriteLine("Ten nv ke toan:");
            this.sname = Console.ReadLine();
            Console.WriteLine("So ngay tang ca: ");
            this.sTangca = Convert.ToInt32(Console.ReadLine());

        }
        public override void xuat()
        {
            Console.Write("Ten nv ke toan: " + sname);
            base.xuat();
        }
    }
}
