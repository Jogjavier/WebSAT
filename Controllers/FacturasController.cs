// FacturasController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebSAT.Models.ViewModels;
using WebSAT.Services; 

namespace WebSAT.Controllers
{
    public class FacturaController : Controller
    {
        private readonly IFacturaService _facturaService;
        private readonly IComprobanteService _comprobanteService;
        private readonly IEmisorService _emisorService;
        private readonly IReceptorService _receptorService;

        public FacturaController(IFacturaService facturaService, IComprobanteService comprobanteService, IEmisorService emisorService, IReceptorService receptorService)
        {
            _facturaService = facturaService;
            _comprobanteService = comprobanteService;
            _emisorService = emisorService;
            _receptorService = receptorService;
        }

        public async Task<IActionResult> Create(FacturaViewModel facturaViewModel, ComprobanteViewModel comprobanteViewModel,EmisorViewModel emisorViewModel, ReceptorViewModel receptorViewModel)
        {
            if (ModelState.IsValid)
            {
                var factura = await _facturaService.CrearFacturaAsync(facturaViewModel);
                await _comprobanteService.CrearComprobanteAsync(comprobanteViewModel);
                await _emisorService.CrearEmisorAsync(emisorViewModel);
                await _receptorService.CrearReceptorAsync(receptorViewModel);

                return RedirectToAction("Index");
            }
            return View(facturaViewModel);
        }
    }

}



