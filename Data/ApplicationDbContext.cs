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
        public DbSet<Concepto> Conceptos { get; set; }
        public DbSet<Impuesto> Impuestos { get; set; }
        public DbSet<Complemento> Complementos { get; set; }
    }
}
