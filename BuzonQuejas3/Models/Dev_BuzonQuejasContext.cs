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
        public virtual DbSet<Departamento> Departamentos { get; set; }
        public virtual DbSet<Rol> Roles { get; set; }
        public virtual DbSet<Municipio> Municipios { get; set; }
        public virtual DbSet<UnidadAdministrativa> UnidadAdministrativas { get; set; }
        //public virtual DbSet<CentroTrabajo> CentroTrabajos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("server=10.24.1.48;database=Dev_BuzonQuejas;User Id=buzon;Password=buzon;");
            }
        }

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
            
            modelBuilder.Entity<Departamento>(entity =>
            {
                entity.HasKey(e => e.DepartamentoID);
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

            //// Roles
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("77a225a3-1266-4b1f-b11c-504969afa856"), Nombre = "Root" });
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("9a39bcce-b092-4f90-9de7-9e0fb2137034"), Nombre = "Administrador" });
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7"), Nombre = "Departamental" });
            modelBuilder.Entity<Rol>().HasData(new Rol { RolID = new Guid("942f1900-7987-4820-a40b-7f4b78099d85"), Nombre = "Administrativo" });
            //modelBuilder.Entity<Roles>().HasData(new Roles { Id = new Guid("592d923a-9d0b-424c-8bc3-0c42ff72495e"), Nombre = "UnidadAdministrativa", Activo=true });

            ////Departamentos
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("fc574c1e-8f81-40bd-8624-8f7e443cea4c"), Nombre = "Oficina de FGE" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("db9b55d6-d582-437d-8b9c-c1ba810760f0"), Nombre = "Servicios a la comunidad" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("0168408d-f59c-49b6-9aff-d818095bafd1"), Nombre = "Comunicación social" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("80a14da2-e2d7-43ee-89eb-0419c93cf6df"), Nombre = "Visitaduría" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("ddb159b4-c10b-42c9-ad19-dda253ccf896"), Nombre = "OIC" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("85c3f06b-45bd-4bc3-a712-935b5c6f2436"), Nombre = "FEAI" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("7a7bb933-7142-4222-a159-4ea52dc8b5d9"), Nombre = "FDH" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("8a6aeedd-336d-4e65-bede-b95f4bf83cf5"), Nombre = "Correo FGE" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("dec844ee-a2ba-4a09-a4e1-62a5ea6a46b7"), Nombre = "Conmutador" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("8562af28-e0c7-4ba1-a889-9a3294cd70e0"), Nombre = "CG Análisis de la información" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), Nombre = "Administración" });
            modelBuilder.Entity<Departamento>().HasData(new Departamento { DepartamentoID = new Guid("8ecec734-2171-4bec-aaec-eba010af2489"), Nombre = "General" });

            //// Unidades Administrativas

            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("4b0240b3-98e7-4f86-881b-10f760c32f71"), Nombre = "AGENCIA ESTATAL DE INVESTIGACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("dbfcacdf-82c3-49cd-b035-f992aa39a4e0"), Nombre = "COORDINACION GENERAL DE ANALISIS DE INFORMACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("9bfcf217-97d8-469f-9652-d6741fce84a1"), Nombre = "COORDINACION GENERAL DE ASUNTOS JURIDICOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("30ebd546-ab4e-4cb6-8d0e-9623d50a7869"), Nombre = "COORDINACION GENERAL DE COLABORACION INTERINSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("f9e1ead4-61d4-473e-a73a-a8389fc13e33"), Nombre = "COORDINACION GENERAL DE DESARROLLO INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("e7d58ae0-9a84-4cc6-889e-9a7fd9b078b4"), Nombre = "COORDINACION GENERAL DE ESTADISTICA Y SISTEMAS DE INFORMACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("6a8e78c6-a792-46b3-8a09-ef0d5eeccbae"), Nombre = "COORDINACION GENERAL DE GESTION DOCUMENTAL INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("0d9102d0-d3c8-4e18-a13d-21fdedb7d9d6"), Nombre = "COORDINACION GENERAL DE INVESTIGACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("6f3bc61c-6e7e-42b0-b89e-00b919d5a096"), Nombre = "COORDINACION GENERAL DE LITIGACION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("c76d8cbc-34a8-47ad-a75a-7342eb11974f"), Nombre = "COORDINACION GENERAL DE MECANISMOS ALTERNATIVOS DE SOLUCION DE CONTROVERSIAS EN MATERIA PENAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("766edba0-def6-4c84-98ed-ee5329c8a055"), Nombre = "COORDINACION GENERAL DE SERVICIOS A LA COMUNIDAD" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("039c76d3-4ca7-4c63-aa74-cbc7e001553d"), Nombre = "DIRECCION GENERAL DE COMUNICACION ESTRATEGICA Y VINCULACION SOCIAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("4619dc4c-d498-4726-81a7-78d4d624d790"), Nombre = "DIRECCION GENERAL DE PLANEACION INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("58da64f2-2cb3-4912-b378-4b6b53e29a37"), Nombre = "DIRECCION GENERAL DE SEGURIDAD INSTITUCIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("32c97d34-0fd4-46a0-9366-67843e3864ee"), Nombre = "FISCALIA DE INVESTIGACION METROPOLITANA" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("32d4cca4-63fb-460d-8c7a-62a652346378"), Nombre = "FISCALIA DE INVESTIGACION REGIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("61e8ffa1-6e7a-4855-a5ba-437c8ea6a815"), Nombre = "FISCALIA ESPECIALIZADA DE ASUNTOS INTERNOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("da78b3f2-8cb2-4c60-ae7a-c390a99febfe"), Nombre = "FISCALIA ESPECIALIZADA DE COMBATE A LA CORRUPCION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("d052658e-e743-478d-aa94-21f279ddde3d"), Nombre = "FISCALIA ESPECIALIZADA EN DERECHOS HUMANOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("dfafd2a3-a200-4f1e-aebd-f791bd14d879"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE ALTA INCIDENCIA" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("31a77f82-63e0-44c5-afea-337d6d8af47d"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS DE VIOLENCIA DE GENERO CONTRA LAS MUJERES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("96559f1b-3880-4339-9c73-fed0ec116105"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE DELITOS ELECTORALES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("00fe8231-6879-4189-b706-e3abdf62d4b7"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE DESAPARICION FORZADA DE PERSONAS Y DESAPARICION COMETIDA POR PARTICULARES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("2c9b14d2-8868-49ac-a503-584f44b7a6a1"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE LOS DELITOS DE OPERACIONES CON RECURSOS DE PROCEDENCIA ILICITA FISCALES Y RELACIONADOS" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("e1a28eb5-19d7-4aa6-a340-d6366c46118c"), Nombre = "FISCALIA ESPECIALIZADA EN INVESTIGACION DE SECUESTRO Y EXTORSION" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("3a719e2b-7777-4694-aceb-157be081f8b3"), Nombre = "FISCALIA GENERAL DEL ESTADO" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("b467dc5a-5fb0-4399-9740-5877f10ce814"), Nombre = "INSTITUTO DE CIENCIAS FORENSES" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("bbe7a98c-7420-43da-8a4a-e80d331f4517"), Nombre = "INSTITUTO DE FORMACION PROFESIONAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("1c52fb81-0802-49f1-ad79-f53a05fc65fa"), Nombre = "OFICIALIA MAYOR" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("98b8fe5f-ba52-45cc-a416-cd509356cef1"), Nombre = "OFICINA DEL FISCAL GENERAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("199240cf-7e2a-4f72-99f9-90a3d9e93ec1"), Nombre = "ORGANO INTERNO DE CONTROL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("2c1dcd2b-da26-414b-9a97-652f0d2809a4"), Nombre = "UNIDAD DE TRANSPARENCIA" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("53f19eac-b8f3-4486-8be4-4ef56fcb5084"), Nombre = "UNIDAD ESPECIALIZADA EN MATERIA DE EXTINCION DE DOMINIO" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("4f0f5406-572d-409c-8cf2-4add53fceb78"), Nombre = "VISITADURIA GENERAL" });
            modelBuilder.Entity<UnidadAdministrativa>().HasData(new UnidadAdministrativa { UnidadAdministrativaID = new Guid("88f8cf91-458b-438c-b882-75a842387c64"), Nombre = "GENERAL" });
           
            //// Usuarios
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("1139861b-5044-4257-b89a-db1b5d4402bf"), Nombre = "root", Correo="root@root.com", Clave = "123", Activo = true, RolID = Guid.Parse("77a225a3-1266-4b1f-b11c-504969afa856"), DepartamentoID= Guid.Parse("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), UnidadAdministrativaID = Guid.Parse("88f8cf91-458b-438c-b882-75a842387c64") });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("7467db95-c0a1-41df-a844-bbb00b60b952"), Nombre = "Administrador", Correo="administrador@administrador.com", Clave = "123", Activo = true, RolID = Guid.Parse("9a39bcce-b092-4f90-9de7-9e0fb2137034"), DepartamentoID= Guid.Parse("8a8e1e09-f9ce-41cb-b0b2-4ef91f7b4d61"), UnidadAdministrativaID = Guid.Parse("88f8cf91-458b-438c-b882-75a842387c64") });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("a22533a6-7621-492c-b10b-a9363668a2f4"), Nombre = "Angel Sayago Arcos", Correo="angel@gmail.com", Clave = "123", Activo = true, RolID = Guid.Parse("a7c2766f-c09e-41a1-b6e4-35aeed3ad8e7"), DepartamentoID= Guid.Parse("8a6aeedd-336d-4e65-bede-b95f4bf83cf5"), UnidadAdministrativaID = Guid.Parse("88f8cf91-458b-438c-b882-75a842387c64") });
            modelBuilder.Entity<Usuario>().HasData(new Usuario { UsuarioID = new Guid("2e3ff721-5a7d-4b82-87bb-3a593824ce25"), Nombre = "Magali Herrera Ramirez", Correo="magali@gmail.com", Clave = "123", Activo = true, RolID = Guid.Parse("942f1900-7987-4820-a40b-7f4b78099d85"), DepartamentoID= Guid.Parse("8ecec734-2171-4bec-aaec-eba010af2489"), UnidadAdministrativaID = Guid.Parse("4f0f5406-572d-409c-8cf2-4add53fceb78") });


            ////Municipios
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8a2eec57-3f89-4815-a37e-4a8794f23932"), Nombre = "ACAJETE" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0fe356fb-b431-431c-a622-815e85b9e0ed"), Nombre = "ACATENO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("af7b1630-8ba5-4320-9766-898ded1a8dcf"), Nombre = "ACATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bfbc011a-1d34-4f65-af7b-166212abd6b9"), Nombre = "ACATZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("840a9308-ab81-4b01-bc1f-c2e33c8bed69"), Nombre = "ACTEOPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8c07e9aa-0247-4000-8216-376b650d81a0"), Nombre = "AHUACATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("823317e0-12de-471e-9f83-ab679882ee8f"), Nombre = "AHUATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("12a9e605-7824-443b-bb0c-59ae30716cdb"), Nombre = "AHUAZOTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a4b948b4-e990-4e1e-b84a-391dc0b9d408"), Nombre = "AHUEHUETITLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6abde6ad-fa6a-46e4-9cc9-b829a20bfca4"), Nombre = "AJALPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("75ec7d72-f948-4415-ac9b-df22759ba077"), Nombre = "ALBINO ZERTUCHE" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f12af03b-940f-4e78-a0ee-32164243cf86"), Nombre = "ALJOJUCA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e4283090-366c-4c7c-a80a-a0a4a7bd1747"), Nombre = "ALTEPEXI" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d0e4567b-e3f8-4a5f-bae6-f34cd50221d0"), Nombre = "AMIXTLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b73b24a4-3a16-4f5c-828b-5554f14e7ee4"), Nombre = "AMOZOC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0c9a3403-1986-4e7c-8e67-8b46cffdee33"), Nombre = "AQUIXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ccabcdbd-6870-47bd-b69b-89a5e7dc0015"), Nombre = "ATEMPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0f2c20d5-a9c0-4370-98f8-efa56e0550d7"), Nombre = "ATEXCAL" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ee120a6e-e68f-4c37-9b62-0aa1df3b149f"), Nombre = "ATLIXCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("909e81fd-63ee-4b9a-8423-12d69e07b6ba"), Nombre = "ATOYATEMPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("19713617-031a-4e0a-b65c-b2116bc8f07e"), Nombre = "ATZALA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2aebe25a-dbd6-4636-b0e7-5b9c1bc00acb"), Nombre = "ATZITZIHUACAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("83ab75ab-2c92-4b36-af4d-acc69e19bc32"), Nombre = "ATZITZINTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1973b1af-ba3c-435b-b922-ccc973054778"), Nombre = "AXUTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("13ed3d8a-3c9c-4d96-8244-7f0d3baf7d45"), Nombre = "AYOTOXCO DE GUERRERO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b700df4b-7985-455e-a65e-5e9eb9f46015"), Nombre = "CALPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("006889f8-b5d9-4ff3-8df1-a66c454862f4"), Nombre = "CALTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f993c5bf-ef48-4376-89ce-d5b5da0c8607"), Nombre = "CAMOCUAUTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f635ab64-0027-4f16-bbe0-16e8ca698b24"), Nombre = "CAXHUACAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ff270e22-7846-40ab-adb5-4f2f715f99cf"), Nombre = "COATEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("73c2fc84-68a2-4fdf-8a7a-333f3527d2bc"), Nombre = "COATZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("89b1986a-21f7-47af-92d5-f2029173418e"), Nombre = "COHETZALA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4775767a-f004-4089-be45-d1faf5944dcc"), Nombre = "COHUECAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d50693ad-c855-4e27-96ec-95b8d69e3cf7"), Nombre = "CORONANGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("44e4b1a1-4ad2-406c-9c2b-c718609eb12a"), Nombre = "COXCATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9ee91716-b29a-43dd-b131-7c2dfa2346ca"), Nombre = "COYOMEAPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e307bbce-d45e-4222-b983-02dc8a204ec7"), Nombre = "COYOTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1885d3d1-6f7e-4c83-8a2e-2d76d3be6496"), Nombre = "CUAPIAXTLA DE MADERO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2346a1ef-ae38-4861-b411-cb6ebc5ef259"), Nombre = "CUAUTEMPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("48b1e89c-da02-43c5-aaa1-1866770eb217"), Nombre = "CUAUTINCHAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6e090986-3e32-4a13-b648-cf7844752930"), Nombre = "CUAUTLANCINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6271e3c3-5f1c-4319-b66c-c0c7d37cf5c1"), Nombre = "CUAYUCA DE ANDRADE" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bd11d6fc-e5e2-40b3-b9e7-4f30f728f3ca"), Nombre = "CUETZALAN DEL PROGRESO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4bb37a73-3b1b-40bc-bbb4-410d0243d0c2"), Nombre = "CUYOACO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2048e5a8-f080-43dd-8084-c6a1ae355ecb"), Nombre = "CHALCHICOMULA DE SESMA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ea4c1169-7793-431f-a5d4-6ce9b57be34c"), Nombre = "CHAPULCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e23b3a09-8039-4e88-ace4-ef647127825a"), Nombre = "CHIAUTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5ce1ad1b-8342-4433-8a5c-3ab942f0b642"), Nombre = "CHIAUTZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b840328d-c5c1-41b1-8a28-a2d8ca2197da"), Nombre = "CHICONCUAUTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("03a3d7ec-af1b-43c9-b03d-75f7288b6968"), Nombre = "CHICHIQUILA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2d4fab62-b3e3-4f63-b307-1fcce884dee0"), Nombre = "CHIETLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e13c5d9e-cbc0-4e4c-b2fd-cb95644708c2"), Nombre = "CHIGMECATITLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ead014cf-27e2-4244-b5d7-4e3e7b979c65"), Nombre = "CHIGNAHUAPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e4b0f3df-5c48-4875-8c6e-0e8fb52551b4"), Nombre = "CHIGNAUTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bef8b34a-8cc9-417d-b71c-ab26327964f0"), Nombre = "CHILA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("66377da5-fbc0-4e07-b9eb-00aca42d8ea3"), Nombre = "CHILA DE LA SAL" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6075e940-5e1c-4ab8-a07d-a1484bb307cf"), Nombre = "HONEY" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4dd95aaf-08d6-4056-a3fa-c8020dd3c8a5"), Nombre = "CHILCHOTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("829f24e0-2f28-4bbb-a071-b65991d2af97"), Nombre = "CHINANTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c98b57fa-b13a-4fd1-89a5-625b8d23d9a3"), Nombre = "DOMINGO ARENAS" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ae3ce140-fb00-49af-ba1b-0c6b59df34cb"), Nombre = "ELOXOCHITLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f537cd59-2f47-438c-9e57-ec53ae50fb92"), Nombre = "EPATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d6d7212c-5197-42ac-8013-4d6e567ee33a"), Nombre = "ESPERANZA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("27e71d48-0841-4390-b50a-6a9dc06e2dfb"), Nombre = "FRANCISCO Z. MENA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cc76e568-d6e7-4f94-b6be-5088091bdc1d"), Nombre = "GENERAL FELIPE ANGELES" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("49bd61b1-fd49-4a6c-ba9d-0b06f973e523"), Nombre = "GUADALUPE" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f89e331e-5bd0-495b-a9be-aec53903d49d"), Nombre = "GUADALUPE VICTORIA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9f4c77aa-42ce-49db-9690-683c9ed55d8c"), Nombre = "HERMENEGILDO GALEANA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("28370ae3-6d8d-4be8-9fce-cd90da40cb27"), Nombre = "HUAQUECHULA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f4d99b30-aeb1-462e-9244-c0b1ed03ba56"), Nombre = "HUATLATLAUCA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bf447292-6874-4d7e-8790-946362b43fae"), Nombre = "HUAUCHINANGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e9831b76-fd9a-479f-a092-99959ce42003"), Nombre = "HUEHUETLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("abae6922-c82a-4641-9400-f6c4e5f6e074"), Nombre = "HUEHUETLAN EL CHICO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2c1cc628-785c-462f-87ed-2cfd93a9c2a9"), Nombre = "HUEJOTZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("133d5400-25b2-45a2-8b71-953491024885"), Nombre = "HUEYAPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5779a362-2a8a-4b59-b467-37cc1353c55f"), Nombre = "HUEYTAMALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4f865cf9-bd58-4971-aa79-eec2bc2e74bd"), Nombre = "HUEYTLALPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("df2a228b-3b08-4810-832b-243eb92b4d1f"), Nombre = "HUITZILAN DE SERDAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4cbca531-c59f-4d18-ba0c-1331bfdb5429"), Nombre = "HUITZILTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("804e7bab-0d0a-4b1b-8d0e-e1ccad05a046"), Nombre = "ATLEQUIZAYAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e8840ad7-605a-4d0e-815c-522d498f13fc"), Nombre = "IXCAMILPA DE GUERRERO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4aaebe1d-b624-47c8-8d53-fb6a6f17c088"), Nombre = "IXCAQUIXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("488a103a-b38d-490c-851f-5b8129d25f09"), Nombre = "IXTACAMAXTITLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("142e04d7-97fc-45af-800d-8c840033b829"), Nombre = "IXTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2a2dc495-ddc1-49f8-bcf2-2b6c9cef84cd"), Nombre = "IZUCAR DE MATAMOROS" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("189c3643-13d7-4413-bbd9-33331eec7fa4"), Nombre = "JALPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7a01377b-6582-48a5-bd47-a6dc237fc73c"), Nombre = "JOLALPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1157ff74-5207-4722-8b95-2c63629a64ed"), Nombre = "JONOTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("72298c90-8cb5-4de7-9e8d-c04336d5092e"), Nombre = "JOPALA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a5d6fc46-9f9b-4c76-a081-974bac548ee9"), Nombre = "JUAN C. BONILLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bce4fd8b-87da-4614-a142-ce280c11d5f2"), Nombre = "JUAN GALINDO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2457aa01-4c63-4f89-ad2d-adf66a05092c"), Nombre = "JUAN N. MENDEZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("30d10d87-b039-4aaf-a4ef-9d57c1a1fbd8"), Nombre = "LAFRAGUA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ee1123ce-64ac-43b5-be81-c57b70444bdd"), Nombre = "LIBRES" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8ff69105-de9b-494c-98c6-a2f3e0f1c3ce"), Nombre = "LA MAGDALENA TLATLAUQUITEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7a139790-eb48-47dc-ae3a-20297745885a"), Nombre = "MAZAPILTEPEC DE JUAREZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("afa3f65b-c426-45cd-b05f-386590a07700"), Nombre = "MIXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7fb38e1e-37e9-4226-ad2c-bda84124f541"), Nombre = "MOLCAXAC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ec30f6a2-2185-45e2-9568-a108c12136ff"), Nombre = "CAÑADA MORELOS" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("76555ea1-66ec-41a8-83dc-1b6952cd116d"), Nombre = "NAUPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("eb078984-7842-4850-a9a0-27ca9b857dce"), Nombre = "NAUZONTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("39e6ae1a-b799-4a14-834a-56cdcb29ce52"), Nombre = "NEALTICAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0ac3f2af-443e-4ec2-bb07-da2f4f8819a5"), Nombre = "NICOLAS BRAVO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4dd53f09-a313-417e-980c-c1a3894ef012"), Nombre = "NOPALUCAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("44e3688b-4fa0-47e5-8526-29c6b98ea6bf"), Nombre = "OCOTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f93a9af8-9ada-454e-aa67-805dd376623b"), Nombre = "OCOYUCAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("fa05b28b-0949-4e1e-bcbd-2e24103a3664"), Nombre = "OLINTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d6b02a53-8089-4f8d-9b2e-9eca63363325"), Nombre = "ORIENTAL" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8340602f-711a-467c-8e59-a2abb587b604"), Nombre = "PAHUATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7932138c-18d2-4a83-bdca-2892210684c3"), Nombre = "PALMAR DE BRAVO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6faf0c5c-bfcb-47eb-a430-bfad3a3a169e"), Nombre = "PANTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("731d7347-37b0-4667-a08d-121add8a4295"), Nombre = "PETLALCINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("dbd57015-16f6-4ce3-aa44-94695ee49db1"), Nombre = "PIAXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("69279724-374a-4fff-8dfa-3221c202fa4b"), Nombre = "PUEBLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e53e118b-b5d5-40b1-90bf-3e6d01039812"), Nombre = "QUECHOLAC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2f765df8-e46c-4e03-b23b-f24984a8b111"), Nombre = "QUIMIXTLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("367c3734-6864-4801-8dca-161d1f371713"), Nombre = "RAFAEL LARA GRAJALES" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b28e047d-b3a1-4e24-a414-e6716e37b363"), Nombre = "LOS REYES DE JUAREZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("36b6f2cd-e602-4cc0-acd2-a45fdfd29e10"), Nombre = "SAN ANDRES CHOLULA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c0f1abb2-3ff1-407a-a1ca-2cde191237d5"), Nombre = "SAN ANTONIO CAÑADA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("2a19bb6d-1e13-4784-88c8-62d16d760e51"), Nombre = "SAN DIEGO LA MESA TOCHIMILTZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("623098dd-3ac0-4229-bcd8-7802318c3fdb"), Nombre = "SAN FELIPE TEOTLALCINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("838881f6-eb1c-4004-bd14-411e063d657c"), Nombre = "SAN FELIPE TEPATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0dafd331-e51e-4d3b-a5f3-d69c532e30b5"), Nombre = "SAN GABRIEL CHILAC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("44da0137-6c7d-4cee-9b78-22a170c2687c"), Nombre = "SAN GREGORIO ATZOMPA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7982bf83-0074-46fb-9d9b-f7e1ac0ade62"), Nombre = "SAN JERONIMO TECUANIPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("02a51ab7-1217-46a5-9ebe-cd6e34400143"), Nombre = "SAN JERONIMO XAYACATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c1ae921b-4deb-4fbf-a0de-4daed33d59c0"), Nombre = "SAN JOSE CHIAPA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("aa022af9-1364-46dd-9804-15bbf72cfecd"), Nombre = "SAN JOSE MIAHUATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4ee68423-71cd-44b4-951e-539ca72b4fcb"), Nombre = "SAN JUAN ATENCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("bbe460a3-8847-4923-b4a9-9acc1a3f9773"), Nombre = "SAN JUAN ATZOMPA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0eb3e1ba-e67a-4cc3-a88c-671297cbc96a"), Nombre = "SAN MARTIN TEXMELUCAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7b3656fc-abc8-4cce-9d19-65b8f3e6c323"), Nombre = "SAN MARTIN TOTOLTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d14e7485-8fa9-47d4-b684-e96fca467e21"), Nombre = "SAN MATIAS TLALANCALECA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("db092b2f-d154-40d9-a49c-f6705910e888"), Nombre = "SAN MIGUEL IXITLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cf50c366-a8d7-4430-b3d6-20d16f661162"), Nombre = "SAN MIGUEL XOXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("dd7e3968-c504-4f96-9a9d-5935a001393a"), Nombre = "SAN NICOLAS BUENOS AIRES" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a79ca31c-259f-46cf-8fd1-ac31b7f1e3a2"), Nombre = "SAN NICOLAS DE LOS RANCHOS" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7451e764-5d9e-4427-9b4d-1ba0c9a09efd"), Nombre = "SAN PABLO ANICANO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("80948f99-4c11-4d37-a73a-803970ea9a72"), Nombre = "SAN PEDRO CHOLULA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e07b1808-4af8-4834-bca1-a09157c5d10e"), Nombre = "SAN PEDRO YELOIXTLAHUACA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("96282c38-e892-4399-b814-568127e5dff1"), Nombre = "SAN SALVADOR EL SECO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("16361230-1bdd-4133-87e1-4db480602b15"), Nombre = "SAN SALVADOR EL VERDE" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e8ee2dc6-8304-4d75-840d-4c26e8b93afe"), Nombre = "SAN SALVADOR HUIXCOLOTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0b9af652-e4cb-4b88-a2da-3df709488ce2"), Nombre = "SAN SEBASTIAN TLACOTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("071dc637-57e0-4f94-89f4-d2200840d84d"), Nombre = "SANTA CATARINA TLALTEMPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e05d08a9-c3bf-4907-b64f-6966d1b8bab6"), Nombre = "SANTA INES AHUATEMPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e78781af-ff29-45dc-b39a-74db1f06c521"), Nombre = "SANTA ISABEL CHOLULA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9fc2cce1-f9f0-4010-a043-1ef31ebc5ca0"), Nombre = "SANTIAGO MIAHUATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5725ad2c-4481-40df-a0bd-0d358f205b5c"), Nombre = "HUEHUETLAN EL GRANDE" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("fd628b6d-0964-4735-a112-d5579943e1fd"), Nombre = "SANTO TOMAS HUEYOTLIPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("39e062ff-6a16-4def-bbc4-a57fb807b32c"), Nombre = "SOLTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c1f2d5cc-e16f-463f-bfdc-873579f1fc4c"), Nombre = "TECALI DE HERRERA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("0414c2b0-311a-43df-b907-238b2e7bb7ce"), Nombre = "TECAMACHALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4ef206dd-de20-47f0-9be9-ea382a4b1b28"), Nombre = "TECOMATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("38eab4c2-7ce3-4e3c-971d-78cd78e45de1"), Nombre = "TEHUACAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b99f1884-8403-4d4a-87e2-0455da7b7c67"), Nombre = "TEHUITZINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("97098c1c-bc49-4abe-b22d-3a4d8f60aa29"), Nombre = "TENAMPULCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cddce61c-3c5d-49e2-841a-2a805b1d5e6e"), Nombre = "TEOPANTLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("946c022a-8933-4d77-9313-d3e907518684"), Nombre = "TEOTLALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e05fcf8b-16f2-4b48-b5ec-7364be12d24a"), Nombre = "TEPANCO DE LOPEZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("4b4bb755-d591-49ad-bfdd-b135b4998278"), Nombre = "TEPANGO DE RODRIGUEZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("19b20f14-0d71-49a8-8e2a-ad13ca6e6290"), Nombre = "TEPATLAXCO DE HIDALGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("61b3e675-7340-48ef-8217-6c7577c28cfe"), Nombre = "TEPEACA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("67ce3450-478e-4f3d-a6e6-6f6ab35abd50"), Nombre = "TEPEMAXALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("73c192ff-d467-47e4-8957-4b3b47dfe3ba"), Nombre = "TEPEOJUMA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f34ef5cb-4191-4680-8b9a-4a82eff6c292"), Nombre = "TEPEZINTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("58e264f6-5b29-41d7-990a-95dc7175dfaf"), Nombre = "TEPEXCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("80261179-cc03-47f8-89fe-cf001811739a"), Nombre = "TEPEXI DE RODRIGUEZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("51b25a8f-af7c-47fd-be3b-5047261a0382"), Nombre = "TEPEYAHUALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("da041bf7-f859-4fec-9c80-43180d90c8fa"), Nombre = "TEPEYAHUALCO DE CUAUHTEMOC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cf8eb8cc-3270-4211-89c4-bfab4b117f6b"), Nombre = "TETELA DE OCAMPO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("730191fe-8d4b-407e-9dfd-f7404e8451ec"), Nombre = "TETELES DE AVILA CASTILLO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a2accadd-282b-4a02-90fa-7944a4c03726"), Nombre = "TEZIUTLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f5d7b5fa-177c-4935-8f6f-ddb9fb366cd7"), Nombre = "TIANGUISMANALCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e6742496-0928-494e-b970-8813dcfd7cee"), Nombre = "TILAPA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("affcde71-1800-4e11-aa9e-fc2ba7348100"), Nombre = "TLACOTEPEC DE BENITO JUAREZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5b0df721-cd09-4858-99ad-bffbf8aa1a1e"), Nombre = "TLACUILOTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f9422f25-fa05-456f-a1eb-22325d90a0b7"), Nombre = "TLACHICHUCA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cf5acff1-377d-4911-bc2a-87c5bd38b4e6"), Nombre = "TLAHUAPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("5a4b90a0-8bb7-4814-84c4-44980195173c"), Nombre = "TLALTENANGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("195db7dc-3bbc-47ef-bd82-6abcffe04cb3"), Nombre = "TLANEPANTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8492ccff-f6e6-4133-a9ff-e43575fc0047"), Nombre = "TLAOLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("1a9e2ec9-bb72-4809-9d5f-a73cc4b975c1"), Nombre = "TLAPACOYA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7b0c4509-0939-4bfc-a744-7eb67be293ba"), Nombre = "TLAPANALA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("49053c6a-b41f-4274-8309-ccc7461a108f"), Nombre = "TLATLAUQUITEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9eb235c0-e5a8-4f51-ae9c-3cefa623bb31"), Nombre = "TLAXCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("b3c7628f-a7b7-44df-b618-1265b2f0b7f7"), Nombre = "TOCHIMILCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c0d56773-01d8-41a9-8e21-24bbc0a0ea20"), Nombre = "TOCHTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("cb0e2292-2039-4f55-87c1-dd55c90fc002"), Nombre = "TOTOLTEPEC DE GUERRERO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("405a2fe3-3be5-4c29-8f28-0e71f0a5c4dc"), Nombre = "TULCINGO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("8bb21d7e-afa0-43b0-bdbf-4cee3bcf6741"), Nombre = "TUZAMAPAN DE GALEANA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("434cda54-fd1c-43f8-8f30-b6078d32bc80"), Nombre = "TZICATLACOYAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("59b7d064-17d8-48cb-a0b7-d90870a937d4"), Nombre = "VENUSTIANO CARRANZA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("33869def-c861-4536-952d-3a0768b10212"), Nombre = "VICENTE GUERRERO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("65a9ea6d-0783-4c43-a688-37428acfd2c2"), Nombre = "XAYACATLAN DE BRAVO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("f9cefc8b-da26-4ec1-9f46-3a240d1d4878"), Nombre = "XICOTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("17d251d7-b894-499c-8213-a34700eaee64"), Nombre = "XICOTLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("c9ed9b5d-e55e-4bdc-b123-3ad409340ed1"), Nombre = "XIUTETELCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("023cb73d-ab39-4d44-98ec-43d7af56a725"), Nombre = "XOCHIAPULCO" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a90778b7-f37e-4195-85cc-cb28013f2b55"), Nombre = "XOCHILTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("6ca4dbd0-5ea7-4a3d-8169-dfad1f9ba752"), Nombre = "XOCHITLAN DE VICENTE SUAREZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7baa727c-2af9-44a3-a49d-a1366c53a897"), Nombre = "XOCHITLAN TODOS SANTOS" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("e926e7a3-6ab8-493b-b52c-c233a218829b"), Nombre = "YAONAHUAC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("9c933cf8-5f3b-44fb-b107-b6627814c1bb"), Nombre = "YEHUALTEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("37cf93c9-2a40-47dd-a55e-cb8289650346"), Nombre = "ZACAPALA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("91b7a2b6-3426-4d68-bebd-4078c3a8d176"), Nombre = "ZACAPOAXTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("49af4078-ea81-4554-932a-76274f7c9e50"), Nombre = "ZACATLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d027d6b9-d21b-4829-ab30-afacf1dc7466"), Nombre = "ZAPOTITLAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("a250ea1a-d762-465c-9b45-89c711935787"), Nombre = "ZAPOTITLAN DE MENDEZ" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("ce54dedd-6965-4dec-ae8d-29c26423ca18"), Nombre = "ZARAGOZA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("7d5891a4-d9ba-4bd2-93e2-2a001ddce36e"), Nombre = "ZAUTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("74c34e7e-48d3-49f0-b120-7b8b2db29982"), Nombre = "ZIHUATEUTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("3a63a8df-b830-4745-ab4e-c4bff852b1b4"), Nombre = "ZINACATEPEC" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("aa844fdd-81bd-4ae4-bba9-0a27df08afc0"), Nombre = "ZONGOZOTLA" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d15ff9e1-3f2a-470d-beaf-8e656c62e542"), Nombre = "ZOQUIAPAN" });
            modelBuilder.Entity<Municipio>().HasData(new Municipio { MunicipioID = new Guid("d8c697be-c4c2-45ed-9e52-a54fcc5db144"), Nombre = "ZOQUITLAN" });

            
        }

        //partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
