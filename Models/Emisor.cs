// Emisor.cs

using System.ComponentModel.DataAnnotations;

namespace WebSAT.Models
{
    public class Emisor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(13)]
        public required string RFC { get; set; }

        [Required]
        [MaxLength(255)]
        public required string Nombre { get; set; }

        [Required]
        public required string RegimenFiscal { get; set; }

        // Relación con Factura
        public required ICollection<Factura> Facturas { get; set; }
    }
}
