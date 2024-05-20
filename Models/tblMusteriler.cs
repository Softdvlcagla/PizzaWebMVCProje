namespace PizzaWebMVCProje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblMusteriler")]
    public partial class tblMusteriler
    {
        [Key]
        public int MusteriD { get; set; }

        [Required]
        [StringLength(500)]
        public string MusteriAd { get; set; }

        [Required]
        [StringLength(500)]
        public string MusteriSoyad { get; set; }
    }
}
