using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap an so a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap an so b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Nhap an so c: ");
            double c = double.Parse(Console.ReadLine());

            GiaiPTBac2(a, b, c);
            Console.ReadKey();
        }
        static void GiaiPTBac2(double a, double b, double c)
        {
            double delta = b * b - 4 * a * c;

            // Kiểm tra giá trị của delta để xác định số nghiệm
            if (delta > 0)
            {
                double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                double x2 = (-b - Math.Sqrt(delta)) / (2 * a);

                Console.WriteLine("PT co 2 nghiem phan biet:");
                Console.WriteLine("x1 = " + x1);
                Console.WriteLine("x2 = " + x2);
            }
            else if (delta == 0)
            {
                double x = -b / (2 * a);

                Console.WriteLine("PT co nghiem kep:");
                Console.WriteLine("x = "+ x);
            }
            else
            {
                Console.WriteLine("PT vo nghiem.");
            }
        }
    }
}
