namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PHANHOI")]
    public partial class PHANHOI
    {
        public int ID { get; set; }

        public string TEN { get; set; }

        public string EMAIL { get; set; }

        public string TIEUDE { get; set; }

        public string NOIDUNG { get; set; }

        public DateTime? NGAY { get; set; }

        public int? TRANGTHAI { get; set; }
    }
}
