// ApplicationDbContext.cs

using Microsoft.EntityFrameworkCore;
using WebSAT.Models;

namespace WebSAT.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Factura> Facturas { get; set; }
        public DbSet<Emisor> Emisores { get; set; }
        public DbSet<Receptor> Receptores { get; set; }
        public DbSet<Conceptos> Conceptos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            modelBuilder.Entity<Factura>()
                .HasOne(f => f.Emisor)
                .WithMany(e => e.)
                .HasForeignKey(f => f.EmisorId);

            modelBuilder.Entity<Factura>()
                .HasOne(f => f.Receptor)
                .WithMany(r => r.Facturas)
                .HasForeignKey(f => f.ReceptorId);

            modelBuilder.Entity<Factura>()
                .HasMany(f => f.Conceptos)
                .WithOne(c => c.Factura)
                .HasForeignKey(c => c.FacturaId);
        }
    }
}
