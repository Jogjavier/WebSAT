// ConceptoViewModel.cs

namespace WebSAT.Models.ViewModels;

public class ConceptoViewModel
{
    public string? ClaveProdServ { get; set; }
    public decimal? Cantidad { get; set; }
    public string? ClaveUnidad { get; set; }
    public string? Descripcion { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal Importe { get; set; }
}