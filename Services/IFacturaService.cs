using WebSAT.Models;
using WebSAT.Models.ViewModels;

namespace WebSAT.Services
{
    public interface IFacturaService
    {
        Task<Factura> CrearFacturaAsync(FacturaViewModel facturaViewModel);
    }
}