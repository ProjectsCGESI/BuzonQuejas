using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class ActualizacionModeloQueja : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CentroTrabajoID",
                table: "Quejas");

            migrationBuilder.AlterColumn<string>(
                name: "ServidorInvolucrado",
                table: "Quejas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.AlterColumn<string>(
                name: "Resolucion",
                table: "Quejas",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "RelatoHechos",
                table: "Quejas",
                type: "nvarchar(400)",
                maxLength: 400,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "MotivoQueja",
                table: "Quejas",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "AtendidoPor",
                table: "Quejas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(50)",
                oldMaxLength: 50);

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("00fe8231-6879-4189-b706-e3abdf62d4b7"),
                column: "Nombre",
                value: "fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("039c76d3-4ca7-4c63-aa74-cbc7e001553d"),
                column: "Nombre",
                value: "dirección general de comunicación estratégica y vinculación social");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("0d9102d0-d3c8-4e18-a13d-21fdedb7d9d6"),
                column: "Nombre",
                value: "coordinación general de investigación");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("199240cf-7e2a-4f72-99f9-90a3d9e93ec1"),
                column: "Nombre",
                value: "órgano interno de control");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("1c52fb81-0802-49f1-ad79-f53a05fc65fa"),
                column: "Nombre",
                value: "oficialia mayor");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("2c1dcd2b-da26-414b-9a97-652f0d2809a4"),
                column: "Nombre",
                value: "unidad de transparencia");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("2c9b14d2-8868-49ac-a503-584f44b7a6a1"),
                column: "Nombre",
                value: "fiscalía especializada en investigación de los delitos de operaciones con recursos de procedencia ilícita fiscales y relacionados");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("30ebd546-ab4e-4cb6-8d0e-9623d50a7869"),
                column: "Nombre",
                value: "coordinación general de colaboración interinstitucional");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("31a77f82-63e0-44c5-afea-337d6d8af47d"),
                column: "Nombre",
                value: "fiscalía especializada en investigación de delitos de violencia de género contra las mujeres");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("32c97d34-0fd4-46a0-9366-67843e3864ee"),
                column: "Nombre",
                value: "fiscalía de investigación metropolitana");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("32d4cca4-63fb-460d-8c7a-62a652346378"),
                column: "Nombre",
                value: "fiscalía de investigación regional");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("3a719e2b-7777-4694-aceb-157be081f8b3"),
                column: "Nombre",
                value: "fiscalía general del estado");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("4619dc4c-d498-4726-81a7-78d4d624d790"),
                column: "Nombre",
                value: "dirección general de planeación institucional");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("4b0240b3-98e7-4f86-881b-10f760c32f71"),
                column: "Nombre",
                value: "agencia estatal de investigación");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78"),
                column: "Nombre",
                value: "visitaduría general");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("53f19eac-b8f3-4486-8be4-4ef56fcb5084"),
                column: "Nombre",
                value: "unidad especializada en materia de extinción de dominio");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("58da64f2-2cb3-4912-b378-4b6b53e29a37"),
                column: "Nombre",
                value: "dirección general de seguridad institucional");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("61e8ffa1-6e7a-4855-a5ba-437c8ea6a815"),
                column: "Nombre",
                value: "fiscalía especializada de asuntos internos");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("6a8e78c6-a792-46b3-8a09-ef0d5eeccbae"),
                column: "Nombre",
                value: "coordinación general de gestión documental institucional");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("6f3bc61c-6e7e-42b0-b89e-00b919d5a096"),
                column: "Nombre",
                value: "coordinación general de litigación");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("766edba0-def6-4c84-98ed-ee5329c8a055"),
                column: "Nombre",
                value: "coordinación general de servicios a la comunidad");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("88f8cf91-458b-438c-b882-75a842387c64"),
                column: "Nombre",
                value: "general");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("96559f1b-3880-4339-9c73-fed0ec116105"),
                column: "Nombre",
                value: "fiscalía especializada en investigación de delitos electorales");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("98b8fe5f-ba52-45cc-a416-cd509356cef1"),
                column: "Nombre",
                value: "oficina del fiscal general");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("9bfcf217-97d8-469f-9652-d6741fce84a1"),
                column: "Nombre",
                value: "coordinación general de asuntos jurídicos");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("b467dc5a-5fb0-4399-9740-5877f10ce814"),
                column: "Nombre",
                value: "instituto de ciencias forenses");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("bbe7a98c-7420-43da-8a4a-e80d331f4517"),
                column: "Nombre",
                value: "instituto de formación profesional");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("c76d8cbc-34a8-47ad-a75a-7342eb11974f"),
                column: "Nombre",
                value: "coordinación general de mecanismos alternativos de solución de controversias en materia penal");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("d052658e-e743-478d-aa94-21f279ddde3d"),
                column: "Nombre",
                value: "fiscalía especializada en derechos humanos");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("da78b3f2-8cb2-4c60-ae7a-c390a99febfe"),
                column: "Nombre",
                value: "fiscalía especializada de combate a la corrupción");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("dbfcacdf-82c3-49cd-b035-f992aa39a4e0"),
                column: "Nombre",
                value: "coordinación general de análisis de información");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("dfafd2a3-a200-4f1e-aebd-f791bd14d879"),
                column: "Nombre",
                value: "fiscalía especializada en investigación de delitos de alta incidencia");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("e1a28eb5-19d7-4aa6-a340-d6366c46118c"),
                column: "Nombre",
                value: "fiscalía especializada en investigación de secuestro y extorsión");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4"),
                column: "Nombre",
                value: "coordinación general de estadística y sistemas de información");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("f9e1ead4-61d4-473e-a73a-a8389fc13e33"),
                column: "Nombre",
                value: "coordinación general de desarrollo institucional");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ServidorInvolucrado",
                table: "Quejas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AlterColumn<string>(
                name: "Resolucion",
                table: "Quejas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(300)",
                oldMaxLength: 300);

            migrationBuilder.AlterColumn<string>(
                name: "RelatoHechos",
                table: "Quejas",
                type: "nvarchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(400)",
                oldMaxLength: 400);

            migrationBuilder.AlterColumn<string>(
                name: "MotivoQueja",
                table: "Quejas",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);

            migrationBuilder.AlterColumn<string>(
                name: "AtendidoPor",
                table: "Quejas",
                type: "nvarchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(100)",
                oldMaxLength: 100);

            migrationBuilder.AddColumn<Guid>(
                name: "CentroTrabajoID",
                table: "Quejas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("00fe8231-6879-4189-b706-e3abdf62d4b7"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("039c76d3-4ca7-4c63-aa74-cbc7e001553d"),
                column: "Nombre",
                value: "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("0d9102d0-d3c8-4e18-a13d-21fdedb7d9d6"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE INVESTIGACION");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("199240cf-7e2a-4f72-99f9-90a3d9e93ec1"),
                column: "Nombre",
                value: "ORGANO INTERNO DE CONTROL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("1c52fb81-0802-49f1-ad79-f53a05fc65fa"),
                column: "Nombre",
                value: "OFICIALIA MAYOR");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("2c1dcd2b-da26-414b-9a97-652f0d2809a4"),
                column: "Nombre",
                value: "UNIDAD DE TRANSPARENCIA");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("2c9b14d2-8868-49ac-a503-584f44b7a6a1"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA FISCALES Y RELACIONADOS");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("30ebd546-ab4e-4cb6-8d0e-9623d50a7869"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("31a77f82-63e0-44c5-afea-337d6d8af47d"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("32c97d34-0fd4-46a0-9366-67843e3864ee"),
                column: "Nombre",
                value: "FISCALIA DE INVESTIGACION METROPOLITANA");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("32d4cca4-63fb-460d-8c7a-62a652346378"),
                column: "Nombre",
                value: "FISCALIA DE INVESTIGACION REGIONAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("3a719e2b-7777-4694-aceb-157be081f8b3"),
                column: "Nombre",
                value: "FISCALIA GENERAL DEL ESTADO");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("4619dc4c-d498-4726-81a7-78d4d624d790"),
                column: "Nombre",
                value: "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("4b0240b3-98e7-4f86-881b-10f760c32f71"),
                column: "Nombre",
                value: "AGENCIA ESTATAL DE INVESTIGACION");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78"),
                column: "Nombre",
                value: "VISITADURIA GENERAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("53f19eac-b8f3-4486-8be4-4ef56fcb5084"),
                column: "Nombre",
                value: "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("58da64f2-2cb3-4912-b378-4b6b53e29a37"),
                column: "Nombre",
                value: "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("61e8ffa1-6e7a-4855-a5ba-437c8ea6a815"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("6a8e78c6-a792-46b3-8a09-ef0d5eeccbae"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("6f3bc61c-6e7e-42b0-b89e-00b919d5a096"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE LITIGACION");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("766edba0-def6-4c84-98ed-ee5329c8a055"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("88f8cf91-458b-438c-b882-75a842387c64"),
                column: "Nombre",
                value: "GENERAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("96559f1b-3880-4339-9c73-fed0ec116105"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("98b8fe5f-ba52-45cc-a416-cd509356cef1"),
                column: "Nombre",
                value: "OFICINA DEL FISCAL GENERAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("9bfcf217-97d8-469f-9652-d6741fce84a1"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE ASUNTOS JURIDICOS");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("b467dc5a-5fb0-4399-9740-5877f10ce814"),
                column: "Nombre",
                value: "INSTITUTO DE CIENCIAS FORENSES");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("bbe7a98c-7420-43da-8a4a-e80d331f4517"),
                column: "Nombre",
                value: "INSTITUTO DE FORMACION PROFESIONAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("c76d8cbc-34a8-47ad-a75a-7342eb11974f"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("d052658e-e743-478d-aa94-21f279ddde3d"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("da78b3f2-8cb2-4c60-ae7a-c390a99febfe"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("dbfcacdf-82c3-49cd-b035-f992aa39a4e0"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE ANALISIS DE INFORMACION");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("dfafd2a3-a200-4f1e-aebd-f791bd14d879"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("e1a28eb5-19d7-4aa6-a340-d6366c46118c"),
                column: "Nombre",
                value: "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("f9e1ead4-61d4-473e-a73a-a8389fc13e33"),
                column: "Nombre",
                value: "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL");
        }
    }
}
