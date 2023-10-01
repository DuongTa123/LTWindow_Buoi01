using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_2
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
        public SinhVien(SinhVien sv)
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

        public static List<SinhVien> NhapDSSVien()
        {
            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.Write("Nhap tong so sinh vien n=");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("\n ====Nhap Danh Sach Sinh Vien====");
            for(int i = 0; i<N;i++)
            {
                Console.Write("Nhap Sinh Vien Thu {0}:", i + 1);
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }
            return listSinhVien;
        }
        public static void XuatDSSVien(List<SinhVien> listSinhVien)
        {
            //Console.WriteLine("\n ==== Xuat Danh Sach Sinh Vien====");
            foreach(SinhVien sv in listSinhVien)
            {
                sv.XuatSV();
            }    
        }
        public static void DSSVienCNTT(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listCNTT = listSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien khoa CNTT");
            }
            else
            {
                XuatDSSVien(listCNTT);
            }
        }
        public static void DSSVienHon5Diem(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSVHon5Diem = listSinhVien.Where(p => p.DiemTB >= 5).ToList();
            if (listSVHon5Diem.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien nao >= 5 diem");
            }
            else
            {
                XuatDSSVien(listSVHon5Diem);
            }
        }
        public static void DSSVienSapXep(List<SinhVien> listSinhVien)
        {
            List<SinhVien> listSVSapXep = listSinhVien.OrderBy(p => p.DiemTB).ToList();
            
                XuatDSSVien(listSVSapXep);
       
        }
    }
}
