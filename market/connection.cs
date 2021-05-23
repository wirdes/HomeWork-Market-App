using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace market
{
    public partial class connection : DbContext
    {
        public connection()
            : base("name=Model16")
        {
        }

        public virtual DbSet<borc> borc { get; set; }
        public virtual DbSet<irsaliye> irsaliye { get; set; }
        public virtual DbSet<musteriler> musteriler { get; set; }
        public virtual DbSet<musteriOzet> musteriOzet { get; set; }
        public virtual DbSet<satici> satici { get; set; }
        public virtual DbSet<satis> satis { get; set; }
        public virtual DbSet<tedarikci> tedarikci { get; set; }
        public virtual DbSet<urunler> urunler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<musteriler>()
                .Property(e => e.isimSoyisim)
                .IsUnicode(false);

            modelBuilder.Entity<musteriler>()
                .Property(e => e.telNO)
                .IsUnicode(false);

            modelBuilder.Entity<musteriler>()
                .HasMany(e => e.musteriOzet)
                .WithOptional(e => e.musteriler)
                .WillCascadeOnDelete();

            modelBuilder.Entity<musteriler>()
                .HasMany(e => e.satis)
                .WithOptional(e => e.musteriler)
                .WillCascadeOnDelete();

            modelBuilder.Entity<satici>()
                .HasMany(e => e.satis)
                .WithOptional(e => e.satici)
                .WillCascadeOnDelete();

            modelBuilder.Entity<satis>()
                .Property(e => e.satisTipi)
                .IsUnicode(false);

            modelBuilder.Entity<tedarikci>()
                .Property(e => e.isim)
                .IsUnicode(false);

            modelBuilder.Entity<urunler>()
                .Property(e => e.urunAdi)
                .IsUnicode(false);

            modelBuilder.Entity<urunler>()
                .Property(e => e.kategori)
                .IsUnicode(false);



            modelBuilder.Entity<urunler>()
                .HasMany(e => e.satis)
                .WithOptional(e => e.urunler)
                .WillCascadeOnDelete();
        }
    }
}
