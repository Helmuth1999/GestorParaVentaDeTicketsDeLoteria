using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.AccesoADatos
{

        public class Context : DbContext
        {

            protected override void OnModelCreating(DbModelBuilder modelBuilder)
            {
               modelBuilder.Entity<GestorParaVentaDeLoteria.Modelo.Sorteos>().ToTable("Sorteos");
               modelBuilder.Entity<GestorParaVentaDeLoteria.Modelo.SorteosHistorico>().ToTable("SorteosHistorico");
        }
            public DbSet<GestorParaVentaDeLoteria.Modelo.Sorteos> Sorteos { get; set; }
        public DbSet<GestorParaVentaDeLoteria.Modelo.SorteosHistorico> SorteosHistorico { get; set; }
    }
}
