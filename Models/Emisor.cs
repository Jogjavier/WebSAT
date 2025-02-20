using System.ComponentModel.DataAnnotations;

namespace WebSAT.Models
{
    public class Emisor
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(13)]
        public string RFC { get; set; }

        [Required]
        [MaxLength(255)]
        public string Nombre { get; set; }

        [Required]
        public string RegimenFiscal { get; set; }

        // Relación con Factura
        public ICollection<Factura> Facturas { get; set; }
    }
}
