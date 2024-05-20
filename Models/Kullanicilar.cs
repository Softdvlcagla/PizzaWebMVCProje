namespace PizzaWebMVCProje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kullanicilar")]
    public partial class Kullanicilar
    {
        [Key]
        public int KullaniciID { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciAd { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciSoyAd { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciEposta { get; set; }

        [Required]
        [StringLength(50)]
        public string KullaniciSifre { get; set; }
    }
}
