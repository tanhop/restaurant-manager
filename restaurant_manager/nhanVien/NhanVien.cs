using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    class NhanVien
    {
        protected string sname;
        protected string sNamsinh;
        protected double sLuong;
        protected int sTangca;

        public string Nvname { get => sname; set => sname = value; }
        public string Day { get => sNamsinh; set => sNamsinh = value; }
        public double Luongcoban { get => sLuong; set => sLuong = value; }
        public int SoNgayTangCa { get => sTangca; set => sTangca = value; }

        public NhanVien()
        {

        }
        public NhanVien(string Nvname, string Day, double Luongcoban)
        {
            this.sname = Nvname;
            this.sNamsinh = Day;
            this.sLuong = Luongcoban;
        }
        public NhanVien(string Nvname, string Day)
        {
            this.sname = Nvname;
            this.sNamsinh = Day;

        }
        public NhanVien(string Nvname)
        {
            this.sname = Nvname;

        }
        ~NhanVien()
        {

        }
        public virtual void nhap()
        {
            Console.Write("Nam sinh : ");
            this.sNamsinh = Console.ReadLine();
            Console.Write("Luong co ban: " );
            this.sLuong = Convert.ToInt32(Console.ReadLine());
        }
        public virtual void xuat()
        {
             
            
            Console.Write("Nam sinh : "+sNamsinh);
  
            Console.Write("Luong co ban: "+ sLuong );
          
        }

       // public abstract double luong()


    }
}
