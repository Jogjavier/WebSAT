// DomicilioViewModel.cs

namespace WebSAT.Models.ViewModels;
public class DomicilioViewModel
{
    public string Calle { get; set; }
    public string NumExt { get; set; }
    public string NumInt { get; set; }
    public string Colonia { get; set; }
    public string Localidad { get; set; }
    public string Municipio { get; set; }
    public string Estado { get; set; }
    public string CodigoPostal { get; set; }
}