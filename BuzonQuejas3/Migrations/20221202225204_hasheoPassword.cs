using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class hasheoPassword : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuarios",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.AlterColumn<string>(
                name: "RelatoHechos",
                table: "Quejas",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Quejas",
                type: "nvarchar(40)",
                maxLength: 40,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(30)",
                oldMaxLength: 30);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("03147300-43fc-4294-81d4-4bc08366f4a4"),
                column: "Clave",
                value: "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"),
                column: "Clave",
                value: "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("2e3ff721-5a7d-4b82-87bb-3a593824ce25"),
                column: "Clave",
                value: "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("7467db95-c0a1-41df-a844-bbb00b60b952"),
                column: "Clave",
                value: "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("a22533a6-7621-492c-b10b-a9363668a2f4"),
                column: "Clave",
                value: "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Clave",
                table: "Usuarios",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "RelatoHechos",
                table: "Quejas",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AlterColumn<string>(
                name: "Correo",
                table: "Quejas",
                type: "nvarchar(30)",
                maxLength: 30,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(40)",
                oldMaxLength: 40);

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("03147300-43fc-4294-81d4-4bc08366f4a4"),
                column: "Clave",
                value: "123");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"),
                column: "Clave",
                value: "123");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("2e3ff721-5a7d-4b82-87bb-3a593824ce25"),
                column: "Clave",
                value: "123");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("7467db95-c0a1-41df-a844-bbb00b60b952"),
                column: "Clave",
                value: "123");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("a22533a6-7621-492c-b10b-a9363668a2f4"),
                column: "Clave",
                value: "123");
        }
    }
}
