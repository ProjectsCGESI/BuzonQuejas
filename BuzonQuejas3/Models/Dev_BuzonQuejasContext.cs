using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace BuzonQuejas3.Models
{
    public partial class Dev_BuzonQuejasContext : DbContext
    {
        public Dev_BuzonQuejasContext()
        {
        }

        public Dev_BuzonQuejasContext(DbContextOptions<Dev_BuzonQuejasContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Queja> Quejas { get; set; }
        public virtual DbSet<Usuario> Usuarios { get; set; }
        public virtual DbSet<UnidadRemitente> UnidadRemitentes { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<UnidadAdministrativa> UnidadAdministrativas { get; set; }
        public virtual DbSet<Medio> Medios { get; set; }
        public virtual DbSet<Cargo> Cargos { get; set; }
        public virtual DbSet<Motivo> Motivos { get; set; }

//        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
//        {
//            if (!optionsBuilder.IsConfigured)
//            {
////#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
//                optionsBuilder.UseSqlServer("server=10.24.1.48;database=Dev_BuzonQuejas;User Id=buzon;Password=buzon;");
//            }
//        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //modelBuilder.Entity<Queja>().ToTable("Queja");
            //modelBuilder.Entity<Usuario>().ToTable("Usuario");
            //modelBuilder.Entity<Departamento>().ToTable("Departamento");
            //modelBuilder.Entity<Rol>().ToTable("Rol");
            //modelBuilder.Entity<Municipio>().ToTable("Municipio");
            //modelBuilder.Entity<UnidadAdministrativa>().ToTable("UnidadAdministrativa");
            //modelBuilder.Entity<CentroTrabajo>().ToTable("CentroTrabajo");

            modelBuilder.Entity<Queja>(entity =>
            {
                entity.HasKey(e => e.QuejaID);
            });
            
            modelBuilder.Entity<Usuario>(entity =>
            {
                entity.HasKey(e => e.UsuarioID);
            });
            
            modelBuilder.Entity<UnidadRemitente>(entity =>
            {
                entity.HasKey(e => e.UnidadRemitenteID);
            });
            
            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.RolID);
            });

            modelBuilder.Entity<Municipio>(entity =>
            {
                entity.HasKey(e => e.MunicipioID);
            });

            modelBuilder.Entity<UnidadAdministrativa>(entity =>
            {
                entity.HasKey(e => e.UnidadAdministrativaID);
            });
            
            modelBuilder.Entity<Medio>(entity =>
            {
                entity.HasKey(e => e.MedioID);
            });
            
            modelBuilder.Entity<Cargo>(entity =>
            {
                entity.HasKey(e => e.CargoID);
            });
            
            modelBuilder.Entity<Motivo>(entity =>
            {
                entity.HasKey(e => e.MotivoID);
            });

            //// Roles
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("77a225a3-1266-4b1f-b11c-504969afa856"), Nombre = "Root" });
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("9a39bcce-b092-4f90-9de7-9e0fb2137034"), Nombre = "Administrador" });
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7"), Nombre = "UnidadRemitente" });
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("942f1900-7987-4820-a40b-7f4b78099d85"), Nombre = "UnidadAdministrativa" });
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("39b991ab-e83e-4441-9638-9bd8fa647cb5"), Nombre = "Fiscal" });
            //modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("592d923a-9d0b-424c-8bc3-0c42ff72495e"), Nombre = "UnidadAdministrativa", Activo=true });

            ////Departamentos
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("fc574c1e-8f81-40bd-8624-8f7e443cea4c"), Nombre = "Oficina de FGE" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("db9b55d6-d582-437d-8b9c-c1ba810760f0"), Nombre = "Servicios a la comunidad" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("0168408d-f59c-49b6-9aff-d818095bafd1"), Nombre = "Comunicación social" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("80a14da2-e2d7-43ee-89eb-0419c93cf6df"), Nombre = "Visitaduría" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("ddb159b4-c10b-42c9-ad19-dda253ccf896"), Nombre = "OIC" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("85c3f06b-45bd-4bc3-a712-935b5c6f2436"), Nombre = "FEAI" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("7a7bb933-7142-4222-a159-4ea52dc8b5d9"), Nombre = "FDH" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("8a6aeedd-336d-4e65-bede-b95f4bf83cf5"), Nombre = "Correo FGE" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("dec844ee-a2ba-4a09-a4e1-62a5ea6a46b7"), Nombre = "Conmutador" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("8562af28-e0c7-4ba1-a889-9a3294cd70e0"), Nombre = "CG Análisis de la información" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), Nombre = "Administración" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("b1b2722e-ffef-40fc-8b01-d4a81be9558f"), Nombre = "Buzón web FGE" });
            modelBuilder.Entity<UnidadRemitente>().HasData(new UnidadRemitente { UnidadRemitenteID = new Guid("8ecec734-2171-4bec-aaec-eba010af2489"), Nombre = "No Aplica" });

            //// Unidades Administrativas
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("4b0240b3-98e7-4f86-881b-10f760c32f71"), Nombre = "Agencia Estatal de Investigación" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("dbfcacdf-82c3-49cd-b035-f992aa39a4e0"), Nombre = "Coordinación General de Análisis de Información" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("9bfcf217-97d8-469f-9652-d6741fce84a1"), Nombre = "Coordinación General de Asuntos Jurídicos" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("30ebd546-ab4e-4cb6-8d0e-9623d50a7869"), Nombre = "Coordinación General de Colaboración Interinstitucional" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("f9e1ead4-61d4-473e-a73a-a8389fc13e33"), Nombre = "Coordinación General de Desarrollo Institucional" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4"), Nombre = "Coordinación General de Estadística y Sistemas de Información" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("6a8e78c6-a792-46b3-8a09-ef0d5eeccbae"), Nombre = "Coordinación General de Gestión Documental Institucional" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("0d9102d0-d3c8-4e18-a13d-21fdedb7d9d6"), Nombre = "Coordinación General de Investigación" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("6f3bc61c-6e7e-42b0-b89e-00b919d5a096"), Nombre = "Coordinación General de Litigación" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("c76d8cbc-34a8-47ad-a75a-7342eb11974f"), Nombre = "Coordinación General de Mecanismos Alternativos de Solución de Controversias en Materia Penal" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("766edba0-def6-4c84-98ed-ee5329c8a055"), Nombre = "Coordinación General de Servicios a la Comunidad" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("039c76d3-4ca7-4c63-aa74-cbc7e001553d"), Nombre = "Dirección General de Comunicación Estratégica y Vinculación Social" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("4619dc4c-d498-4726-81a7-78d4d624d790"), Nombre = "Dirección General de Planeación Institucional" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("58da64f2-2cb3-4912-b378-4b6b53e29a37"), Nombre = "Dirección General de Seguridad Institucional" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("32c97d34-0fd4-46a0-9366-67843e3864ee"), Nombre = "Fiscalía de Investigación Metropolitana" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("32d4cca4-63fb-460d-8c7a-62a652346378"), Nombre = "Fiscalía de Investigación Regional" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("61e8ffa1-6e7a-4855-a5ba-437c8ea6a815"), Nombre = "Fiscalía Especializada de Asuntos Internos" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("da78b3f2-8cb2-4c60-ae7a-c390a99febfe"), Nombre = "Fiscalía Especializada de Combate a la Corrupción" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("d052658e-e743-478d-aa94-21f279ddde3d"), Nombre = "Fiscalía Especializada en Derechos Humanos" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("dfafd2a3-a200-4f1e-aebd-f791bd14d879"), Nombre = "Fiscalía Especializada en Investigación de Delitos de Alta Incidencia" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("31a77f82-63e0-44c5-afea-337d6d8af47d"), Nombre = "Fiscalía Especializada en Investigación de Delitos de Violencia de Género Contra las Mujeres" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("96559f1b-3880-4339-9c73-fed0ec116105"), Nombre = "Fiscalía Especializada en Investigación de Delitos Electorales" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("00fe8231-6879-4189-b706-e3abdf62d4b7"), Nombre = "Fiscalía Especializada en Investigación de Los Delitos de Desaparición Forzada de Personas y Desaparición Cometida por Particulares" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("2c9b14d2-8868-49ac-a503-584f44b7a6a1"), Nombre = "Fiscalía Especializada en Investigación de los Delitos de Operaciones con Recursos de Procedencia Ilícita Fiscales y Relacionados" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("e1a28eb5-19d7-4aa6-a340-d6366c46118c"), Nombre = "Fiscalía Especializada en Investigación de Secuestro y Extorsión" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("3a719e2b-7777-4694-aceb-157be081f8b3"), Nombre = "Fiscalía General del Estado" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("b467dc5a-5fb0-4399-9740-5877f10ce814"), Nombre = "Instituto de Ciencias Forenses" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("bbe7a98c-7420-43da-8a4a-e80d331f4517"), Nombre = "Instituto de Formación Profesional" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("1c52fb81-0802-49f1-ad79-f53a05fc65fa"), Nombre = "Oficialía Mayor" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("98b8fe5f-ba52-45cc-a416-cd509356cef1"), Nombre = "Oficina del Fiscal General" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("199240cf-7e2a-4f72-99f9-90a3d9e93ec1"), Nombre = "Órgano Interno de Control" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("2c1dcd2b-da26-414b-9a97-652f0d2809a4"), Nombre = "Unidad de Transparencia" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("53f19eac-b8f3-4486-8be4-4ef56fcb5084"), Nombre = "Unidad Especializada en Materia de Extinción de Dominio" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78"), Nombre = "Visitaduría General" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("88f8cf91-458b-438c-b882-75a842387c64"), Nombre = "Sin Asignar" });
           
            //// Usuarios
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"), Nombre = "root", Correo="root@root.com", Clave = "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=", Activo = true, RolID = Guid.Parse("77a225a3-1266-4b1f-b11c-504969afa856"), UnidadRemitenteID= Guid.Parse("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), UnidadAdministrativaID = Guid.Parse("88f8cf91-458b-438c-b882-75a842387c64") });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("7467db95-c0a1-41df-a844-bbb00b60b952"), Nombre = "Administrador", Correo="administrador@administrador.com", Clave = "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=", Activo = true, RolID = Guid.Parse("9a39bcce-b092-4f90-9de7-9e0fb2137034"), UnidadRemitenteID= Guid.Parse("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), UnidadAdministrativaID = Guid.Parse("88f8cf91-458b-438c-b882-75a842387c64") });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("a22533a6-7621-492c-b10b-a9363668a2f4"), Nombre = "Angel Sayago Arcos", Correo="angel@gmail.com", Clave = "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=", Activo = true, RolID = Guid.Parse("a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7"), UnidadRemitenteID= Guid.Parse("dec844ee-a2ba-4a09-a4e1-62a5ea6a46b7"), UnidadAdministrativaID = Guid.Parse("88f8cf91-458b-438c-b882-75a842387c64") });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("2e3ff721-5a7d-4b82-87bb-3a593824ce25"), Nombre = "Magali Herrera Ramirez", Correo="magali@gmail.com", Clave = "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=", Activo = true, RolID = Guid.Parse("942f1900-7987-4820-a40b-7f4b78099d85"), UnidadRemitenteID= Guid.Parse("8ecec734-2171-4bec-aaec-eba010af2489"), UnidadAdministrativaID = Guid.Parse("4f0f5406-572d-409c-8cf2-4add53fceb78") });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("03147300-43fc-4294-81d4-4bc08366f4a4"), Nombre = "Fiscal Mario", Correo="fiscal@gmail.com", Clave = "4OMrm+P3jNpf7pTqrqf8aWCZ/TJgqfaI1LkxFvHu13E=", Activo = true, RolID = Guid.Parse("39b991ab-e83e-4441-9638-9bd8fa647cb5"), UnidadRemitenteID= Guid.Parse("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), UnidadAdministrativaID = Guid.Parse("88f8cf91-458b-438c-b882-75a842387c64") });


            ////Municipios
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8a2eec57-3f89-4815-a37e-4a8794f23932"), Nombre = "Acajete" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0fe356fb-b431-431c-a622-815e85b9e0ed"), Nombre = "Acateno" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), Nombre = "Acatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bfbc011a-1d34-4f65-af7b-166212abd6b9"), Nombre = "Acatzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("840a9308-ab81-4b01-bc1f-c2e33c8bed69"), Nombre = "Acteopan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8c07e9aa-0247-4000-8216-376b650d81a0"), Nombre = "Ahuacatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("823317e0-12de-471e-9f83-ab679882ee8f"), Nombre = "Ahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("12a9e605-7824-443b-bb0c-59ae30716cdb"), Nombre = "Ahuazotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a4b948b4-e990-4e1e-b84a-391dc0b9d408"), Nombre = "Ahuehuetitla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6abde6ad-fa6a-46e4-9cc9-b829a20bfca4"), Nombre = "Ajalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("75ec7d72-f948-4415-ac9b-df22759ba077"), Nombre = "Albino Zertuche" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f12af03b-940f-4e78-a0ee-32164243cf86"), Nombre = "Aljojuca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e4283090-366c-4c7c-a80a-a0a4a7bd1747"), Nombre = "Altepexi" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d0e4567b-e3f8-4a5f-bae6-f34cd50221d0"), Nombre = "Amixtlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), Nombre = "Amozoc" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0c9a3403-1986-4e7c-8e67-8b46cffdee33"), Nombre = "Aquixtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ccabcdbd-6870-47bd-b69b-89a5e7dc0015"), Nombre = "Atempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0f2c20d5-a9c0-4370-98f8-efa56e0550d7"), Nombre = "Atexcal" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), Nombre = "Atlixco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("909e81fd-63ee-4b9a-8423-12d69e07b6ba"), Nombre = "Atoyatempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("19713617-031a-4e0a-b65c-b2116bc8f07e"), Nombre = "Atzala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2aebe25a-dbd6-4636-b0e7-5b9c1bc00acb"), Nombre = "Atzitzihuacán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("83ab75ab-2c92-4b36-af4d-acc69e19bc32"), Nombre = "Atzitzintla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1973b1af-ba3c-435b-b922-ccc973054778"), Nombre = "Axutla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("13ed3d8a-3c9c-4d96-8244-7f0d3baf7d45"), Nombre = "Ayotoxco de Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b700df4b-7985-455e-a65e-5e9eb9f46015"), Nombre = "Calpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("006889f8-b5d9-4ff3-8df1-a66c454862f4"), Nombre = "Caltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f993c5bf-ef48-4376-89ce-d5b5da0c8607"), Nombre = "Camocuautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f635ab64-0027-4f16-bbe0-16e8ca698b24"), Nombre = "Caxhuacan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ff270e22-7846-40ab-adb5-4f2f715f99cf"), Nombre = "Coatepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("73c2fc84-68a2-4fdf-8a7a-333f3527d2bc"), Nombre = "Coatzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("89b1986a-21f7-47af-92d5-f2029173418e"), Nombre = "Cohetzala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4775767a-f004-4089-be45-d1faf5944dcc"), Nombre = "Cohuecan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d50693ad-c855-4e27-96ec-95b8d69e3cf7"), Nombre = "Coronango" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("44e4b1a1-4ad2-406c-9c2b-c718609eb12a"), Nombre = "Coxcatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9ee91716-b29a-43dd-b131-7c2dfa2346ca"), Nombre = "Coyomeapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e307bbce-d45e-4222-b983-02dc8a204ec7"), Nombre = "Coyotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1885d3d1-6f7e-4c83-8a2e-2d76d3be6496"), Nombre = "Cuapiaxtla de Madero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2346a1ef-ae38-4861-b411-cb6ebc5ef259"), Nombre = "Cuautempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("48b1e89c-da02-43c5-aaa1-1866770eb217"), Nombre = "Cuautinchán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Nombre = "Cuautlancingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6271e3c3-5f1c-4319-b66c-c0c7d37cf5c1"), Nombre = "Cuayuca de Andrade" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bd11d6fc-e5e2-40b3-b9e7-4f30f728f3ca"), Nombre = "Cuetzalan del Progreso" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4bb37a73-3b1b-40bc-bbb4-410d0243d0c2"), Nombre = "Cuyoaco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2048e5a8-f080-43dd-8084-c6a1ae355ecb"), Nombre = "Chalchicomula de Sesma" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ea4c1169-7793-431f-a5d4-6ce9b57be34c"), Nombre = "Chapulco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e23b3a09-8039-4e88-ace4-ef647127825a"), Nombre = "Chiautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5ce1ad1b-8342-4433-8a5c-3ab942f0b642"), Nombre = "Chiautzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b840328d-c5c1-41b1-8a28-a2d8ca2197da"), Nombre = "Chiconcuautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("03a3d7ec-af1b-43c9-b03d-75f7288b6968"), Nombre = "Chichiquila" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2d4fab62-b3e3-4f63-b307-1fcce884dee0"), Nombre = "Chietla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e13c5d9e-cbc0-4e4c-b2fd-cb95644708c2"), Nombre = "Chigmecatitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), Nombre = "Chignahuapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e4b0f3df-5c48-4875-8c6e-0e8fb52551b4"), Nombre = "Chignautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bef8b34a-8cc9-417d-b71c-ab26327964f0"), Nombre = "Chila" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("66377da5-fbc0-4e07-b9eb-00aca42d8ea3"), Nombre = "Chila de la Sal" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6075e940-5e1c-4ab8-a07d-a1484bb307cf"), Nombre = "Honey" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4dd95aaf-08d6-4056-a3fa-c8020dd3c8a5"), Nombre = "Chilchotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("829f24e0-2f28-4bbb-a071-b65991d2af97"), Nombre = "Chinantla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c98b57fa-b13a-4fd1-89a5-625b8d23d9a3"), Nombre = "Domingo Arenas" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ae3ce140-fb00-49af-ba1b-0c6b59df34cb"), Nombre = "Eloxochitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f537cd59-2f47-438c-9e57-ec53ae50fb92"), Nombre = "Epatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d6d7212c-5197-42ac-8013-4d6e567ee33a"), Nombre = "Esperanza" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("27e71d48-0841-4390-b50a-6a9dc06e2dfb"), Nombre = "Francisco Z. Mena" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cc76e568-d6e7-4f94-b6be-5088091bdc1d"), Nombre = "General Felipe Ángeles" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("49bd61b1-fd49-4a6c-ba9d-0b06f973e523"), Nombre = "Guadalupe" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f89e331e-5bd0-495b-a9be-aec53903d49d"), Nombre = "Guadalupe Victoria" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9f4c77aa-42ce-49db-9690-683c9ed55d8c"), Nombre = "Hermenegildo Galeana" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("28370ae3-6d8d-4be8-9fce-cd90da40cb27"), Nombre = "Huaquechula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f4d99b30-aeb1-462e-9244-c0b1ed03ba56"), Nombre = "Huatlatlauca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bf447292-6874-4d7e-8790-946362b43fae"), Nombre = "Huauchinango" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e9831b76-fd9a-479f-a092-99959ce42003"), Nombre = "Huehuetla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("abae6922-c82a-4641-9400-f6c4e5f6e074"), Nombre = "Huehuetlán EL Chico" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), Nombre = "Huejotzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("133d5400-25b2-45a2-8b71-953491024885"), Nombre = "Hueyapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5779a362-2a8a-4b59-b467-37cc1353c55f"), Nombre = "Hueytamalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4f865cf9-bd58-4971-aa79-eec2bc2e74bd"), Nombre = "Hueytlalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("df2a228b-3b08-4810-832b-243eb92b4d1f"), Nombre = "Huitzilan de Serdán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4cbca531-c59f-4d18-ba0c-1331bfdb5429"), Nombre = "Huitziltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("804e7bab-0d0a-4b1b-8d0e-e1ccad05a046"), Nombre = "Atlequizayan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e8840ad7-605a-4d0e-815c-522d498f13fc"), Nombre = "Ixcamilpa de Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4aaebe1d-b624-47c8-8d53-fb6a6f17c088"), Nombre = "Ixcaquixtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("488a103a-b38d-490c-851f-5b8129d25f09"), Nombre = "Ixtacamaxtitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("142e04d7-97fc-45af-800d-8c840033b829"), Nombre = "Ixtepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), Nombre = "Izúcar de Matamoros" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("189c3643-13d7-4413-bbd9-33331eec7fa4"), Nombre = "Jalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7a01377b-6582-48a5-bd47-a6dc237fc73c"), Nombre = "Jolalpan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1157ff74-5207-4722-8b95-2c63629a64ed"), Nombre = "Jonotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("72298c90-8cb5-4de7-9e8d-c04336d5092e"), Nombre = "Jopala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a5d6fc46-9f9b-4c76-a081-974bac548ee9"), Nombre = "Juan C. Bonilla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bce4fd8b-87da-4614-a142-ce280c11d5f2"), Nombre = "Juan Galindo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2457aa01-4c63-4f89-ad2d-adf66a05092c"), Nombre = "Juan N. Méndez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("30d10d87-b039-4aaf-a4ef-9d57c1a1fbd8"), Nombre = "Lafragua" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), Nombre = "Libres" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8ff69105-de9b-494c-98c6-a2f3e0f1c3ce"), Nombre = "La Magdalena Tlatlauquitepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7a139790-eb48-47dc-ae3a-20297745885a"), Nombre = "Mazapiltepec de Juárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("afa3f65b-c426-45cd-b05f-386590a07700"), Nombre = "Mixtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7fb38e1e-37e9-4226-ad2c-bda84124f541"), Nombre = "Molcaxac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ec30f6a2-2185-45e2-9568-a108c12136ff"), Nombre = "Cañada Morelos" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("76555ea1-66ec-41a8-83dc-1b6952cd116d"), Nombre = "Naupan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("eb078984-7842-4850-a9a0-27ca9b857dce"), Nombre = "Nauzontla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("39e6ae1a-b799-4a14-834a-56cdcb29ce52"), Nombre = "Nealtican" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0ac3f2af-443e-4ec2-bb07-da2f4f8819a5"), Nombre = "Nicolás Bravo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4dd53f09-a313-417e-980c-c1a3894ef012"), Nombre = "Nopalucan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("44e3688b-4fa0-47e5-8526-29c6b98ea6bf"), Nombre = "Ocotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f93a9af8-9ada-454e-aa67-805dd376623b"), Nombre = "Ocoyucan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("fa05b28b-0949-4e1e-bcbd-2e24103a3664"), Nombre = "Olintla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d6b02a53-8089-4f8d-9b2e-9eca63363325"), Nombre = "Oriental" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8340602f-711a-467c-8e59-a2abb587b604"), Nombre = "Pahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), Nombre = "Palmar de Bravo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6faf0c5c-bfcb-47eb-a430-bfad3a3a169e"), Nombre = "Pantepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("731d7347-37b0-4667-a08d-121add8a4295"), Nombre = "Petlalcingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("dbd57015-16f6-4ce3-aa44-94695ee49db1"), Nombre = "Piaxtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Nombre = "Puebla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e53e118b-b5d5-40b1-90bf-3e6d01039812"), Nombre = "Quecholac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2f765df8-e46c-4e03-b23b-f24984a8b111"), Nombre = "Quimixtlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("367c3734-6864-4801-8dca-161d1f371713"), Nombre = "Rafael Lara Grajales" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b28e047d-b3a1-4e24-a414-e6716e37b363"), Nombre = "Los Reyes de Juárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Nombre = "San Andrés Cholula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c0f1abb2-3ff1-407a-a1ca-2cde191237d5"), Nombre = "San Antonio Cañada" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2a19bb6d-1e13-4784-88c8-62d16d760e51"), Nombre = "San Diego la Mesa Tochimiltzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("623098dd-3ac0-4229-bcd8-7802318c3fdb"), Nombre = "San Felipe Teotlalcingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("838881f6-eb1c-4004-bd14-411e063d657c"), Nombre = "San Felipe Tepatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0dafd331-e51e-4d3b-a5f3-d69c532e30b5"), Nombre = "San Gabriel Chilac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("44da0137-6c7d-4cee-9b78-22a170c2687c"), Nombre = "San Gregorio Atzompa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7982bf83-0074-46fb-9d9b-f7e1ac0ade62"), Nombre = "San Jerónimo Tecuanipan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("02a51ab7-1217-46a5-9ebe-cd6e34400143"), Nombre = "San Jerónimo Xayacatlan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c1ae921b-4deb-4fbf-a0de-4daed33d59c0"), Nombre = "San José Chiapa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("aa022af9-1364-46dd-9804-15bbf72cfecd"), Nombre = "San José Miahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4ee68423-71cd-44b4-951e-539ca72b4fcb"), Nombre = "San Juan Atenco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bbe460a3-8847-4923-b4a9-9acc1a3f9773"), Nombre = "San Juan Atzompa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), Nombre = "San Martín Texmelucan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7b3656fc-abc8-4cce-9d19-65b8f3e6c323"), Nombre = "San Martín Totoltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d14e7485-8fa9-47d4-b684-e96fca467e21"), Nombre = "San Matías Tlalancaleca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("db092b2f-d154-40d9-a49c-f6705910e888"), Nombre = "San Miguel Ixitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cf50c366-a8d7-4430-b3d6-20d16f661162"), Nombre = "San Miguel Xoxtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("dd7e3968-c504-4f96-9a9d-5935a001393a"), Nombre = "San Nicolás buenos Aires" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a79ca31c-259f-46cf-8fd1-ac31b7f1e3a2"), Nombre = "San Nicolás de los Ranchos" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7451e764-5d9e-4427-9b4d-1ba0c9a09efd"), Nombre = "San Pablo Anicano" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("80948f99-4c11-4d37-a73a-803970ea9a72"), Nombre = "San Pedro Cholula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e07b1808-4af8-4834-bca1-a09157c5d10e"), Nombre = "San Pedro Yeloixtlahuaca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("96282c38-e892-4399-b814-568127e5dff1"), Nombre = "San Salvador el Seco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("16361230-1bdd-4133-87e1-4db480602b15"), Nombre = "San Salvador el Verde" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e8ee2dc6-8304-4d75-840d-4c26e8b93afe"), Nombre = "San Salvador Huixcolotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0b9af652-e4cb-4b88-a2da-3df709488ce2"), Nombre = "San Sebastián Tlacotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("071dc637-57e0-4f94-89f4-d2200840d84d"), Nombre = "Santa catarina Tlaltempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e05d08a9-c3bf-4907-b64f-6966d1b8bab6"), Nombre = "Santa Inés Ahuatempan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e78781af-ff29-45dc-b39a-74db1f06c521"), Nombre = "Santa Isabel Cholula" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9fc2cce1-f9f0-4010-a043-1ef31ebc5ca0"), Nombre = "Santiago Miahuatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5725ad2c-4481-40df-a0bd-0d358f205b5c"), Nombre = "Huehuetlán el Grande" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("fd628b6d-0964-4735-a112-d5579943e1fd"), Nombre = "Santo Tomás Hueyotlipan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("39e062ff-6a16-4def-bbc4-a57fb807b32c"), Nombre = "Soltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), Nombre = "Tecali de Herrera" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), Nombre = "Tecamachalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4ef206dd-de20-47f0-9be9-ea382a4b1b28"), Nombre = "Tecomatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Nombre = "Tehuacán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b99f1884-8403-4d4a-87e2-0455da7b7c67"), Nombre = "Tehuitzingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("97098c1c-bc49-4abe-b22d-3a4d8f60aa29"), Nombre = "Tenampulco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cddce61c-3c5d-49e2-841a-2a805b1d5e6e"), Nombre = "Teopantlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("946c022a-8933-4d77-9313-d3e907518684"), Nombre = "Teotlalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e05fcf8b-16f2-4b48-b5ec-7364be12d24a"), Nombre = "Tepanco de López" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4b4bb755-d591-49ad-bfdd-b135b4998278"), Nombre = "Tepango de Rodríguez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("19b20f14-0d71-49a8-8e2a-ad13ca6e6290"), Nombre = "Tepatlaxco de Hidalgo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), Nombre = "Tepeaca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("67ce3450-478e-4f3d-a6e6-6f6ab35abd50"), Nombre = "Tepemaxalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("73c192ff-d467-47e4-8957-4b3b47dfe3ba"), Nombre = "Tepeojuma" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f34ef5cb-4191-4680-8b9a-4a82eff6c292"), Nombre = "Tepezintla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("58e264f6-5b29-41d7-990a-95dc7175dfaf"), Nombre = "Tepexco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("80261179-cc03-47f8-89fe-cf001811739a"), Nombre = "Tepexi de Rodríguez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("51b25a8f-af7c-47fd-be3b-5047261a0382"), Nombre = "Tepeyahualco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("da041bf7-f859-4fec-9c80-43180d90c8fa"), Nombre = "Tepeyahualco de Cuauhtémoc" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cf8eb8cc-3270-4211-89c4-bfab4b117f6b"), Nombre = "Tetela de Ocampo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("730191fe-8d4b-407e-9dfd-f7404e8451ec"), Nombre = "Teteles de Ávila Castillo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), Nombre = "Teziutlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f5d7b5fa-177c-4935-8f6f-ddb9fb366cd7"), Nombre = "Tianguismanalco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e6742496-0928-494e-b970-8813dcfd7cee"), Nombre = "Tilapa" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("affcde71-1800-4e11-aa9e-fc2ba7348100"), Nombre = "Tlacotepec de Benito Juárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5b0df721-cd09-4858-99ad-bffbf8aa1a1e"), Nombre = "Tlacuilotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f9422f25-fa05-456f-a1eb-22325d90a0b7"), Nombre = "Tlachichuca" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cf5acff1-377d-4911-bc2a-87c5bd38b4e6"), Nombre = "Tlahuapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5a4b90a0-8bb7-4814-84c4-44980195173c"), Nombre = "Tlaltenango" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("195db7dc-3bbc-47ef-bd82-6abcffe04cb3"), Nombre = "Tlanepantla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8492ccff-f6e6-4133-a9ff-e43575fc0047"), Nombre = "Tlaola" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1a9e2ec9-bb72-4809-9d5f-a73cc4b975c1"), Nombre = "Tlapacoya" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7b0c4509-0939-4bfc-a744-7eb67be293ba"), Nombre = "Tlapanalá" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), Nombre = "Tlatlauquitepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9eb235c0-e5a8-4f51-ae9c-3cefa623bb31"), Nombre = "Tlaxco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), Nombre = "Tochimilco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c0d56773-01d8-41a9-8e21-24bbc0a0ea20"), Nombre = "Tochtepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cb0e2292-2039-4f55-87c1-dd55c90fc002"), Nombre = "Totoltepec de Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("405a2fe3-3be5-4c29-8f28-0e71f0a5c4dc"), Nombre = "Tulcingo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8bb21d7e-afa0-43b0-bdbf-4cee3bcf6741"), Nombre = "Tuzamapan De Galeana" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("434cda54-fd1c-43f8-8f30-b6078d32bc80"), Nombre = "Tzicatlacoyan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("59b7d064-17d8-48cb-a0b7-d90870a937d4"), Nombre = "Venustiano Carranza" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("33869def-c861-4536-952d-3a0768b10212"), Nombre = "Vicente Guerrero" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("65a9ea6d-0783-4c43-a688-37428acfd2c2"), Nombre = "Xayacatlán de Bravo" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), Nombre = "Xicotepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("17d251d7-b894-499c-8213-a34700eaee64"), Nombre = "Xicotlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c9ed9b5d-e55e-4bdc-b123-3ad409340ed1"), Nombre = "Xiutetelco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("023cb73d-ab39-4d44-98ec-43d7af56a725"), Nombre = "Xochiapulco" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a90778b7-f37e-4195-85cc-cb28013f2b55"), Nombre = "Xochiltepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6ca4dbd0-5ea7-4a3d-8169-dfad1f9ba752"), Nombre = "Xochitlán de Vicente Suárez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7baa727c-2af9-44a3-a49d-a1366c53a897"), Nombre = "Xochitlán Todos Santos" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e926e7a3-6ab8-493b-b52c-c233a218829b"), Nombre = "Yaonáhuac" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9c933cf8-5f3b-44fb-b107-b6627814c1bb"), Nombre = "Yehualtepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("37cf93c9-2a40-47dd-a55e-cb8289650346"), Nombre = "Zacapala" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), Nombre = "Zacapoaxtla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), Nombre = "Zacatlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d027d6b9-d21b-4829-ab30-afacf1dc7466"), Nombre = "Zapotitlán" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a250ea1a-d762-465c-9b45-89c711935787"), Nombre = "Zapotitlán de Méndez" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ce54dedd-6965-4dec-ae8d-29c26423ca18"), Nombre = "Zaragoza" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7d5891a4-d9ba-4bd2-93e2-2a001ddce36e"), Nombre = "Zautla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("74c34e7e-48d3-49f0-b120-7b8b2db29982"), Nombre = "Zihuateutla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("3a63a8df-b830-4745-ab4e-c4bff852b1b4"), Nombre = "Zinacatepec" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("aa844fdd-81bd-4ae4-bba9-0a27df08afc0"), Nombre = "Zongozotla" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d15ff9e1-3f2a-470d-beaf-8e656c62e542"), Nombre = "Zoquiapan" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d8c697be-c4c2-45ed-9e52-a54fcc5db144"), Nombre = "Zoquitlán" });

            //// Medios
            modelBuilder.Entity<Medio>().HasData(new Medio { MedioID = new Guid("6a45ab2f-8171-4ffc-b74e-8c8ac6842a21"), Nombre = "Vía telefónica" });
            modelBuilder.Entity<Medio>().HasData(new Medio { MedioID = new Guid("57740f1c-c60f-4232-bfc1-a07b08d2dbea"), Nombre = "Correo" });
            modelBuilder.Entity<Medio>().HasData(new Medio { MedioID = new Guid("acfca6b3-1cd0-4f6e-a299-685d9ee6a6ee"), Nombre = "Presencial" });
            modelBuilder.Entity<Medio>().HasData(new Medio { MedioID = new Guid("df534fce-96dc-4346-b47b-589b0f915708"), Nombre = "Buzón" });
            modelBuilder.Entity<Medio>().HasData(new Medio { MedioID = new Guid("a04c1856-54b5-4699-8660-367a5ac5444d"), Nombre = "Web" });

            ////Tipos de Cargos - Nuevos
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("35f230e5-95d9-4740-9d5e-a2d6330bcbb3"), Nombre = "Agente del ministerio público" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("593c34fc-af4d-443e-a583-f2038a971e63"), Nombre = "Agente investigador" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9a694e5a-d4aa-41de-818f-a916f4f0a47d"), Nombre = "Agente investigador (encargado de apoyo policial de San Pedro Cholula)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("aa32ac89-9b43-48e6-88af-18b1ec2ac0fa"), Nombre = "Agente investigador (encargado de apoyo policial de Tehuacán)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5040fa04-5492-4f84-aa6b-ae150fcd14b7"), Nombre = "Agente investigador (encargado de apoyo policial de San Andrés Cholula)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("4694b457-6ef2-4963-ae78-ff7e59b198b8"), Nombre = "Agente investigador (encargado del despacho de la dirección de intervención inmediata)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("53d194e7-48d2-4eab-9e4d-dc76d50587e0"), Nombre = "Agente investigador (encargado de apoyo policial de Cuautlancingo)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6a2e9821-91b9-4288-88de-b34f2bb99d9a"), Nombre = "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de delitos de violencia de género contra las mujeres" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("0a7a3893-e6a1-4877-b46b-2e182c6f8489"), Nombre = "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("96917de1-28e2-43d4-b835-4b2dd1092dba"), Nombre = "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("94aa3a6a-edc9-4474-8f9a-6df79360e01a"), Nombre = "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada de asuntos internos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5881b348-068f-42ee-8777-74b5a0c30c51"), Nombre = "Agente investigador, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada de combate a la corrupción" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5e5ecc06-7eb4-4285-a6e6-2b364e59d8df"), Nombre = "Agente investigador, encargado de la unidad de apoyo policial de la fiscalía de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("4d60047d-f909-4d07-a580-ba8ead2b194f"), Nombre = "Agente ministerial" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("74979f8d-97c6-46fe-8149-ec508e22e73d"), Nombre = "Analista" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a18fa257-fa4e-405e-a712-3b5f78250cfd"), Nombre = "Analista de información" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("16c6cee1-5f83-4a8f-842f-14fd9076c65c"), Nombre = "Asesor especial" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("f1e6482f-9cf9-433b-8b30-047edf19467b"), Nombre = "Asesor técnico" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("fc7cb1e0-a22b-411a-8da9-335b74606583"), Nombre = "Asesor técnico, responsable del área normativa de la dirección consultiva y de normatividad de la coordinación general de asuntos jurídicos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("54101122-6e91-42a3-a458-3d4d6156d35f"), Nombre = "Auxiliar" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("7ca27770-d11b-432d-89cf-53c905d520a2"), Nombre = "Auxiliar de facilitador" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("0c8b53be-d105-43a5-a316-fb078427f91f"), Nombre = "Auxiliar del ministerio público" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("27ec76fb-1551-4b0e-b8ec-0d8858c16cb4"), Nombre = "Comandante ministerial" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("03b07bb4-dc2b-4369-afec-133bba26da3d"), Nombre = "Comandante ministerial (encargado de apoyo policial de amozoc)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9167fc65-0416-4837-91f2-ddbd8a0c55ef"), Nombre = "Comandante ministerial (encargado de apoyo policial de San Martín Texmelucan)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("35b34c2c-484b-4d80-82eb-ce99a3424eac"), Nombre = "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de secuestro y extorsión" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("4ccb61b9-5693-408a-8aa0-66cf1a284552"), Nombre = "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de delitos de alta incidencia" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("cae3c364-b530-4e2b-b65a-1a1b7fc965c6"), Nombre = "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("184aa5ad-2201-4458-8916-8c7cb7688e5d"), Nombre = "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de los delitos de operaciones con recursos de procedencia ilícita, fiscales y relacionados" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9b54e77a-0aad-4d40-a6f6-769075bffd2d"), Nombre = "Comandante ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en investigación de delitos electorales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("86c0688b-3bf3-47af-b3c6-e1bbc2bbd367"), Nombre = "Comandante ministerial, encargado de la unidad de apoyo policial de la fiscalía especializada en investigación de los delitos de procedencia ilícita, fiscales y relacionados" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("30001459-aab0-4c6f-b7cc-b6d758ae3b5a"), Nombre = "Comandante, encargado de despacho de la dirección de investigación de la agencia estatal de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a831d19c-b733-406d-92eb-bc9950068ce8"), Nombre = "Coordinador de análisis estadística y base de datos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("500c309a-1fca-46cb-be2b-7ef05f774bb8"), Nombre = "Coordinador de investigación de la fiscalía de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("54bb2be3-9066-4002-a1e3-9fa5e556c552"), Nombre = "Coordinador de investigación de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a5549901-7b6c-4106-b738-6265bccb61f3"), Nombre = "Coordinador de investigación de la fiscalía especializada en investigación de delitos electorales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("778e91ef-b9df-4ab8-ac1c-89e64fbb48e4"), Nombre = "Coordinador de litigación de la fiscalía de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("0273cab0-21d4-4c77-84fb-4ecd421055d9"), Nombre = "Coordinador de litigación de la fiscalía en investigación de delitos de alta incidencia" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d37b21d2-175f-434a-862d-76755c1baad9"), Nombre = "Coordinador de litigación de la fiscalía especializada de combate a la corrupción" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c180e628-6b5e-4ae3-8324-f8cd95dbaef3"), Nombre = "Coordinador de litigación de la fiscalía especializada en investigación de delitos electorales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("48097932-e268-43fb-9e39-1dfe40ab1620"), Nombre = "Coordinador de litigación de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a58df3e0-2d4d-4124-9990-8ca6d930c241"), Nombre = "Coordinador de medios alternativos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("28409eeb-104b-47df-9fa0-d3217886c247"), Nombre = "Coordinador general de análisis de información" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ff52b028-e91a-4ec3-b407-c28edb7c5391"), Nombre = "Coordinador general de asuntos jurídicos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8b74cc38-c0f1-450b-bea9-2a7e3295c2eb"), Nombre = "Coordinador general de desarrollo institucional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("48f3fadd-1508-4f31-9383-53c7ca5a5346"), Nombre = "Coordinador general de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("dac27498-9d86-4196-adef-8311e24d1aec"), Nombre = "Coordinador general de litigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("bfffe331-abbe-4742-b71f-810f43e2d798"), Nombre = "Coordinador general de mecanismos alternativos de solución de controversias en materia penal" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a4ae229d-36c9-4095-89ce-135b38a0f1fa"), Nombre = "Coordinador general de servicios a la comunidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("77af20f3-d48c-4f7b-adaa-74a35797cc6e"), Nombre = "Coordinador investigación de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("62133114-2fa7-4ea9-a3ae-4eb1e2a7eb05"), Nombre = "Coordinador(a) de medios alternativos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("1f3c0415-c148-45a5-86a3-5c2c33bc38a2"), Nombre = "Coordinadora de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("0e06a1f1-7b84-4aed-aad1-aae581a415b9"), Nombre = "Coordinadora de investigación de la fiscalía de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6c9cab3c-cafa-4525-8765-c7be1c71e7a2"), Nombre = "Coordinadora de investigación de la fiscalía especializada en asuntos internos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("766ad9f3-10dc-4df2-905c-05fa96f64233"), Nombre = "Coordinadora de investigación de la fiscalía especializada en investigación de delitos de violencia de género contra las mujeres" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9f6b4a71-c59b-44bc-a9f7-bbf68ce448cc"), Nombre = "Coordinadora de investigación, encargada del despacho de la fiscalía especializada en investigación de delitos electorales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("11aa1204-6cbc-4d6d-ab0c-b9082310d046"), Nombre = "Coordinadora de litigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("01e70220-a3ef-4c8e-a0df-6fc8bf40f062"), Nombre = "Coordinadora de litigación de la fiscalía de investigación metropolitana " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("63448169-d24c-43b2-8012-bce9bd81ba73"), Nombre = "Coordinadora de litigación de la fiscalía especializada de asuntos internos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("bd1f7545-2c2c-42b8-b0cb-25d7c99c29e6"), Nombre = "Coordinadora de litigación de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("34c2b5ab-f1db-4183-92c8-561e18539f21"), Nombre = "Coordinadora de medios alternativos del área de la región poniente" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2ecaa075-e4e7-48e2-a8b9-0ddebeca2412"), Nombre = "Coordinadora general de colaboración interinstitucional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("410c0b79-4761-4a61-9aa0-d8d0e3bccac2"), Nombre = "Coordinadora general de estadística y sistemas de información" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("b6dcca3f-5e8e-4fb6-9fc6-466a61b2d5d7"), Nombre = "Director de apoyo y logística administrativa de le visitaduría general" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("fa627a73-0bd4-418a-8dac-8709b7566cf0"), Nombre = "Director de área" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e77721de-2182-47e8-ba54-080a1b533adf"), Nombre = "Director de asuntos indígenas" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("360b1252-f739-4445-a6b4-98d7016adc1f"), Nombre = "Director de atención a mandamientos ministeriales de la agencia estatal de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5ab2e92a-a6df-4001-a357-33151dfbc900"), Nombre = "Director de atención ciudadana de la coordinación general de servicios a la comunidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("626af01f-6af9-41f8-8f9f-a98e6cb314d3"), Nombre = "Director de bienes asegurados" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("28de3497-d7ad-4d03-ac17-14aa806a2762"), Nombre = "Director de calidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("b95959c9-3143-4906-90dd-52a8d2e5976d"), Nombre = "Director de colaboración de la agencia estatal de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6eccb3d8-5907-4831-a59e-44aa7d18fb50"), Nombre = "Director de desarrollo financiero y presupuestal" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6d4b9970-47e6-42ea-9462-03cf99e2784b"), Nombre = "Director de información" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ecdd7e59-084d-4372-a850-925cf303e780"), Nombre = "Director de investigación de la visitaduría general" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c2a6c1c1-f9a5-43e7-8ec6-d1142c823a46"), Nombre = "Director de mandamientos judiciales de la agencia estatal de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("19d94a22-f666-42e4-aa54-aae5f30d1d21"), Nombre = "Director de seguridad a servidores públicos, instalaciones y eventos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ad0ceb1f-504a-4420-a629-c9516d5e4267"), Nombre = "Director de servicio profesional de carrera" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("b6a8963e-7062-4833-84e9-b37a68b24fbf"), Nombre = "Director de tecnología" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("7fcd5229-71c2-4f71-894f-9e5653d0969d"), Nombre = "Director general de planeación institucional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8ae094bc-2d78-4d3f-85ca-704db06c6f00"), Nombre = "Director general de seguridad institucional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("f0a6f8c3-e476-45ad-ba26-0e4b1acff615"), Nombre = "Director general del servicio médico forense" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("f669d723-a983-4c94-ba77-39d1363c7037"), Nombre = "Directora consultiva y de normatividad de la coordinación general de asuntos jurídicos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("da5bf6f4-3c0a-4522-9981-70659d986949"), Nombre = "Directora de administración" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ac53ffd6-1e6e-4ff5-82c1-93bcf64ca0c3"), Nombre = "Directora de apoyo a la investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("cbd08941-8071-4587-8634-b16b7745ad2f"), Nombre = "Directora de apoyo técnico operativo" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("177313bd-de66-4d2f-9e63-32c8eb69d209"), Nombre = "Directora de apoyo y logística administrativa de la agencia estatal de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("fdc3bd62-b5a3-4732-bed3-df0d78817339"), Nombre = "Directora de comunicación social" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("222f8817-a919-42da-8efd-782f487d5bde"), Nombre = "Directora de criminalística" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e6702c15-b81d-4560-9a87-810d3939f5bd"), Nombre = "Directora de gestión documental" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("619b37d0-c307-4745-a038-daf0700f9ffa"), Nombre = "Directora de laboratorios" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("38651a2e-4fa8-4ec8-9ab7-c6ce5afa82d0"), Nombre = "Directora de lo contencioso" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("966e6431-5c8c-44c7-a80b-191c4a8715ef"), Nombre = "Directora de operación de la agencia estatal de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("cbc1e1c7-fd36-48dd-9ef6-172f866be596"), Nombre = "Directora de profesionalización" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("b62ac4e9-48a7-400f-8ab7-d093b40641e5"), Nombre = "Directora de responsabilidades" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("4aaf1b68-81d7-4490-9d41-0d78f88d69e9"), Nombre = "Directora de seguimiento, evaluación y mejora institucional de la coordinación general de desarrollo institucional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8ecf1984-75de-475a-8fd2-b92fc5a98736"), Nombre = "Directora de servicios a la comunidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e2eb4f41-676c-40e9-9213-0bacfaf1e55a"), Nombre = "Directora de supervisión técnica de la visitaduría general" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8cc11e9f-a13e-420a-a17c-c3c8a7ac0f5b"), Nombre = "Directora general de comunicación estratégica y vinculación social" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("dddaa1d9-e5fd-48ec-9298-0e32c4095e7f"), Nombre = "Directora regional de investigación de la coordinación general de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c4bae6f4-eb77-4bc9-953a-e47a967d052b"), Nombre = "Encargada de despacho de la dirección de planeación, programación, evaluación y organización" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("7af398cd-7fb4-4328-ad78-4f0287482fc2"), Nombre = "Encargada de despacho de la dirección general de los centros de justicia para las mujeres" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("52f954be-d31f-4cd2-8ff5-ab5823fe67f8"), Nombre = "Encargada de despacho de la subdirección de proyectos de inversión y bienes muebles e inmuebles" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5f8ec1d8-4242-4da6-847c-5f20572d5288"), Nombre = "Encargada de despacho de la unidad de investigación (Teziutlán)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("934952f3-4c28-492c-be97-8630a65e2792"), Nombre = "Encargada de despacho de la unidad de investigación de hechos de corrupción en el ámbito municipal de la fiscalía especializada de combate a la corrupción" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d28415b1-bfb9-4eb8-90d4-6e35bc1b55c7"), Nombre = "Encargada de despacho de la unidad de servicios periciales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("31272963-6362-4bd7-a3d8-a0567eeadb87"), Nombre = "Encargado de despacho de de la unidad especializada en investigación de robo a transeunte" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8d744475-c50d-40c8-8d3e-91c1a5462994"), Nombre = "Encargado de despacho de la unidad de flagrancia (Huauchinango)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("10301d51-7922-4e23-b7e1-f847c2cde3d1"), Nombre = "Encargado de despacho de la unidad de investigación especializada de narcomenudeo" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("261a4c97-0e35-4353-bd7d-ad1c5e061ae5"), Nombre = "Encargado de despacho de la unidad de investigación especializada en trata de personas" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("bcea2722-432e-43d3-8040-46cb88669680"), Nombre = "Encargado de despacho de la unidad especializada de combate al secuestro" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("88c72324-a50c-4716-8e07-54c8d8017c2c"), Nombre = "Encargado de despacho de la unidad especializada en investigación de robo a comercio" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5f4505f6-5f42-4c5d-85b6-597d4c604932"), Nombre = "Encargado de despacho de la unidad especializada en investigación de trata de personas" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2a04734c-c58f-4fc8-819a-ff8b326ae094"), Nombre = "Encargado de la fiscalía de zona regional sur (Izúcar de Matamoros)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("cbb7161f-c5cc-4f08-b35b-646413c1968f"), Nombre = "Encargado del despacho de la subdirección de desarrollo administrativo y planeación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ba50798e-399f-4343-b52b-f7b53993bbee"), Nombre = "Encargado del despacho del departamento de control interno y fiscalización" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("3c3f3bdd-6d70-47aa-86f1-44e42570f616"), Nombre = "Encargado del despacho del departamento de proveeduría" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d851fe2c-ca9f-4aa0-9bd2-59e3c8610962"), Nombre = "Encargado del despacho del departamento de siniestros" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("70069f7b-fee1-4a13-aae5-da74666a9369"), Nombre = "Encargado de despacho de la unidad especializada en investigación de delitos sexuales y ciberacoso" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d4d8e18f-bea0-4547-b60b-767ab94a9f6f"), Nombre = "Enlace de apoyo administrativo y bienes asegurados de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("821d8509-c900-49ec-878e-ebd255174c37"), Nombre = "Enlace de apoyo adsministrativo y bienes asegurados" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8826d959-338d-47d7-965b-4017d6d386d1"), Nombre = "Enlace de apoyo jurídico (pendiente oficio)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("b91392e9-cf6a-4738-996c-e0968d587942"), Nombre = "Enlace de estadística y sistemas de información de la fiscalía de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("df47294a-11eb-4cb7-a0f3-f26402c3847f"), Nombre = "Enlace de estadística y sistemas de información de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ae6f888f-a3c3-4dc6-a36d-9014acacd162"), Nombre = "Enlace de gestión documental de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5df5e537-953b-42b8-bcf8-2dc09e8f7156"), Nombre = "Enlace de gestión documental de la fiscalía especializada en investigación  de los delitos de desaparición forzada de personas y desaparición cometida por particulares" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a7f43660-49a0-436b-ab82-d6f08ab14056"), Nombre = "Enlace de gestión documental de la fiscalía especializada en investigación de delitos de violencia de género contra las mujeres" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5f154595-96e6-49f8-ad5a-86d6eeb550de"), Nombre = "Facilitador" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("16dbcf26-c2b5-4de9-bd71-597171c7f3c2"), Nombre = "Facilitadora" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("41ffa416-1660-45b9-b5ef-bb5e3a51fc7c"), Nombre = "Fiscal de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2205d53e-82e7-4222-ae58-d24d9ed6918a"), Nombre = "Fiscal de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("203c2302-371e-44a9-9cc1-834900f29d7c"), Nombre = "Fiscal de zona poniente" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("3c6de366-c5c4-445c-980c-b4975cf0f4ae"), Nombre = "Fiscal de zona sur de la fiscalía de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("eca1fb98-995c-4abb-8d9f-a6cff9bff3b0"), Nombre = "Fiscal especializada en investigación de delitos de violencia de género contra las mujeres,coordinadora de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a336d28f-f5e3-4927-bc34-8e48b44a4c6c"), Nombre = "Fiscal especializado de asuntos internos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c362e7cc-6169-4ef6-9966-3ee9e57ed7d0"), Nombre = "Fiscal especializado de combate a la corrupción" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("20458759-dac9-4579-bc14-3b20480781e0"), Nombre = "Fiscal especializado en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6d2c7c85-9207-460a-ae94-a99e61a1b01d"), Nombre = "Fiscal especializado en investigación de delitos de alta incidencia" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("4ec5deb5-db2f-45e5-a99b-b7d350d8cfd8"), Nombre = "Fiscal especializado en investigación de los delitos de operaciones con recursos de precedencia ilícita, fiscales y relacionados" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a491d4ce-671f-49cf-84b9-4bba51a10f53"), Nombre = "Fiscal especializado en investigación de los delitos desaparición forzada de personas y desaparición cometida por particulares" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c8a12d82-bd40-40d2-b78f-5b43ac2e8492"), Nombre = "Fiscal especializado en investigación de secuestro y extorsión" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("06d23cba-8825-4787-a76a-69acc3132609"), Nombre = "Fiscal general del estado" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("137a7a20-3692-4e98-99a0-133a882870bf"), Nombre = "Honorarios" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ee8c95f9-8438-40d2-985c-f577f50d05d8"), Nombre = "Inspector general" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2a98f412-0d1b-487f-bc34-06fc1b6cd77b"), Nombre = "Invitador" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("908501cc-9993-4fe2-8257-c8b14514cac4"), Nombre = "Jefa de departamento" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("f486d22c-5d94-44d2-9d4e-52196a0867f4"), Nombre = "Jefa de departamento de control de indicios de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("b8e51bdc-fca6-45ad-9f9e-97d62893f1a5"), Nombre = "Jefa del departamento de apoyo técnico de la fiscalía especializada de combate a la corrupción" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2fb58fee-a5aa-499f-87e8-63f92445959c"), Nombre = "Jefa del departamento de control de inmuebles" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("11762e06-28bd-4807-a523-67e09ff86304"), Nombre = "Jefa del departamento de desarrollo administrativo" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("89f4699c-3bce-4e0b-9fdd-cd75027e5a20"), Nombre = "Jefa del departamento de expedientes de inversión y banco de proyectos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5c716978-4394-463c-a281-3075240b6775"), Nombre = "Jefa del departamento de expedientes de personal  de la subdirección de servicios personales de la dirección de administración de la oficialía mayor" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("265b6fb1-9931-404b-8b29-8ec26effb629"), Nombre = "Jefa del departamento de gestión documental de la coordinación general de asuntos jurídicos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("0575c16d-e0db-47f2-9edb-ea565c2fd2be"), Nombre = "Jefa del departamento de mantenimiento de vehículos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c70ba7be-da95-4e52-ac3e-823fbf058c7f"), Nombre = "Jefa del departamento de movimientos y percepciones extraordinarias" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("f694701a-4ed9-4808-a8e4-359a27740d69"), Nombre = "Jefa del departamento de organización de la estructura orgánica de la dirección de organización y desarrollo administrativo de la oficialía mayor" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9cee6ab6-0a39-477b-8425-2b245ccd619e"), Nombre = "Jefa del departamento de procedimientos para el destino final de bienes asegurados" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("19579446-96b6-476f-8eaf-e94fc311ecc3"), Nombre = "Jefe de departamento" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("698c91a9-eef1-4aaa-afb5-ec3165dadbb0"), Nombre = "Jefe de departamento de adquisiciones y adjudicaciones" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("bd60c318-f90f-4937-b329-4943010b5fb9"), Nombre = "Jefe de departamento de indicios y bienes afectos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("064f278b-2461-418b-90ad-5c81c5fff7d7"), Nombre = "Jefe de departamento de información vehicular de la dirección de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c7dffaf9-6306-46f1-9a21-7752d348678c"), Nombre = "Jefe de grupo ministerial" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a082cd25-2262-474b-845b-20c49da7b537"), Nombre = "Jefe de grupo ministerial (encargado de apoyo policial de Atlixco)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2d4c71bf-0fb6-4420-88cd-ab5d481b98f2"), Nombre = "Jefe de grupo ministerial (encargado de apoyo policial de Tepeaca)" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d83fb7e8-d82e-4838-9b57-c3fbe7dd2d56"), Nombre = "Jefe de grupo ministerial, encargado de despacho de la unidad de apoyo policial de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("fba77d27-28b6-4eda-97be-ee44eb4b746d"), Nombre = "Jefe del departamento de apoyo técnico " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c9fec10c-cd1d-44d4-964e-b81f434bbae6"), Nombre = "Jefe del departamento de control vehicular" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a1a4686d-46f1-4faa-ba80-567479279477"), Nombre = "Jefe del departamento de diseño e imagen institucional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("97fb1504-48ee-4460-a313-7ff4dbca6ff2"), Nombre = "Jefe del departamento de servicios generales metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("36cd244f-d36f-4469-8b7d-f27a125c58ad"), Nombre = "Jefe del departamento jurídico de manuales administrativos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("36fde145-e0b8-45b3-b95d-e37a4cc95d69"), Nombre = "Oficial A" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("f080e0e7-6e1f-41dd-b432-e73906fcff63"), Nombre = "Oficial E" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("87d46917-7f04-4a59-975d-a72bdcc20f17"), Nombre = "Oficial I" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c1c81fc7-7ecb-4b38-b520-0bb93c7e85ac"), Nombre = "Oficial M" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("1c3267bd-dab9-4e35-a9f9-0f0a1364cc67"), Nombre = "Oficial R" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("76733838-b1db-4c0d-831d-d8844f26dbd3"), Nombre = "Oficial del ministerio público" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8a214f30-083a-43dd-970c-18c1ab84cdfa"), Nombre = "Oficial mayor" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("71f6e543-05e3-4346-b92d-ff3b515547aa"), Nombre = "Perita" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5fb3a3bf-9372-4d74-8884-a5156123e6cc"), Nombre = "Perita en contabilidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9378897d-3c18-4295-8518-21faf65f5811"), Nombre = "Perito" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("966bf88f-e037-4f6c-97c7-d30a9828d912"), Nombre = "Perito en contabilidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("746b3784-08d6-43f6-863c-ada46d4a5a12"), Nombre = "Perito técnico" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("139887dd-0377-433a-b42f-4fd31703428e"), Nombre = "Responsable del área de lo contencioso de la coordinación general de asuntos jurídicos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2abf41c5-f1ca-4115-bc28-50a9e02c8294"), Nombre = "Subdirector" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("0e9fe512-c47b-4546-9854-d6d7c47e6512"), Nombre = "Subdirector académico" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("3c9aee73-53ec-4504-ad0f-08a4dcb3d9c2"), Nombre = "Subdirector de apoyo técnico operativo" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("3a7137b4-a2de-42ee-81aa-1b13c12a807d"), Nombre = "Subdirector de contabilidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("dc6aa2a1-fff7-41d1-b26c-4be062d104cf"), Nombre = "Subdirector de control y seguimiento documental" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("01510334-9dd9-488b-a89b-a082b4f453f4"), Nombre = "Subdirector de profesionalización" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e0c81eed-9072-47cd-bd5d-8598f7ac3b30"), Nombre = "Subdirector de recursos materiales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("7dc71bc7-05f1-4676-82d0-54560136d092"), Nombre = "Subdirector de redes de la dirección de infraestructura tecnológica de la coordinación general de estadística y sistemas de información" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("3f49112f-f7f2-4433-98ec-d4f3ada920e8"), Nombre = "Subdirector de suministros" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("64363e08-1512-4cac-b30d-417b7e300f74"), Nombre = "Subdirector de tesorería de la dirección de desarrollo financiero y presupuestal " });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8a459e96-d449-4f42-a412-961c0aea8128"), Nombre = "Subdirector de vehículos y banco de armas" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ac104386-d442-4203-aec8-1159745f7aa1"), Nombre = "Subdirectora de control de gestión de la dirección de auditoría del órgano interno de control" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("42a36d6f-01d7-46f6-b8c4-e90a434592e8"), Nombre = "Subdirectora de fondos y política presupuestal" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("7017774e-2514-4c7f-9a08-8ef6bddd9790"), Nombre = "Subdirectora de glosa de gasto corriente e inversión" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6f225a75-f2b6-461f-ac76-3ecfef52046c"), Nombre = "Subdirectora de la delegación Tehuacán" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("cda9acc4-94c0-44eb-b1a5-f579b61f0f17"), Nombre = "Subdirectora de recepción y despacho documental" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("feef5cbb-64d4-41de-afb5-fcd8da2ed3e7"), Nombre = "Subdirectora de servicio civil de carrera" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e903db7a-d78e-4094-84d1-8760539585e3"), Nombre = "Subdirectora de servicios personales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("de6b5495-e9b6-43eb-95c6-f447d03ed2dc"), Nombre = "Subdirectora del servicio médico forense" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("bd11c0a6-75fa-46f9-a703-5842ce088c35"), Nombre = "Titular de la agencia estatal de investigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("13670d5f-bddb-4274-9679-31e24a8fd69f"), Nombre = "Titular de la dirección metropolitana de litigación de la coordinación general de litigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d4f076ea-18cd-4899-987b-9b9e1c54137c"), Nombre = "Titular de la dirección regional de litigación de la coordinación general de litigación" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("828b21e9-4c4d-4428-b59b-a545b02d21c8"), Nombre = "Titular de la oficina del fiscal general del estado" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("24f20c86-5d72-49dc-bd89-3090ea26c5fa"), Nombre = "Titular de la unidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5f1a8517-157c-429e-8c2d-0b4340fd832a"), Nombre = "Titular de la unidad  de investigación de delitos relacionados con personas desaparecidas de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e4974367-c31e-46ab-a375-5994772bafce"), Nombre = "Titular de la unidad coordinadora de archivos de la coordinación general de gestión documental institucional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6f67d27c-38a6-4e70-a2c8-cbdd90abe529"), Nombre = "Titular de la unidad de análisis y contexto de la fiscalía de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("70a77508-cc1c-4f82-9af4-24606952a82c"), Nombre = "Titular de la unidad de análisis y contexto de la fiscalía en investigación de delitos de violencia de género contra las mujeres" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("36bbd816-f0a9-48fc-a668-0b33fee64b50"), Nombre = "Titular de la unidad de análisis y contexto de la fiscalía especializada de combate a la corrupción" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("42960505-2789-4b23-82ac-e90601b3e53d"), Nombre = "Titular de la unidad de análisis y contexto de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e90e03b4-d62d-454e-b5bd-0b59c44f6935"), Nombre = "Titular de la unidad de derechos humanos de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8d446da1-4206-4dad-9855-bc5ddb24510e"), Nombre = "Titular de la unidad de flagrancia" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9c66e495-7ddf-4d3f-b293-8d1cf51cb262"), Nombre = "Titular de la unidad de flagrancia central I" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("094209ac-a783-4b99-b13e-7da82e0f7396"), Nombre = "Titular de la unidad de investigación de hechos de corrupción en el ámbito estatal de la fiscalía especializada de combate a la corrupción" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("988e2025-9650-45d6-b8a1-eee5812b7f15"), Nombre = "Titular de la unidad de investigación de la dirección de responsabilidades del órgano interno de control" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e15e3d5b-8fb8-4d15-8e29-549577534629"), Nombre = "Titular de la unidad de investigación especializada de sistema tradicional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("5fd8bba5-f8a1-41b8-9bb6-8e3f67815ba8"), Nombre = "Titular de la unidad de investigación especializada en delitos financieros y patrimoniales" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("ed158acd-e469-47f7-9ffa-c820b0b421d7"), Nombre = "Titular de la unidad de investigación especializada en feminicidio" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("11004dfa-721e-4834-a45c-abb0b77c0d2a"), Nombre = "Titular de la unidad de investigación especializada en violencia familiar y delitos de género" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("e068ed49-da14-48a5-9f89-5763cac17a81"), Nombre = "Titular de la unidad de investigación de periodistas y defensores de derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d0e7d6a1-873f-4eae-b4b2-1d2e62727834"), Nombre = "Titular de la unidad de localización de personas desaparecidas" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c79ae3f9-4df9-4628-9741-0392063f2319"), Nombre = "Titular de la unidad de situación patrimonial de la dirección de responsabilidades del órgano interno de control" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("f5b93b97-778c-4df4-b7f4-5e8107dc284e"), Nombre = "Titular de la unidad de sustanciación del órgano interno de control" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("23cdc855-96b5-4ddd-99a1-d57980ac0dc4"), Nombre = "Titular de la unidad de transparencia" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("c48b6f63-f20e-4e43-a92e-8a584c809018"), Nombre = "Titular de la unidad especializada de investigación de delitos ambientales de la fiscalía de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("49b515e1-92af-4f32-aff3-e078941daeec"), Nombre = "Titular de la unidad especializada de investigación de delitos contra la paz, la seguridad y las garantías de las personas de la fiscalía de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("51e230d1-a4e6-4cad-beeb-1a2bccb9da6f"), Nombre = "Titular de la unidad especializada de investigación de delitos contra la vida y la integridad corporal de la fiscalía de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("a7c69146-2a72-4929-864e-66893241bf96"), Nombre = "Titular de la unidad especializada de investigación de delitos contra los animales de la fiscalía de investigación regional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("980e4407-af2a-45fc-9ab6-2cd2e3a216da"), Nombre = "Titular de la unidad especializada de investigación de delitos de abuso de confianza, fraude, despojo, daño en propiedad ajena, robo de ganado, robo de maquinaria e implementos diversos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("1478aaca-c922-41ab-8cab-34e6dce9aad8"), Nombre = "Titular de la unidad especializada de investigación de robo de vehículos de la fiscalía especializada en investigación de  delitos de alta incidencia" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("dd55db68-ec82-47b7-b630-7941e8d67f08"), Nombre = "Titular de la unidad especializada de investigación del delito de tortura y otros tratos crueles, inhumanos o degradantes de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("75419c29-be4f-4f75-97f6-9b1af211349f"), Nombre = "Titular de la unidad especializada de justicia para adolescentes de la fiscalía especializada en derechos humanos" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("611d87de-3f4c-44fa-8455-76822828cb8a"), Nombre = "Titular de la unidad especializada en investigación de delitos cometidos contra la comunidad LGBTTTIQ" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("8e51c0d5-1b81-4946-b350-c175523ad26e"), Nombre = "Titular de la unidad especializada en investigación de delitos cometidos contra los animales de la fiscalía de investigación metropolitana" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("538936b5-0a05-4ce7-ae22-a6be4b55a83e"), Nombre = "Titular de la unidad especializada en materia de extinción de dominio" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6be4c160-2802-41d8-bc19-8da78dfa46b9"), Nombre = "Titular de la unidad resolutora de la dirección de responsabilidades del órgano interno de control" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("d193efc9-b89f-45d4-85ae-ed0ea8af8413"), Nombre = "Titular de la unidad unidad para la búsqueda de mujeres y niñas desaparecidas y delitos relacionados a través de la aplicación del protocolo alba y la coordinación con la alerta amber de la fiscalía especializada en investigación de los delitos de desaparición forzada de personas y desaparición cometida por particulares" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("2a2d1519-02d7-4b86-a76c-9ece94562a75"), Nombre = "Titular de unidad" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("6bb5329b-e07a-4c99-bd27-5994ad239e54"), Nombre = "Titular de unidad de apoyo administrativo" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("9a790101-e4fe-4e8d-aa4c-b6e954a4db03"), Nombre = "Titular del departamento de control de indicios de la fiscalía especializada en investigación de secuestro y extorsión" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("fbd7b890-d200-4055-a7fc-973990f68c68"), Nombre = "Titular del instituto de ciencias forenses" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("cc85ec17-87d2-4ae2-a1ea-ea963534007b"), Nombre = "Titular del instituto de formación profesional" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("057035c9-1e3d-4342-9e02-3b2c785bcae5"), Nombre = "Titular del órgano interno de control" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("81b47efb-2bfd-43f5-83cb-70fa069ee2c8"), Nombre = "Titular de la unidad de investigación especializada en robo a casa habitación y  robo a comercio" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("23637a0a-a8f2-4cfd-a99d-95e4d0a2e70e"), Nombre = "Visitador general" });
            modelBuilder.Entity<Cargo>().HasData(new Cargo { CargoID = new Guid("b9ac7679-b2df-4f1c-aa1f-d54d823bcd91"), Nombre = "Visitadora" });

            //motivos
            modelBuilder.Entity<Motivo>().HasData(new Motivo { MotivoID = new Guid("315a7096-1389-4db2-aed4-a423fb96eb5e"), Descripcion = "Problema al hacer cita para Antecendentes no penales", UnidadAdministrativaID = Guid.Parse("4f0f5406-572d-409c-8cf2-4add53fceb78") });
            modelBuilder.Entity<Motivo>().HasData(new Motivo { MotivoID = new Guid("a4bf6977-c3f2-4552-ad40-a159cacfda51"), Descripcion = "Falta a la moral", UnidadAdministrativaID = Guid.Parse("4f0f5406-572d-409c-8cf2-4add53fceb78") });

        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
