// Complemento.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models
{
    public class Complemento
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string? Tipo { get; set; }

        public string? DatosAdicionales { get; set; }

        // Relación con Factura
        [ForeignKey("Factura")]
        public int FacturaId { get; set; }
        public Factura? Factura { get; set; }
    }
}
