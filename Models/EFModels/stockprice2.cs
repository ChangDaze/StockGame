namespace FirstTrade_.Models.EFModels
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class stockprice2
    {
        public int id { get; set; }

        [StringLength(4)]
        public string 證券代碼 { get; set; }

        [StringLength(50)]
        public string 年月日 { get; set; }

        [Column("收盤價(元)")]
        public double? 收盤價_元_ { get; set; }
    }
}
