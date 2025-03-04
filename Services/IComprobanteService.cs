using WebSAT.Models.ViewModels;

namespace WebSAT.Services
{
    public interface IComprobanteService
    {
        Task CrearComprobanteAsync(ComprobanteViewModel comprobanteViewModel);
    }
}