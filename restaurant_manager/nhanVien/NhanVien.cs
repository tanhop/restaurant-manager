using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    abstract class NhanVien
    {


        public string Nvname { get; set; }
        public string Day { get; set; }
        public int DayNghi { get; set; }
        public int SoNgayTangCa { get; set; }
        public double Luongcoban { get; set; }    

        public NhanVien() { }

        public abstract void nhap();

        public abstract void xuat();

        public abstract double LuongNV();





    }
}
