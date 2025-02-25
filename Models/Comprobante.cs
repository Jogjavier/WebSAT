// Comprobante.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models;
public class Comprobante
{
    [Key]
    public int Id { get; set; }
    [Required]
    public string Estatus { get; set; }
    [Required]
    public DateTime Fecha { get; set; } = DateTime.Now;
    [Required]
    public string TipoDeComprobante { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal SubTotal { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Total { get; set; }
    [Required]
    public string MetodoPago { get; set; }
}

