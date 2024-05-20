using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace PizzaWebMVCProje.Models
{
    public partial class Model1 : DbContext
    {
        public Model1()
            : base("name=Model1")
        {
        }

        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<tblKategoriler> tblKategoriler { get; set; }
        public virtual DbSet<tblKullanici> tblKullanici { get; set; }
        public virtual DbSet<tblMusteriler> tblMusteriler { get; set; }
        public virtual DbSet<tblSatislar> tblSatislar { get; set; }
        public virtual DbSet<tblSiparisler> tblSiparisler { get; set; }
        public virtual DbSet<tblUrunler> tblUrunler { get; set; }
        public virtual DbSet<Yoneticiler> Yoneticiler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<tblKullanici>()
                .Property(e => e.UserName)
                .IsUnicode(false);

            modelBuilder.Entity<tblKullanici>()
                .Property(e => e.Sifre)
                .IsUnicode(false);

            modelBuilder.Entity<tblKullanici>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<tblKullanici>()
                .Property(e => e.Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<tblKullanici>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Yoneticiler>()
                .Property(e => e.Ad)
                .IsUnicode(false);

            modelBuilder.Entity<Yoneticiler>()
                .Property(e => e.Soyad)
                .IsUnicode(false);

            modelBuilder.Entity<Yoneticiler>()
                .Property(e => e.Mail)
                .IsUnicode(false);

            modelBuilder.Entity<Yoneticiler>()
                .Property(e => e.Sifre)
                .IsUnicode(false);
        }
    }
}
