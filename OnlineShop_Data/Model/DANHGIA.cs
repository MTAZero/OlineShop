namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DANHGIA")]
    public partial class DANHGIA
    {
        public int ID { get; set; }

        public int? SANPHAMID { get; set; }

        public int? NGUOIDUNGID { get; set; }

        [Column("DANHGIA")]
        public int? DANHGIA1 { get; set; }

        public int? TRANGTHAI { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
