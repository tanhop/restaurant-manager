using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace restaurant_manager
{
    class Program
    {
            static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu.docDataThucUong();
            Menu.docDataMonAn();
            BanAn a = new BanAn();
            a.stt = status.trống;
            a.so = 1;
            a.datMon();
            a.xuat();
            a.xuatHoaDon();
            a.daTinhTien();
            a.xuat();
            Console.ReadKey();
        }
       
    }
}
