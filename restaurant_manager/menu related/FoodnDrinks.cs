using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace restaurant_manager
{
    public interface FoodnDrinks
    {
        int iMa { get; set; }
        string sTen { get; set; }
        double dGia { get; set; }

        void nhap();
        void xuat();
        
    }
}
