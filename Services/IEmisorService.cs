using WebSAT.Models.ViewModels;

namespace WebSAT.Services
{
    public interface IEmisorService
    {
        Task CrearEmisorAsync(EmisorViewModel emisorViewModel);
    }
}