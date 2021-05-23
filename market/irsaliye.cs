namespace market
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("irsaliye")]
    public partial class irsaliye
    {
        public int irsaliyeID { get; set; }

        public int? tedarikciID { get; set; }

        public int? urunID { get; set; }

        public int? miktar { get; set; }

        public double? birimfiyat { get; set; }

        public int? barkodID { get; set; }

        public int? irsaliyeNo { get; set; }

        public virtual urunler urunler { get; set; }
    }
}
