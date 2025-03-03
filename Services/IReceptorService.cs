using WebSAT.Models.ViewModels;

namespace WebSAT.Services
{
    public interface IReceptorService
    {
        Task CrearReceptorAsync(ReceptorViewModel receptorViewModel);
    }
}