namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("COMMENT")]
    public partial class COMMENT
    {
        public int ID { get; set; }

        public int? NGUOIDUNGID { get; set; }

        public int? SANPHAMID { get; set; }

        public DateTime? THOIGIAN { get; set; }

        public string NOIDUNG { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
