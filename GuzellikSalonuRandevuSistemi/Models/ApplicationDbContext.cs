using System.Collections.Generic;

namespace GuzellikSalonuRandevuSistemi.Models
{
    public class ApplicationDbContext
    {
        using Microsoft.EntityFrameworkCore;

public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Salon> Salons { get; set; }
        public DbSet<Calisan> Calisans { get; set; }
        public DbSet<Islem> Islems { get; set; }
        public DbSet<Randevu> Randevus { get; set; }

        // Override methods if needed for further customization
    }

}
}
