namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANHSP")]
    public partial class ANHSP
    {
        public int ID { get; set; }

        public int? SANPHAMID { get; set; }

        public string SRC { get; set; }

        public virtual SANPHAM SANPHAM { get; set; }
    }
}
