using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class separarNombreAtendio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "AtendidoPor",
                table: "Quejas");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoMServidor",
                table: "Quejas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<string>(
                name: "ApellidoMAtendio",
                table: "Quejas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ApellidoPAtendio",
                table: "Quejas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "NombreAtendio",
                table: "Quejas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "ApellidoMAtendio",
                table: "Quejas");

            migrationBuilder.DropColumn(
                name: "ApellidoPAtendio",
                table: "Quejas");

            migrationBuilder.DropColumn(
                name: "NombreAtendio",
                table: "Quejas");

            migrationBuilder.AlterColumn<string>(
                name: "ApellidoMServidor",
                table: "Quejas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AddColumn<string>(
                name: "AtendidoPor",
                table: "Quejas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");
        }
    }
}
