using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace TaDangAnhDuong_2119110313
{
    public partial class QLSachDBContext : DbContext
    {
        public QLSachDBContext()
            : base("name=ChuoiKN")
        {
        }

        public virtual DbSet<LoaiSach> LoaiSaches { get; set; }
        public virtual DbSet<Sach> Saches { get; set; }
        public virtual DbSet<ThanhVien> ThanhViens { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiSach>()
                .HasMany(e => e.Saches)
                .WithRequired(e => e.LoaiSach)
                .WillCascadeOnDelete(false);
        }
    }
}
