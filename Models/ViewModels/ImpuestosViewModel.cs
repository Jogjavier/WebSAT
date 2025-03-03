// ImpuestosViewModel.cs

namespace WebSAT.Models.ViewModels;
public class ImpuestosViewModel
{
    public decimal TotalImpuestosTrasladados { get; set; }
    public DetallesImpuestosViewModel? DetallesImpuestosTrasladados { get; set; }
    public decimal TotalImpuestosRetenidos { get; set; }
    public DetallesImpuestosViewModel? DetallesImpuestosRetenidos { get; set; }
}
