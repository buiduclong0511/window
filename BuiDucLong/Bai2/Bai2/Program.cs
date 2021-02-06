using System;

namespace Bai2
{
    class Program
    {
        static void Main(string[] args)
        {
            HocSinh hs1 = new HocSinh();
            hs1.nhap();
            hs1.xuat();
            Console.WriteLine("Xep loai: {0}", hs1.xepLoai());
            Console.ReadLine();
        }
    }
}
