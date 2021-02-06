using System;

namespace Bai1
{
    class Program
    {
        static void Main(string[] args)
        {
            Luong l1 = new Luong();
            double bacLuong, phuCap;
            int ngayCong;
            l1.nhap(out bacLuong, out ngayCong, out phuCap);
            Console.Write("Luong = {0}", l1.tinhTien(bacLuong, ngayCong, phuCap));

            Console.ReadLine();
        }
    }
}
