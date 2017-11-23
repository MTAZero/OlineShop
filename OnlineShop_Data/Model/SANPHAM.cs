namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SANPHAM")]
    public partial class SANPHAM
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SANPHAM()
        {
            ANHSPs = new HashSet<ANHSP>();
            CHITIETGIOHANGs = new HashSet<CHITIETGIOHANG>();
            COMMENTs = new HashSet<COMMENT>();
            DANHGIAs = new HashSet<DANHGIA>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public int? GIASANPHAM { get; set; }

        public int? KHUYENMAI { get; set; }

        public string MOTA { get; set; }

        public string THONGTIN { get; set; }

        public int? LOAISP { get; set; }

        public int? DOITUONG { get; set; }

        public int? TRANGTHAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ANHSP> ANHSPs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMMENT> COMMENTs { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DANHGIA> DANHGIAs { get; set; }
    }
}
