using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class datosPruebaMotivos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("315a7096-1389-4db2-aed4-a423fb96eb5e"),
                columns: new[] { "Descripcion", "UnidadAdministrativaID" },
                values: new object[] { "Problemas al realizar su denuncia en línea", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") });

            migrationBuilder.UpdateData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("a4bf6977-c3f2-4552-ad40-a159cacfda51"),
                columns: new[] { "Descripcion", "UnidadAdministrativaID" },
                values: new object[] { "Problemas al realizar su cita para la expedición de Constancias de No Antecedentes Penales", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") });

            migrationBuilder.InsertData(
                table: "Motivos",
                columns: new[] { "MotivoID", "Descripcion", "UnidadAdministrativaID" },
                values: new object[,]
                {
                    { new Guid("500c6720-b3a1-4d33-b13b-cda184ece0ab"), "Campos de texto ambiguos", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("841865d4-a0c8-4fb6-978b-a2944451f7a1"), "proceso complejo", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("b306b384-a08a-453c-b3eb-a6e9a7496de5"), "Mal diseño en la página", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("c45de56d-98d3-4203-a05e-b6b017dcf9ed"), "Falta opción para adjuntar evidecia", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("22f266a9-a718-4b23-8c95-53c2e6bf585a"), "Opción requerida no aparece", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("584de2c5-eb29-49e3-a847-da57e7fa64f5"), "Datos desconocidos obligatorios en formulario", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("bd518516-0b31-4aa6-b943-a9ceeeec5d65"), "No hay citas disponibles", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("2a22677f-12d6-45fc-b84c-3200e1400415"), "Fallas en la página", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("1fd4973f-ae52-4461-b587-20fd6f57261d"), "No aparece mi colonia", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("c8fbcf31-db11-47f5-86b8-eaf199ac49fc"), "Negación del servicio por falta de cita", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("c05a58b3-e59d-42cf-8f63-8683b4406d91"), "Ténicismo en los datos solicitados", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("d4a31a24-9d57-49c3-9859-912901caed9a"), "El proceso del trámite es muy tardado", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("6fa74793-8c90-4428-a3be-b06b77061460"), "Queja con la integración de su expediente", new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78") },
                    { new Guid("6ce6caa2-03ec-4274-b6c3-075203cfc0a4"), "Correo de confirmación no llegó o tardó demasiado tiempo", new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4") },
                    { new Guid("55ac0719-3d48-4e85-bdc1-55058aaf5ffa"), "Queja con la atención de algún servidor público", new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78") }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("1fd4973f-ae52-4461-b587-20fd6f57261d"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("22f266a9-a718-4b23-8c95-53c2e6bf585a"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("2a22677f-12d6-45fc-b84c-3200e1400415"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("500c6720-b3a1-4d33-b13b-cda184ece0ab"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("55ac0719-3d48-4e85-bdc1-55058aaf5ffa"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("584de2c5-eb29-49e3-a847-da57e7fa64f5"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("6ce6caa2-03ec-4274-b6c3-075203cfc0a4"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("6fa74793-8c90-4428-a3be-b06b77061460"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("841865d4-a0c8-4fb6-978b-a2944451f7a1"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("b306b384-a08a-453c-b3eb-a6e9a7496de5"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("bd518516-0b31-4aa6-b943-a9ceeeec5d65"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("c05a58b3-e59d-42cf-8f63-8683b4406d91"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("c45de56d-98d3-4203-a05e-b6b017dcf9ed"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("c8fbcf31-db11-47f5-86b8-eaf199ac49fc"));

            migrationBuilder.DeleteData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("d4a31a24-9d57-49c3-9859-912901caed9a"));

            migrationBuilder.UpdateData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("315a7096-1389-4db2-aed4-a423fb96eb5e"),
                columns: new[] { "Descripcion", "UnidadAdministrativaID" },
                values: new object[] { "Problema al hacer cita para Antecendentes no penales", new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78") });

            migrationBuilder.UpdateData(
                table: "Motivos",
                keyColumn: "MotivoID",
                keyValue: new Guid("a4bf6977-c3f2-4552-ad40-a159cacfda51"),
                columns: new[] { "Descripcion", "UnidadAdministrativaID" },
                values: new object[] { "Falta a la moral", new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78") });
        }
    }
}
