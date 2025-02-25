// Impuesto.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models
{
    public class Impuesto
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Tipo { get; set; } // IVA, ISR, IEPS, etc.

        [Required]
        public string? TasaOCuota { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Importe { get; set; }

        // Relación con Concepto
        [ForeignKey("Concepto")]
        public int ConceptoId { get; set; }
        public Concepto? Concepto { get; set; }
    }
}
