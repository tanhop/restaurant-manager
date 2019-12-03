using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    static class Quanli
    {
        private static List<Daubep> Daubep;
        private static List<Phucvu> Phucvu;
        private static List<NVketoan> Ketoan;
        private static List<NVtieptan> Tieptan;
        static string NameNhaHang;

        public static List<Daubep> ListDauBep { get => Daubep; set => Daubep = value; }
        public static List<Phucvu> ListPhucvu { get => Phucvu; set => Phucvu = value; }
        public static List<NVketoan> ListKeToan { get => Ketoan; set => Ketoan = value; }
        public static List<NVtieptan> ListTieptan { get => Tieptan; set => Tieptan = value; }
       

        public static void nhap()
        {
            Daubep = new List<Daubep>();
            Phucvu = new List<Phucvu>();
            Ketoan = new List<NVketoan>();
            Tieptan = new List<NVtieptan>();

            Console.WriteLine("Nhap ten nha hang: ");
            NameNhaHang = Console.ReadLine();
            Console.Write("Nhap so luong dau bep: ");
            int soDB=
        }
    }
}
