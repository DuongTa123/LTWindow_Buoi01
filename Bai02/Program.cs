using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Nhap thang: ");
            int month = int.Parse(Console.ReadLine());

            Console.WriteLine("Nhap nam: ");
            int year = int.Parse(Console.ReadLine());

            int day = Getday(month, year);
            Console.WriteLine($"So ngay trong thang {month}/{year}: {day}");
            Console.ReadKey();

        }
        static int Getday(int month, int year)
        {
            if (month < 1 || month > 12)
            {
                Console.WriteLine("Thang khong hop le.");
                return 0;
            }

            if (month == 2)
            {
                if (checkNamNhuan(year))
                {
                    return 29;
                }
                else
                {
                    return 28;
                }
            }
            else if (month == 4 || month == 6 || month == 9 || month == 11)
            {
                return 30;
            }
            else
            {
                return 31;
            }
        }

        static bool checkNamNhuan(int year)
        {
            return (year % 4 == 0 && year % 100 != 0) || (year % 400 == 0);
        }
    }
}
