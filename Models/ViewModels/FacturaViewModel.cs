// FacturaViewModel.cs

namespace WebSAT.Models.ViewModels;
public class FacturaViewModel
{
    public ComprobanteViewModel? Comprobante { get; set; }
    public int EmisorId { get; set; } 
    public EmisorViewModel? Emisor { get; set; }
    public int ReceptorId { get; set; }
    public ReceptorViewModel? Receptor { get; set; }
    public ConceptosViewModel? Conceptos { get; set; }
    public ImpuestosViewModel? Impuestos { get; set; }
    public ComplementosViewModel? Complementos { get; set; } 
}

