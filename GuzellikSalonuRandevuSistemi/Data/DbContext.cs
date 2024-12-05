using Microsoft.EntityFrameworkCore;

namespace GuzellikSalonuRandevuSistemi.Models
{
    using Microsoft.EntityFrameworkCore;

    namespace GuzellikRandevuSistemi.Models
    {
        namespace GuzellikSalonuRandevuSistemi.Models
        {
            using global::GuzellikSalonuRandevuSistemi.Models.GuzellikSalonuRandevuSistemi.Models;
            using Microsoft.EntityFrameworkCore;

            public class GuzellikRandevuDbContext : DbContext
            {
                public GuzellikRandevuDbContext(DbContextOptions<GuzellikRandevuDbContext> options)
                    : base(options)
                {
                }

                // Tabloları temsil eden DbSet'ler
                public DbSet<Islem> Islemler { get; set; }
                public DbSet<GuzellikSalonu> GuzellikSalonlari { get; set; }
                public DbSet<Kuafor> Kuaforler { get; set; }
                public DbSet<Musteri> Musteriler { get; set; }
                public DbSet<Randevu> Randevular { get; set; }
                public DbSet<CalismaSaatleri> CalismaSaatleri { get; set; }

                // Fluent API ile veritabanı yapılandırması
                protected override void OnModelCreating(ModelBuilder modelBuilder)
                {
                    base.OnModelCreating(modelBuilder);

                    // Tablo adlarını özelleştirme
                    modelBuilder.Entity<Islem>().ToTable("Islemler");
                    modelBuilder.Entity<GuzellikSalonu>().ToTable("GuzellikSalonlari");
                    modelBuilder.Entity<Kuafor>().ToTable("Kuaforler");
                    modelBuilder.Entity<Musteri>().ToTable("Musteriler");
                    modelBuilder.Entity<Randevu>().ToTable("Randevular");
                    modelBuilder.Entity<CalismaSaatleri>().ToTable("CalismaSaatleri");

                    // Fluent API ile ilişki yapılandırmaları
                    modelBuilder.Entity<Kuafor>()
                        .HasMany(k => k.CalismaSaatleri)
                        .WithOne(c => c.Kuafor)
                        .HasForeignKey(c => c.KuaforId);

                    modelBuilder.Entity<Randevu>()
                        .HasOne(r => r.Kuafor)
                        .WithMany(k => k.Randevular)
                        .HasForeignKey(r => r.KuaforId);

                    modelBuilder.Entity<Randevu>()
                        .HasOne(r => r.Musteri)
                        .WithMany(m => m.Randevular)
                        .HasForeignKey(r => r.MusteriId);

                    modelBuilder.Entity<Randevu>()
                        .HasOne(r => r.Islem)
                        .WithMany(i => i.Randevular)
                        .HasForeignKey(r => r.IslemId);
                }
            }
        }
    }
}
