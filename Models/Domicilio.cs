// Domicilio.cs

using System.ComponentModel.DataAnnotations;

namespace WebSAT.Models;
public class Domicilio
{
    [Key]
    public int Id { get; set; }
    [Required] 
    public string Calle { get; set; }
    [Required]
    public string NumExt { get; set; }
    [Required]
    public string NumInt { get; set; }
    [Required]
    public string Colonia { get; set; }
    [Required]
    public string Localidad { get; set; }
    [Required]
    public string Municipio { get; set; }
    [Required]
    public string Estado { get; set; }
    [Required]
    public string CodigoPostal { get; set; }
}

