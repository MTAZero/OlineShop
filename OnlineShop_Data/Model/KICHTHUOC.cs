namespace OnlineShop_Data
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KICHTHUOC")]
    public partial class KICHTHUOC
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public KICHTHUOC()
        {
            CHITIETGIOHANGs = new HashSet<CHITIETGIOHANG>();
        }

        public int ID { get; set; }

        public string TEN { get; set; }

        public int? LOAI { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<CHITIETGIOHANG> CHITIETGIOHANGs { get; set; }
    }
}
