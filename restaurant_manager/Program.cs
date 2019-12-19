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
            Quanli.KhoiTaoListNV();

            int a = 10;
            int b = 10;
            int c = 10;
            int d = 10;

            while (a != 0)
            {
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("1. Quản lý kinh doanh");
                Console.WriteLine("2. Quản lý Menu");
                Console.WriteLine("3. Quản lý nhân viên");

                a = int.Parse(Console.ReadLine());

                switch (a)
                {
                    case 1:
                        b = 10;
                        while (b != 0)
                        {
                            a = 10;
                            b = 10;
                            Console.Clear();
                            Console.WriteLine("0. Quay lại màn hình quản lý");
                            Console.WriteLine("1. xuất trạng thái các bàn");
                            Console.WriteLine("2. đặt món, xuất hóa đơn, tính tiền");
                            Console.WriteLine("3. Xuất doanh thu");
                            Console.WriteLine("4. xuất danh sách hóa đơn đã phục vụ");
                            b = int.Parse(Console.ReadLine());
                            switch (b)
                            {
                                case 1:
                                    Console.Clear();
                                    QLKinhDoanh.xuatListBan();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    while (c != 0)
                                    {
                                        c = 10;
                                        Console.Clear();
                                        Console.WriteLine("0. quay lại");
                                        Console.WriteLine("1. đặt bàn");
                                        Console.WriteLine("2. xuất hóa đơn");
                                        Console.WriteLine("3. nhận nhận đã thanh toán");
                                        c = int.Parse(Console.ReadLine());
                                        switch (c)
                                        {
                                            case 1:
                                                Console.Clear();
                                                QLKinhDoanh.datMon();
                                                Console.WriteLine("Press any key to exit");
                                                Console.ReadKey();
                                                break;
                                            case 2:
                                                Console.Clear();
                                                QLKinhDoanh.xuatHoaDon();
                                                Console.WriteLine("Press any key to exit");
                                                Console.ReadKey();
                                                break;
                                            case 3:
                                                Console.Clear();
                                                QLKinhDoanh.daTinhTien();
                                                Console.WriteLine("Press any key to exit");
                                                Console.ReadKey();
                                                break;
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    QLKinhDoanh.xuatDoanhThu();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    Console.Clear();
                                    QLKinhDoanh.xuatDSHoaDon();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadKey();
                                    break;
                            }
                        }
                        Console.Clear();
                        break;
                    case 2:
                        b = 10;
                        while (b!=0)
                        {
                            a = 10;
                            b = 10;
                            Console.Clear();
                            Console.WriteLine("0. Quay lại màn hình quản lý");
                            Console.WriteLine("1. Xuất Menu");
                            Console.WriteLine("2. Thêm món");
                            Console.WriteLine("3. Xóa món");
                            b = int.Parse(Console.ReadLine());
                            switch (b)
                            {
                                case 1:
                                    Console.Clear();
                                    Menu.xuat();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Console.Clear();
                                    Menu.them();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Console.Clear();
                                    Menu.xoa();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadKey();
                                    break;                                 
                            }
                        }
                        Console.Clear();
                        break;
                    case 3:
                        b = 10;
                        while (b != 0)
                        {
                            a = 10;
                            b = 10;
                            Console.Clear();
                            Console.WriteLine("0. Quay lại màn hình quản lý");
                            Console.WriteLine("1. Xuất danh sách nhân viên");
                            Console.WriteLine("2. Thêm, xóa nhân viên");
                            Console.WriteLine("3. So sánh lương");
                            b = int.Parse(Console.ReadLine());
                            switch(b)
                            {
                                case 1:
                                    Console.Clear();
                                    Quanli.xuatNV();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    while (c != 0)
                                    {
                                        c = 10;
                                    Console.Clear();
                                    Console.WriteLine("0. Quay lại");
                                    Console.WriteLine("1. Thêm nhân viên");
                                    Console.WriteLine("2. Xóa nhân viên");
                                    c = Convert.ToInt32(Console.ReadLine());
                                        Console.Clear();
                                        switch (c)
                                        {
                                            case 1:
                                                while (d != 0)
                                                {
                                                    d = 10;
                                                    Console.Clear();
                                                    Console.WriteLine("0. Quay lại");
                                                    Console.WriteLine("1. Thêm đầu bếp");
                                                    Console.WriteLine("2. Thêm kế toán");
                                                    Console.WriteLine("3. Thêm tiếp tân");
                                                    Console.WriteLine("4. Thêm phục vụ");
                                                    d = int.Parse(Console.ReadLine());
                                                    switch (d)
                                                    {
                                                        case 1:
                                                            NhanVien db = new Daubep();
                                                            db.nhap();
                                                            Quanli.ListNhanvien.Add(db);
                                                            Console.WriteLine("Press any key to exit");
                                                            Console.ReadKey();
                                                            break;

                                                        case 2:
                                                            NhanVien kt = new NVketoan();
                                                            kt.nhap();
                                                            Quanli.ListNhanvien.Add(kt);
                                                            Console.WriteLine("Press any key to exit");
                                                            Console.ReadKey();
                                                            break;

                                                        case 3:

                                                            NhanVien tt = new NVtieptan();
                                                            tt.nhap();
                                                            Quanli.ListNhanvien.Add(tt);
                                                            Console.WriteLine("Press any key to exit");
                                                            Console.ReadKey();
                                                            break;

                                                        case 4:

                                                            NhanVien pv = new Phucvu();
                                                            pv.nhap();
                                                            Quanli.ListNhanvien.Add(pv);
                                                            Console.WriteLine("Press any key to exit");
                                                            Console.ReadKey();
                                                            break;
                                                    }
                                                    break;
                                                }
                                                break;
                                            case 2:
                                                Console.Clear();
                                                Quanli.xoaNV();
                                                Console.WriteLine("Press any key to exit");
                                                Console.ReadKey();
                                                c = 0;
                                                break;
                                        }
                                    }
                                    break;
                                case 3:
                                    Console.Clear();
                                    Quanli.soSanhLuong();
                                    Console.WriteLine("Press any key to exit");
                                    Console.ReadLine();
                                    break;
                            }

                        }
                        Console.Clear();
                        break;
                }

            }
        }
       
    }
}
