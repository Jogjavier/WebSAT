// Factura.cs

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace WebSAT.Models;

public class Factura
{
    [Key]
    public int Id { get; set; }
    
    [ForeignKey("Comprobante")]
    public Comprobante? Comprobante { get; set;}

    [ForeignKey("Emisor")]
    public int EmisorId { get; set; }
    public Emisor? Emisor { get; set;}

    [ForeignKey("Receptor")]
    public int ReceptorId { get; set; }
    public Receptor? Receptor { get; set; }

    [ForeignKey("Receptor")]
    public Conceptos? Conceptos { get; set; }

    [ForeignKey("Impuestos")]
    public Impuestos? Impuestos { get; set; }

    [ForeignKey("Complementos")]
    public Complementos? Complementos { get; set; }

    }

