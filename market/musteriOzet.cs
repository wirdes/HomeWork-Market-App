namespace market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("musteriOzet")]
    public partial class musteriOzet
    {
        public int id { get; set; }

        public int? musteriID { get; set; }

        public double? tutar { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        public int? faturaID { get; set; }

        public virtual musteriler musteriler { get; set; }
    }
}
