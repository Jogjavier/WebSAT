// Concepto.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models
{
    public class Concepto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? ClaveProdServ { get; set; }

        [Required]
        public string? Cantidad { get; set; }

        [Required]
        public string? ClaveUnidad { get; set; }

        [Required]
        [MaxLength(255)]
        public string? Descripcion { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ValorUnitario { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Importe { get; set; }

        // Relación con Factura
        [ForeignKey("Factura")]
        public int FacturaId { get; set; }
        public Factura? Factura { get; set; }
    }
}
