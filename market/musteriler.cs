namespace market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("musteriler")]
    public partial class musteriler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public musteriler()
        {
            musteriOzet = new HashSet<musteriOzet>();
            satis = new HashSet<satis>();
        }

        [Key]
        public int musteriID { get; set; }

        [StringLength(255)]
        public string isimSoyisim { get; set; }

        [StringLength(255)]
        public string telNO { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<musteriOzet> musteriOzet { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<satis> satis { get; set; }
    }
}
