// ComprobanteViewModel.cs

namespace WebSAT.Models.ViewModels;
public class ComprobanteViewModel
{
    public string? Version { get; set; }
    public DateTime Fecha { get; set; }
    public string? TipoDeComprobante { get; set; }
    public string? Moneda { get; set; }
    public decimal SubTotal { get; set; }
    public decimal Total { get; set; }
    public string? LugarExpedicion { get; set; }
    public string? FormaPago { get; set; }
    public string? MetodoPago { get; set; }
}
