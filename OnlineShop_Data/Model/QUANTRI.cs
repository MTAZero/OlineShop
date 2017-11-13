namespace OnlineShop_Data.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("QUANTRI")]
    public partial class QUANTRI
    {
        public int ID { get; set; }

        public string HOTEN { get; set; }

        public string DIACHI { get; set; }

        public string SDT { get; set; }

        public string TAIKHOAN { get; set; }

        public string MATKHAUMD5 { get; set; }
    }
}
