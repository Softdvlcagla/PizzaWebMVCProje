namespace PizzaWebMVCProje.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("tblKategoriler")]
    public partial class tblKategoriler
    {
        [Key]
        public int KategoriID { get; set; }

        [Required]
        [StringLength(500)]
        public string KategoriAdi { get; set; }
    }
}
