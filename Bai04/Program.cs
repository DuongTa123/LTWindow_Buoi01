using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen a: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen b: ");
            int b = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap so nguyen c: ");
            int c = int.Parse(Console.ReadLine());

            if (KT3CanhTamGiac(a, b, c))
            {
                double CVi = ChuViTamGiac(a, b, c);
                double DTich = DienTich(a, b, c);

                Console.WriteLine($"Ba so {a}, {b}, {c} la 3 canh cua mot tam giac.");
                Console.WriteLine("Chu vi cua tam giac la: " + CVi);
                Console.WriteLine("Dien tich cua tam giac la: " + DTich);
            }
            else
            {
                Console.WriteLine($"Ba so {a}, {b}, {c} khong phai la 3 canh cua mot tam giac.");
            }
            Console.ReadKey();
        }
        static bool KT3CanhTamGiac(int a, int b, int c)
            {
                 return a + b > c && a + c > b && b + c > a;
            }

        static double ChuViTamGiac(int a, int b, int c)
             {
                 return a + b + c;
             }

        static double DienTich(int a, int b, int c)
            {
                 double p = ChuViTamGiac(a, b, c) / 2;
                 return Math.Sqrt(p * (p - a) * (p - b) * (p - c));
            }
    }
}
