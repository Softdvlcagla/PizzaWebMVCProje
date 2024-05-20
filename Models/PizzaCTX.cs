using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PizzaWebMVCProje.Models
{
    public partial class PizzaCTX : DbContext
    {
        public PizzaCTX()
            : base("name=PizzaCTX")
        {
        }

        public virtual DbSet<Kullanicilar> Kullanicilar { get; set; }
        public virtual DbSet<tblKategoriler> tblKategoriler { get; set; }
        public virtual DbSet<tblMusteriler> tblMusteriler { get; set; }
        public virtual DbSet<tblSatislar> tblSatislar { get; set; }
        public virtual DbSet<tblSiparisler> tblSiparisler { get; set; }
        public virtual DbSet<tblUrunler> tblUrunler { get; set; }
        public virtual DbSet<Yoneticiler> Yoneticiler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
