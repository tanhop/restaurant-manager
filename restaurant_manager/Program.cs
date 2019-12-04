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
            QLKinhDoanh.khoiTao();
            QLKinhDoanh.xuat();
            Console.ReadKey();
        }
       
    }
}
