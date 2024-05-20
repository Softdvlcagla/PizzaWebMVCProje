namespace PizzaWebMVCProje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblUrunler")]
    public partial class tblUrunler
    {
        [Key]
        public int UrunID { get; set; }

        [Required]
        [StringLength(500)]
        public string UrunAdi { get; set; }

        public int UrunKategori { get; set; }

        public decimal Fiyat { get; set; }
    }
}
