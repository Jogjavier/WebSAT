// FacturaViewModel.cs

namespace WebSAT.Models.ViewModels;
public class FacturaViewModel
{
    public string? Version { get; set; }
    public string? Serie { get; set; }
    public string? Folio { get; set; }
    public DateTime Fecha { get; set; }
    public string? FormaPago { get; set; }
    public string? MetodoPago { get; set; }
    public string? LugarExpedicion { get; set; }
    public decimal SubTotal { get; set; }
    public string? Moneda { get; set; }
    public decimal Total { get; set; }
    public string? TipoDeComprobante { get; set; } 

    public int EmisorId { get; set; } 
    public EmisorViewModel? Emisor { get; set; }
    public int ReceptorId { get; set; }
    public ReceptorViewModel? Receptor { get; set; }

    public List<ConceptoViewModel> ?Conceptos { get; set; }
}







