using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so luong sinh vien: ");
            int n = int.Parse(Console.ReadLine());

            string[] dssinhvien = NhapSV(n);
            XuatSV(dssinhvien, n);
            Console.ReadKey();
        }
        static string[] NhapSV(int n)
        {
            string[] dssinhvien = new string[n];

            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Nhap ho ten sinh vien thu {i + 1}: ");
                dssinhvien[i] = Console.ReadLine();
            }

            return dssinhvien;
        }
        static void XuatSV(string[] dssinhvien, int n)
        {
            Console.WriteLine("Danh sach sinh vien:");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"- {dssinhvien[i]}");
            }
        }
    }
}
