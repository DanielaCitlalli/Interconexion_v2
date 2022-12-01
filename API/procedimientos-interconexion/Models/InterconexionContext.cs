using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace procedimientos_interconexion.Models
{
    public partial class InterconexionContext : DbContext
    {
        public InterconexionContext()
        {
        }

        public InterconexionContext(DbContextOptions<InterconexionContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Bitacora> Bitacora { get; set; }
        public virtual DbSet<BitacoraImp> BitacoraImp { get; set; }
        public virtual DbSet<BitacoraImpresion> BitacoraImpresion { get; set; }
        public virtual DbSet<BitacoraRnp> BitacoraRnp { get; set; }
        public virtual DbSet<Categorias> Categorias { get; set; }
        public virtual DbSet<CirrImagenes> CirrImagenes { get; set; }
        public virtual DbSet<CirrRespuestas> CirrRespuestas { get; set; }
        public virtual DbSet<CirrSemaforo> CirrSemaforo { get; set; }
        public virtual DbSet<CirrTa01Napeticion> CirrTa01Napeticion { get; set; }
        public virtual DbSet<CirrTa02Configuracion> CirrTa02Configuracion { get; set; }
        public virtual DbSet<CirrTa03Depeticion> CirrTa03Depeticion { get; set; }
        public virtual DbSet<CirrTa04Apuntadores> CirrTa04Apuntadores { get; set; }
        public virtual DbSet<CirrTa05Aspeticion> CirrTa05Aspeticion { get; set; }
        public virtual DbSet<CirrTa06Repeticion> CirrTa06Repeticion { get; set; }
        public virtual DbSet<CirrTa07OrPeImpfor> CirrTa07OrPeImpfor { get; set; }
        public virtual DbSet<CirrTa07OrPeImpforTemp> CirrTa07OrPeImpforTemp { get; set; }
        public virtual DbSet<CirrTa08DePeImpfor> CirrTa08DePeImpfor { get; set; }
        public virtual DbSet<CirrTa09Mapeticion> CirrTa09Mapeticion { get; set; }
        public virtual DbSet<CirrTa10OrReImpfor> CirrTa10OrReImpfor { get; set; }
        public virtual DbSet<CirrTa11Hnapeticion> CirrTa11Hnapeticion { get; set; }
        public virtual DbSet<CirrTa13Hdepeticion> CirrTa13Hdepeticion { get; set; }
        public virtual DbSet<CirrTa15Haspeticion> CirrTa15Haspeticion { get; set; }
        public virtual DbSet<CirrTa16Hrepeticion> CirrTa16Hrepeticion { get; set; }
        public virtual DbSet<CirrTa17HorPeImpfor> CirrTa17HorPeImpfor { get; set; }
        public virtual DbSet<CirrTa18HdePeImpfor> CirrTa18HdePeImpfor { get; set; }
        public virtual DbSet<CirrTa19Hmapeticion> CirrTa19Hmapeticion { get; set; }
        public virtual DbSet<CirrTa20HorReImpfor> CirrTa20HorReImpfor { get; set; }
        public virtual DbSet<CirrTa21Narespuesta> CirrTa21Narespuesta { get; set; }
        public virtual DbSet<CirrTa22Adrespuesta> CirrTa22Adrespuesta { get; set; }
        public virtual DbSet<CirrTa23Rerespuesta> CirrTa23Rerespuesta { get; set; }
        public virtual DbSet<CirrTa24Derespuesta> CirrTa24Derespuesta { get; set; }
        public virtual DbSet<CirrTa25Dipeticion> CirrTa25Dipeticion { get; set; }
        public virtual DbSet<CirrTa26Marespuesta> CirrTa26Marespuesta { get; set; }
        public virtual DbSet<CirrTa27Direspuesta> CirrTa27Direspuesta { get; set; }
        public virtual DbSet<CirrTa29Sepeticion> CirrTa29Sepeticion { get; set; }
        public virtual DbSet<CirrTa30Serespuesta> CirrTa30Serespuesta { get; set; }
        public virtual DbSet<CirrTa31Hnarespuesta> CirrTa31Hnarespuesta { get; set; }
        public virtual DbSet<CirrTa32Hadrespuesta> CirrTa32Hadrespuesta { get; set; }
        public virtual DbSet<CirrTa33Hrerespuesta> CirrTa33Hrerespuesta { get; set; }
        public virtual DbSet<CirrTa34Hderespuesta> CirrTa34Hderespuesta { get; set; }
        public virtual DbSet<CirrTa35Hdipeticion> CirrTa35Hdipeticion { get; set; }
        public virtual DbSet<Ciudades> Ciudades { get; set; }
        public virtual DbSet<LogSeg> LogSeg { get; set; }
        public virtual DbSet<Nacimientos> Nacimientos { get; set; }
        public virtual DbSet<NrcAdopciones> NrcAdopciones { get; set; }
        public virtual DbSet<NrcDefunciones> NrcDefunciones { get; set; }
        public virtual DbSet<NrcDivorcios> NrcDivorcios { get; set; }
        public virtual DbSet<NrcMatrimonios> NrcMatrimonios { get; set; }
        public virtual DbSet<NrcNacimientos> NrcNacimientos { get; set; }
        public virtual DbSet<NrcNacimientosBak> NrcNacimientosBak { get; set; }
        public virtual DbSet<NrcPais> NrcPais { get; set; }
        public virtual DbSet<NrcReconocimientos> NrcReconocimientos { get; set; }
        public virtual DbSet<Paises> Paises { get; set; }
        public virtual DbSet<PaisesIdioma> PaisesIdioma { get; set; }
        public virtual DbSet<Perfil> Perfil { get; set; }
        public virtual DbSet<Productos> Productos { get; set; }
        public virtual DbSet<Proveedores> Proveedores { get; set; }
        public virtual DbSet<ResponseForUser> ResponseForUser { get; set; }
        public virtual DbSet<Rol> Rol { get; set; }
        public virtual DbSet<SolicitudActas> SolicitudActas { get; set; }
        public virtual DbSet<Usuariorear> Usuariorear { get; set; }
        public virtual DbSet<Usuarios> Usuarios { get; set; }
        public virtual DbSet<VistaNacimientos> VistaNacimientos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=10.254.65.232; Database=Interconexion; User=usuario; Password=123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Bitacora>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK__BITACORA__7D439ABD");

                entity.ToTable("BITACORA");

                entity.Property(e => e.IdBitacora)
                    .HasColumnName("ID_BITACORA")
                    .HasColumnType("numeric(3, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Accion)
                    .IsRequired()
                    .HasColumnName("ACCION")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHora)
                    .HasColumnName("FECHA_HORA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Rol)
                    .HasColumnName("ROL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BitacoraImp>(entity =>
            {
                entity.HasKey(e => e.IdBitacora)
                    .HasName("PK__BITACORA_IMP__01142BA1");

                entity.ToTable("BITACORA_IMP");

                entity.Property(e => e.IdBitacora)
                    .HasColumnName("ID_BITACORA")
                    .HasColumnType("numeric(3, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Acto)
                    .HasColumnName("ACTO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FechaHora)
                    .HasColumnName("FECHA_HORA")
                    .HasColumnType("datetime");

                entity.Property(e => e.NumImp)
                    .HasColumnName("NUM_IMP")
                    .HasColumnType("numeric(10, 0)");

                entity.Property(e => e.Rol)
                    .HasColumnName("ROL")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TipoImp)
                    .HasColumnName("TIPO_IMP")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usuario)
                    .IsRequired()
                    .HasColumnName("USUARIO")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BitacoraImpresion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BITACORA_IMPRESION");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Cantidad)
                    .HasColumnName("CANTIDAD")
                    .HasColumnType("numeric(18, 0)");

                entity.Property(e => e.EntidadDestino)
                    .HasColumnName("ENTIDAD_DESTINO")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.EntidadOrigen)
                    .HasColumnName("ENTIDAD_ORIGEN")
                    .HasMaxLength(2)
                    .IsUnicode(false);

                entity.Property(e => e.FechaImpresion)
                    .HasColumnName("FECHA_IMPRESION")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.OidPeticion)
                    .HasColumnName("OID_PETICION")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.OidRespuesta)
                    .HasColumnName("OID_RESPUESTA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Usuario)
                    .HasColumnName("USUARIO")
                    .HasMaxLength(11)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<BitacoraRnp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("BITACORA_RNP");

                entity.Property(e => e.Acto).HasColumnName("ACTO");

                entity.Property(e => e.Ano).HasColumnName("ANO");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CveOficialia)
                    .HasColumnName("CVE_OFICIALIA")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Estatus)
                    .HasColumnName("ESTATUS")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.FechaInsert)
                    .HasColumnName("FECHA_INSERT")
                    .HasColumnType("datetime");

                entity.Property(e => e.IdBit)
                    .HasColumnName("ID_BIT")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Movimiento).HasColumnName("MOVIMIENTO");

                entity.Property(e => e.Servicio)
                    .HasColumnName("SERVICIO")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tramite)
                    .HasColumnName("TRAMITE")
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Categorias>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<CirrImagenes>(entity =>
            {
                entity.HasKey(e => e.Idconsec);

                entity.ToTable("cirr_imagenes");

                entity.HasIndex(e => new { e.Idproc, e.Cadena })
                    .HasName("idximgcad");

                entity.Property(e => e.Idconsec)
                    .HasColumnName("idconsec")
                    .HasColumnType("numeric(18, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Cadena)
                    .HasColumnName("cadena")
                    .HasMaxLength(20);

                entity.Property(e => e.Fechaproc)
                    .HasColumnName("fechaproc")
                    .HasColumnType("smalldatetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Idproc)
                    .HasColumnName("idproc")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Res)
                    .HasColumnName("res")
                    .HasMaxLength(100);

                entity.Property(e => e.Ubicacion)
                    .HasColumnName("ubicacion")
                    .HasMaxLength(500);
            });

            modelBuilder.Entity<CirrRespuestas>(entity =>
            {
                entity.ToTable("CIRR_RESPUESTAS");

                entity.HasIndex(e => new { e.Oid, e.Acto, e.Prioridad })
                    .HasName("<IndexActoPrioridad, sysname,>");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.Acto).HasColumnName("acto");

                entity.Property(e => e.Fecha)
                    .HasColumnName("fecha")
                    .HasColumnType("smalldatetime");

                entity.Property(e => e.Oid).HasColumnName("oid");

                entity.Property(e => e.Prioridad).HasColumnName("prioridad");
            });

            modelBuilder.Entity<CirrSemaforo>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_SEMAFORO");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Valor)
                    .HasColumnName("VALOR")
                    .HasColumnType("numeric(24, 0)");
            });

            modelBuilder.Entity<CirrTa01Napeticion>(entity =>
            {
                entity.HasKey(e => e.Ta01EOid);

                entity.ToTable("CIRR_TA01_NAPETICION");

                entity.HasIndex(e => e.Ta01EEstatus)
                    .HasName("IDX_ESTATUS");

                entity.HasIndex(e => e.Ta01ESecuencia)
                    .HasName("IDX_SECUENCIA");

                entity.HasIndex(e => e.Ta01FAtencion)
                    .HasName("IDX_ATENCION");

                entity.HasIndex(e => e.Ta01FEntrada)
                    .HasName("IDX_ENTRADA");

                entity.Property(e => e.Ta01EOid)
                    .HasColumnName("TA01_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta01CCadena)
                    .IsRequired()
                    .HasColumnName("TA01_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta01ECuantos)
                    .HasColumnName("TA01_E_CUANTOS")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ta01EEstatus)
                    .HasColumnName("TA01_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta01EOperacionacto)
                    .HasColumnName("TA01_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta01EPrioridad)
                    .HasColumnName("TA01_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta01ESecuencia)
                    .HasColumnName("TA01_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta01FAtencion)
                    .HasColumnName("TA01_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta01FEntrada)
                    .HasColumnName("TA01_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<CirrTa02Configuracion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA02_CONFIGURACION");

                entity.Property(e => e.Ta02EActivo)
                    .HasColumnName("TA02_E_ACTIVO")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Ta02EContador)
                    .HasColumnName("TA02_E_CONTADOR")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta02EEstado).HasColumnName("TA02_E_ESTADO");

                entity.Property(e => e.Ta02EFactor)
                    .HasColumnName("TA02_E_FACTOR")
                    .HasColumnType("numeric(24, 0)");
            });

            modelBuilder.Entity<CirrTa03Depeticion>(entity =>
            {
                entity.HasKey(e => e.Ta03EOid);

                entity.ToTable("CIRR_TA03_DEPETICION");

                entity.HasIndex(e => e.Ta03ESecuencia)
                    .HasName("IX_CIRR_TA03_SECUENCIA");

                entity.HasIndex(e => e.Ta03FAtencion)
                    .HasName("IX_CIRR_TA03_FATENCION");

                entity.HasIndex(e => new { e.Ta03EOid, e.Ta03EEstatus })
                    .HasName("<IndexCirr03, sysname,>");

                entity.Property(e => e.Ta03EOid)
                    .HasColumnName("TA03_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta03CCadena)
                    .IsRequired()
                    .HasColumnName("TA03_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta03ECuantos)
                    .HasColumnName("TA03_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta03EEstatus)
                    .HasColumnName("TA03_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta03EOperacionacto)
                    .HasColumnName("TA03_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta03EPrioridad)
                    .HasColumnName("TA03_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta03ESecuencia)
                    .HasColumnName("TA03_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta03FAtencion)
                    .HasColumnName("TA03_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta03FEntrada)
                    .HasColumnName("TA03_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<CirrTa04Apuntadores>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA04_APUNTADORES");

                entity.Property(e => e.Ta04CActo)
                    .IsRequired()
                    .HasColumnName("TA04_C_ACTO")
                    .HasMaxLength(20)
                    .IsFixedLength();

                entity.Property(e => e.Ta04EPrioridad)
                    .HasColumnName("TA04_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta04EUltimo)
                    .HasColumnName("TA04_E_ULTIMO")
                    .HasColumnType("numeric(24, 0)");
            });

            modelBuilder.Entity<CirrTa05Aspeticion>(entity =>
            {
                entity.HasKey(e => e.Ta05EOid)
                    .HasName("PK_CIRR_TA05_ASPETICIONS");

                entity.ToTable("CIRR_TA05_ASPETICION");

                entity.Property(e => e.Ta05EOid)
                    .HasColumnName("TA05_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta05CCadena)
                    .IsRequired()
                    .HasColumnName("TA05_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta05ECuantos)
                    .HasColumnName("TA05_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta05EEstatus)
                    .HasColumnName("TA05_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta05EOperacionacto)
                    .HasColumnName("TA05_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta05EPrioridad).HasColumnName("TA05_E_PRIORIDAD");

                entity.Property(e => e.Ta05ESecuencia).HasColumnName("TA05_E_SECUENCIA");

                entity.Property(e => e.Ta05FAtencion)
                    .HasColumnName("TA05_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta05FEntrada)
                    .HasColumnName("TA05_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<CirrTa06Repeticion>(entity =>
            {
                entity.HasKey(e => e.Ta06EOid);

                entity.ToTable("CIRR_TA06_REPETICION");

                entity.Property(e => e.Ta06EOid)
                    .HasColumnName("TA06_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta06CCadena)
                    .IsRequired()
                    .HasColumnName("TA06_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta06ECuantos)
                    .HasColumnName("TA06_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta06EEstatus)
                    .HasColumnName("TA06_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta06EOperacionacto)
                    .HasColumnName("TA06_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta06EPrioridad).HasColumnName("TA06_E_PRIORIDAD");

                entity.Property(e => e.Ta06ESecuencia).HasColumnName("TA06_E_SECUENCIA");

                entity.Property(e => e.Ta06FAtencion)
                    .HasColumnName("TA06_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta06FEntrada)
                    .HasColumnName("TA06_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<CirrTa07OrPeImpfor>(entity =>
            {
                entity.HasKey(e => e.Ta07EOid);

                entity.ToTable("CIRR_TA07_OR_PE_IMPFOR");

                entity.Property(e => e.Ta07EOid)
                    .HasColumnName("TA07_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta07CCadena)
                    .HasColumnName("TA07_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CMaterno)
                    .HasColumnName("TA07_C_MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CNombres)
                    .HasColumnName("TA07_C_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CPaterno)
                    .HasColumnName("TA07_C_PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CSexo)
                    .HasColumnName("TA07_C_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07EBusqueda).HasColumnName("TA07_E_BUSQUEDA");

                entity.Property(e => e.Ta07ECuantos).HasColumnName("TA07_E_CUANTOS");

                entity.Property(e => e.Ta07ECurp)
                    .HasColumnName("TA07_E_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EEstadoorig)
                    .HasColumnName("TA07_E_ESTADOORIG")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EEstatus)
                    .HasColumnName("TA07_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta07ETipo)
                    .HasColumnName("TA07_E_TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07FAtencion)
                    .HasColumnName("TA07_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07FEntrada)
                    .HasColumnName("TA07_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07FNacimiento)
                    .HasColumnName("TA07_F_NACIMIENTO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa07OrPeImpforTemp>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA07_OR_PE_IMPFOR_TEMP");

                entity.Property(e => e.Ta07CCadena)
                    .HasColumnName("TA07_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CMaterno)
                    .HasColumnName("TA07_C_MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CNombres)
                    .HasColumnName("TA07_C_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CPaterno)
                    .HasColumnName("TA07_C_PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07CSexo)
                    .HasColumnName("TA07_C_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07EBusqueda)
                    .HasColumnName("TA07_E_BUSQUEDA")
                    .HasColumnType("numeric(38, 0)");

                entity.Property(e => e.Ta07ECuantos)
                    .HasColumnName("TA07_E_CUANTOS")
                    .HasColumnType("numeric(38, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta07ECurp)
                    .HasColumnName("TA07_E_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EEstadoimpresion)
                    .HasColumnName("TA07_E_ESTADOIMPRESION")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Ta07EEstadoorig)
                    .HasColumnName("TA07_E_ESTADOORIG")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EEstatus)
                    .HasColumnName("TA07_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta07EOid)
                    .HasColumnName("TA07_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07EOidestado)
                    .HasColumnName("TA07_E_OIDESTADO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta07ETipo)
                    .HasColumnName("TA07_E_TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07FAtencion)
                    .HasColumnName("TA07_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07FEntrada)
                    .HasColumnName("TA07_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07FNacimiento)
                    .HasColumnName("TA07_F_NACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta17EOidestado)
                    .HasColumnName("TA17_E_OIDESTADO")
                    .HasColumnType("numeric(24, 0)");
            });

            modelBuilder.Entity<CirrTa08DePeImpfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA08_DE_PE_IMPFOR");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta08CCadena)
                    .HasColumnName("TA08_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08CMaterno)
                    .HasColumnName("TA08_C_MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08CNombres)
                    .HasColumnName("TA08_C_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08CPaterno)
                    .HasColumnName("TA08_C_PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08CSexo)
                    .HasColumnName("TA08_C_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08EBusqueda).HasColumnName("TA08_E_BUSQUEDA");

                entity.Property(e => e.Ta08ECurp)
                    .HasColumnName("TA08_E_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08EEstadodest)
                    .HasColumnName("TA08_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta08EEstadoorig)
                    .HasColumnName("TA08_E_ESTADOORIG")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta08EEstatus)
                    .HasColumnName("TA08_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta08EOid)
                    .HasColumnName("TA08_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta08EOidestado)
                    .HasColumnName("TA08_E_OIDESTADO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta08ETipo)
                    .HasColumnName("TA08_E_TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08FEntrada)
                    .HasColumnName("TA08_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta08FNacimiento)
                    .HasColumnName("TA08_F_NACIMIENTO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa09Mapeticion>(entity =>
            {
                entity.HasKey(e => e.Ta09EOid)
                    .HasName("CIRR_TA09_MAPETICION_PK");

                entity.ToTable("CIRR_TA09_MAPETICION");

                entity.Property(e => e.Ta09EOid)
                    .HasColumnName("TA09_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta09CCadena)
                    .IsRequired()
                    .HasColumnName("TA09_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta09ECuantos)
                    .HasColumnName("TA09_E_CUANTOS")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta09EEstatus)
                    .HasColumnName("TA09_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta09EOperacionacto)
                    .HasColumnName("TA09_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta09EPrioridad)
                    .HasColumnName("TA09_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta09ESecuencia)
                    .HasColumnName("TA09_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta09FAtencion)
                    .HasColumnName("TA09_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta09FEntrada)
                    .HasColumnName("TA09_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa10OrReImpfor>(entity =>
            {
                entity.HasKey(e => e.Ta10EOid);

                entity.ToTable("CIRR_TA10_OR_RE_IMPFOR");

                entity.HasIndex(e => e.Ta10EOidorigen)
                    .HasName("IX_CIRR_TA10_OR_RE_IMPFOR");

                entity.Property(e => e.Ta10EOid)
                    .HasColumnName("TA10_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.T10ETipo)
                    .HasColumnName("T10_E_TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07EOidimpresion)
                    .HasColumnName("TA07_E_OIDIMPRESION")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta10BImagen).HasColumnName("TA10_B_IMAGEN");

                entity.Property(e => e.Ta10CCadena)
                    .IsRequired()
                    .HasColumnName("TA10_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta10ECuantos)
                    .HasColumnName("TA10_E_CUANTOS")
                    .HasColumnType("numeric(2, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta10EEstadodest)
                    .HasColumnName("TA10_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta10EEstadoorig)
                    .HasColumnName("TA10_E_ESTADOORIG")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta10EEstatus)
                    .HasColumnName("TA10_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta10EOidorigen)
                    .HasColumnName("TA10_E_OIDORIGEN")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta10FAtencion)
                    .HasColumnName("TA10_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta10FEntrada)
                    .HasColumnName("TA10_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa11Hnapeticion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA11_HNAPETICION");

                entity.Property(e => e.Ta01ECuantos)
                    .HasColumnName("TA01_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta01FAtencion)
                    .HasColumnName("TA01_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta01FSalida)
                    .HasColumnName("TA01_F_SALIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta11CCadena)
                    .HasColumnName("TA11_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta11EEstatus)
                    .HasColumnName("TA11_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta11EOid)
                    .HasColumnName("TA11_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta11EOperacionacto)
                    .HasColumnName("TA11_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta11EPrioridad)
                    .HasColumnName("TA11_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta11ESecuencia)
                    .HasColumnName("TA11_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta11FEntrada)
                    .HasColumnName("TA11_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta11FFsalida01)
                    .HasColumnName("TA11_F_FSALIDA01")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<CirrTa13Hdepeticion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA13_HDEPETICION");

                entity.Property(e => e.Ta03ECuantos)
                    .HasColumnName("TA03_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta03FAtencion)
                    .HasColumnName("TA03_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta03FSalida)
                    .HasColumnName("TA03_F_SALIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta13CCadena)
                    .HasColumnName("TA13_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta13EEstatus)
                    .HasColumnName("TA13_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta13EOid)
                    .HasColumnName("TA13_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta13EOperacionacto)
                    .HasColumnName("TA13_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta13EPrioridad).HasColumnName("TA13_E_PRIORIDAD");

                entity.Property(e => e.Ta13ESecuencia).HasColumnName("TA13_E_SECUENCIA");

                entity.Property(e => e.Ta13FEntrada)
                    .HasColumnName("TA13_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa15Haspeticion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA15_HASPETICION");

                entity.Property(e => e.Ta05ECuantos)
                    .HasColumnName("TA05_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta05FAtencion)
                    .HasColumnName("TA05_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta05FSalida)
                    .HasColumnName("TA05_F_SALIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta15CCadena)
                    .HasColumnName("TA15_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta15EEstatus)
                    .HasColumnName("TA15_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta15EOid)
                    .HasColumnName("TA15_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta15EOperacionacto)
                    .HasColumnName("TA15_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta15EPrioridad).HasColumnName("TA15_E_PRIORIDAD");

                entity.Property(e => e.Ta15ESecuencia).HasColumnName("TA15_E_SECUENCIA");

                entity.Property(e => e.Ta15FEntrada)
                    .HasColumnName("TA15_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa16Hrepeticion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA16_HREPETICION");

                entity.Property(e => e.Ta06ECuantos)
                    .HasColumnName("TA06_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta06FAtencion)
                    .HasColumnName("TA06_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta06FSalida)
                    .HasColumnName("TA06_F_SALIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta16CCadena)
                    .HasColumnName("TA16_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta16EEstatus)
                    .HasColumnName("TA16_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta16EOid)
                    .HasColumnName("TA16_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta16EOperacionacto)
                    .HasColumnName("TA16_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta16EPrioridad).HasColumnName("TA16_E_PRIORIDAD");

                entity.Property(e => e.Ta16ESecuencia).HasColumnName("TA16_E_SECUENCIA");

                entity.Property(e => e.Ta16FEntrada)
                    .HasColumnName("TA16_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa17HorPeImpfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA17_HOR_PE_IMPFOR");

                entity.Property(e => e.Ta07CCadena)
                    .HasColumnName("TA07_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta07EBusqueda).HasColumnName("TA07_E_BUSQUEDA");

                entity.Property(e => e.Ta07ECuantos)
                    .HasColumnName("TA07_E_CUANTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta07FAtencion)
                    .HasColumnName("TA07_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta07FSalida)
                    .HasColumnName("TA07_F_SALIDA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta17CMaterno)
                    .HasColumnName("TA17_C_MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta17CNombres)
                    .HasColumnName("TA17_C_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta17CPaterno)
                    .HasColumnName("TA17_C_PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta17CSexo)
                    .HasColumnName("TA17_C_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ta17ECurp)
                    .HasColumnName("TA17_E_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta17EEstadodest)
                    .HasColumnName("TA17_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta17EEstadoorig)
                    .HasColumnName("TA17_E_ESTADOORIG")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta17EEstatus)
                    .HasColumnName("TA17_E_ESTATUS")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta17EOid)
                    .HasColumnName("TA17_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta17ESolicitarimagen)
                    .HasColumnName("TA17_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta17ETipo)
                    .HasColumnName("TA17_E_TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta17FEntrada)
                    .HasColumnName("TA17_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta17FNacimiento)
                    .HasColumnName("TA17_F_NACIMIENTO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa18HdePeImpfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA18_HDE_PE_IMPFOR");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta08CCadena)
                    .HasColumnName("TA08_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta08EBusqueda).HasColumnName("TA08_E_BUSQUEDA");

                entity.Property(e => e.Ta18CMaterno)
                    .HasColumnName("TA18_C_MATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta18CNombres)
                    .HasColumnName("TA18_C_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta18CPaterno)
                    .HasColumnName("TA18_C_PATERNO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Ta18CSexo)
                    .HasColumnName("TA18_C_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Ta18ECurp)
                    .IsRequired()
                    .HasColumnName("TA18_E_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta18EEstadodest)
                    .HasColumnName("TA18_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta18EEstadoorig)
                    .HasColumnName("TA18_E_ESTADOORIG")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta18EEstatus)
                    .HasColumnName("TA18_E_ESTATUS")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta18EOid)
                    .HasColumnName("TA18_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta18EOidestado)
                    .HasColumnName("TA18_E_OIDESTADO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta18ETipo)
                    .HasColumnName("TA18_E_TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta18FEntrada)
                    .HasColumnName("TA18_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta18FNacimiento)
                    .HasColumnName("TA18_F_NACIMIENTO")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa19Hmapeticion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA19_HMAPETICION");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta19CCadena)
                    .IsRequired()
                    .HasColumnName("TA19_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta19ECuantos)
                    .HasColumnName("TA19_E_CUANTOS")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta19EEstatus)
                    .HasColumnName("TA19_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta19EOid)
                    .HasColumnName("TA19_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta19EOperacionacto)
                    .HasColumnName("TA19_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta19EPrioridad)
                    .HasColumnName("TA19_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta19ESecuencia)
                    .HasColumnName("TA19_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta19FAtencion)
                    .HasColumnName("TA19_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta19FEntrada)
                    .HasColumnName("TA19_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta19FSalida)
                    .HasColumnName("TA19_F_SALIDA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa20HorReImpfor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA20_HOR_RE_IMPFOR");

                entity.Property(e => e.Ta20BImagen).HasColumnName("TA20_B_IMAGEN");

                entity.Property(e => e.Ta20CCadena)
                    .HasColumnName("TA20_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta20EEstadodest)
                    .HasColumnName("TA20_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta20EEstadoorig)
                    .HasColumnName("TA20_E_ESTADOORIG")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta20EEstatus)
                    .HasColumnName("TA20_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta20EOid)
                    .HasColumnName("TA20_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta20EOidorigen)
                    .HasColumnName("TA20_E_OIDORIGEN")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta20FEntrada)
                    .HasColumnName("TA20_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa21Narespuesta>(entity =>
            {
                entity.HasKey(e => e.Ta21EOid);

                entity.ToTable("CIRR_TA21_NARESPUESTA");

                entity.Property(e => e.Ta21EOid)
                    .HasColumnName("TA21_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta01EOid)
                    .HasColumnName("TA01_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta21BSello)
                    .HasColumnName("TA21_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta21CCadena)
                    .IsRequired()
                    .HasColumnName("TA21_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta21CCurp)
                    .HasColumnName("TA21_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta21CDescError)
                    .HasColumnName("TA21_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta21EError)
                    .HasColumnName("TA21_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta21EEstatus)
                    .HasColumnName("TA21_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta21EOperacionacto)
                    .HasColumnName("TA21_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta21FEntrada)
                    .HasColumnName("TA21_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa22Adrespuesta>(entity =>
            {
                entity.HasKey(e => e.Ta22EOid);

                entity.ToTable("CIRR_TA22_ADRESPUESTA");

                entity.Property(e => e.Ta22EOid)
                    .HasColumnName("TA22_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta05EOid)
                    .HasColumnName("TA05_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta22BSello)
                    .HasColumnName("TA22_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta22CCadena)
                    .IsRequired()
                    .HasColumnName("TA22_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta22CCurp)
                    .HasColumnName("TA22_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta22CDescError)
                    .HasColumnName("TA22_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta22EError)
                    .HasColumnName("TA22_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta22EEstatus)
                    .HasColumnName("TA22_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta22EOperacionacto)
                    .HasColumnName("TA22_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta22FEntrada)
                    .HasColumnName("TA22_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa23Rerespuesta>(entity =>
            {
                entity.HasKey(e => e.Ta23EOid);

                entity.ToTable("CIRR_TA23_RERESPUESTA");

                entity.Property(e => e.Ta23EOid)
                    .HasColumnName("TA23_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta06EOid)
                    .HasColumnName("TA06_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta23BSello)
                    .HasColumnName("TA23_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta23CCadena)
                    .IsRequired()
                    .HasColumnName("TA23_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta23CCurp)
                    .HasColumnName("TA23_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta23CDescError)
                    .HasColumnName("TA23_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta23EError)
                    .HasColumnName("TA23_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta23EEstatus)
                    .HasColumnName("TA23_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta23EOperacionacto)
                    .HasColumnName("TA23_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta23FEntrada)
                    .HasColumnName("TA23_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa24Derespuesta>(entity =>
            {
                entity.HasKey(e => e.Ta24EOid);

                entity.ToTable("CIRR_TA24_DERESPUESTA");

                entity.Property(e => e.Ta24EOid)
                    .HasColumnName("TA24_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta03EOid)
                    .HasColumnName("TA03_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta24BSello)
                    .HasColumnName("TA24_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta24CCadena)
                    .IsRequired()
                    .HasColumnName("TA24_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta24CCurp)
                    .HasColumnName("TA24_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta24CDescError)
                    .HasColumnName("TA24_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta24EError)
                    .HasColumnName("TA24_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta24EEstatus)
                    .HasColumnName("TA24_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta24EOperacionacto)
                    .HasColumnName("TA24_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta24FEntrada)
                    .HasColumnName("TA24_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa25Dipeticion>(entity =>
            {
                entity.HasKey(e => e.Ta25EOid)
                    .HasName("CIRR_TA25_DIPETICION_PK");

                entity.ToTable("CIRR_TA25_DIPETICION");

                entity.Property(e => e.Ta25EOid)
                    .HasColumnName("TA25_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta25CCadena)
                    .IsRequired()
                    .HasColumnName("TA25_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta25ECuantos)
                    .HasColumnName("TA25_E_CUANTOS")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta25EEstatus)
                    .HasColumnName("TA25_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta25EOperacionacto)
                    .HasColumnName("TA25_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta25EPrioridad)
                    .HasColumnName("TA25_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta25ESecuencia)
                    .HasColumnName("TA25_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta25FAtencion)
                    .HasColumnName("TA25_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta25FEntrada)
                    .HasColumnName("TA25_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa26Marespuesta>(entity =>
            {
                entity.HasKey(e => e.Ta26EOid)
                    .HasName("CIRR_TA26_MARESPUESTA_PK");

                entity.ToTable("CIRR_TA26_MARESPUESTA");

                entity.Property(e => e.Ta26EOid)
                    .HasColumnName("TA26_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta09EOid)
                    .HasColumnName("TA09_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta26BSello)
                    .HasColumnName("TA26_B_SELLO")
                    .IsUnicode(false);

                entity.Property(e => e.Ta26CCadena)
                    .IsRequired()
                    .HasColumnName("TA26_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta26CCurp)
                    .HasColumnName("TA26_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta26CDescError)
                    .HasColumnName("TA26_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta26EError)
                    .HasColumnName("TA26_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta26EEstatus)
                    .HasColumnName("TA26_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta26EOperacionacto)
                    .HasColumnName("TA26_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta26FEntrada)
                    .HasColumnName("TA26_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa27Direspuesta>(entity =>
            {
                entity.HasKey(e => e.Ta27EOid)
                    .HasName("CIRR_TA27_DIRESPUESTA_PK");

                entity.ToTable("CIRR_TA27_DIRESPUESTA");

                entity.Property(e => e.Ta27EOid)
                    .HasColumnName("TA27_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta25EOid)
                    .HasColumnName("TA25_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta27BSello)
                    .HasColumnName("TA27_B_SELLO")
                    .IsUnicode(false);

                entity.Property(e => e.Ta27CCadena)
                    .IsRequired()
                    .HasColumnName("TA27_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta27CCurp)
                    .HasColumnName("TA27_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta27CDescError)
                    .HasColumnName("TA27_C_DESC_ERROR")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Ta27EError)
                    .HasColumnName("TA27_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta27EEstatus)
                    .HasColumnName("TA27_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta27EOperacionacto)
                    .HasColumnName("TA27_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta27FEntrada)
                    .HasColumnName("TA27_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa29Sepeticion>(entity =>
            {
                entity.HasKey(e => e.Ta29EOid);

                entity.ToTable("CIRR_TA29_SEPETICION");

                entity.Property(e => e.Ta29EOid)
                    .HasColumnName("TA29_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta29CCadena)
                    .IsRequired()
                    .HasColumnName("TA29_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta29ECuantos)
                    .HasColumnName("TA29_E_CUANTOS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta29EEstatus)
                    .HasColumnName("TA29_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta29EOperacionacto)
                    .HasColumnName("TA29_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta29EPrioridad)
                    .HasColumnName("TA29_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta29ESecuencia)
                    .HasColumnName("TA29_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta29FAtencion)
                    .HasColumnName("TA29_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta29FEntrada)
                    .HasColumnName("TA29_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa30Serespuesta>(entity =>
            {
                entity.HasKey(e => e.Ta30EOid);

                entity.ToTable("CIRR_TA30_SERESPUESTA");

                entity.Property(e => e.Ta30EOid)
                    .HasColumnName("TA30_E_OID")
                    .HasColumnType("numeric(24, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Ta29EOid)
                    .HasColumnName("TA29_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta30BSello)
                    .HasColumnName("TA30_B_SELLO")
                    .IsUnicode(false);

                entity.Property(e => e.Ta30CCadena)
                    .IsRequired()
                    .HasColumnName("TA30_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta30CCurp)
                    .HasColumnName("TA30_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta30CDescError)
                    .HasColumnName("TA30_C_DESC_ERROR")
                    .IsUnicode(false);

                entity.Property(e => e.Ta30EError)
                    .HasColumnName("TA30_E_ERROR")
                    .IsUnicode(false);

                entity.Property(e => e.Ta30EEstatus)
                    .HasColumnName("TA30_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta30EOperacionacto)
                    .HasColumnName("TA30_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta30FEntrada)
                    .HasColumnName("TA30_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa31Hnarespuesta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA31_HNARESPUESTA");

                entity.Property(e => e.Ta01CDescError)
                    .HasColumnName("TA01_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta01EError)
                    .HasColumnName("TA01_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta01EOid)
                    .HasColumnName("TA01_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta31BSello)
                    .HasColumnName("TA31_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta31CCadena)
                    .HasColumnName("TA31_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta31CCurp)
                    .HasColumnName("TA31_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta31EEstatus)
                    .HasColumnName("TA31_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta31EOid)
                    .HasColumnName("TA31_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta31EOperacionacto)
                    .HasColumnName("TA31_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta31FEntrada)
                    .HasColumnName("TA31_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa32Hadrespuesta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA32_HADRESPUESTA");

                entity.Property(e => e.Ta05EOid)
                    .HasColumnName("TA05_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta32BSello)
                    .HasColumnName("TA32_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta32CCadena)
                    .HasColumnName("TA32_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta32CCurp)
                    .HasColumnName("TA32_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta32CDescError)
                    .HasColumnName("TA32_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta32EError)
                    .HasColumnName("TA32_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta32EEstatus)
                    .HasColumnName("TA32_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta32EOid)
                    .HasColumnName("TA32_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta32EOperacionacto)
                    .HasColumnName("TA32_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta32FEntrada)
                    .HasColumnName("TA32_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa33Hrerespuesta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA33_HRERESPUESTA");

                entity.Property(e => e.Ta05EOid)
                    .HasColumnName("TA05_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta33BSello)
                    .HasColumnName("TA33_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta33CCadena)
                    .HasColumnName("TA33_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta33CCurp)
                    .HasColumnName("TA33_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta33CDescError)
                    .HasColumnName("TA33_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta33EError)
                    .HasColumnName("TA33_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta33EEstatus)
                    .HasColumnName("TA33_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta33EOid)
                    .HasColumnName("TA33_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta33EOperacionacto)
                    .HasColumnName("TA33_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta33FEntrada)
                    .HasColumnName("TA33_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa34Hderespuesta>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA34_HDERESPUESTA");

                entity.Property(e => e.Ta03EOid)
                    .HasColumnName("TA03_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta34BSello)
                    .HasColumnName("TA34_B_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta34CCadena)
                    .HasColumnName("TA34_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta34CCurp)
                    .HasColumnName("TA34_C_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.Ta34CDescError)
                    .HasColumnName("TA34_C_DESC_ERROR")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.Ta34EError)
                    .HasColumnName("TA34_E_ERROR")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta34EEstatus)
                    .HasColumnName("TA34_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta34EOid)
                    .HasColumnName("TA34_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta34EOperacionacto)
                    .HasColumnName("TA34_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta34FEntrada)
                    .HasColumnName("TA34_F_ENTRADA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<CirrTa35Hdipeticion>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("CIRR_TA35_HDIPETICION");

                entity.Property(e => e.Ta07EEstadodest)
                    .HasColumnName("TA07_E_ESTADODEST")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.Ta07EOiddestino)
                    .HasColumnName("TA07_E_OIDDESTINO")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta07ESolicitarimagen)
                    .HasColumnName("TA07_E_SOLICITARIMAGEN")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta35CCadena)
                    .IsRequired()
                    .HasColumnName("TA35_C_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ta35ECuantos)
                    .HasColumnName("TA35_E_CUANTOS")
                    .HasColumnType("numeric(38, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Ta35EEstatus)
                    .HasColumnName("TA35_E_ESTATUS")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta35EOid)
                    .HasColumnName("TA35_E_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta35EOperacionacto)
                    .HasColumnName("TA35_E_OPERACIONACTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta35EPrioridad)
                    .HasColumnName("TA35_E_PRIORIDAD")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Ta35ESecuencia)
                    .HasColumnName("TA35_E_SECUENCIA")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.Ta35FAtencion)
                    .HasColumnName("TA35_F_ATENCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta35FEntrada)
                    .HasColumnName("TA35_F_ENTRADA")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ta35FSalida)
                    .HasColumnName("TA35_F_SALIDA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Ciudades>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.CodigoPais).HasMaxLength(20);

                entity.Property(e => e.Distrito).HasMaxLength(100);

                entity.Property(e => e.Nombre).HasMaxLength(50);
            });

            modelBuilder.Entity<LogSeg>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_seg");

                entity.Property(e => e.Curp)
                    .HasColumnName("curp")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Exitosa)
                    .HasColumnName("exitosa")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Fechanac)
                    .HasColumnName("fechanac")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Nombres)
                    .HasColumnName("nombres")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Primerapellido)
                    .HasColumnName("primerapellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Segundoapellido)
                    .HasColumnName("segundoapellido")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Nacimientos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("NACIMIENTOS");

                entity.Property(e => e.Cadena)
                    .IsRequired()
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtCrip)
                    .HasColumnName("OT_CRIP")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.PeCurp)
                    .HasColumnName("PE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PeFechanacimiento)
                    .HasColumnName("PE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeLocalidadnacimiento)
                    .HasColumnName("PE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PeNombres)
                    .HasColumnName("PE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PePrimerapellido)
                    .HasColumnName("PE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSegundoapellido)
                    .HasColumnName("PE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSexo)
                    .HasColumnName("PE_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NrcAdopciones>(entity =>
            {
                entity.HasKey(e => e.Cadena)
                    .HasName("PK_NRC_ADOPCIONESSS");

                entity.ToTable("NRC_ADOPCIONES");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechaactualizacionInc)
                    .HasColumnName("CN_FECHAACTUALIZACION_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistroInc)
                    .HasColumnName("CO_FECHA_REGISTRO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaActabis)
                    .HasColumnName("MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaAnioregistro)
                    .HasColumnName("MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaCurp)
                    .HasColumnName("MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MaEdad)
                    .HasColumnName("MA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadnacimiento)
                    .HasColumnName("MA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadregistro)
                    .HasColumnName("MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaFechanacimiento)
                    .HasColumnName("MA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaFechanacimientoInc)
                    .HasColumnName("MA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaLocalidadnacimiento)
                    .HasColumnName("MA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.MaMunicipionacimiento)
                    .HasColumnName("MA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaMunicipioregistro)
                    .HasColumnName("MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNacionalidad)
                    .HasColumnName("MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNombres)
                    .IsRequired()
                    .HasColumnName("MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNumeroacta)
                    .HasColumnName("MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MaOficialia)
                    .HasColumnName("MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaPaisnacimiento)
                    .HasColumnName("MA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaPrimerapellido)
                    .HasColumnName("MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSegundoapellido)
                    .HasColumnName("MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSexo)
                    .HasColumnName("MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaTipodocumento)
                    .HasColumnName("MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NaActabis)
                    .IsRequired()
                    .HasColumnName("NA_ACTABIS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NaAnioregistro)
                    .HasColumnName("NA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.NaEntidadregistro)
                    .HasColumnName("NA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.NaMunicipioregistro)
                    .HasColumnName("NA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NaNumeroacta)
                    .HasColumnName("NA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NaOficialia)
                    .HasColumnName("NA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.NaTipodocumento)
                    .HasColumnName("NA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCrip)
                    .HasColumnName("OT_CRIP")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharegistroennacimiento)
                    .HasColumnName("OT_FECHAREGISTROENNACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtFecharegistronacimientoInc)
                    .HasColumnName("OT_FECHAREGISTRONACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharesolutivojudicial)
                    .HasColumnName("OT_FECHARESOLUTIVOJUDICIAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtLocadoptadoennacimiento)
                    .HasColumnName("OT_LOCADOPTADOENNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.OtLocalidadadoptado)
                    .HasColumnName("OT_LOCALIDADADOPTADO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtParteresolutivajudicial)
                    .HasColumnName("OT_PARTERESOLUTIVAJUDICIAL")
                    .IsUnicode(false);

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OtUltactualizacion).HasColumnName("OT_ULTACTUALIZACION");

                entity.Property(e => e.PaActabis)
                    .HasColumnName("PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaAnioregistro)
                    .HasColumnName("PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaCurp)
                    .HasColumnName("PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PaEdad)
                    .HasColumnName("PA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadnacimiento)
                    .HasColumnName("PA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadregistro)
                    .HasColumnName("PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaFechanacimiento)
                    .HasColumnName("PA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaFechanacimientoInc)
                    .HasColumnName("PA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaLocalidadnacimiento)
                    .HasColumnName("PA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PaMunicipionacimiento)
                    .HasColumnName("PA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaMunicipioregistro)
                    .HasColumnName("PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNacionalidad)
                    .HasColumnName("PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNombres)
                    .HasColumnName("PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaNumeroacta)
                    .HasColumnName("PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PaOficialia)
                    .HasColumnName("PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaPaisnacimiento)
                    .HasColumnName("PA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaPrimerapellido)
                    .HasColumnName("PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSegundoapellido)
                    .HasColumnName("PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSexo)
                    .HasColumnName("PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaTipodocumento)
                    .HasColumnName("PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeCurp)
                    .HasColumnName("PE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PeEdad)
                    .HasColumnName("PE_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeEntidadnacimiento)
                    .HasColumnName("PE_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeFechanacimiento)
                    .HasColumnName("PE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeFechanacimientoInc)
                    .HasColumnName("PE_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PeLocalidadnacimiento)
                    .HasColumnName("PE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PeMunicipionacimiento)
                    .HasColumnName("PE_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNacionalidad)
                    .HasColumnName("PE_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNombres)
                    .HasColumnName("PE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PePaisnacimiento)
                    .HasColumnName("PE_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PePrimerapellido)
                    .HasColumnName("PE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSegundoapellido)
                    .HasColumnName("PE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSexo)
                    .IsRequired()
                    .HasColumnName("PE_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipocadena)
                    .HasColumnName("TIPOCADENA")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TmpFecha)
                    .HasColumnName("TMP_FECHA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NrcDefunciones>(entity =>
            {
                entity.HasKey(e => e.Cadena);

                entity.ToTable("NRC_DEFUNCIONES");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechaactualizacionInc)
                    .HasColumnName("CN_FECHAACTUALIZACION_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistroInc)
                    .HasColumnName("CO_FECHA_REGISTRO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CoFechaoriginal)
                    .HasColumnName("CO_FECHAORIGINAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoSoporte).HasColumnName("CO_SOPORTE");

                entity.Property(e => e.CoTipo)
                    .HasColumnName("CO_TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoTranscripcion)
                    .HasColumnName("CO_TRANSCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e.CyActabis)
                    .HasColumnName("CY_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CyAnioregistro)
                    .HasColumnName("CY_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CyCurp)
                    .HasColumnName("CY_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.CyEdad)
                    .HasColumnName("CY_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CyEntidadnacimiento)
                    .HasColumnName("CY_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CyEntidadregistro)
                    .HasColumnName("CY_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.CyFechanacimiento)
                    .HasColumnName("CY_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CyFechanacimientoInc)
                    .HasColumnName("CY_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CyLocalidadnacimiento)
                    .HasColumnName("CY_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CyMunicipionacimiento)
                    .HasColumnName("CY_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CyMunicipioregistro)
                    .HasColumnName("CY_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CyNacionalidad)
                    .HasColumnName("CY_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CyNombres)
                    .HasColumnName("CY_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CyNumeroacta)
                    .HasColumnName("CY_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CyOficialia)
                    .HasColumnName("CY_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CyPaisnacimiento)
                    .HasColumnName("CY_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CyPrimerapellido)
                    .HasColumnName("CY_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CySegundoapellido)
                    .HasColumnName("CY_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CySexo)
                    .HasColumnName("CY_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.CyTipodocumento)
                    .HasColumnName("CY_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaActabis)
                    .HasColumnName("MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaAnioregistro)
                    .HasColumnName("MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaCurp)
                    .HasColumnName("MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MaEdad)
                    .HasColumnName("MA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadnacimiento)
                    .HasColumnName("MA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadregistro)
                    .HasColumnName("MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaFechanacimiento)
                    .HasColumnName("MA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaFechanacimientoInc)
                    .HasColumnName("MA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaLocalidadnacimiento)
                    .HasColumnName("MA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MaMunicipionacimiento)
                    .HasColumnName("MA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaMunicipioregistro)
                    .HasColumnName("MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNacionalidad)
                    .HasColumnName("MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNombres)
                    .HasColumnName("MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNumeroacta)
                    .HasColumnName("MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MaOficialia)
                    .HasColumnName("MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaPaisnacimiento)
                    .HasColumnName("MA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaPrimerapellido)
                    .HasColumnName("MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSegundoapellido)
                    .HasColumnName("MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSexo)
                    .HasColumnName("MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaTipodocumento)
                    .HasColumnName("MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NaActabis)
                    .HasColumnName("NA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.NaAnioregistro)
                    .HasColumnName("NA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.NaEntidadregistro)
                    .HasColumnName("NA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.NaMunicipioregistro)
                    .HasColumnName("NA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NaNumeroacta)
                    .HasColumnName("NA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NaOficialia)
                    .HasColumnName("NA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.NaTipodocumento)
                    .HasColumnName("NA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCausadefuncion)
                    .HasColumnName("OT_CAUSADEFUNCION")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtCertificadoDe)
                    .HasColumnName("OT_CERTIFICADO_DE")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OtCrip)
                    .HasColumnName("OT_CRIP")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtDias)
                    .HasColumnName("OT_DIAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtEstadocivildifunto)
                    .HasColumnName("OT_ESTADOCIVILDIFUNTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.OtFechadefuncion)
                    .HasColumnName("OT_FECHADEFUNCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtFechadefuncionInc)
                    .HasColumnName("OT_FECHADEFUNCION_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharegistroennacimiento)
                    .HasColumnName("OT_FECHAREGISTROENNACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtFecharegistronacimientoInc)
                    .HasColumnName("OT_FECHAREGISTRONACIMIENTO_INC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtHoras)
                    .HasColumnName("OT_HORAS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtLlaverenadi)
                    .HasColumnName("OT_LLAVERENADI")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.OtLocalidaddefuncion)
                    .HasColumnName("OT_LOCALIDADDEFUNCION")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.OtMeses)
                    .HasColumnName("OT_MESES")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtMinutos)
                    .HasColumnName("OT_MINUTOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtSegundos)
                    .HasColumnName("OT_SEGUNDOS")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OtTipodefuncion)
                    .HasColumnName("OT_TIPODEFUNCION")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaActabis)
                    .HasColumnName("PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaAnioregistro)
                    .HasColumnName("PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaCurp)
                    .HasColumnName("PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PaEdad)
                    .HasColumnName("PA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadnacimiento)
                    .HasColumnName("PA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadregistro)
                    .HasColumnName("PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaFechanacimiento)
                    .HasColumnName("PA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaFechanacimientoInc)
                    .HasColumnName("PA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaLocalidadnacimiento)
                    .HasColumnName("PA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PaMunicipionacimiento)
                    .HasColumnName("PA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaMunicipioregistro)
                    .HasColumnName("PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNacionalidad)
                    .HasColumnName("PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNombres)
                    .HasColumnName("PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaNumeroacta)
                    .HasColumnName("PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PaOficialia)
                    .HasColumnName("PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaPaisnacimiento)
                    .HasColumnName("PA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaPrimerapellido)
                    .HasColumnName("PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSegundoapellido)
                    .HasColumnName("PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSexo)
                    .HasColumnName("PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaTipodocumento)
                    .HasColumnName("PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeCurp)
                    .HasColumnName("PE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PeEdad)
                    .HasColumnName("PE_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeEntidadnacimiento)
                    .HasColumnName("PE_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeFechanacimiento)
                    .HasColumnName("PE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeFechanacimientoInc)
                    .HasColumnName("PE_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PeLocalidadnacimiento)
                    .HasColumnName("PE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PeMunicipionacimiento)
                    .HasColumnName("PE_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNacionalidad)
                    .HasColumnName("PE_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNombres)
                    .HasColumnName("PE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PePaisnacimiento)
                    .HasColumnName("PE_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PePrimerapellido)
                    .HasColumnName("PE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSegundoapellido)
                    .HasColumnName("PE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSexo)
                    .HasColumnName("PE_SEXO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipocadena)
                    .HasColumnName("TIPOCADENA")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TmpFecha)
                    .HasColumnName("TMP_FECHA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NrcDivorcios>(entity =>
            {
                entity.HasKey(e => e.Cadena);

                entity.ToTable("NRC_DIVORCIOS");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaoriginal)
                    .HasColumnName("CO_FECHAORIGINAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoSoporte).HasColumnName("CO_SOPORTE");

                entity.Property(e => e.CoTipo)
                    .HasColumnName("CO_TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CoTranscripcion)
                    .HasColumnName("CO_TRANSCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.EntidadregistroMatrimonio)
                    .HasColumnName("ENTIDADREGISTRO_MATRIMONIO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.FechaRegistroMatrimonio)
                    .HasColumnName("FECHA_REGISTRO_MATRIMONIO")
                    .HasColumnType("datetime");

                entity.Property(e => e.FojaMatrimonio)
                    .HasColumnName("FOJA_MATRIMONIO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.LibroMatrimonio)
                    .HasColumnName("LIBRO_MATRIMONIO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaActabis)
                    .HasColumnName("MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaCadena)
                    .HasColumnName("MA_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MunicipioregistroMatrimonio)
                    .HasColumnName("MUNICIPIOREGISTRO_MATRIMONIO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NumeroactaMatrimonio)
                    .HasColumnName("NUMEROACTA_MATRIMONIO")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OficialiaMatrimonio)
                    .HasColumnName("OFICIALIA_MATRIMONIO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCripP1)
                    .HasColumnName("OT_CRIP_P1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtCripP2)
                    .HasColumnName("OT_CRIP_P2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharesolucion)
                    .HasColumnName("OT_FECHARESOLUCION")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtResolucionAdmin)
                    .IsRequired()
                    .HasColumnName("OT_RESOLUCION_ADMIN")
                    .IsUnicode(false);

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .IsUnicode(false);

                entity.Property(e => e.OtTipoDivorcio)
                    .HasColumnName("OT_TIPO_DIVORCIO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1Actabis)
                    .HasColumnName("P1_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1Anioregistro)
                    .HasColumnName("P1_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1Cadena)
                    .HasColumnName("P1_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P1Curp)
                    .HasColumnName("P1_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P1Edad)
                    .HasColumnName("P1_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1Entidadnacimiento)
                    .HasColumnName("P1_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1Entidadregistro)
                    .HasColumnName("P1_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1FechaRegistro)
                    .HasColumnName("P1_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.P1Fechanacimiento)
                    .HasColumnName("P1_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.P1Foja)
                    .HasColumnName("P1_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P1Libro)
                    .HasColumnName("P1_LIBRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1Localidadnacimiento)
                    .HasColumnName("P1_LOCALIDADNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.P1Municipionacimiento)
                    .HasColumnName("P1_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Municipioregistro)
                    .HasColumnName("P1_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Nacionalidad)
                    .HasColumnName("P1_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Nombres)
                    .IsRequired()
                    .HasColumnName("P1_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1Numeroacta)
                    .HasColumnName("P1_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P1Oficialia)
                    .HasColumnName("P1_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1Paisnacimiento)
                    .HasColumnName("P1_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Primerapellido)
                    .IsRequired()
                    .HasColumnName("P1_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1Segundoapellido)
                    .HasColumnName("P1_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1Sexo)
                    .HasColumnName("P1_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1Tipodocumento)
                    .HasColumnName("P1_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P1Tomo)
                    .HasColumnName("P1_TOMO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Actabis)
                    .HasColumnName("P2_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2Anioregistro)
                    .HasColumnName("P2_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2Cadena)
                    .HasColumnName("P2_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P2Curp)
                    .HasColumnName("P2_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P2Edad)
                    .HasColumnName("P2_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2Entidadnacimiento)
                    .HasColumnName("P2_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2Entidadregistro)
                    .HasColumnName("P2_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2FechaRegistro)
                    .HasColumnName("P2_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.P2Fechanacimiento)
                    .HasColumnName("P2_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.P2Foja)
                    .HasColumnName("P2_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P2Libro)
                    .HasColumnName("P2_LIBRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2Localidadnacimiento)
                    .HasColumnName("P2_LOCALIDADNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.P2Municipionacimiento)
                    .HasColumnName("P2_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Municipioregistro)
                    .HasColumnName("P2_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Nacionalidad)
                    .HasColumnName("P2_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Nombres)
                    .IsRequired()
                    .HasColumnName("P2_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2Numeroacta)
                    .HasColumnName("P2_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P2Oficialia)
                    .HasColumnName("P2_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2Paisnacimiento)
                    .HasColumnName("P2_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Primerapellido)
                    .IsRequired()
                    .HasColumnName("P2_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2Segundoapellido)
                    .HasColumnName("P2_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2Sexo)
                    .HasColumnName("P2_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2Tipodocumento)
                    .HasColumnName("P2_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P2Tomo)
                    .HasColumnName("P2_TOMO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Tipocadena)
                    .HasColumnName("TIPOCADENA")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TomoMatrimonio)
                    .HasColumnName("TOMO_MATRIMONIO")
                    .HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<NrcMatrimonios>(entity =>
            {
                entity.HasKey(e => e.Cadena)
                    .HasName("NRC_MATRIMONIOS3_PK");

                entity.ToTable("NRC_MATRIMONIOS");

                entity.HasIndex(e => e.CoLlaveregistrocivil)
                    .HasName("idxcolla");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaoriginal)
                    .HasColumnName("CO_FECHAORIGINAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoSoporte).HasColumnName("CO_SOPORTE");

                entity.Property(e => e.CoTipo)
                    .HasColumnName("CO_TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.CoTranscripcion)
                    .HasColumnName("CO_TRANSCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCripP1)
                    .HasColumnName("OT_CRIP_P1")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtCripP2)
                    .HasColumnName("OT_CRIP_P2")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .IsUnicode(false);

                entity.Property(e => e.OtRegistropatrimonial)
                    .HasColumnName("OT_REGISTROPATRIMONIAL")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .IsUnicode(false);

                entity.Property(e => e.P1Actabis)
                    .HasColumnName("P1_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1Anioregistro)
                    .HasColumnName("P1_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1Cadena)
                    .HasColumnName("P1_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P1Curp)
                    .HasColumnName("P1_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P1Edad)
                    .HasColumnName("P1_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1Entidadnacimiento)
                    .HasColumnName("P1_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1Entidadregistro)
                    .HasColumnName("P1_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1Fechanacimiento)
                    .HasColumnName("P1_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.P1Localidadnacimiento)
                    .HasColumnName("P1_LOCALIDADNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaActabis)
                    .HasColumnName("P1_MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaAnioregistro)
                    .HasColumnName("P1_MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1MaCadena)
                    .HasColumnName("P1_MA_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaCurp)
                    .HasColumnName("P1_MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaEntidadregistro)
                    .HasColumnName("P1_MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1MaMunicipioregistro)
                    .HasColumnName("P1_MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1MaNacionalidad)
                    .HasColumnName("P1_MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1MaNombres)
                    .HasColumnName("P1_MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaNumeroacta)
                    .HasColumnName("P1_MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P1MaOficialia)
                    .HasColumnName("P1_MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1MaPrimerapellido)
                    .HasColumnName("P1_MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaSegundoapellido)
                    .HasColumnName("P1_MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaSexo)
                    .HasColumnName("P1_MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1MaTipodocumento)
                    .HasColumnName("P1_MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P1Municipionacimiento)
                    .HasColumnName("P1_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Municipioregistro)
                    .HasColumnName("P1_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Nacionalidad)
                    .HasColumnName("P1_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Nombres)
                    .HasColumnName("P1_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1Numeroacta)
                    .HasColumnName("P1_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P1Oficialia)
                    .HasColumnName("P1_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1PaActabis)
                    .HasColumnName("P1_PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1PaAnioregistro)
                    .HasColumnName("P1_PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1PaCadena)
                    .HasColumnName("P1_PA_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P1PaCurp)
                    .HasColumnName("P1_PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P1PaEntidadregistro)
                    .HasColumnName("P1_PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P1PaMunicipioregistro)
                    .HasColumnName("P1_PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1PaNacionalidad)
                    .HasColumnName("P1_PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1PaNombres)
                    .HasColumnName("P1_PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1PaNumeroacta)
                    .HasColumnName("P1_PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P1PaOficialia)
                    .HasColumnName("P1_PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P1PaPrimerapellido)
                    .HasColumnName("P1_PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1PaSegundoapellido)
                    .HasColumnName("P1_PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1PaSexo)
                    .HasColumnName("P1_PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1PaTipodocumento)
                    .HasColumnName("P1_PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P1Paisnacimiento)
                    .HasColumnName("P1_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P1Primerapellido)
                    .HasColumnName("P1_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1Segundoapellido)
                    .HasColumnName("P1_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P1Sexo)
                    .HasColumnName("P1_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P1Tipodocumento)
                    .HasColumnName("P1_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P2Actabis)
                    .HasColumnName("P2_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2Anioregistro)
                    .HasColumnName("P2_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2Cadena)
                    .HasColumnName("P2_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P2Curp)
                    .HasColumnName("P2_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P2Edad)
                    .HasColumnName("P2_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2Entidadnacimiento)
                    .HasColumnName("P2_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2Entidadregistro)
                    .HasColumnName("P2_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2Fechanacimiento)
                    .HasColumnName("P2_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.P2Localidadnacimiento)
                    .HasColumnName("P2_LOCALIDADNACIMIENTO")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaActabis)
                    .HasColumnName("P2_MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaAnioregistro)
                    .HasColumnName("P2_MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2MaCadena)
                    .HasColumnName("P2_MA_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaCurp)
                    .HasColumnName("P2_MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaEntidadregistro)
                    .HasColumnName("P2_MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2MaMunicipioregistro)
                    .HasColumnName("P2_MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2MaNacionalidad)
                    .HasColumnName("P2_MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2MaNombres)
                    .HasColumnName("P2_MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaNumeroacta)
                    .HasColumnName("P2_MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P2MaOficialia)
                    .HasColumnName("P2_MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2MaPrimerapellido)
                    .HasColumnName("P2_MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaSegundoapellido)
                    .HasColumnName("P2_MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaSexo)
                    .HasColumnName("P2_MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2MaTipodocumento)
                    .HasColumnName("P2_MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P2Municipionacimiento)
                    .HasColumnName("P2_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Municipioregistro)
                    .HasColumnName("P2_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Nacionalidad)
                    .HasColumnName("P2_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Nombres)
                    .HasColumnName("P2_NOMBRES")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.P2Numeroacta)
                    .HasColumnName("P2_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P2Oficialia)
                    .HasColumnName("P2_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2PaActabis)
                    .HasColumnName("P2_PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2PaAnioregistro)
                    .HasColumnName("P2_PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2PaCadena)
                    .HasColumnName("P2_PA_CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.P2PaCurp)
                    .HasColumnName("P2_PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.P2PaEntidadregistro)
                    .HasColumnName("P2_PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.P2PaMunicipioregistro)
                    .HasColumnName("P2_PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2PaNacionalidad)
                    .HasColumnName("P2_PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2PaNombres)
                    .HasColumnName("P2_PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2PaNumeroacta)
                    .HasColumnName("P2_PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.P2PaOficialia)
                    .HasColumnName("P2_PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.P2PaPrimerapellido)
                    .HasColumnName("P2_PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2PaSegundoapellido)
                    .HasColumnName("P2_PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.P2PaSexo)
                    .HasColumnName("P2_PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2PaTipodocumento)
                    .HasColumnName("P2_PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.P2Paisnacimiento)
                    .HasColumnName("P2_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.P2Primerapellido)
                    .HasColumnName("P2_PRIMERAPELLIDO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.P2Segundoapellido)
                    .HasColumnName("P2_SEGUNDOAPELLIDO")
                    .HasMaxLength(60)
                    .IsUnicode(false);

                entity.Property(e => e.P2Sexo)
                    .HasColumnName("P2_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.P2Tipodocumento)
                    .HasColumnName("P2_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Tipocadena).HasColumnName("TIPOCADENA");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");
            });

            modelBuilder.Entity<NrcNacimientos>(entity =>
            {
                entity.HasKey(e => e.Cadena)
                    .HasName("PK_NRC_NACIMIENTOS_1");

                entity.ToTable("NRC_NACIMIENTOS");

                entity.HasIndex(e => e.CoFechaRegistro)
                    .HasName("idxfechareg");

                entity.HasIndex(e => e.CoLlaveregistrocivil)
                    .HasName("idxco_llaveregistrocivil");

                entity.HasIndex(e => e.PeCurp)
                    .HasName("idxcurp");

                entity.HasIndex(e => new { e.MaNombres, e.MaPrimerapellido, e.MaSegundoapellido })
                    .HasName("idx_mama");

                entity.HasIndex(e => new { e.PaNombres, e.PaPrimerapellido, e.PaSegundoapellido })
                    .HasName("idx_papa");

                entity.HasIndex(e => new { e.PeNombres, e.PePrimerapellido, e.PeSegundoapellido, e.PeFechanacimiento })
                    .HasName("idxdatosper");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechaactualizacionInc)
                    .HasColumnName("CN_FECHAACTUALIZACION_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistroInc)
                    .HasColumnName("CO_FECHA_REGISTRO_INC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoFechaoriginal)
                    .HasColumnName("CO_FECHAORIGINAL")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoSoporte).HasColumnName("CO_SOPORTE");

                entity.Property(e => e.CoTipo)
                    .HasColumnName("CO_TIPO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('N')");

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CoTranscripcion)
                    .HasColumnName("CO_TRANSCRIPCION")
                    .IsUnicode(false);

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaActabis)
                    .HasColumnName("MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaAnioregistro)
                    .HasColumnName("MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaCurp)
                    .HasColumnName("MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MaEdad)
                    .HasColumnName("MA_EDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaEntidadnacimiento)
                    .HasColumnName("MA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadregistro)
                    .HasColumnName("MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaFechanacimiento)
                    .HasColumnName("MA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaFechanacimientoInc)
                    .HasColumnName("MA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaLocalidadnacimiento)
                    .HasColumnName("MA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MaMunicipionacimiento)
                    .HasColumnName("MA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaMunicipioregistro)
                    .HasColumnName("MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNacionalidad)
                    .HasColumnName("MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNombres)
                    .HasColumnName("MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNumeroacta)
                    .HasColumnName("MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MaOficialia)
                    .HasColumnName("MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaPaisnacimiento)
                    .HasColumnName("MA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaPrimerapellido)
                    .HasColumnName("MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSegundoapellido)
                    .HasColumnName("MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSexo)
                    .HasColumnName("MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaTipodocumento)
                    .HasColumnName("MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Nactoid).HasColumnName("nactoid");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCertificadoNa)
                    .HasColumnName("OT_CERTIFICADO_NA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OtCrip)
                    .HasColumnName("OT_CRIP")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharegistronacimientoInc)
                    .HasColumnName("OT_FECHAREGISTRONACIMIENTO_INC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OtVivoomuerto)
                    .HasColumnName("OT_VIVOOMUERTO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaActabis)
                    .HasColumnName("PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaAnioregistro)
                    .HasColumnName("PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaCurp)
                    .HasColumnName("PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PaEdad)
                    .HasColumnName("PA_EDAD")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaEntidadnacimiento)
                    .HasColumnName("PA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadregistro)
                    .HasColumnName("PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaFechanacimiento)
                    .HasColumnName("PA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaFechanacimientoInc)
                    .HasColumnName("PA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaLocalidadnacimiento)
                    .HasColumnName("PA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PaMunicipionacimiento)
                    .HasColumnName("PA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaMunicipioregistro)
                    .HasColumnName("PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNacionalidad)
                    .HasColumnName("PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNombres)
                    .HasColumnName("PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaNumeroacta)
                    .HasColumnName("PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PaOficialia)
                    .HasColumnName("PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaPaisnacimiento)
                    .HasColumnName("PA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaPrimerapellido)
                    .HasColumnName("PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSegundoapellido)
                    .HasColumnName("PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSexo)
                    .HasColumnName("PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaTipodocumento)
                    .HasColumnName("PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeCurp)
                    .HasColumnName("PE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PeEdad)
                    .HasColumnName("PE_EDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeEntidadnacimiento)
                    .HasColumnName("PE_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeFechanacimiento)
                    .HasColumnName("PE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeFechanacimientoInc)
                    .HasColumnName("PE_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PeLocalidadnacimiento)
                    .HasColumnName("PE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PeMunicipionacimiento)
                    .HasColumnName("PE_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNacionalidad)
                    .HasColumnName("PE_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNombres)
                    .HasColumnName("PE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PePaisnacimiento)
                    .HasColumnName("PE_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PePrimerapellido)
                    .HasColumnName("PE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSegundoapellido)
                    .HasColumnName("PE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSexo)
                    .HasColumnName("PE_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Tipocadena)
                    .HasColumnName("TIPOCADENA")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TmpFecha)
                    .HasColumnName("TMP_FECHA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NrcNacimientosBak>(entity =>
            {
                entity.HasKey(e => e.Cadena)
                    .HasName("PK_NRC_NACIMIENTOS");

                entity.ToTable("NRC_NACIMIENTOS_Bak");

                entity.HasIndex(e => new { e.Municipioregistro, e.Oficialia, e.Anioregistro, e.Numeroacta })
                    .HasName("idxcadfs");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechaactualizacionInc)
                    .HasColumnName("CN_FECHAACTUALIZACION_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistroInc)
                    .HasColumnName("CO_FECHA_REGISTRO_INC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaActabis)
                    .HasColumnName("MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaAnioregistro)
                    .HasColumnName("MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaCurp)
                    .HasColumnName("MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MaEdad)
                    .HasColumnName("MA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadnacimiento)
                    .HasColumnName("MA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadregistro)
                    .HasColumnName("MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaFechanacimiento)
                    .HasColumnName("MA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaFechanacimientoInc)
                    .HasColumnName("MA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaLocalidadnacimiento)
                    .HasColumnName("MA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MaMunicipionacimiento)
                    .HasColumnName("MA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaMunicipioregistro)
                    .HasColumnName("MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNacionalidad)
                    .HasColumnName("MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNombres)
                    .HasColumnName("MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNumeroacta)
                    .HasColumnName("MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MaOficialia)
                    .HasColumnName("MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaPaisnacimiento)
                    .HasColumnName("MA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaPrimerapellido)
                    .HasColumnName("MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSegundoapellido)
                    .HasColumnName("MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSexo)
                    .HasColumnName("MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaTipodocumento)
                    .HasColumnName("MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Nactoid).HasColumnName("nactoid");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCertificadoNa)
                    .HasColumnName("OT_CERTIFICADO_NA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OtCrip)
                    .HasColumnName("OT_CRIP")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharegistronacimientoInc)
                    .HasColumnName("OT_FECHAREGISTRONACIMIENTO_INC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OtVivoomuerto)
                    .IsRequired()
                    .HasColumnName("OT_VIVOOMUERTO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaActabis)
                    .HasColumnName("PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaAnioregistro)
                    .HasColumnName("PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaCurp)
                    .HasColumnName("PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PaEdad)
                    .HasColumnName("PA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadnacimiento)
                    .HasColumnName("PA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadregistro)
                    .HasColumnName("PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaFechanacimiento)
                    .HasColumnName("PA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaFechanacimientoInc)
                    .HasColumnName("PA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaLocalidadnacimiento)
                    .HasColumnName("PA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PaMunicipionacimiento)
                    .HasColumnName("PA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaMunicipioregistro)
                    .HasColumnName("PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNacionalidad)
                    .HasColumnName("PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNombres)
                    .HasColumnName("PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaNumeroacta)
                    .HasColumnName("PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PaOficialia)
                    .HasColumnName("PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaPaisnacimiento)
                    .HasColumnName("PA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaPrimerapellido)
                    .HasColumnName("PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSegundoapellido)
                    .HasColumnName("PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSexo)
                    .HasColumnName("PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaTipodocumento)
                    .HasColumnName("PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeCurp)
                    .HasColumnName("PE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PeEdad)
                    .HasColumnName("PE_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeEntidadnacimiento)
                    .HasColumnName("PE_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeFechanacimiento)
                    .HasColumnName("PE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeFechanacimientoInc)
                    .HasColumnName("PE_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PeLocalidadnacimiento)
                    .HasColumnName("PE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PeMunicipionacimiento)
                    .HasColumnName("PE_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNacionalidad)
                    .HasColumnName("PE_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNombres)
                    .IsRequired()
                    .HasColumnName("PE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PePaisnacimiento)
                    .HasColumnName("PE_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PePrimerapellido)
                    .IsRequired()
                    .HasColumnName("PE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSegundoapellido)
                    .HasColumnName("PE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSexo)
                    .IsRequired()
                    .HasColumnName("PE_SEXO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TmpFecha)
                    .HasColumnName("TMP_FECHA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<NrcPais>(entity =>
            {
                entity.HasKey(e => e.PaiCodigo);

                entity.ToTable("NRC_PAIS");

                entity.HasIndex(e => e.PaiNacionalidad)
                    .HasName("idxpainac");

                entity.Property(e => e.PaiCodigo)
                    .HasColumnName("PAI_CODIGO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaiCveNacionalidad)
                    .HasColumnName("PAI_CVE_NACIONALIDAD")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.PaiDescripcion)
                    .IsRequired()
                    .HasColumnName("PAI_DESCRIPCION")
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.PaiFechaCreacion)
                    .HasColumnName("PAI_FECHA_CREACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaiFechaModificacion)
                    .HasColumnName("PAI_FECHA_MODIFICACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaiNacionalidad)
                    .IsRequired()
                    .HasColumnName("PAI_NACIONALIDAD")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PaiUsuarioCreacion)
                    .IsRequired()
                    .HasColumnName("PAI_USUARIO_CREACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PaiUsuarioModificacion)
                    .HasColumnName("PAI_USUARIO_MODIFICACION")
                    .HasMaxLength(10)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<NrcReconocimientos>(entity =>
            {
                entity.HasKey(e => e.Cadena);

                entity.ToTable("NRC_RECONOCIMIENTOS");

                entity.Property(e => e.Cadena)
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechaactualizacionInc)
                    .HasColumnName("CN_FECHAACTUALIZACION_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistroInc)
                    .HasColumnName("CO_FECHA_REGISTRO_INC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(4, 0)")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaActabis)
                    .HasColumnName("MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaAnioregistro)
                    .HasColumnName("MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaCurp)
                    .HasColumnName("MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MaEdad)
                    .HasColumnName("MA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadnacimiento)
                    .HasColumnName("MA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadregistro)
                    .HasColumnName("MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaFechanacimiento)
                    .HasColumnName("MA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaFechanacimientoInc)
                    .HasColumnName("MA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaLocalidadnacimiento)
                    .HasColumnName("MA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MaMunicipionacimiento)
                    .HasColumnName("MA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaMunicipioregistro)
                    .HasColumnName("MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNacionalidad)
                    .HasColumnName("MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNombres)
                    .HasColumnName("MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNumeroacta)
                    .HasColumnName("MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MaOficialia)
                    .HasColumnName("MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaPaisnacimiento)
                    .HasColumnName("MA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaPrimerapellido)
                    .HasColumnName("MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSegundoapellido)
                    .HasColumnName("MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSexo)
                    .HasColumnName("MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaTipodocumento)
                    .HasColumnName("MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NaActabis)
                    .HasColumnName("NA_ACTABIS")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NaAnioregistro)
                    .HasColumnName("NA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.NaEntidadregistro)
                    .HasColumnName("NA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.NaLocalidadReconocido)
                    .HasColumnName("NA_LOCALIDAD_RECONOCIDO")
                    .HasMaxLength(40)
                    .IsFixedLength();

                entity.Property(e => e.NaMunicipioregistro)
                    .HasColumnName("NA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.NaNumeroacta)
                    .HasColumnName("NA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.NaOficialia)
                    .HasColumnName("NA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.NaTipodocumento)
                    .HasColumnName("NA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCrip)
                    .HasColumnName("OT_CRIP")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharegistroennacimiento)
                    .HasColumnName("OT_FECHAREGISTROENNACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.OtFecharegistronacimientoInc)
                    .HasColumnName("OT_FECHAREGISTRONACIMIENTO_INC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtFirmarc)
                    .HasColumnName("OT_FIRMARC")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.PaActabis)
                    .HasColumnName("PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaAnioregistro)
                    .HasColumnName("PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaCurp)
                    .HasColumnName("PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PaEdad)
                    .HasColumnName("PA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadnacimiento)
                    .HasColumnName("PA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadregistro)
                    .HasColumnName("PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaFechanacimiento)
                    .HasColumnName("PA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaFechanacimientoInc)
                    .HasColumnName("PA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaLocalidadnacimiento)
                    .HasColumnName("PA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PaMunicipionacimiento)
                    .HasColumnName("PA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaMunicipioregistro)
                    .HasColumnName("PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNacionalidad)
                    .HasColumnName("PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNombres)
                    .HasColumnName("PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaNumeroacta)
                    .HasColumnName("PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PaOficialia)
                    .HasColumnName("PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaPaisnacimiento)
                    .HasColumnName("PA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaPrimerapellido)
                    .HasColumnName("PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSegundoapellido)
                    .HasColumnName("PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSexo)
                    .HasColumnName("PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaTipodocumento)
                    .HasColumnName("PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeCurp)
                    .HasColumnName("PE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PeEdad)
                    .HasColumnName("PE_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeEntidadnacimiento)
                    .HasColumnName("PE_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeFechanacimiento)
                    .HasColumnName("PE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeFechanacimientoInc)
                    .HasColumnName("PE_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PeLocalidadnacimiento)
                    .HasColumnName("PE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PeMunicipionacimiento)
                    .HasColumnName("PE_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNacionalidad)
                    .HasColumnName("PE_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNombres)
                    .IsRequired()
                    .HasColumnName("PE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PePaisnacimiento)
                    .HasColumnName("PE_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PePrimerapellido)
                    .IsRequired()
                    .HasColumnName("PE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSegundoapellido)
                    .HasColumnName("PE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSexo)
                    .IsRequired()
                    .HasColumnName("PE_SEXO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReActabis)
                    .HasColumnName("RE_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReAnioregistro)
                    .HasColumnName("RE_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.ReCurp)
                    .HasColumnName("RE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.ReEdad)
                    .HasColumnName("RE_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ReEntidadnacimiento)
                    .HasColumnName("RE_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ReEntidadregistro)
                    .HasColumnName("RE_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ReFechanacimiento)
                    .HasColumnName("RE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReFechanacimientoInc)
                    .HasColumnName("RE_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ReLocalidadnacimiento)
                    .HasColumnName("RE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.ReMunicipionacimiento)
                    .HasColumnName("RE_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ReMunicipioregistro)
                    .HasColumnName("RE_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ReNacionalidad)
                    .HasColumnName("RE_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ReNombres)
                    .HasColumnName("RE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReNumeroacta)
                    .HasColumnName("RE_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.ReOficialia)
                    .HasColumnName("RE_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.RePaisnacimiento)
                    .HasColumnName("RE_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.RePrimerapellido)
                    .HasColumnName("RE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReSegundoapellido)
                    .HasColumnName("RE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ReSexo)
                    .HasColumnName("RE_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.ReTipodocumento)
                    .HasColumnName("RE_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Tipocadena)
                    .HasColumnName("TIPOCADENA")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.TmpFecha)
                    .HasColumnName("TMP_FECHA")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Paises>(entity =>
            {
                entity.HasKey(e => e.Codigo);

                entity.Property(e => e.Codigo).HasMaxLength(20);

                entity.Property(e => e.Continente).HasMaxLength(100);

                entity.Property(e => e.Iso).HasMaxLength(20);

                entity.Property(e => e.Iso3).HasMaxLength(20);

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.NombreLocal).HasMaxLength(100);

                entity.Property(e => e.Region).HasMaxLength(50);
            });

            modelBuilder.Entity<PaisesIdioma>(entity =>
            {
                entity.HasKey(e => new { e.PaisCodigo, e.PaisIdioma })
                    .HasName("PK__PaisesIdioma__5BAD9CC8");

                entity.Property(e => e.PaisCodigo)
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.PaisIdioma)
                    .HasMaxLength(30)
                    .IsUnicode(false)
                    .IsFixedLength();
            });

            modelBuilder.Entity<Perfil>(entity =>
            {
                entity.HasKey(e => e.IdPerfil)
                    .HasName("PK__PERFIL__7F2BE32F");

                entity.ToTable("PERFIL");

                entity.Property(e => e.IdPerfil)
                    .HasColumnName("ID_PERFIL")
                    .HasColumnType("numeric(3, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.IdRol)
                    .HasColumnName("ID_ROL")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.IdUsu)
                    .HasColumnName("ID_USU")
                    .HasColumnType("numeric(3, 0)");
            });

            modelBuilder.Entity<Productos>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Costo).HasColumnType("decimal(18, 2)");

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).HasMaxLength(100);

                entity.Property(e => e.Precio).HasColumnType("decimal(18, 2)");
            });

            modelBuilder.Entity<Proveedores>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.Nombre).HasMaxLength(100);
            });

            modelBuilder.Entity<ResponseForUser>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("RESPONSE_FOR_USER");

                entity.Property(e => e.RequestETipo)
                    .HasColumnName("REQUEST_E_TIPO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.RequestOid)
                    .HasColumnName("REQUEST_OID")
                    .HasColumnType("numeric(24, 0)");

                entity.Property(e => e.RequestUser)
                    .HasColumnName("REQUEST_USER")
                    .HasMaxLength(15)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Rol>(entity =>
            {
                entity.HasKey(e => e.IdRol)
                    .HasName("PK__ROL__7B5B524B");

                entity.ToTable("ROL");

                entity.Property(e => e.IdRol)
                    .HasColumnName("ID_ROL")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.ClvRol)
                    .IsRequired()
                    .HasColumnName("CLV_ROL")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Descripcion)
                    .HasColumnName("DESCRIPCION")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Rol1)
                    .IsRequired()
                    .HasColumnName("ROL")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SolicitudActas>(entity =>
            {
                entity.HasKey(e => e.IdSolicitud);

                entity.Property(e => e.Acta)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Correoe)
                    .IsRequired()
                    .HasColumnName("correoe")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Curp)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EstatusSolicitud)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LineaCaptura)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Obrservaciones)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.PrimerApellido)
                    .IsRequired()
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.SegundoApellido)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Telefono)
                    .IsRequired()
                    .HasColumnName("telefono")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuariorear>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("USUARIOREAR");

                entity.Property(e => e.Entidad)
                    .HasColumnName("ENTIDAD")
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Grupousuclave)
                    .HasColumnName("GRUPOUSUCLAVE")
                    .HasMaxLength(3)
                    .IsUnicode(false);

                entity.Property(e => e.Municipio)
                    .HasColumnName("MUNICIPIO")
                    .HasMaxLength(3)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuactivo)
                    .HasColumnName("USUACTIVO")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Usuemail)
                    .HasColumnName("USUEMAIL")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Usuid)
                    .HasColumnName("USUID")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Usulogin)
                    .HasColumnName("USULOGIN")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Usunombre)
                    .HasColumnName("USUNOMBRE")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.Usupaswd)
                    .HasColumnName("USUPASWD")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Usutel)
                    .HasColumnName("USUTEL")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Usuarios>(entity =>
            {
                entity.HasKey(e => e.IdUsu)
                    .HasName("PK__USUARIOS__787EE5A0");

                entity.ToTable("USUARIOS");

                entity.HasIndex(e => e.Usulogin)
                    .HasName("UQ_UNICO_LOG")
                    .IsUnique();

                entity.Property(e => e.IdUsu)
                    .HasColumnName("ID_USU")
                    .HasColumnType("numeric(3, 0)")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Activo)
                    .HasColumnName("ACTIVO")
                    .HasColumnType("numeric(11, 0)");

                entity.Property(e => e.Apellidos)
                    .HasColumnName("APELLIDOS")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Estado)
                    .HasColumnName("ESTADO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Salt)
                    .IsRequired()
                    .HasColumnName("SALT");

                entity.Property(e => e.Usulogin)
                    .IsRequired()
                    .HasColumnName("USULOGIN")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usunombre)
                    .IsRequired()
                    .HasColumnName("USUNOMBRE")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Usupaswd).HasColumnName("USUPASWD");
            });

            modelBuilder.Entity<VistaNacimientos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VISTA_NACIMIENTOS");

                entity.Property(e => e.Actabis)
                    .IsRequired()
                    .HasColumnName("ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Anioregistro)
                    .HasColumnName("ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Cadena)
                    .IsRequired()
                    .HasColumnName("CADENA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CnFechaactualizacion)
                    .HasColumnName("CN_FECHAACTUALIZACION")
                    .HasColumnType("datetime");

                entity.Property(e => e.CnFechaactualizacionInc)
                    .HasColumnName("CN_FECHAACTUALIZACION_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.CnFechacaptura)
                    .HasColumnName("CN_FECHACAPTURA")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistro)
                    .HasColumnName("CO_FECHA_REGISTRO")
                    .HasColumnType("datetime");

                entity.Property(e => e.CoFechaRegistroInc)
                    .HasColumnName("CO_FECHA_REGISTRO_INC")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CoFoja)
                    .HasColumnName("CO_FOJA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.CoLibro)
                    .HasColumnName("CO_LIBRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.CoLlaveregistrocivil)
                    .HasColumnName("CO_LLAVEREGISTROCIVIL")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.CoTomo)
                    .HasColumnName("CO_TOMO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.Entidadregistro)
                    .HasColumnName("ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.ImArchivo).HasColumnName("IM_ARCHIVO");

                entity.Property(e => e.ImNombreoriginalimagen)
                    .HasColumnName("IM_NOMBREORIGINALIMAGEN")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MaActabis)
                    .HasColumnName("MA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaAnioregistro)
                    .HasColumnName("MA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaCurp)
                    .HasColumnName("MA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.MaEdad)
                    .HasColumnName("MA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadnacimiento)
                    .HasColumnName("MA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaEntidadregistro)
                    .HasColumnName("MA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.MaFechanacimiento)
                    .HasColumnName("MA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaFechanacimientoInc)
                    .HasColumnName("MA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MaLocalidadnacimiento)
                    .HasColumnName("MA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.MaMunicipionacimiento)
                    .HasColumnName("MA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaMunicipioregistro)
                    .HasColumnName("MA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNacionalidad)
                    .HasColumnName("MA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaNombres)
                    .HasColumnName("MA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaNumeroacta)
                    .HasColumnName("MA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.MaOficialia)
                    .HasColumnName("MA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.MaPaisnacimiento)
                    .HasColumnName("MA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.MaPrimerapellido)
                    .HasColumnName("MA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSegundoapellido)
                    .HasColumnName("MA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MaSexo)
                    .HasColumnName("MA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.MaTipodocumento)
                    .HasColumnName("MA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Municipioregistro)
                    .HasColumnName("MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.Nactoid).HasColumnName("nactoid");

                entity.Property(e => e.Numeroacta)
                    .HasColumnName("NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.Oficialia)
                    .HasColumnName("OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.OtCertificadoNa)
                    .HasColumnName("OT_CERTIFICADO_NA")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.OtCrip)
                    .HasColumnName("OT_CRIP")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtErrororigen)
                    .HasColumnName("OT_ERRORORIGEN")
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.OtFecharegistronacimientoInc)
                    .HasColumnName("OT_FECHAREGISTRONACIMIENTO_INC")
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.OtFirma)
                    .HasColumnName("OT_FIRMA")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtNotasmarginales)
                    .HasColumnName("OT_NOTASMARGINALES")
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OtSello)
                    .HasColumnName("OT_SELLO")
                    .HasMaxLength(8000)
                    .IsUnicode(false);

                entity.Property(e => e.OtVivoomuerto)
                    .IsRequired()
                    .HasColumnName("OT_VIVOOMUERTO")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PaActabis)
                    .HasColumnName("PA_ACTABIS")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaAnioregistro)
                    .HasColumnName("PA_ANIOREGISTRO")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaCurp)
                    .HasColumnName("PA_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PaEdad)
                    .HasColumnName("PA_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadnacimiento)
                    .HasColumnName("PA_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaEntidadregistro)
                    .HasColumnName("PA_ENTIDADREGISTRO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PaFechanacimiento)
                    .HasColumnName("PA_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaFechanacimientoInc)
                    .HasColumnName("PA_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PaLocalidadnacimiento)
                    .HasColumnName("PA_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PaMunicipionacimiento)
                    .HasColumnName("PA_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaMunicipioregistro)
                    .HasColumnName("PA_MUNICIPIOREGISTRO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNacionalidad)
                    .HasColumnName("PA_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaNombres)
                    .HasColumnName("PA_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaNumeroacta)
                    .HasColumnName("PA_NUMEROACTA")
                    .HasColumnType("numeric(5, 0)");

                entity.Property(e => e.PaOficialia)
                    .HasColumnName("PA_OFICIALIA")
                    .HasColumnType("numeric(4, 0)");

                entity.Property(e => e.PaPaisnacimiento)
                    .HasColumnName("PA_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PaPrimerapellido)
                    .HasColumnName("PA_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSegundoapellido)
                    .HasColumnName("PA_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PaSexo)
                    .HasColumnName("PA_SEXO")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.PaTipodocumento)
                    .HasColumnName("PA_TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.PeCurp)
                    .HasColumnName("PE_CURP")
                    .HasMaxLength(18)
                    .IsUnicode(false);

                entity.Property(e => e.PeEdad)
                    .HasColumnName("PE_EDAD")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeEntidadnacimiento)
                    .HasColumnName("PE_ENTIDADNACIMIENTO")
                    .HasColumnType("numeric(2, 0)");

                entity.Property(e => e.PeFechanacimiento)
                    .HasColumnName("PE_FECHANACIMIENTO")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeFechanacimientoInc)
                    .HasColumnName("PE_FECHANACIMIENTO_INC")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.PeLocalidadnacimiento)
                    .HasColumnName("PE_LOCALIDADNACIMIENTO")
                    .HasMaxLength(70)
                    .IsUnicode(false);

                entity.Property(e => e.PeMunicipionacimiento)
                    .HasColumnName("PE_MUNICIPIONACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNacionalidad)
                    .HasColumnName("PE_NACIONALIDAD")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PeNombres)
                    .IsRequired()
                    .HasColumnName("PE_NOMBRES")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PePaisnacimiento)
                    .HasColumnName("PE_PAISNACIMIENTO")
                    .HasColumnType("numeric(3, 0)");

                entity.Property(e => e.PePrimerapellido)
                    .IsRequired()
                    .HasColumnName("PE_PRIMERAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSegundoapellido)
                    .HasColumnName("PE_SEGUNDOAPELLIDO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PeSexo)
                    .IsRequired()
                    .HasColumnName("PE_SEXO")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Tipocadena)
                    .HasColumnName("TIPOCADENA")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.Tipodocumento)
                    .HasColumnName("TIPODOCUMENTO")
                    .HasColumnType("numeric(1, 0)");

                entity.Property(e => e.TmpFecha)
                    .HasColumnName("TMP_FECHA")
                    .HasColumnType("datetime");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
