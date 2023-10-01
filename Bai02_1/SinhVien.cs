using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_1
{
    internal class SinhVien
    {
        public string MaSV { get; set; }
        public string HoTen { get; set; }
        public double DiemTB { get; set; }
        public string Khoa { get; set; }
        public SinhVien() { }
        public SinhVien(string masv, string hoten, double diemtb, string khoa)
        {
            MaSV = masv;
            HoTen = hoten;
            DiemTB = diemtb;
            Khoa = khoa;
        }
        public SinhVien (SinhVien sv)
        {

            this.MaSV = sv.MaSV;
            this.HoTen = sv.HoTen;
            this.DiemTB = sv.DiemTB;
            this.Khoa = sv.Khoa;
        }
        public void NhapSV()
        {
            Console.Write("Nhap MaSV: ");
            MaSV = Console.ReadLine();
            Console.Write("Nhap HoTen: ");
            HoTen = Console.ReadLine();
            Console.Write("Nhap DiemTB: ");
            DiemTB = double.Parse(Console.ReadLine());
            Console.Write("Nhap Khoa: ");
            Khoa = Console.ReadLine();

        }
        public void XuatSV()
        {
            Console.WriteLine("MaSV:{0} \t HoTen:{1} \t DiemTB:{2} \t Khoa:{3}", MaSV, HoTen, DiemTB, Khoa);
        }
    }
   
}
