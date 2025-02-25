// ImpuestosViewModel.cs

namespace WebSAT.Models.ViewModels;

public class ImpuestosViewModel
{
    public decimal TotalImpuestosTrasladados { get; set; }
    public decimal TBase { get; set; }
    public string? TImpuesto { get; set; }
    public string? TTipoFactor { get; set; }
    public decimal TTasaOCuota { get; set; }
    public decimal TImporte { get; set; }
    public decimal TotalImpuestosRetenidos { get; set; }
    public decimal RBase { get; set; }
    public string? RImpuesto { get; set; }
    public string? RTipoFactor { get; set; }
    public decimal RTasaOCuota { get; set; }
    public decimal RImporte { get; set; }
}
