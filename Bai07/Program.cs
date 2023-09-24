using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Cac so nguyen to tu 1 den n :"+ n);
            for (int i = 2; i <= n; i++)
            {
                if (LaSoNguyenTo(i))
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();
        }
        static bool LaSoNguyenTo(int number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
