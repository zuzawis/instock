using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace InStock.Database
{
    public class InStockDatabase : DbContext
    {
        public DbSet<Produkt> Produkty { get; set; }
        public DbSet<Powiadomienie> Powiadomienia { get; set; }
        public DbSet<Sprzedaz> Sprzedaz { get; set; }
        public DbSet<StanSklepu> StanSklepu { get; set; }

        public InStockDatabase(DbContextOptions<InStockDatabase> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Produkt>().HasIndex(x => x.Kod).IsUnique();
        }
    }
}
