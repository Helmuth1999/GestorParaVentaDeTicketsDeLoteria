namespace GestorParaVentaDeLoteria.AccesoADatos
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using GestorParaVentaDeLoteria.Modelo;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; }
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; }
        public virtual DbSet<SorteoDetalleVentas> SorteoDetalleVentas { get; set; }
        public virtual DbSet<Sorteos> Sorteos { get; set; }
        public virtual DbSet<SorteosDetalleVentas> SorteosDetalleVentas { get; set; }
        public virtual DbSet<SorteosHistorico> SorteosHistorico { get; set; }
        public virtual DbSet<SorteosRestriciones> SorteosRestriciones { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>()
                .HasMany(e => e.AspNetUsers)
                .WithMany(e => e.AspNetRoles)
                .Map(m => m.ToTable("AspNetUserRoles").MapLeftKey("RoleId").MapRightKey("UserId"));

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserClaims)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.AspNetUserLogins)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<AspNetUsers>()
                .HasMany(e => e.SorteosDetalleVentas)
                .WithRequired(e => e.AspNetUsers)
                .HasForeignKey(e => e.Id_AspNetUser)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SorteoDetalleVentas>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Sorteos>()
                .HasMany(e => e.SorteoDetalleVentas)
                .WithRequired(e => e.Sorteos)
                .HasForeignKey(e => e.IdSorteos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sorteos>()
                .HasMany(e => e.SorteosDetalleVentas)
                .WithRequired(e => e.Sorteos)
                .HasForeignKey(e => e.IdSorteos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sorteos>()
                .HasMany(e => e.SorteosHistorico)
                .WithRequired(e => e.Sorteos)
                .HasForeignKey(e => e.IdSorteo)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Sorteos>()
                .HasMany(e => e.SorteosRestriciones)
                .WithRequired(e => e.Sorteos)
                .HasForeignKey(e => e.IdSorteos)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<SorteosDetalleVentas>()
                .Property(e => e.Monto)
                .HasPrecision(19, 4);

            modelBuilder.Entity<SorteosHistorico>()
                .Property(e => e.DescripcionDeLaModificacion)
                .IsUnicode(false);

            modelBuilder.Entity<SorteosRestriciones>()
                .Property(e => e.MontoMáximo)
                .HasPrecision(19, 4);
        }
    }
}
