using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    public class Teacher : Person
    {
        public string MaGV { get; set; }
        public string Khoa { get; set; }
        public string ChucVu { get; set; }

        public Teacher() { }
        public Teacher(string cnmd, string hoTen, string diaChi, string maGV, string khoa, string chucVu)
            : base(cnmd, hoTen, diaChi)
        {
            MaGV = maGV;
            Khoa = khoa;
            ChucVu = chucVu;
        }
        public Teacher(Teacher gv)
        {

            this.MaGV = gv.MaGV;
            this.Khoa = gv.Khoa;
            this.ChucVu = gv.ChucVu;
        }

        public void NhapThongTinGV()
        {
            Console.WriteLine("Nhập thông tin giáo viên:");
            NhapTTin();  // Gọi phương thức "NhapThongTin" của lớp cha "Person"

            Console.Write("Nhập mã giáo viên: ");
            MaGV = Console.ReadLine();

            Console.Write("Nhập khoa: ");
            Khoa = Console.ReadLine();

            Console.Write("Nhập chức vụ: ");
            ChucVu = Console.ReadLine();
        }
        public void XuatGV()
        {
            Console.WriteLine("CCND:{0} \t HoTen:{1} \t DiaChi:{2} \t MaGV:{3} \t Khoa:{4} \t ChucVu:{5} ", CNMD, HoTen, DiaChi, MaGV, Khoa, ChucVu);
        }


        public void XuatThongTinGV()
        {
            Console.WriteLine("Thông tin giáo viên:");
            XuatTTin();  // Gọi phương thức "XuatThongTin" của lớp cha Person
            Console.WriteLine("Mã giáo viên: " + MaGV);
            Console.WriteLine("Khoa: " + Khoa);
            Console.WriteLine("Chức vụ: " + ChucVu);
        }
        public static void XuatDSGVien(List<Teacher> danhSachGiaoVien)
        {
            foreach (Teacher gv in danhSachGiaoVien)
            {
                gv.XuatGV();
            }
        }
        public static List<Teacher> NhapDanhSachGiaoVien()
        {
            List<Teacher> danhSachGiaoVien = new List<Teacher>();
            Console.Write("Nhập số lượng giáo viên: ");
            int soLuongGV = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < soLuongGV; i++)
            {
                Teacher gv = new Teacher("", "", "", "", "", "");
                Console.WriteLine($"\nNhập thông tin giáo viên thứ {i + 1}:");
                gv.NhapThongTinGV();
                danhSachGiaoVien.Add(gv);
            }

            return danhSachGiaoVien;
        }
    }
}
