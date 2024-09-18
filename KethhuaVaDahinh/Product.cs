using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethhuaVaDahinh
{
    internal class Product
    {
        private String Ten;
        private float Gia;
        private String Mota;
        private int Soluong;
        public float LayGia()
        {
            return this.Gia;
        }
        public Product(String ten, float gia, String Mota, int soluong)
        {
            this.Ten = ten;
            this.Gia = gia;
            this.Mota = Mota;
            this.Soluong = soluong;
        }
        public virtual void HienThi()
        {
            Console.WriteLine("Ten:" + Ten + " Gia:" + Gia + " Mo Ta:" + Mota + " Soluong:" + Soluong);
        }
    }
}
