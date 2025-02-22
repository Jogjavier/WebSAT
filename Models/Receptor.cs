// Receptor.cs

using System.ComponentModel.DataAnnotations;

namespace WebSAT.Models
{
    public class Receptor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(13)]
        public string? RFC { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Nombre { get; set; }

        [Required]
        public string? UsoCFDI { get; set; }

        // Relación con Factura
        public ICollection<Factura> ?Facturas { get; set; }
    }
}
