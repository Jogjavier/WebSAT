using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSAT.Data;
using WebSAT.Models;
using WebSAT.Models.ViewModels;
namespace WebSAT.Service
{
    public class ReceptorService
    {
        private readonly ApplicationDbContext _context;

        public ReceptorService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CrearReceptorAsync(ReceptorViewModel receptorViewModel)
        {
            var receptor = new Receptor
            {
                RFC = receptorViewModel.RFC,
                Nombre = receptorViewModel.Nombre,
            };

            _context.Receptores.Add(receptor);
            await _context.SaveChangesAsync();
        }
    }
}
