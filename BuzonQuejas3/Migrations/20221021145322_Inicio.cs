using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class Inicio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Queja",
                columns: table => new
                {
                    idQueja = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    nombreCreador = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    direccion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    telefono = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    correo = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    motivoQueja = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    relatoHechos = table.Column<string>(type: "varchar(200)", unicode: false, maxLength: 200, nullable: false),
                    servidorInvolucrado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    departamentoAsignado = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    fechaCreacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    fechaActualizacion = table.Column<DateTime>(type: "datetime", nullable: false),
                    estatus = table.Column<string>(type: "varchar(20)", unicode: false, maxLength: 20, nullable: false),
                    fechaAtencion = table.Column<DateTime>(type: "datetime", nullable: false),
                    atendidoPor = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    resolucion = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Queja", x => x.idQueja);
                });

            migrationBuilder.CreateTable(
                name: "Usuarios",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Correo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Clave = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rol = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Usuarios", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Queja");

            migrationBuilder.DropTable(
                name: "Usuarios");
        }
    }
}
