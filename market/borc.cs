namespace market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("borc")]
    public partial class borc
    {
        public int borcID { get; set; }

        public int? irsaliyeNo { get; set; }

        public int? tedarikciID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? tarih { get; set; }

        public double? tutar { get; set; }
    }
}
