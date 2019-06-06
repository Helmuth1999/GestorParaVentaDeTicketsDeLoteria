using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using GestorParaVentaDeLoteria.Modelo;
namespace GestorParaVentaDeLoteria.AccesoADatos
{
    

    public class Context : DbContext
    {

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AspNetRoles>().ToTable("AspNetRoles");
            modelBuilder.Entity<AspNetUserClaims>().ToTable("AspNetUserClaims");
            modelBuilder.Entity<AspNetUserLogins>().ToTable("AspNetUserLogins");
            modelBuilder.Entity<AspNetUsers>().ToTable("AspNetUsers");
            modelBuilder.Entity<SorteoDetalleVentas>().ToTable("SorteoDetalleVentas");
            modelBuilder.Entity<Sorteos>().ToTable("Sorteos");
            modelBuilder.Entity<SorteosDetalleVentas>().ToTable("SorteosDetalleVentas");
            modelBuilder.Entity<SorteosHistorico>().ToTable("SorteosHistorico");
            modelBuilder.Entity<SorteosRestriciones>().ToTable("SorteosRestriciones");
        }

        public DbSet<AspNetRoles> AspNetRoles { get; set; }
        public DbSet<AspNetUserClaims> AspNetUserClaims { get; set; }
        public DbSet<AspNetUserLogins> AspNetUserLogins { get; set; }
        public DbSet<AspNetUsers> AspNetUsers { get; set; }
        public DbSet<SorteoDetalleVentas> SorteoDetalleVentas { get; set; }
        public DbSet<Sorteos> Sorteos { get; set; }
        public DbSet<SorteosDetalleVentas> SorteosDetalleVentas { get; set; }
        public DbSet<SorteosHistorico> SorteosHistorico { get; set; }
        public DbSet<SorteosRestriciones> SorteosRestriciones { get; set; }
    }
}
