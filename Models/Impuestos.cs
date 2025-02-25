// Impuestos.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models
{
    public class Impuestos
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public decimal TotalImpuestosTrasladados { get; set; }
        [ForeignKey("DetallesImpuestosTrasladados")]
        public DetallesImpuestos? DetallesImpuestosTrasladados { get; set; }
        [Required]
        public decimal TotalImpuestosRetenidos { get; set; }
        [ForeignKey("DetallesImpuestosRetenidos")]
        public DetallesImpuestos? DetallesImpuestosRetenidos { get; set; }
    }
}

