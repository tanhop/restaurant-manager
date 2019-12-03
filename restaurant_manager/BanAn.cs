using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    enum status { trong, da_dat, dat_truoc }
    class BanAn
    {
        private int so;
        private status trangThai;
        private Order donHang;

        public int soBan { get => so; set => soBan = value; }
        public status stt { get => trangThai; set => trangThai = value; }
        public Order donhang { get => donHang; set => donHang = value; }


    }
}