namespace PizzaWebMVCProje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSatislar")]
    public partial class tblSatislar
    {
        [Key]
        public int SatisID { get; set; }

        public int Urun { get; set; }

        [Required]
        [StringLength(50)]
        public string Musteri { get; set; }

        public byte Adet { get; set; }

        public decimal Fiyat { get; set; }
    }
}
