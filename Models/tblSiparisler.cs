namespace PizzaWebMVCProje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblSiparisler")]
    public partial class tblSiparisler
    {
        [Key]
        public int SiparisID { get; set; }

        [Required]
        [StringLength(500)]
        public string SiparisAd { get; set; }

        [Column(TypeName = "datetime2")]
        public DateTime SiparisTarihi { get; set; }

        public decimal Fiyat { get; set; }
    }
}
