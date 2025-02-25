// Conceptos.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models;

public class Conceptos
{
    [Key]
    public int Id { get; set; }
    // Bienes y servicios rellenar datos
    [Required]
    public string ClaveProdServ { get; set; }
    [Required]
    public decimal Cantidad { get; set; }
    [Required]
    public string ClaveUnidad { get; set; }
    [Required]
    [MaxLength(255)]
    public string Descripcion { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal ValorUnitario { get; set; }
    [Required]
    [Column(TypeName = "decimal(18,2)")]
    public decimal Importe { get; set; }
}

