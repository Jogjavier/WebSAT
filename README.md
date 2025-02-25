# Layout para Factura Electrónica (CFDI) según Anexo 20 del SAT

Este documento describe los campos obligatorios y opcionales necesarios para generar un layout de factura electrónica en México conforme al Anexo 20 del SAT.

---

## cfdi:Comprobante

### Campos obligatorios:
- **Version**: Versión del CFDI (ej. 4.0).
- **Fecha**: Fecha y hora de expedición (formato: `AAAA-MM-DDThh:mm:ss`).
- **TipoDeComprobante**: Tipo de comprobante (por ejemplo, "I" para ingresos, "E" para egresos, etc.).
- **Moneda**: Moneda del comprobante (clave del catálogo del SAT, ej. MXN).
- **SubTotal**: Importe antes de impuestos.
- **Total**: Importe total del comprobante.
- **LugarExpedicion**: Código postal del lugar de expedición.
- **FormaPago**: Condiciones de pago (clave del catálogo del SAT).
- **MetodoPago**: Método de pago (clave del catálogo del SAT).

---

## cfdi:Emisor

### Campos obligatorios:
- **Rfc**: RFC del emisor.
- **Nombre**: Nombre o razón social del emisor.
- **RegimenFiscal**: Régimen fiscal del emisor (clave del catálogo del SAT).

---

## cfdi:Receptor

### Campos obligatorios:
- **Rfc**: RFC del receptor (si es público general, usar `XAXX010101000`).
- **Nombre**: Nombre o razón social del receptor.
- **UsoCFDI**: Uso del CFDI (clave del catálogo del SAT, ej. G03 - Gastos en general).
- **Domicilio**: Domicilio del receptor.
- **CodigoPostal**: Código postal del receptor.

---

## cfdi:Conceptos

### Campos obligatorios por concepto:
- **ClaveProdServ**: Clave del producto o servicio (catálogo del SAT).
- **Cantidad**: Cantidad de unidades.
- **ClaveUnidad**: Clave de la unidad de medida (catálogo del SAT).
- **Descripcion**: Descripción del concepto.
- **ValorUnitario**: Valor unitario del concepto.
- **Importe**: Importe total del concepto (cantidad * valor unitario).

---

## cfdi:Impuestos

### Campos obligatorios:
- **TotalImpuestosTrasladados**: Suma de impuestos trasladados.
- **TotalImpuestosRetenidos**: Suma de impuestos retenidos.

### Detalle de impuestos:
#### Traslados:
- **Base**: Base sobre la que se calcula el impuesto.
- **Impuesto**: Tipo de impuesto (ej. IVA, ISR).
- **TipoFactor**: Tipo de factor (ej. Tasa, Cuota).
- **TasaOCuota**: Tasa o cuota del impuesto.
- **Importe**: Importe del impuesto.

#### Retenciones:
- **Base**: Base sobre la que se calcula el impuesto.
- **Impuesto**: Tipo de impuesto (ej. IVA, ISR).
- **TipoFactor**: Tipo de factor (ej. Tasa, Cuota).
- **TasaOCuota**: Tasa o cuota del impuesto.
- **Importe**: Importe del impuesto.

---

## cfdi:Complemento

### Complementos obligatorios (según el caso):
- **Complemento de pago**: Si el CFDI es un comprobante de pago.
- **Complemento de comercio exterior**: Si aplica para operaciones de comercio exterior.
- **Complemento de timbre fiscal**: Generado por el PAC (Proveedor Autorizado de Certificación).

---

## Sello digital y cadena original

### Sello digital:
- Generado con el Certificado de Sello Digital (CSD) del emisor.
- Debe cumplir con los estándares criptográficos del SAT.

### Cadena original:
- Cadena generada a partir de los datos del CFDI, siguiendo el formato especificado por el SAT.
- Se utiliza para generar el sello digital.


