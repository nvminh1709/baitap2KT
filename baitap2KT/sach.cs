using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace baitap2KT
{
    internal class sach
    {
        public String tenSach { get; set; }
        public String tacGia { get; set; }
        public String MaSach { get; set; }
        public sach()
        {

        }
        public sach(String MaSach, string tenSach, string tacGia)
        {
           this.MaSach = MaSach;
            this.tenSach = tenSach;
            tacGia = tacGia;
        }
        public void Nhap ()
        {
            Console.WriteLine("nhap ma sach : ");
            MaSach = Console.ReadLine();
            Console.WriteLine("nhap ten sach :");
            tenSach = Console.ReadLine();
            Console.WriteLine("nhap ten tac gia :");
            tacGia = Console.ReadLine();
        }
        public void hienthi () {
            Console.WriteLine("ma sach la     :"+   MaSach);
            Console.WriteLine("ten sach la    :"+tenSach);
            Console.WriteLine("ten tac gia la :"+tacGia);
        }
    }
}
