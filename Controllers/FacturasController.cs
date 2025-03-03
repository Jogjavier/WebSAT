// FacturasController.cs

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System;
using System.Threading.Tasks;
using WebSAT.Models.ViewModels;
using WebSAT.Service; 

namespace WebSAT.Controllers
{
    public class FacturaController : Controller
    {
        private readonly FacturaService _facturaService;
        private readonly ComprobanteService _comprobanteService;
        private readonly EmisorService _emisorService;
        private readonly ReceptorService _receptorService;

        public FacturaController(FacturaService facturaService, ComprobanteService comprobanteService, EmisorService emisorService, ReceptorService receptorService)
        {
            _facturaService = facturaService;
            _comprobanteService = comprobanteService;
            _emisorService = emisorService;
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



