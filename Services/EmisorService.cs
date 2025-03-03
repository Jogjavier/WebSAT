using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSAT.Data;
using WebSAT.Models;
using WebSAT.Models.ViewModels;

namespace WebSAT.Services
{
    public class EmisorService : IEmisorService
    {
        private readonly ApplicationDbContext _context;

        public EmisorService(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task CrearEmisorAsync(EmisorViewModel emisorViewModel)
        {
            var emisor = new Emisor
            {
                RFC = emisorViewModel.RFC,
                Nombre = emisorViewModel.Nombre,
                RegimenFiscal = emisorViewModel.RegimenFiscal
            };

            _context.Emisores.Add(emisor);
            await _context.SaveChangesAsync();
        }
    }
}
