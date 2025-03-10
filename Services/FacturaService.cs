﻿using WebSAT.Data;
using WebSAT.Models.ViewModels;
using WebSAT.Models;
namespace WebSAT.Services;
public class FacturaService : IFacturaService
{
    private readonly ApplicationDbContext _context;

    public FacturaService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<Factura> CrearFacturaAsync(FacturaViewModel facturaViewModel)
    {
        var factura = new Factura
        {
            EmisorId = facturaViewModel.EmisorId,
            ReceptorId = facturaViewModel.ReceptorId,
        };

        _context.Facturas.Add(factura);
        await _context.SaveChangesAsync();

        return factura;
    }
}

