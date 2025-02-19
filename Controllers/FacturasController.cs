using Microsoft.AspNetCore.Mvc;
using WebSAT.Data;
using WebSAT.Models;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;


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
        return View();
    }

    // POST: Facturas/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Create([Bind("Version,Serie,Folio,Fecha,Sello,FormaPago,NoCertificado,Certificado,SubTotal,Moneda,Total,TipoDeComprobante,MetodoPago,LugarExpedicion,Emisor,Rfc,Nombre,RegimenFiscal,DomicilioFiscal,CodigoPostal,Receptor,Conceptos")] Factura factura)
    {
        if (ModelState.IsValid)
        {
            _context.Add(factura);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        return View(factura);
    }
}
