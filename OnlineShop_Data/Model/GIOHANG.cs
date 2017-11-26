namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("GIOHANG")]
    public partial class GIOHANG
    {
        public int ID { get; set; }

        public int? NGUOIDUNGID { get; set; }

        public DateTime? NGAY { get; set; }

        public string DIACHIGIAOHANG { get; set; }

        public int? TRANGTHAI { get; set; }

        public double? TONGTIEN { get; set; }

        public int? NGUOIXACNHANID { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG { get; set; }

        public virtual NGUOIDUNG NGUOIDUNG1 { get; set; }
    }
}
