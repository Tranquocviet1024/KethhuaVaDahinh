using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethhuaVaDahinh
{
    internal class Clothing:Product
    {
        private int size;
        private String Color;

        public Clothing(String ten, float gia, String Mota, int soluong, int size, string color):base(ten,gia,Mota,soluong)
        {
            this.size = size;
            Color = color;
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Size:" + size+" Mau:"+Color);
        }
    }
}
