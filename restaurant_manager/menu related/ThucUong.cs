﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    enum eLoaiNuoc { Trà, Nước_ép, Sinh_tố, Thức_uống_khác }
    class ThucUong: FoodnDrinks
    {
        private int maThucUong;
        private eLoaiNuoc loaiNuoc;
        private string tenThucUong;
        private long giaThucUong;
        private int soLuong;

        public int iMa { get => maThucUong; set => maThucUong = value; }
        public eLoaiNuoc loai { get => loaiNuoc; set => loaiNuoc = value; }
        public string sTen { get => tenThucUong; set => tenThucUong = value; }
        public long Gia { get => giaThucUong; set => giaThucUong = value; }
        public int luong { get => soLuong; set => soLuong = value; }
        public ThucUong() { }
        public ThucUong(int ma, eLoaiNuoc loai, string ten, long gia)
        {
            maThucUong = ma;
            loaiNuoc = loai;
            tenThucUong = ten;
            giaThucUong = gia;
        }

        ~ThucUong() { }

        public void nhap()
        {
            Console.WriteLine("nhap ma thuc uong: ");
            maThucUong = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap loai nuoc: ");
            var loaiNuocCount = Enum.GetNames(typeof(eLoaiNuoc)).Length;
            for (int i = 0; i < loaiNuocCount; i++)
                Console.WriteLine(i + "/ " + Enum.GetName(typeof(eLoaiNuoc),i));
            loaiNuoc = (eLoaiNuoc)Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("nhap ten thuc uong: ");
            tenThucUong = Console.ReadLine();
            Console.WriteLine("nhap gia thuc uong: ");
            giaThucUong = Convert.ToInt64(Console.ReadLine());
        }

        public void xuat()
        {
            Console.WriteLine("mã thức uống: " + maThucUong);
            Console.WriteLine("tên thức uống: " + tenThucUong);
            Console.WriteLine("loại thức uống: " + loai);
            Console.WriteLine("giá thức uống: " + giaThucUong);
        }

        public void xuat(eLoaiNuoc loai)
        {
            if (loaiNuoc == loai)
            {
                Console.WriteLine("mã thức uống: "+ maThucUong);
                Console.WriteLine("tên thức uống: "+ tenThucUong);
                Console.WriteLine("giá thức uống: "+ giaThucUong);
            }
        }
    }
}
