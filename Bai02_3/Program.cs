using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            Console.Write("Nhập tổng số sinh viên N = ");
            int N = Convert.ToInt32(Console.ReadLine());

            List<Student> danhSachSinhVien = new List<Student>();
            Console.WriteLine("\n ==== Nhập Danh sách Sinh Viên ====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhập thông tin Sinh Viên thứ {i + 1}:");
                Student sv = new Student();
                sv.NhapThongTinSV();
                danhSachSinhVien.Add(sv);
            }
            // nhap tt GV
            Console.Write("Nhập tổng số Giáo Viên N = ");
             N = Convert.ToInt32(Console.ReadLine());

            List<Teacher> danhSachGiaoVien = new List<Teacher>();
            Console.WriteLine("\n ==== Nhập Danh sách Giáo Viên ====");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"Nhập thông tin Giáo Viên thứ {i + 1}:");
                Teacher gv = new Teacher();
                gv.NhapThongTinGV();
                danhSachGiaoVien.Add(gv);
            }
        }
        
        private static void XuatDanhSachSinhVien(List<Student> danhSachSinhVien)
        {
            foreach (var sv in danhSachSinhVien)
            {
                sv.XuatThongTinSV();
            }
        }
        

        private static void XuatDanhSachGiaoVien(List<Teacher> danhSachGiaoVien)
        {
            foreach (var gv in danhSachGiaoVien)
            {
                gv.XuatThongTinGV();
            }
        }

    }
}
