using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.AccesoADatos
{
    public class OperacionesDeSorteosHistorico
    {
        public void Agregar(Modelo.SorteosHistorico NuevoSorteoHistorico)
        {
            var db = new Context();
            db.SorteosHistorico.Add(NuevoSorteoHistorico);

            db.Entry(NuevoSorteoHistorico).State = System.Data.Entity.EntityState.Added;

            db.SaveChanges();
        }

        public Modelo.SorteosHistorico ObtenerSorteoHistoricoPorId(int Id)
        {

            var db = new Context();
            var resultado = db.SorteosHistorico.Find(Id);

            return resultado;
        }

        public List<Modelo.SorteosHistorico> ObtenerListaConElHistoricoDelSorteo(int idSorteo)
        {
            var db = new Context();

            var resultado = from c in db.SorteosHistorico
                            where c.IdSorteo == idSorteo

                            select c;
            return resultado.ToList();
        }
    }
}
