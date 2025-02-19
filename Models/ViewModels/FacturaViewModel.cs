public class FacturaViewModel
{
    public string? Version { get; set; }
    public string? Serie { get; set; }
    public string? Folio { get; set; }
    public DateTime Fecha { get; set; }
    public string? FormaPago { get; set; }
    public string? MetodoPago { get; set; }
    public string? LugarExpedicion { get; set; }
    public decimal Total { get; set; }

    // Datos del emisor
    public string? RfcEmisor { get; set; }
    public string? NombreEmisor { get; set; }
    public string? RegimenFiscalEmisor { get; set; }

    // Datos del receptor
    public string? RfcReceptor { get; set; }
    public string? NombreReceptor { get; set; }
    public string? UsoCFDIReceptor { get; set; }

    // Otros datos
    public List<ConceptoViewModel> ?Conceptos { get; set; }
}

public class ConceptoViewModel
{
    public string? ClaveProdServ { get; set; }
    public decimal? Cantidad { get; set; }
    public string? ClaveUnidad { get; set; }
    public string? Descripcion { get; set; }
    public decimal ValorUnitario { get; set; }
    public decimal Importe { get; set; }
}
