using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace BuzonQuejas3.Migrations
{
    public partial class addCargoAndMedio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CargoID",
                table: "Quejas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "MedioID",
                table: "Quejas",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.CreateTable(
                name: "Cargos",
                columns: table => new
                {
                    CargoID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(400)", maxLength: 400, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cargos", x => x.CargoID);
                });

            migrationBuilder.CreateTable(
                name: "Medios",
                columns: table => new
                {
                    MedioID = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Nombre = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Medios", x => x.MedioID);
                });

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "CargoID", "Nombre" },
                values: new object[,]
                {
                    { new Guid("35f230e5-95d9-4740-9d5e-a2d6330bcbb3"), "Agente del ministerio público" },
                    { new Guid("bd60c318-f90f-4937-b329-4943010b5fb9"), "Jefe de departamento de indicios y bienes afectos" },
                    { new Guid("064f278b-2461-418b-90ad-5c81c5fff7d7"), "Jefe de departamento de información vehicular de la dirección de investigación" },
                    { new Guid("c7dffaf9-6306-46f1-9a21-7752d348678c"), "Jefe de grupo ministerial" },
                    { new Guid("a082cd25-2262-474b-845b-20c49da7b537"), "Jefe de grupo ministerial (encargado de apoyo policial de Atlixco)" },
                    { new Guid("2d4c71bf-0fb6-4420-88cd-ab5d481b98f2"), "Jefe de grupo ministerial (encargado de apoyo policial de Tepeaca)" },
                    { new Guid("d83fb7e8-d82e-4838-9b57-c3fbe7dd2d56"), "Jefe de grupo ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en derechos humanos" },
                    { new Guid("fba77d27-28b6-4eda-97be-ee44eb4b746d"), "Jefe del departamento de apoyo técnico " },
                    { new Guid("c9fec10c-cd1d-44d4-964e-b81f434bbae6"), "Jefe del departamento de control vehicular" },
                    { new Guid("a1a4686d-46f1-4faa-ba80-567479279477"), "Jefe del departamento de diseño e imagen institucional" },
                    { new Guid("97fb1504-48ee-4460-a313-7ff4dbca6ff2"), "Jefe del departamento de servicios generales metropolitana" },
                    { new Guid("36cd244f-d36f-4469-8b7d-f27a125c58ad"), "Jefe del departamento jurídico de manuales administrativos" },
                    { new Guid("36fde145-e0b8-45b3-b95d-e37a4cc95d69"), "Oficial A" },
                    { new Guid("f080e0e7-6e1f-41dd-b432-e73906fcff63"), "Oficial E" },
                    { new Guid("87d46917-7f04-4a59-975d-a72bdcc20f17"), "Oficial I" },
                    { new Guid("c1c81fc7-7ecb-4b38-b520-0bb93c7e85ac"), "Oficial M" },
                    { new Guid("1c3267bd-dab9-4e35-a9f9-0f0a1364cc67"), "Oficial R" },
                    { new Guid("76733838-b1db-4c0d-831d-d8844f26dbd3"), "Oficial del ministerio público" },
                    { new Guid("8a214f30-083a-43dd-970c-18c1ab84cdfa"), "Oficial mayor" },
                    { new Guid("71f6e543-05e3-4346-b92d-ff3b515547aa"), "Perita" },
                    { new Guid("5fb3a3bf-9372-4d74-8884-a5156123e6cc"), "Perita en contabilidad" },
                    { new Guid("9378897d-3c18-4295-8518-21faf65f5811"), "Perito" },
                    { new Guid("966bf88f-e037-4f6c-97c7-d30a9828d912"), "Perito en contabilidad" },
                    { new Guid("746b3784-08d6-43f6-863c-ada46d4a5a12"), "Perito técnico" },
                    { new Guid("139887dd-0377-433a-b42f-4fd31703428e"), "Responsable del área de lo contencioso de la coordinación general de asuntos jurídicos" },
                    { new Guid("2abf41c5-f1ca-4115-bc28-50a9e02c8294"), "Subdirector" },
                    { new Guid("0e9fe512-c47b-4546-9854-d6d7c47e6512"), "Subdirector académico" },
                    { new Guid("3c9aee73-53ec-4504-ad0f-08a4dcb3d9c2"), "Subdirector de apoyo técnico operativo" },
                    { new Guid("698c91a9-eef1-4aaa-afb5-ec3165dadbb0"), "Jefe de departamento de adquisiciones y adjudicaciones" },
                    { new Guid("3a7137b4-a2de-42ee-81aa-1b13c12a807d"), "Subdirector de contabilidad" },
                    { new Guid("19579446-96b6-476f-8eaf-e94fc311ecc3"), "Jefe de departamento" },
                    { new Guid("f694701a-4ed9-4808-a8e4-359a27740d69"), "Jefa del departamento de organización de la estructura orgánica de la dirección de organización y desarrollo administrativo de la oficialía mayor" },
                    { new Guid("5f154595-96e6-49f8-ad5a-86d6eeb550de"), "Facilitador" },
                    { new Guid("16dbcf26-c2b5-4de9-bd71-597171c7f3c2"), "Facilitadora" },
                    { new Guid("2205d53e-82e7-4222-ae58-d24d9ed6918a"), "Fiscal de investigación regional" },
                    { new Guid("203c2302-371e-44a9-9cc1-834900f29d7c"), "Fiscal de zona poniente" },
                    { new Guid("3c6de366-c5c4-445c-980c-b4975cf0f4ae"), "Fiscal de zona sur de la fiscalía de investigación metropolitana" },
                    { new Guid("eca1fb98-995c-4abb-8d9f-a6cff9bff3b0"), "Fiscal especializada en investigación de delitos de violencia de género contra las mujeres,coordinadora de investigación" },
                    { new Guid("a336d28f-f5e3-4927-bc34-8e48b44a4c6c"), "Fiscal especializado de asuntos internos" },
                    { new Guid("c362e7cc-6169-4ef6-9966-3ee9e57ed7d0"), "Fiscal especializado de combate a la corrupción" },
                    { new Guid("20458759-dac9-4579-bc14-3b20480781e0"), "Fiscal especializado en derechos humanos" },
                    { new Guid("6d2c7c85-9207-460a-ae94-a99e61a1b01d"), "Fiscal especializado en investigación de delitos de alta incidencia" }
                });

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "CargoID", "Nombre" },
                values: new object[,]
                {
                    { new Guid("4ec5deb5-db2f-45e5-a99b-b7d350d8cfd8"), "Fiscal especializado en investigación de los delitos de operaciones con recursos de precedencia ilícita, fiscales y relacionados" },
                    { new Guid("a491d4ce-671f-49cf-84b9-4bba51a10f53"), "Fiscal especializado en investigación de los delitos desaparición forzada de personas y desaparición cometida por particulares" },
                    { new Guid("c8a12d82-bd40-40d2-b78f-5b43ac2e8492"), "Fiscal especializado en investigación de secuestro y extorsión" },
                    { new Guid("06d23cba-8825-4787-a76a-69acc3132609"), "Fiscal general del estado" },
                    { new Guid("137a7a20-3692-4e98-99a0-133a882870bf"), "Honorarios" },
                    { new Guid("ee8c95f9-8438-40d2-985c-f577f50d05d8"), "Inspector general" },
                    { new Guid("2a98f412-0d1b-487f-bc34-06fc1b6cd77b"), "Invitador" },
                    { new Guid("908501cc-9993-4fe2-8257-c8b14514cac4"), "Jefa de departamento" },
                    { new Guid("f486d22c-5d94-44d2-9d4e-52196a0867f4"), "Jefa de departamento de control de indicios de la fiscalía especializada en derechos humanos" },
                    { new Guid("b8e51bdc-fca6-45ad-9f9e-97d62893f1a5"), "Jefa del departamento de apoyo técnico de la fiscalía especializada de combate a la corrupción" },
                    { new Guid("2fb58fee-a5aa-499f-87e8-63f92445959c"), "Jefa del departamento de control de inmuebles" },
                    { new Guid("11762e06-28bd-4807-a523-67e09ff86304"), "Jefa del departamento de desarrollo administrativo" },
                    { new Guid("89f4699c-3bce-4e0b-9fdd-cd75027e5a20"), "Jefa del departamento de expedientes de inversión y banco de proyectos" },
                    { new Guid("5c716978-4394-463c-a281-3075240b6775"), "Jefa del departamento de expedientes de personal  de la subdirección de servicios personales de la dirección de administración de la oficialía mayor" },
                    { new Guid("265b6fb1-9931-404b-8b29-8ec26effb629"), "Jefa del departamento de gestión documental de la coordinación general de asuntos jurídicos" },
                    { new Guid("0575c16d-e0db-47f2-9edb-ea565c2fd2be"), "Jefa del departamento de mantenimiento de vehículos" },
                    { new Guid("c70ba7be-da95-4e52-ac3e-823fbf058c7f"), "Jefa del departamento de movimientos y percepciones extraordinarias" },
                    { new Guid("9cee6ab6-0a39-477b-8425-2b245ccd619e"), "Jefa del departamento de procedimientos para el destino final de bienes asegurados" },
                    { new Guid("dc6aa2a1-fff7-41d1-b26c-4be062d104cf"), "Subdirector de control y seguimiento documental" },
                    { new Guid("01510334-9dd9-488b-a89b-a082b4f453f4"), "Subdirector de profesionalización" },
                    { new Guid("e0c81eed-9072-47cd-bd5d-8598f7ac3b30"), "Subdirector de recursos materiales" },
                    { new Guid("e068ed49-da14-48a5-9f89-5763cac17a81"), "Titular de la unidad de investigación de periodistas y defensores de derechos humanos" },
                    { new Guid("d0e7d6a1-873f-4eae-b4b2-1d2e62727834"), "Titular de la unidad de localización de personas desaparecidas" },
                    { new Guid("c79ae3f9-4df9-4628-9741-0392063f2319"), "Titular de la unidad de situación patrimonial de la dirección de responsabilidades del órgano interno de control" },
                    { new Guid("f5b93b97-778c-4df4-b7f4-5e8107dc284e"), "Titular de la unidad de sustanciación del órgano interno de control" },
                    { new Guid("23cdc855-96b5-4ddd-99a1-d57980ac0dc4"), "Titular de la unidad de transparencia" },
                    { new Guid("c48b6f63-f20e-4e43-a92e-8a584c809018"), "Titular de la unidad especializada de investigación de delitos ambientales de la fiscalía de investigación metropolitana" },
                    { new Guid("49b515e1-92af-4f32-aff3-e078941daeec"), "Titular de la unidad especializada de investigación de delitos contra la paz, la seguridad y las garantías de las personas de la fiscalía de investigación regional" },
                    { new Guid("51e230d1-a4e6-4cad-beeb-1a2bccb9da6f"), "Titular de la unidad especializada de investigación de delitos contra la vida y la integridad corporal de la fiscalía de investigación metropolitana" },
                    { new Guid("a7c69146-2a72-4929-864e-66893241bf96"), "Titular de la unidad especializada de investigación de delitos contra los animales de la fiscalía de investigación regional" },
                    { new Guid("980e4407-af2a-45fc-9ab6-2cd2e3a216da"), "Titular de la unidad especializada de investigación de delitos de abuso de confianza, fraude, despojo, daño en propiedad ajena, robo de ganado, robo de maquinaria e implementos diversos" },
                    { new Guid("1478aaca-c922-41ab-8cab-34e6dce9aad8"), "Titular de la unidad especializada de investigación de robo de vehículos de la fiscalía especializada en investigación de  delitos de alta incidencia" },
                    { new Guid("dd55db68-ec82-47b7-b630-7941e8d67f08"), "Titular de la unidad especializada de investigación del delito de tortura y otros tratos crueles, inhumanos o degradantes de la fiscalía especializada en derechos humanos" },
                    { new Guid("75419c29-be4f-4f75-97f6-9b1af211349f"), "Titular de la unidad especializada de justicia para adolescentes de la fiscalía especializada en derechos humanos" },
                    { new Guid("611d87de-3f4c-44fa-8455-76822828cb8a"), "Titular de la unidad especializada en investigación de delitos cometidos contra la comunidad LGBTTTIQ" },
                    { new Guid("8e51c0d5-1b81-4946-b350-c175523ad26e"), "Titular de la unidad especializada en investigación de delitos cometidos contra los animales de la fiscalía de investigación metropolitana" },
                    { new Guid("538936b5-0a05-4ce7-ae22-a6be4b55a83e"), "Titular de la unidad especializada en materia de extinción de dominio" },
                    { new Guid("6be4c160-2802-41d8-bc19-8da78dfa46b9"), "Titular de la unidad resolutora de la dirección de responsabilidades del órgano interno de control" },
                    { new Guid("d193efc9-b89f-45d4-85ae-ed0ea8af8413"), "Titular de la unidad unidad para la búsqueda de mujeres y niñas desaparecidas y delitos relacionados a través de la aplicación del protocolo alba y la coordinación con la alerta amber de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" },
                    { new Guid("2a2d1519-02d7-4b86-a76c-9ece94562a75"), "Titular de unidad" },
                    { new Guid("6bb5329b-e07a-4c99-bd27-5994ad239e54"), "Titular de unidad de apoyo administrativo" },
                    { new Guid("9a790101-e4fe-4e8d-aa4c-b6e954a4db03"), "Titular del departamento de control de indicios de la fiscalía especializada en investigación de secuestro y extorsión" }
                });

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "CargoID", "Nombre" },
                values: new object[,]
                {
                    { new Guid("fbd7b890-d200-4055-a7fc-973990f68c68"), "Titular del instituto de ciencias forenses" },
                    { new Guid("cc85ec17-87d2-4ae2-a1ea-ea963534007b"), "Titular del instituto de formación profesional" },
                    { new Guid("057035c9-1e3d-4342-9e02-3b2c785bcae5"), "Titular del órgano interno de control" },
                    { new Guid("81b47efb-2bfd-43f5-83cb-70fa069ee2c8"), "Titular de la unidad de investigación especializada en robo a casa habitación y  robo a comercio" },
                    { new Guid("23637a0a-a8f2-4cfd-a99d-95e4d0a2e70e"), "Visitador general" },
                    { new Guid("b9ac7679-b2df-4f1c-aa1f-d54d823bcd91"), "Visitadora" },
                    { new Guid("11004dfa-721e-4834-a45c-abb0b77c0d2a"), "Titular de la unidad de investigación especializada en violencia familiar y delitos de género" },
                    { new Guid("ed158acd-e469-47f7-9ffa-c820b0b421d7"), "Titular de la unidad de investigación especializada en feminicidio" },
                    { new Guid("5fd8bba5-f8a1-41b8-9bb6-8e3f67815ba8"), "Titular de la unidad de investigación especializada en delitos financieros y patrimoniales" },
                    { new Guid("e15e3d5b-8fb8-4d15-8e29-549577534629"), "Titular de la unidad de investigación especializada de sistema tradicional" },
                    { new Guid("7dc71bc7-05f1-4676-82d0-54560136d092"), "Subdirector de redes de la dirección de infraestructura tecnológica de la coordinación general de estadística y sistemas de información" },
                    { new Guid("3f49112f-f7f2-4433-98ec-d4f3ada920e8"), "Subdirector de suministros" },
                    { new Guid("64363e08-1512-4cac-b30d-417b7e300f74"), "Subdirector de tesorería de la dirección de desarrollo financiero y presupuestal " },
                    { new Guid("8a459e96-d449-4f42-a412-961c0aea8128"), "Subdirector de vehículos y banco de armas" },
                    { new Guid("ac104386-d442-4203-aec8-1159745f7aa1"), "Subdirectora de control de gestión de la dirección de auditoría del órgano interno de control" },
                    { new Guid("42a36d6f-01d7-46f6-b8c4-e90a434592e8"), "Subdirectora de fondos y política presupuestal" },
                    { new Guid("7017774e-2514-4c7f-9a08-8ef6bddd9790"), "Subdirectora de glosa de gasto corriente e inversión" },
                    { new Guid("6f225a75-f2b6-461f-ac76-3ecfef52046c"), "Subdirectora de la delegación Tehuacán" },
                    { new Guid("cda9acc4-94c0-44eb-b1a5-f579b61f0f17"), "Subdirectora de recepción y despacho documental" },
                    { new Guid("feef5cbb-64d4-41de-afb5-fcd8da2ed3e7"), "Subdirectora de servicio civil de carrera" },
                    { new Guid("e903db7a-d78e-4094-84d1-8760539585e3"), "Subdirectora de servicios personales" },
                    { new Guid("de6b5495-e9b6-43eb-95c6-f447d03ed2dc"), "Subdirectora del servicio médico forense" },
                    { new Guid("bd11c0a6-75fa-46f9-a703-5842ce088c35"), "Titular de la agencia estatal de investigación" },
                    { new Guid("a7f43660-49a0-436b-ab82-d6f08ab14056"), "Enlace de gestión documental de la fiscalía especializada en investigación de delitos de violencia de género contra las mujeres" },
                    { new Guid("13670d5f-bddb-4274-9679-31e24a8fd69f"), "Titular de la dirección metropolitana de litigación de la coordinación general de litigación" },
                    { new Guid("828b21e9-4c4d-4428-b59b-a545b02d21c8"), "Titular de la oficina del fiscal general del estado" },
                    { new Guid("24f20c86-5d72-49dc-bd89-3090ea26c5fa"), "Titular de la unidad" },
                    { new Guid("5f1a8517-157c-429e-8c2d-0b4340fd832a"), "Titular de la unidad  de investigación de delitos relacionados con personas desaparecidas de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" },
                    { new Guid("e4974367-c31e-46ab-a375-5994772bafce"), "Titular de la unidad coordinadora de archivos de la coordinación general de gestión documental institucional" },
                    { new Guid("6f67d27c-38a6-4e70-a2c8-cbdd90abe529"), "Titular de la unidad de análisis y contexto de la fiscalía de investigación metropolitana" },
                    { new Guid("70a77508-cc1c-4f82-9af4-24606952a82c"), "Titular de la unidad de análisis y contexto de la fiscalía en investigación de delitos de violencia de género contra las mujeres" },
                    { new Guid("36bbd816-f0a9-48fc-a668-0b33fee64b50"), "Titular de la unidad de análisis y contexto de la fiscalía especializada de combate a la corrupción" },
                    { new Guid("42960505-2789-4b23-82ac-e90601b3e53d"), "Titular de la unidad de análisis y contexto de la fiscalía especializada en derechos humanos" },
                    { new Guid("e90e03b4-d62d-454e-b5bd-0b59c44f6935"), "Titular de la unidad de derechos humanos de la fiscalía especializada en derechos humanos" },
                    { new Guid("8d446da1-4206-4dad-9855-bc5ddb24510e"), "Titular de la unidad de flagrancia" },
                    { new Guid("9c66e495-7ddf-4d3f-b293-8d1cf51cb262"), "Titular de la unidad de flagrancia central I" },
                    { new Guid("094209ac-a783-4b99-b13e-7da82e0f7396"), "Titular de la unidad de investigación de hechos de corrupción en el ámbito estatal de la fiscalía especializada de combate a la corrupción" },
                    { new Guid("988e2025-9650-45d6-b8a1-eee5812b7f15"), "Titular de la unidad de investigación de la dirección de responsabilidades del órgano interno de control" },
                    { new Guid("d4f076ea-18cd-4899-987b-9b9e1c54137c"), "Titular de la dirección regional de litigación de la coordinación general de litigación" },
                    { new Guid("5df5e537-953b-42b8-bcf8-2dc09e8f7156"), "Enlace de gestión documental de la fiscalía especializada en investigación  de los delitos de desaparición forzada de personas y desaparición cometida por particulares" },
                    { new Guid("41ffa416-1660-45b9-b5ef-bb5e3a51fc7c"), "Fiscal de investigación metropolitana" },
                    { new Guid("df47294a-11eb-4cb7-a0f3-f26402c3847f"), "Enlace de estadística y sistemas de información de la fiscalía especializada en derechos humanos" }
                });

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "CargoID", "Nombre" },
                values: new object[,]
                {
                    { new Guid("500c309a-1fca-46cb-be2b-7ef05f774bb8"), "Coordinador de investigación de la fiscalía de investigación metropolitana" },
                    { new Guid("54bb2be3-9066-4002-a1e3-9fa5e556c552"), "Coordinador de investigación de la fiscalía especializada en derechos humanos" },
                    { new Guid("a5549901-7b6c-4106-b738-6265bccb61f3"), "Coordinador de investigación de la fiscalía especializada en investigación de delitos electorales" },
                    { new Guid("778e91ef-b9df-4ab8-ac1c-89e64fbb48e4"), "Coordinador de litigación de la fiscalía de investigación regional" },
                    { new Guid("0273cab0-21d4-4c77-84fb-4ecd421055d9"), "Coordinador de litigación de la fiscalía en investigación de delitos de alta incidencia" },
                    { new Guid("d37b21d2-175f-434a-862d-76755c1baad9"), "Coordinador de litigación de la fiscalía especializada de combate a la corrupción" },
                    { new Guid("c180e628-6b5e-4ae3-8324-f8cd95dbaef3"), "Coordinador de litigación de la fiscalía especializada en investigación de delitos electorales" },
                    { new Guid("48097932-e268-43fb-9e39-1dfe40ab1620"), "Coordinador de litigación de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" },
                    { new Guid("a58df3e0-2d4d-4124-9990-8ca6d930c241"), "Coordinador de medios alternativos" },
                    { new Guid("28409eeb-104b-47df-9fa0-d3217886c247"), "Coordinador general de análisis de información" },
                    { new Guid("ff52b028-e91a-4ec3-b407-c28edb7c5391"), "Coordinador general de asuntos jurídicos" },
                    { new Guid("8b74cc38-c0f1-450b-bea9-2a7e3295c2eb"), "Coordinador general de desarrollo institucional" },
                    { new Guid("48f3fadd-1508-4f31-9383-53c7ca5a5346"), "Coordinador general de investigación" },
                    { new Guid("dac27498-9d86-4196-adef-8311e24d1aec"), "Coordinador general de litigación" },
                    { new Guid("bfffe331-abbe-4742-b71f-810f43e2d798"), "Coordinador general de mecanismos alternativos de solución de controversias en materia penal" },
                    { new Guid("a4ae229d-36c9-4095-89ce-135b38a0f1fa"), "Coordinador general de servicios a la comunidad" },
                    { new Guid("77af20f3-d48c-4f7b-adaa-74a35797cc6e"), "Coordinador investigación de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" },
                    { new Guid("62133114-2fa7-4ea9-a3ae-4eb1e2a7eb05"), "Coordinador(a) de medios alternativos" },
                    { new Guid("1f3c0415-c148-45a5-86a3-5c2c33bc38a2"), "Coordinadora de investigación" },
                    { new Guid("0e06a1f1-7b84-4aed-aad1-aae581a415b9"), "Coordinadora de investigación de la fiscalía de investigación regional" },
                    { new Guid("6c9cab3c-cafa-4525-8765-c7be1c71e7a2"), "Coordinadora de investigación de la fiscalía especializada en asuntos internos" },
                    { new Guid("766ad9f3-10dc-4df2-905c-05fa96f64233"), "Coordinadora de investigación de la fiscalía especializada en investigación de delitos de violencia de género contra las mujeres" },
                    { new Guid("9f6b4a71-c59b-44bc-a9f7-bbf68ce448cc"), "Coordinadora de investigación, encargada del despacho de la fiscalía especializada en investigación de delitos electorales" },
                    { new Guid("11aa1204-6cbc-4d6d-ab0c-b9082310d046"), "Coordinadora de litigación" },
                    { new Guid("01e70220-a3ef-4c8e-a0df-6fc8bf40f062"), "Coordinadora de litigación de la fiscalía de investigación metropolitana " },
                    { new Guid("ae6f888f-a3c3-4dc6-a36d-9014acacd162"), "Enlace de gestión documental de la fiscalía especializada en derechos humanos" },
                    { new Guid("bd1f7545-2c2c-42b8-b0cb-25d7c99c29e6"), "Coordinadora de litigación de la fiscalía especializada en derechos humanos" },
                    { new Guid("a831d19c-b733-406d-92eb-bc9950068ce8"), "Coordinador de análisis estadística y base de datos" },
                    { new Guid("30001459-aab0-4c6f-b7cc-b6d758ae3b5a"), "Comandante, encargado de despacho de la dirección de investigación de la agencia estatal de investigación" },
                    { new Guid("86c0688b-3bf3-47af-b3c6-e1bbc2bbd367"), "Comandante ministerial, encargado de la unidad de apoyo policial de la fiscalía especializada en investigación de los delitos de procedencia ilícita, fiscales y relacionados" },
                    { new Guid("9b54e77a-0aad-4d40-a6f6-769075bffd2d"), "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de delitos electorales" },
                    { new Guid("593c34fc-af4d-443e-a583-f2038a971e63"), "Agente investigador" },
                    { new Guid("9a694e5a-d4aa-41de-818f-a916f4f0a47d"), "Agente investigador (encargado de apoyo policial de San Pedro Cholula)" },
                    { new Guid("aa32ac89-9b43-48e6-88af-18b1ec2ac0fa"), "Agente investigador (encargado de apoyo policial de Tehuacán)" },
                    { new Guid("5040fa04-5492-4f84-aa6b-ae150fcd14b7"), "Agente investigador (encargado de apoyo policial de San Andrés Cholula)" },
                    { new Guid("4694b457-6ef2-4963-ae78-ff7e59b198b8"), "Agente investigador (encargado del despacho de la dirección de intervención inmediata)" },
                    { new Guid("53d194e7-48d2-4eab-9e4d-dc76d50587e0"), "Agente investigador (encargado de apoyo policial de Cuautlancingo)" },
                    { new Guid("6a2e9821-91b9-4288-88de-b34f2bb99d9a"), "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de delitos de violencia de género contra las mujeres" },
                    { new Guid("0a7a3893-e6a1-4877-b46b-2e182c6f8489"), "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía de investigación metropolitana" },
                    { new Guid("96917de1-28e2-43d4-b835-4b2dd1092dba"), "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía de investigación regional" },
                    { new Guid("94aa3a6a-edc9-4474-8f9a-6df79360e01a"), "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada de asuntos internos" },
                    { new Guid("5881b348-068f-42ee-8777-74b5a0c30c51"), "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada de combate a la corrupción" }
                });

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "CargoID", "Nombre" },
                values: new object[,]
                {
                    { new Guid("5e5ecc06-7eb4-4285-a6e6-2b364e59d8df"), "Agente investigador, encargado de la unidad de apoyo policial de la fiscalía de investigación regional" },
                    { new Guid("4d60047d-f909-4d07-a580-ba8ead2b194f"), "Agente ministerial" },
                    { new Guid("34c2b5ab-f1db-4183-92c8-561e18539f21"), "Coordinadora de medios alternativos del área de la región poniente" },
                    { new Guid("74979f8d-97c6-46fe-8149-ec508e22e73d"), "Analista" },
                    { new Guid("16c6cee1-5f83-4a8f-842f-14fd9076c65c"), "Asesor especial" },
                    { new Guid("f1e6482f-9cf9-433b-8b30-047edf19467b"), "Asesor técnico" },
                    { new Guid("fc7cb1e0-a22b-411a-8da9-335b74606583"), "Asesor técnico, responsable del área normativa de la dirección consultiva y de normatividad de la coordinación general de asuntos jurídicos" },
                    { new Guid("54101122-6e91-42a3-a458-3d4d6156d35f"), "Auxiliar" },
                    { new Guid("7ca27770-d11b-432d-89cf-53c905d520a2"), "Auxiliar de facilitador" },
                    { new Guid("0c8b53be-d105-43a5-a316-fb078427f91f"), "Auxiliar del ministerio público" },
                    { new Guid("27ec76fb-1551-4b0e-b8ec-0d8858c16cb4"), "Comandante ministerial" },
                    { new Guid("03b07bb4-dc2b-4369-afec-133bba26da3d"), "Comandante ministerial (encargado de apoyo policial de amozoc)" },
                    { new Guid("9167fc65-0416-4837-91f2-ddbd8a0c55ef"), "Comandante ministerial (encargado de apoyo policial de San Martín Texmelucan)" },
                    { new Guid("35b34c2c-484b-4d80-82eb-ce99a3424eac"), "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de secuestro y extorsión" },
                    { new Guid("4ccb61b9-5693-408a-8aa0-66cf1a284552"), "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de delitos de alta incidencia" },
                    { new Guid("cae3c364-b530-4e2b-b65a-1a1b7fc965c6"), "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" },
                    { new Guid("184aa5ad-2201-4458-8916-8c7cb7688e5d"), "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de los delitos de operaciones con recursos de procedencia ilícita, fiscales y relacionados" },
                    { new Guid("a18fa257-fa4e-405e-a712-3b5f78250cfd"), "Analista de información" },
                    { new Guid("2ecaa075-e4e7-48e2-a8b9-0ddebeca2412"), "Coordinadora general de colaboración interinstitucional" },
                    { new Guid("63448169-d24c-43b2-8012-bce9bd81ba73"), "Coordinadora de litigación de la fiscalía especializada de asuntos internos" },
                    { new Guid("b6dcca3f-5e8e-4fb6-9fc6-466a61b2d5d7"), "Director de apoyo y logística administrativa de le visitaduría general" },
                    { new Guid("8ecf1984-75de-475a-8fd2-b92fc5a98736"), "Directora de servicios a la comunidad" },
                    { new Guid("e2eb4f41-676c-40e9-9213-0bacfaf1e55a"), "Directora de supervisión técnica de la visitaduría general" },
                    { new Guid("410c0b79-4761-4a61-9aa0-d8d0e3bccac2"), "Coordinadora general de estadística y sistemas de información" },
                    { new Guid("dddaa1d9-e5fd-48ec-9298-0e32c4095e7f"), "Directora regional de investigación de la coordinación general de investigación" },
                    { new Guid("c4bae6f4-eb77-4bc9-953a-e47a967d052b"), "Encargada de despacho de la dirección de planeación, programación, evaluación y organización" },
                    { new Guid("7af398cd-7fb4-4328-ad78-4f0287482fc2"), "Encargada de despacho de la dirección general de los centros de justicia para las mujeres" },
                    { new Guid("52f954be-d31f-4cd2-8ff5-ab5823fe67f8"), "Encargada de despacho de la subdirección de proyectos de inversión y bienes muebles e inmuebles" },
                    { new Guid("5f8ec1d8-4242-4da6-847c-5f20572d5288"), "Encargada de despacho de la unidad de investigación (Teziutlán)" },
                    { new Guid("934952f3-4c28-492c-be97-8630a65e2792"), "Encargada de despacho de la unidad de investigación de hechos de corrupción en el ámbito municipal de la fiscalía especializada de combate a la corrupción" },
                    { new Guid("d28415b1-bfb9-4eb8-90d4-6e35bc1b55c7"), "Encargada de despacho de la unidad de servicios periciales" },
                    { new Guid("31272963-6362-4bd7-a3d8-a0567eeadb87"), "Encargado de despacho de de la unidad especializada en investigación de robo a transeunte" },
                    { new Guid("8d744475-c50d-40c8-8d3e-91c1a5462994"), "Encargado de despacho de la unidad de flagrancia (Huauchinango)" },
                    { new Guid("10301d51-7922-4e23-b7e1-f847c2cde3d1"), "Encargado de despacho de la unidad de investigación especializada de narcomenudeo" },
                    { new Guid("261a4c97-0e35-4353-bd7d-ad1c5e061ae5"), "Encargado de despacho de la unidad de investigación especializada en trata de personas" },
                    { new Guid("bcea2722-432e-43d3-8040-46cb88669680"), "Encargado de despacho de la unidad especializada de combate al secuestro" },
                    { new Guid("88c72324-a50c-4716-8e07-54c8d8017c2c"), "Encargado de despacho de la unidad especializada en investigación de robo a comercio" },
                    { new Guid("5f4505f6-5f42-4c5d-85b6-597d4c604932"), "Encargado de despacho de la unidad especializada en investigación de trata de personas" },
                    { new Guid("2a04734c-c58f-4fc8-819a-ff8b326ae094"), "Encargado de la fiscalía de zona regional sur (Izúcar de Matamoros)" },
                    { new Guid("cbb7161f-c5cc-4f08-b35b-646413c1968f"), "Encargado del despacho de la subdirección de desarrollo administrativo y planeación" },
                    { new Guid("ba50798e-399f-4343-b52b-f7b53993bbee"), "Encargado del despacho del departamento de control interno y fiscalización" },
                    { new Guid("3c3f3bdd-6d70-47aa-86f1-44e42570f616"), "Encargado del despacho del departamento de proveeduría" }
                });

            migrationBuilder.InsertData(
                table: "Cargos",
                columns: new[] { "CargoID", "Nombre" },
                values: new object[,]
                {
                    { new Guid("d851fe2c-ca9f-4aa0-9bd2-59e3c8610962"), "Encargado del despacho del departamento de siniestros" },
                    { new Guid("70069f7b-fee1-4a13-aae5-da74666a9369"), "Encargado de despacho de la unidad especializada en investigación de delitos sexuales y ciberacoso" },
                    { new Guid("d4d8e18f-bea0-4547-b60b-767ab94a9f6f"), "Enlace de apoyo administrativo y bienes asegurados de la fiscalía especializada en derechos humanos" },
                    { new Guid("821d8509-c900-49ec-878e-ebd255174c37"), "Enlace de apoyo adsministrativo y bienes asegurados" },
                    { new Guid("8826d959-338d-47d7-965b-4017d6d386d1"), "Enlace de apoyo jurídico (pendiente oficio)" },
                    { new Guid("b91392e9-cf6a-4738-996c-e0968d587942"), "Enlace de estadística y sistemas de información de la fiscalía de investigación regional" },
                    { new Guid("4aaf1b68-81d7-4490-9d41-0d78f88d69e9"), "Directora de seguimiento, evaluación y mejora institucional de la coordinación general de desarrollo institucional" },
                    { new Guid("b62ac4e9-48a7-400f-8ab7-d093b40641e5"), "Directora de responsabilidades" },
                    { new Guid("8cc11e9f-a13e-420a-a17c-c3c8a7ac0f5b"), "Directora general de comunicación estratégica y vinculación social" },
                    { new Guid("966e6431-5c8c-44c7-a80b-191c4a8715ef"), "Directora de operación de la agencia estatal de investigación" },
                    { new Guid("fa627a73-0bd4-418a-8dac-8709b7566cf0"), "Director de área" },
                    { new Guid("e77721de-2182-47e8-ba54-080a1b533adf"), "Director de asuntos indígenas" },
                    { new Guid("360b1252-f739-4445-a6b4-98d7016adc1f"), "Director de atención a mandamientos ministeriales de la agencia estatal de investigación" },
                    { new Guid("5ab2e92a-a6df-4001-a357-33151dfbc900"), "Director de atención ciudadana de la coordinación general de servicios a la comunidad" },
                    { new Guid("626af01f-6af9-41f8-8f9f-a98e6cb314d3"), "Director de bienes asegurados" },
                    { new Guid("28de3497-d7ad-4d03-ac17-14aa806a2762"), "Director de calidad" },
                    { new Guid("b95959c9-3143-4906-90dd-52a8d2e5976d"), "Director de colaboración de la agencia estatal de investigación" },
                    { new Guid("6eccb3d8-5907-4831-a59e-44aa7d18fb50"), "Director de desarrollo financiero y presupuestal" },
                    { new Guid("6d4b9970-47e6-42ea-9462-03cf99e2784b"), "Director de información" },
                    { new Guid("cbc1e1c7-fd36-48dd-9ef6-172f866be596"), "Directora de profesionalización" },
                    { new Guid("c2a6c1c1-f9a5-43e7-8ec6-d1142c823a46"), "Director de mandamientos judiciales de la agencia estatal de investigación" },
                    { new Guid("19d94a22-f666-42e4-aa54-aae5f30d1d21"), "Director de seguridad a servidores públicos, instalaciones y eventos" },
                    { new Guid("ad0ceb1f-504a-4420-a629-c9516d5e4267"), "Director de servicio profesional de carrera" },
                    { new Guid("ecdd7e59-084d-4372-a850-925cf303e780"), "Director de investigación de la visitaduría general" },
                    { new Guid("7fcd5229-71c2-4f71-894f-9e5653d0969d"), "Director general de planeación institucional" },
                    { new Guid("38651a2e-4fa8-4ec8-9ab7-c6ce5afa82d0"), "Directora de lo contencioso" },
                    { new Guid("619b37d0-c307-4745-a038-daf0700f9ffa"), "Directora de laboratorios" },
                    { new Guid("b6a8963e-7062-4833-84e9-b37a68b24fbf"), "Director de tecnología" },
                    { new Guid("222f8817-a919-42da-8efd-782f487d5bde"), "Directora de criminalística" },
                    { new Guid("fdc3bd62-b5a3-4732-bed3-df0d78817339"), "Directora de comunicación social" },
                    { new Guid("177313bd-de66-4d2f-9e63-32c8eb69d209"), "Directora de apoyo y logística administrativa de la agencia estatal de investigación" },
                    { new Guid("e6702c15-b81d-4560-9a87-810d3939f5bd"), "Directora de gestión documental" },
                    { new Guid("ac53ffd6-1e6e-4ff5-82c1-93bcf64ca0c3"), "Directora de apoyo a la investigación" },
                    { new Guid("da5bf6f4-3c0a-4522-9981-70659d986949"), "Directora de administración" },
                    { new Guid("f669d723-a983-4c94-ba77-39d1363c7037"), "Directora consultiva y de normatividad de la coordinación general de asuntos jurídicos" },
                    { new Guid("f0a6f8c3-e476-45ad-ba26-0e4b1acff615"), "Director general del servicio médico forense" },
                    { new Guid("8ae094bc-2d78-4d3f-85ca-704db06c6f00"), "Director general de seguridad institucional" },
                    { new Guid("cbd08941-8071-4587-8634-b16b7745ad2f"), "Directora de apoyo técnico operativo" }
                });

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoID",
                keyValue: new Guid("8ecec734-2171-4bec-aaec-eba010af2489"),
                column: "Nombre",
                value: "No Aplica");

            migrationBuilder.InsertData(
                table: "Medios",
                columns: new[] { "MedioID", "Nombre" },
                values: new object[,]
                {
                    { new Guid("6a45ab2f-8171-4ffc-b74e-8c8ac6842a21"), "Vía telefónica" },
                    { new Guid("57740f1c-c60f-4232-bfc1-a07b08d2dbea"), "Correo" },
                    { new Guid("acfca6b3-1cd0-4f6e-a299-685d9ee6a6ee"), "Presencial" }
                });

            migrationBuilder.InsertData(
                table: "Medios",
                columns: new[] { "MedioID", "Nombre" },
                values: new object[] { new Guid("df534fce-96dc-4346-b47b-589b0f915708"), "Buzón" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolID",
                keyValue: new Guid("942f1900-7987-4820-a40b-7f4b78099d85"),
                column: "Nombre",
                value: "UnidadAdministrativa");

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "RolID", "Nombre" },
                values: new object[] { new Guid("39b991ab-e83e-4441-9638-9bd8fa647cb5"), "Fiscal" });

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("88f8cf91-458b-438c-b882-75a842387c64"),
                column: "Nombre",
                value: "No Aplica");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("a22533a6-7621-492c-b10b-a9363668a2f4"),
                column: "DepartamentoID",
                value: new Guid("dec844ee-a2ba-4a09-a4e1-62a5ea6a46b7"));

            migrationBuilder.InsertData(
                table: "Usuarios",
                columns: new[] { "UsuarioID", "Activo", "Clave", "Correo", "DepartamentoID", "Nombre", "RolID", "UnidadAdministrativaID" },
                values: new object[] { new Guid("03147300-43fc-4294-81d4-4bc08366f4a4"), true, "123", "fiscal@gmail.com", new Guid("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), "Fiscal Mario", new Guid("39b991ab-e83e-4441-9638-9bd8fa647cb5"), new Guid("88f8cf91-458b-438c-b882-75a842387c64") });

            migrationBuilder.CreateIndex(
                name: "IX_Quejas_CargoID",
                table: "Quejas",
                column: "CargoID");

            migrationBuilder.CreateIndex(
                name: "IX_Quejas_MedioID",
                table: "Quejas",
                column: "MedioID");

            migrationBuilder.AddForeignKey(
                name: "FK_Quejas_Cargos_CargoID",
                table: "Quejas",
                column: "CargoID",
                principalTable: "Cargos",
                principalColumn: "CargoID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Quejas_Medios_MedioID",
                table: "Quejas",
                column: "MedioID",
                principalTable: "Medios",
                principalColumn: "MedioID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quejas_Cargos_CargoID",
                table: "Quejas");

            migrationBuilder.DropForeignKey(
                name: "FK_Quejas_Medios_MedioID",
                table: "Quejas");

            migrationBuilder.DropTable(
                name: "Cargos");

            migrationBuilder.DropTable(
                name: "Medios");

            migrationBuilder.DropIndex(
                name: "IX_Quejas_CargoID",
                table: "Quejas");

            migrationBuilder.DropIndex(
                name: "IX_Quejas_MedioID",
                table: "Quejas");

            migrationBuilder.DeleteData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("03147300-43fc-4294-81d4-4bc08366f4a4"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "RolID",
                keyValue: new Guid("39b991ab-e83e-4441-9638-9bd8fa647cb5"));

            migrationBuilder.DropColumn(
                name: "CargoID",
                table: "Quejas");

            migrationBuilder.DropColumn(
                name: "MedioID",
                table: "Quejas");

            migrationBuilder.UpdateData(
                table: "Departamentos",
                keyColumn: "DepartamentoID",
                keyValue: new Guid("8ecec734-2171-4bec-aaec-eba010af2489"),
                column: "Nombre",
                value: "General");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "RolID",
                keyValue: new Guid("942f1900-7987-4820-a40b-7f4b78099d85"),
                column: "Nombre",
                value: "Administrativo");

            migrationBuilder.UpdateData(
                table: "UnidadAdministrativas",
                keyColumn: "UnidadAdministrativaID",
                keyValue: new Guid("88f8cf91-458b-438c-b882-75a842387c64"),
                column: "Nombre",
                value: "General");

            migrationBuilder.UpdateData(
                table: "Usuarios",
                keyColumn: "UsuarioID",
                keyValue: new Guid("a22533a6-7621-492c-b10b-a9363668a2f4"),
                column: "DepartamentoID",
                value: new Guid("8a6aeedd-336d-4e65-bede-b95f4bf83cf5"));
        }
    }
}
