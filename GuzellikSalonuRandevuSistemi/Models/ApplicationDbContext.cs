
using Microsoft.EntityFrameworkCore;

namespace GuzellikSalonuRandevuSistemi.Models;

using GuzellikSalonuRandevuSistemi.Data;



        public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<GuzellikSalonu> GuzellikSalonlari { get; set; }
        public DbSet<Kuafor> Kuaforler { get; set; }
        public DbSet<Islem> Islemler { get; set; }
        public DbSet<Randevu> Randevular { get; set; }

        // Override methods if needed for further customization
    }



