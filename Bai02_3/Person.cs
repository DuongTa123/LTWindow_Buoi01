using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    public class Person
    {
        public string CNMD { get; set; }
        public string HoTen { get; set; }
        public string DiaChi { get; set; }

        public Person() { }
        public Person(string cnmd, string hoTen, string diaChi)
        {
            CNMD = cnmd;
            HoTen = hoTen;
            DiaChi = diaChi;
        }
        public Person(Person ps)
        {

            this.CNMD = ps.CNMD;
            this.HoTen = ps.HoTen;
            this.DiaChi = ps.DiaChi;
        }
        public void NhapTTin()
        {
            Console.Write("Nhập số CMND: ");
            CNMD = Console.ReadLine();

            Console.Write("Nhập họ và tên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập địa chỉ: ");
            DiaChi = Console.ReadLine();
        }
        public void XuatThongTin()
        {
            Console.WriteLine("CCND:{0} \t HoTen:{1} \t DiaChi:{2}", CNMD, HoTen, DiaChi);
        }

        public void XuatTTin()
        {
            Console.WriteLine("Thông tin cụ thể là:");
            Console.WriteLine("Số CMND: " + CNMD);
            Console.WriteLine("Họ và tên: " + HoTen);
            Console.WriteLine("Địa chỉ: " + DiaChi);
        }
    }
}
