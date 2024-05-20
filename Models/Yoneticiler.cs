namespace PizzaWebMVCProje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Yoneticiler")]
    public partial class Yoneticiler
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int YoneticiID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string Ad { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string Soyad { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string Mail { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(100)]
        public string Sifre { get; set; }
    }
}
