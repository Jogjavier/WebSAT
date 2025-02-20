using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebSAT.Migrations
{
    /// <inheritdoc />
    public partial class AgregarEntidadesCFDI : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Emisores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RFC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    RegimenFiscal = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Emisores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Receptores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RFC = table.Column<string>(type: "nvarchar(13)", maxLength: 13, nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UsoCFDI = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Receptores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Facturas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Version = table.Column<string>(type: "nvarchar(5)", maxLength: 5, nullable: false),
                    Serie = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Folio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Fecha = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sello = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FormaPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NoCertificado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Certificado = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Moneda = table.Column<string>(type: "nvarchar(3)", maxLength: 3, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TipoDeComprobante = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MetodoPago = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LugarExpedicion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmisorId = table.Column<int>(type: "int", nullable: false),
                    ReceptorId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Facturas", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Facturas_Emisores_EmisorId",
                        column: x => x.EmisorId,
                        principalTable: "Emisores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Facturas_Receptores_ReceptorId",
                        column: x => x.ReceptorId,
                        principalTable: "Receptores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Complementos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatosAdicionales = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Complementos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Complementos_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Conceptos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ClaveProdServ = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cantidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ClaveUnidad = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Descripcion = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    ValorUnitario = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Importe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    FacturaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Conceptos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Conceptos_Facturas_FacturaId",
                        column: x => x.FacturaId,
                        principalTable: "Facturas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Impuestos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Tipo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TasaOCuota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Importe = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ConceptoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Impuestos", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Impuestos_Conceptos_ConceptoId",
                        column: x => x.ConceptoId,
                        principalTable: "Conceptos",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Complementos_FacturaId",
                table: "Complementos",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Conceptos_FacturaId",
                table: "Conceptos",
                column: "FacturaId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_EmisorId",
                table: "Facturas",
                column: "EmisorId");

            migrationBuilder.CreateIndex(
                name: "IX_Facturas_ReceptorId",
                table: "Facturas",
                column: "ReceptorId");

            migrationBuilder.CreateIndex(
                name: "IX_Impuestos_ConceptoId",
                table: "Impuestos",
                column: "ConceptoId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Complementos");

            migrationBuilder.DropTable(
                name: "Impuestos");

            migrationBuilder.DropTable(
                name: "Conceptos");

            migrationBuilder.DropTable(
                name: "Facturas");

            migrationBuilder.DropTable(
                name: "Emisores");

            migrationBuilder.DropTable(
                name: "Receptores");
        }
    }
}
