using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Nhập tổng số sinh viên N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            List<SinhVien> listSinhVien = new List<SinhVien>();
            Console.WriteLine("\n ==== Nhập Danh sách Sinh Viên ====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhập thông tin Sinh Viên thứ {i + 1}:");
                SinhVien sv = new SinhVien();
                sv.NhapSV();
                listSinhVien.Add(sv);
            }

            Console.WriteLine("\n ==== Xuất Danh Sách Sinh Viên ====");
            SinhVien.XuatDSSVien(listSinhVien);

            Console.WriteLine("\n ==== Xuất Sinh Viên thuộc khoa CNTT ====");
            SinhVien.DSSVienCNTT(listSinhVien);

            Console.WriteLine("\n ==== Xuất Sinh Viên có điểm TB trên 5 ====");
            SinhVien.DSSVienHon5Diem(listSinhVien);

            Console.WriteLine("\n ==== Xuất Danh Sách Sinh Viên được sắp xếp theo điểm TB ====");
            SinhVien.DSSVienSapXep(listSinhVien);

            Console.ReadKey();
        }
    }
}
