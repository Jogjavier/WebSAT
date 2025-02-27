using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using WebSAT.Data;
using WebSAT.Models;
using WebSAT.Models.ViewModels;
namespace WebSAT.Service
{
    public class ComprobanteService
    {
        private readonly ApplicationDbContext _context;

        public ComprobanteService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task CrearComprobanteAsync(ComprobanteViewModel comprobanteViewModel)
        {
            var comprobante = new Comprobante
            {
                Fecha = comprobanteViewModel.Fecha,
                SubTotal = comprobanteViewModel.SubTotal
            };

            _context.Comprobantes.Add(comprobante);
            await _context.SaveChangesAsync();
        }
    }

}
