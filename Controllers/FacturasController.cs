using Microsoft.AspNetCore.Mvc;
using WebSAT.Data;
using WebSAT.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebSAT.Models.ViewModels;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

public class FacturasController : Controller
{
    private readonly ApplicationDbContext _context;

    public FacturasController(ApplicationDbContext context)
    {
        _context = context;
    }

    // GET: Facturas
    public async Task<IActionResult> Index()
    {
        var facturas = await _context.Facturas.ToListAsync(); 
        return View(facturas); 
    }

    // GET: Facturas/Create

    public IActionResult Create()
    {
        var emisores = _context.Emisores
            .Select(e => new SelectListItem
            {
                Value = e.Id.ToString(),
                Text = e.Nombre
            })
            .ToList();

        var receptores = _context.Receptores
            .Select(r => new SelectListItem
            {
                Value = r.Id.ToString(),
                Text = r.Nombre
            })
            .ToList();

        ViewBag.Emisores = emisores;
        ViewBag.Receptores = receptores;

        var facturaViewModel = new FacturaViewModel
        {
            Version = "4.0",
            Moneda = "MXN",
            Fecha = DateTime.Now
        };
        return View(facturaViewModel);
    }

    // POST: Facturas/Create
    [HttpPost]
    public IActionResult Create(FacturaViewModel facturaViewModel)
    {
        if (ModelState.IsValid)
        {
            var factura = new Factura
            {
                Version = facturaViewModel.Version ?? "default_version",
                Serie = facturaViewModel.Serie,
                Folio = facturaViewModel.Folio,
                Fecha = facturaViewModel.Fecha,
                SubTotal = facturaViewModel.SubTotal,
                Moneda = facturaViewModel.Moneda ?? "default_moneda",
                Total = facturaViewModel.Total,
                TipoDeComprobante = facturaViewModel.TipoDeComprobante,
                MetodoPago = facturaViewModel.MetodoPago,
                LugarExpedicion = facturaViewModel.LugarExpedicion,
                EmisorId = facturaViewModel.EmisorId,
                ReceptorId = facturaViewModel.ReceptorId
            };

            _context.Facturas.Add(factura);
            _context.SaveChanges();

            return RedirectToAction("Index");
        }
        return View(facturaViewModel);
    }
}
