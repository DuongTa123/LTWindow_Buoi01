using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Console.Write("Nhap Tong So Sinh Vien N =");
            int N = Convert.ToInt32(Console.ReadLine());
            SinhVien[] arrSinhVien = new SinhVien[N];
            Console.WriteLine("\n ====Nhap Danh Sach Sinh Vien====");
            for (int i = 0; i < N; i++)
            {
                Console.Write("Nhap Sinh Vien Thu {0}:", i + 1);
                arrSinhVien[i] = new SinhVien();
                arrSinhVien[i].NhapSV();
            }

             
            Console.WriteLine("\n ====Xuất Danh Sách Sinh Viên====");
            foreach(SinhVien sv in arrSinhVien)
            {
                sv.XuatSV();
            }
            Console.ReadKey();
        }
    }
}
