using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai01
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, tong, hieu, tich;
            double thuong = 0;
            // input a
            Console.Write("Nhap so a: ");
            // input a, ép kiểu
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Nhhap so b: ");
            b = Int32.Parse(Console.ReadLine());
            // tính 
            tong = a + b;
            hieu = a - b;
            tich = a * b;
            if(b!=0)
            {
                thuong = (double) a / b;
            }
            //KQ
            Console.WriteLine("Tong = " + tong);
            Console.WriteLine("Hieu = {0}" , hieu);
            Console.WriteLine("Tich = {0}, thuong {1}" , tich, thuong);
            // dừng màn hình để xem
            Console.ReadKey();
        }
    }
}
