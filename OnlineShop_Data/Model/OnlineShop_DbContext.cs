namespace OnlineShop_Data.Model
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

        public virtual DbSet<CHITIETHOADON> CHITIETHOADONs { get; set; }
        public virtual DbSet<HOADON> HOADONs { get; set; }
        public virtual DbSet<KHACHHANG> KHACHHANGs { get; set; }
        public virtual DbSet<MATHANG> MATHANGs { get; set; }
        public virtual DbSet<QUANTRI> QUANTRIs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KHACHHANG>()
                .Property(e => e.TAIKHOAN)
                .IsUnicode(false);

            modelBuilder.Entity<QUANTRI>()
                .Property(e => e.TAIKHOAN)
                .IsUnicode(false);

            modelBuilder.Entity<QUANTRI>()
                .Property(e => e.MATKHAUMD5)
                .IsUnicode(false);
        }
    }
}
