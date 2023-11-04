using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaDangAnhDuong_2119110313
{
    class ThanhVienDao
    {
        QLSachDBContext db = null;
        public ThanhVienDao()
        {
            db = new QLSachDBContext();
        }
        public ThanhVien getRow(string tendh, string matkhau)
        {
            return db.ThanhViens.Where(m => m.TenDN == tendh && m.MatKhau == matkhau).FirstOrDefault();
        }
       
        public LoaiSach getRow(int maLoaiSach)
        {
            return db.LoaiSaches.Find(maLoaiSach);
        }
        public int getCount()
        {
            return db.LoaiSaches.Count();
        }
        public void Insert(LoaiSach LoaiSach)
        {
            db.LoaiSaches.Add(LoaiSach);
            db.SaveChanges();
        }
        public void Update(LoaiSach LoaiSach)
        {
            db.Entry(LoaiSach).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Delete(LoaiSach LoaiSach)
        {
            db.LoaiSaches.Remove(LoaiSach);
            db.SaveChanges();
        }
        public void Delete(int maLoaiSach)
        {
            LoaiSach LoaiSach = db.LoaiSaches.Find(maLoaiSach);
            db.LoaiSaches.Remove(LoaiSach);
            db.SaveChanges();
        }
    }
}
