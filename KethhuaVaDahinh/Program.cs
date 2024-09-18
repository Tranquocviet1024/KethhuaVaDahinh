using System;
namespace KethhuaVaDahinh
{

    class Program
    {
        public static void Main(string[] args)
        {
            Product sp1 = new Product("Laptop", 1000.0f, "May tinh", 1);
            Product sp2 = new Product("DienThoai", 500.0f, "Dien thoai", 1);
            ShoppingCart cart = new ShoppingCart();
            cart.ThemSanPham(sp2);
            cart.ThemSanPham(sp1); 
            cart.HiendsSanPham();
            float tinhtong=cart.TongTien(sp2 );
            Console.WriteLine( tinhtong );
            cart.XoaSanPham(sp2);
            cart.HiendsSanPham();


        }
    }
}