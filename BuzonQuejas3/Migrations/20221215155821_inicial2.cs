using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class inicial2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medios",
                keyColumn: "MedioID",
                keyValue: new Guid("a04c1856-54b5-4699-8660-367a5ac5444d"),
                column: "Nombre",
                value: "Web");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Medios",
                keyColumn: "MedioID",
                keyValue: new Guid("a04c1856-54b5-4699-8660-367a5ac5444d"),
                column: "Nombre",
                value: "Webs");
        }
    }
}
