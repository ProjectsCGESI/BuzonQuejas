using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class fechaAtencionNull : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAtencion",
                table: "Quejas",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Medios",
                keyColumn: "MedioID",
                keyValue: new Guid("a04c1856-54b5-4699-8660-367a5ac5444d"),
                column: "Nombre",
                value: "Buzón web");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "FechaAtencion",
                table: "Quejas",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "Medios",
                keyColumn: "MedioID",
                keyValue: new Guid("a04c1856-54b5-4699-8660-367a5ac5444d"),
                column: "Nombre",
                value: "Web");
        }
    }
}
