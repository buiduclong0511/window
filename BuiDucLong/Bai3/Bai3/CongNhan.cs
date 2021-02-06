using System;
using System.Collections.Generic;
using System.Text;

namespace Bai3
{
    class CongNhan:Person
    {
        private string tenCongTy;
        private string ngayVaoLamViec;
        private double heSoLuong;

        public void nhap()
        {
            Console.Write("Nhap ho ten: ");
            this.hoTen = Console.ReadLine();
            Console.Write("Nhap nam sinh: ");
            this.namSinh = int.Parse(Console.ReadLine());
            Console.Write("Nhap dia chi: ");
            this.diaChi = Console.ReadLine();
            Console.Write("Nhap ten cong ty: ");
            this.tenCongTy = Console.ReadLine();
            Console.Write("Nhap ngay vao lam viec: ");
            this.ngayVaoLamViec = Console.ReadLine();
            Console.Write("Nhap he so luong: ");
            this.heSoLuong = double.Parse(Console.ReadLine());
        }

        public void xuat ()
        {
            Console.WriteLine("\nThong tin cong nhan: ");
            Console.WriteLine("Ho ten: {0}", this.hoTen);
            Console.WriteLine("Nam sinh: {0}", this.namSinh);
            Console.WriteLine("Dia chi: {0}", this.diaChi);
            Console.WriteLine("Ten cong ty: {0}", this.tenCongTy);
            Console.WriteLine("Ngay vao lam viec: {0}", this.ngayVaoLamViec);
            Console.WriteLine("He so luong: {0}", this.heSoLuong);
        }
    }
}
