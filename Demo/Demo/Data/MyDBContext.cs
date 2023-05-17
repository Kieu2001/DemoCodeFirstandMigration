using Microsoft.EntityFrameworkCore;

namespace Demo.Data
{
    public class MyDBContext : DbContext
    {
        public MyDBContext(DbContextOptions options) : base(options) { }

        //#region
        public DbSet<HangHoa> HangHoas { get; set; }
        public DbSet<Loai> Loais { get; set; }
        public DbSet<DonHang> DonHangs { get; set; }
        public DbSet<DonHangChiTiet> DonHangChiTiets { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DonHang>(e =>
            {
                e.ToTable(nameof(DonHang));
                e.HasKey(dh => dh.MaDh);
                e.Property(x => x.NgayDat).HasDefaultValueSql("getutcdate()");
                e.Property(dh => dh.NguoiNhan).IsRequired().HasMaxLength(100);
            });
            modelBuilder.Entity<DonHangChiTiet>(e =>
            {
                e.ToTable("DonHangChiTiet");
                e.HasKey(e => new { e.MaDh, e.MaHh });

                e.HasOne(e => e.DonHang).WithMany(e => e.DonHangChiTiets).HasForeignKey(e => e.MaDh).HasConstraintName("FK_DonHangCT_DonHang");
                e.HasOne(e => e.HangHoa).WithMany(e => e.DonHangChiTiets).HasForeignKey(e => e.MaHh).HasConstraintName("FK_DonHangCT_HangHoa");
            });
        }
    }
}
