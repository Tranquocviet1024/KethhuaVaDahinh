using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethhuaVaDahinh
{
    internal class ShoppingCart
    {
        private List<Product> dsSanPham = new List<Product>();

        public void ThemSanPham(Product product)
        {
            dsSanPham.Add(product);
            Console.WriteLine("Da Them SP!");
        }
        public void XoaSanPham(Product product)
        {
            if (dsSanPham.Contains(product))
            {
                dsSanPham.Remove(product);
                Console.WriteLine("Da xoa!");
            }
            else
            {
                Console.WriteLine("Khong co San pham de xoa!");
            }
        }
        public float TongTien(Product product)
        {
            float tong = 0;
            foreach (Product p in dsSanPham)
            {
                tong += p.LayGia();
            }
            return tong;
        }
        public void HiendsSanPham()
        {
            Console.WriteLine("Hien Thi San Pham:");
            foreach (Product p in dsSanPham)
            {
                p.HienThi();
            }
        }
     }
   
}
