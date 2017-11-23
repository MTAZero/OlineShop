namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CHITIETGIOHANG")]
    public partial class CHITIETGIOHANG
    {
        public int ID { get; set; }

        public int? SANPHAMID { get; set; }

        public int? SOLUONG { get; set; }

        public int? DONGIA { get; set; }

        public int? THANHTIEN { get; set; }

        public int? KICHTHUOCID { get; set; }

        public virtual KICHTHUOC KICHTHUOC { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
