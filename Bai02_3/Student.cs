using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai02_3
{
    public class Student : Person
    {
        public string MaSV { get; set; } 
        public double DiemTB { get; set; }
        public string Khoa { get; set; }

        public Student() { }

        public Student(string cnmd, string hoTen, string diaChi, string maSV, double diemTB, string khoa)
            : base(cnmd, hoTen, diaChi)
        {
            MaSV = maSV;
            DiemTB = diemTB;
            Khoa = khoa;
        }

        public Student(Student sv)
        {

            this.MaSV = sv.MaSV;
            this.DiemTB = sv.DiemTB;
            this.Khoa = sv.Khoa;
        }
        public void NhapThongTinSV()
        {
            Console.WriteLine("Nhập thông tin sinh viên:");
            NhapTTin();  // Gọi phương thức "NhapThongTin"  của lớp cha Person"

            Console.Write("Nhập mã sinh viên: ");
            MaSV = Console.ReadLine();

            Console.Write("Nhập điểm trung bình: ");
            DiemTB = double.Parse(Console.ReadLine());

            Console.Write("Nhập khoa: ");
            Khoa = Console.ReadLine();
        }
        public void XuatSV()
        {
            Console.WriteLine("CCND:{0} \t HoTen:{1} \t DiaChi:{2} \t MaSV:{3} \tDiemTB:{4} \t Khoa:{5}",CNMD, HoTen, DiaChi, MaSV, DiemTB, Khoa);
        }

        public void XuatThongTinSV()
        {
            Console.WriteLine("Thông tin sinh viên:");
            XuatTTin();  // Gọi phương thức "XuatThongTin" của lớp cha "Person"
            Console.WriteLine("Mã sinh viên: " + MaSV);
            Console.WriteLine("Điểm trung bình: " + DiemTB);
            Console.WriteLine("Khoa: " + Khoa);
        }
        public static void XuatDSSVien(List<Student> danhSachSinhVien)
        {
            foreach (Student sv in danhSachSinhVien)
            {
                sv.XuatSV();
            }
        }

        public static void SinhVienKhoaCNTT(List<Student> danhSachSinhVien)
        {
            List<Student> listCNTT = danhSachSinhVien.Where(p => p.Khoa == "CNTT").ToList();
            if (listCNTT.Count() == 0)
            {
                Console.WriteLine("Khong co sinh vien khoa CNTT");
            }
            else
            {
                XuatDSSVien(listCNTT);
            }
        }
        public static List<Student> NhapDanhSachSinhVien()
        {
            List<Student> danhSachSinhVien = new List<Student>();
            Console.Write("Nhập số lượng sinh viên: ");
            int soLuongSV = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < soLuongSV; i++)
            {
                Student sv = new Student("", "", "", "", 0.0, "");
                Console.WriteLine($"\nNhập thông tin sinh viên thứ {i + 1}:");
                sv.NhapThongTinSV();
                danhSachSinhVien.Add(sv);
            }

            return danhSachSinhVien;
        }
    }
}
