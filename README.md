# Layout para Factura Electrónica (CFDI) según Anexo 20 del SAT

Este documento describe los campos obligatorios y opcionales necesarios para generar un layout de factura electrónica en México conforme al Anexo 20 del SAT.

---

## 1. Datos generales del CFDI

### Campos obligatorios:
- **Version**: Versión del CFDI (ej. 4.0).
- **Serie**: Serie de la factura (opcional, pero recomendado para control interno).
- **Folio**: Número de folio de la factura (opcional, pero recomendado para control interno).
- **Fecha**: Fecha y hora de expedición (formato: `AAAA-MM-DDThh:mm:ss`).
- **Sello**: Sello digital del CFDI.
- **FormaPago**: Condiciones de pago (clave del catálogo del SAT).
- **NoCertificado**: Número de certificado del CSD (Certificado de Sello Digital).
- **Certificado**: Certificado del emisor en formato base64.
- **SubTotal**: Importe antes de impuestos.
- **Moneda**: Moneda del comprobante (clave del catálogo del SAT, ej. MXN).
- **Total**: Importe total del comprobante.
- **TipoDeComprobante**: Tipo de comprobante (ingreso, egreso, traslado, etc.).
- **MetodoPago**: Método de pago (clave del catálogo del SAT).
- **LugarExpedicion**: Código postal del lugar de expedición.

---

## 2. Datos del emisor

### Campos obligatorios:
- **Rfc**: RFC del emisor.
- **Nombre**: Nombre o razón social del emisor.
- **RegimenFiscal**: Régimen fiscal del emisor (clave del catálogo del SAT).

### Campos opcionales:
- **DomicilioFiscal**: Domicilio fiscal del emisor.
- **CodigoPostal**: Código postal del domicilio fiscal.

---

## 3. Datos del receptor

### Campos obligatorios:
- **Rfc**: RFC del receptor (si es público general, usar `XAXX010101000`).
- **Nombre**: Nombre o razón social del receptor.
- **UsoCFDI**: Uso del CFDI (clave del catálogo del SAT, ej. G03 - Gastos en general).

### Campos opcionales:
- **Domicilio**: Domicilio del receptor.
- **CodigoPostal**: Código postal del receptor.

---

## 4. Conceptos

### Campos obligatorios por concepto:
- **ClaveProdServ**: Clave del producto o servicio (catálogo del SAT).
- **Cantidad**: Cantidad de unidades.
- **ClaveUnidad**: Clave de la unidad de medida (catálogo del SAT).
- **Descripcion**: Descripción del concepto.
- **ValorUnitario**: Valor unitario del concepto.
- **Importe**: Importe total del concepto (cantidad * valor unitario).

### Campos opcionales:
- **Descuento**: Descuento aplicado al concepto.
- **Impuestos**: Impuestos trasladados o retenidos por concepto.

---

## 5. Impuestos

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

## 6. Complementos

### Complementos obligatorios (según el caso):
- **Complemento de pago**: Si el CFDI es un comprobante de pago.
- **Complemento de comercio exterior**: Si aplica para operaciones de comercio exterior.
- **Complemento de timbre fiscal**: Generado por el PAC (Proveedor Autorizado de Certificación).

### Estructura:
- Cada complemento debe incluir los campos requeridos según el Anexo 20 y las reglas de validación del SAT.

---

## 7. Sello digital y cadena original

### Sello digital:
- Generado con el Certificado de Sello Digital (CSD) del emisor.
- Debe cumplir con los estándares criptográficos del SAT.

### Cadena original:
- Cadena generada a partir de los datos del CFDI, siguiendo el formato especificado por el SAT.
- Se utiliza para generar el sello digital.

---

## 8. Otros datos relevantes

### Campos adicionales:
- **CondicionesDePago**: Condiciones comerciales de pago.
- **TipoCambio**: Tipo de cambio (si la moneda es diferente a MXN).
- **NumCtaPago**: Número de cuenta de pago (opcional).

### Validaciones:
- Verificar que todos los campos obligatorios estén completos.
- Asegurar que los valores numéricos estén redondeados correctamente.
- Validar que las claves del catálogo del SAT sean correctas.---
