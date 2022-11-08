using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class AgregarUnidadEnUsuario : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "UnidadAdministrativaID",
                table: "Usuarios",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.InsertData(
                table: "Departamentos",
                columns: new[] { "DepartamentoID", "Nombre" },
                values: new object[] { new Guid("8ecec734-2171-4bec-aaec-eba010af2489"), "General" });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolID", "Nombre" },
                values: new object[] { new Guid("942f1900-7987-4820-a40b-7f4b78099d85"), "Administrativo" });

            migrationBuilder.InsertData(
                table: "UnidadAdministrativas",
                columns: new[] { "UnidadAdministrativaID", "Nombre" },
                values: new object[] { new Guid("88f8cf91-458b-438c-b882-75a842387c64"), "GENERAL" });

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"),
                column: "UnidadAdministrativaID",
                value: new Guid("88f8cf91-458b-438c-b882-75a842387c64"));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("7467db95-c0a1-41df-a844-bbb00b60b952"),
                column: "UnidadAdministrativaID",
                value: new Guid("88f8cf91-458b-438c-b882-75a842387c64"));

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("a22533a6-7621-492c-b10b-a9363668a2f4"),
                column: "UnidadAdministrativaID",
                value: new Guid("88f8cf91-458b-438c-b882-75a842387c64"));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioID", "Activo", "Clave", "Correo", "DepartamentoID", "Nombre", "RolID", "UnidadAdministrativaID" },
                values: new object[] { new Guid("2e3ff721-5a7d-4b82-87bb-3a593824ce25"), true, "123", "magali@gmail.com", new Guid("8ecec734-2171-4bec-aaec-eba010af2489"), "Magali Herrera Ramirez", new Guid("942f1900-7987-4820-a40b-7f4b78099d85"), new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78") });

            migrationBuilder.CreateIndex(
                name: "IX_Usuarios_UnidadAdministrativaID",
                table: "Usuarios",
                column: "UnidadAdministrativaID");

            migrationBuilder.AddForeignKey(
                name: "FK_Usuarios_UnidadAdministrativas_UnidadAdministrativaID",
                table: "Usuarios",
                column: "UnidadAdministrativaID",
                principalTable: "UnidadAdministrativas",
                principalColumn: "UnidadAdministrativaID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Usuarios_UnidadAdministrativas_UnidadAdministrativaID",
                table: "Usuarios");

            migrationBuilder.DropIndex(
                name: "IX_Usuarios_UnidadAdministrativaID",
                table: "Usuarios");

            migrationBuilder.DeleteData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("88f8cf91-458b-438c-b882-75a842387c64"));

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("2e3ff721-5a7d-4b82-87bb-3a593824ce25"));

            migrationBuilder.DeleteData(
                table: "Departamentos",
                keyColumn: "DepartamentoID",
                keyValue: new Guid("8ecec734-2171-4bec-aaec-eba010af2489"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RolID",
                keyValue: new Guid("942f1900-7987-4820-a40b-7f4b78099d85"));

            migrationBuilder.DropColumn(
                name: "UnidadAdministrativaID",
                table: "Usuarios");
        }
    }
}
