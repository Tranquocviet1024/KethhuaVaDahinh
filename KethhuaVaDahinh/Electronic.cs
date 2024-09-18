using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KethhuaVaDahinh
{
    internal class Electronic:Product
    {
            private int sothangBaoHanh;
            public Electronic(String ten, float gia, String Mota, int soluong, int sothangBaoHanh) : base(ten, gia, Mota, soluong)
            {
                this.sothangBaoHanh = sothangBaoHanh;
            }
            public override void HienThi()
            {
                base.HienThi();
                Console.WriteLine("Thang Bao Hanh:" + sothangBaoHanh);
            }
    }
}
