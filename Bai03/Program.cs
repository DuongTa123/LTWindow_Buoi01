using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai03
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap vao so nguyen duong n: ");
            int n = int.Parse(Console.ReadLine());

            int sum = TongSoLe(n);
            Console.WriteLine("Tong cac so le tu 1 đen 2n-1 la: "+ sum);
            Console.ReadKey();
        }
        static int TongSoLe(int n)
        {
            int sum = 0;
            for (int i = 1; i <= 2 * n - 1; i += 2)
            {
                sum += i;
            }
            return sum;
        }
    }
}
