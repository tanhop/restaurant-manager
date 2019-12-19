using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    abstract class NhanVien
    {

        protected string sMaNV;
        protected string sname;
        protected string sNamsinh;
        protected int sDayNghi;
        protected int sTangca;
        protected double sLuong;




        public string Nvname { get => sname; set => sname = value; }
        public string Day { get => sNamsinh; set => sNamsinh = value; }
        public int DayNghi { get => sDayNghi; set => sDayNghi = value; }
        public int SoNgayTangCa { get => sTangca; set => sTangca = value; }
        public double Luongcoban { get => sLuong; set => sLuong = value; }
        public string maNV { get => sMaNV; set => sMaNV = value; }

        public NhanVien() { }

        public abstract void nhap();

        public abstract void xuat();

        public abstract double LuongNV();

        public static bool operator >(NhanVien a, NhanVien b)
        {
            if (a.LuongNV() > b.LuongNV())
                return true;
            return false;
        }
        public static bool operator <(NhanVien a, NhanVien b)
        {
            if (a.LuongNV() > b.LuongNV())
                return false;
            return true;
        }


    }
}
