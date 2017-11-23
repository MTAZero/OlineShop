namespace OnlineShop_Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class OnlineShop_DbContext : DbContext
    {
        public OnlineShop_DbContext()
            : base("name=OnlineShop_DbContext")
        {
        }

        public virtual DbSet<ANHSP> ANHSPs { get; set; }
        public virtual DbSet<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }
        public virtual DbSet<COMMENT> COMMENTs { get; set; }
        public virtual DbSet<DANHGIA> DANHGIAs { get; set; }
        public virtual DbSet<GIOHANG> GIOHANGs { get; set; }
        public virtual DbSet<KICHTHUOC> KICHTHUOCs { get; set; }
        public virtual DbSet<NGUOIDUNG> NGUOIDUNGs { get; set; }
        public virtual DbSet<PHANHOI> PHANHOIs { get; set; }
        public virtual DbSet<SANPHAM> SANPHAMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.GIOHANGs)
                .WithOptional(e => e.NGUOIDUNG)
                .HasForeignKey(e => e.NGUOIDUNGID);

            modelBuilder.Entity<NGUOIDUNG>()
                .HasMany(e => e.GIOHANGs1)
                .WithOptional(e => e.NGUOIDUNG1)
                .HasForeignKey(e => e.NGUOIXACNHANID);
        }
    }
}
