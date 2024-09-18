using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethhuaVaDahinh
{
    internal class Food:Product
    {
        private DateTime Expriration_Date;
        public Food(String ten, float gia, String Mota, int soluong, DateTime expriration_Date):base(ten,gia,Mota,soluong)
        {
            Expriration_Date = expriration_Date;
        }
        public override void HienThi()
        {
            base.HienThi();
            Console.WriteLine("Ngay het han:"+Expriration_Date);
        }
    }
}
