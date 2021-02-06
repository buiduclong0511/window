using System;
using System.Collections.Generic;
using System.Text;

namespace Bai1
{
    class Luong
    {
        private double bacLuong;
        private int ngayCong;
        private double phuCap;

        public void nhap(out double bacLuong, out int ngayCong, out double phuCap)
        {
            Console.Write("Nhap bac luong: ");
            bacLuong = double.Parse(Console.ReadLine());
            Console.Write("Nhap ngay cong: ");
            ngayCong = int.Parse(Console.ReadLine());
            Console.Write("Nhap phu cap: ");
            phuCap = double.Parse(Console.ReadLine());
        }

        public double tinhTien(double bacLuong, int ngayCong, double phuCap)
        {
            int nctl;
            if (ngayCong < 25)
            {
                nctl = ngayCong;
            } else
            {
                nctl = (ngayCong - 25) * 2 + 25;
            }
            return bacLuong * 60000 * nctl + phuCap;
        }
    }
}
