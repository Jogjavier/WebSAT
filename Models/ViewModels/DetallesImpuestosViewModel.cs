// DetallesImpuestosViewModel.cs

namespace WebSAT.Models.ViewModels;
public class DetallesImpuestosViewModel
{
    public decimal? Base { get; set; }
    public string? Impuesto { get; set; }
    public string? TipoFactor { get; set; }
    public decimal? TasaOCuota { get; set; }
    public decimal? Importe { get; set; }
}