using System;
using System.Collections.Generic;
using System.Text;

namespace Bai2
{
    class HocSinh
    {
        private string hoTen;
        private int tuoi;
        private int diemT;
        private int diemL;
        private int diemH;

        public void nhap ()
        {
            Console.Write("Nhap ho ten: ");
            hoTen = Console.ReadLine();
            Console.Write("Nhap tuoi: ");
            tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem toan: ");
            diemT = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem ly: ");
            diemL = int.Parse(Console.ReadLine());
            Console.Write("Nhap diem hoa: ");
            diemH = int.Parse(Console.ReadLine());
        }

        public void xuat ()
        {
            Console.WriteLine("Thong tin hoc sinh:\n\tHo ten: {0}\n\tTuoi: {1}\n\tDiem toan: {2}\n\tDiem ly: {3}\n\tDiem hoa: {4}", hoTen, tuoi, diemT, diemL, diemH);
        }

        public string xepLoai ()
        {
            string xepLoai;
            double diemTB = (diemL + diemT + diemH) / 3;
            if (diemTB < 3)
            {
                xepLoai = "Kem";
            } else if (diemTB < 5)
            {
                xepLoai = "Trung binh";
            } else if (diemTB < 6.5)
            {
                xepLoai = "Trung binh kha";
            } else if (diemTB < 8.5)
            {
                xepLoai = "Kha";
            } else
            {
                xepLoai = "Gioi";
            }

            return xepLoai;
        }
    }
}
