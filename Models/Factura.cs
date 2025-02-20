using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models
{
    public class Factura
    {
        [Key]
        public int Id { get; set; }
        
        [Required]
        [MaxLength(5)]
        public string Version { get; set; } = "4.0";

        public string? Serie { get; set; }
        public string? Folio { get; set; }

        [Required]
        public DateTime Fecha { get; set; } = DateTime.Now;

        public string? Sello { get; set; }

        [Required]
        public string? FormaPago { get; set; }

        [Required]
        public string ?NoCertificado { get; set; }

        public string? Certificado { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }

        [Required]
        [MaxLength(3)]
        public string Moneda { get; set; } = "MXN";

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }

        [Required]
        public string ?TipoDeComprobante { get; set; }

        [Required]
        public string? MetodoPago { get; set; }

        [Required]
        public string? LugarExpedicion { get; set; }

        // Relación con Emisor y Receptor
        [ForeignKey("Emisor")]
        public int EmisorId { get; set; }
        public Emisor? Emisor { get; set;}

        [ForeignKey("Receptor")]
        public int ReceptorId { get; set; }
        public Receptor ?Receptor { get; set; }
        public List<Concepto> ?Conceptos { get; set; }
    }
}
