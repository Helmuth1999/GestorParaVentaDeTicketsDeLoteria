using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.AccesoADatos
{
    public class OperacionesDeSorteos
    {
        public void Agregar(Modelo.Sorteos NuevoSorteo)
        {
            var db = new Context();
            db.Sorteos.Add(NuevoSorteo);

            db.Entry(NuevoSorteo).State = System.Data.Entity.EntityState.Added;

            db.SaveChanges();
        }

        public Modelo.Sorteos ObtenerSorteoPorId(int Id)
        {

            var db = new Context();
            var resultado = db.Sorteos.Find(Id);

            return resultado;
        }

        public void Actualizar(Modelo.Sorteos elSorteo)
        {
            var valorBd = ObtenerSorteoPorId(elSorteo.Id);
            var db = new Context();
            valorBd.Fecha = elSorteo.Fecha;
            valorBd.Estado = elSorteo.Estado;

            db.Entry(valorBd).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }

        public Modelo.Sorteos Consultar(int Id)
        {

            var db = new Context();
            var resultado = db.Sorteos.Find(Id);


            return resultado;
        }

        public List<Modelo.Sorteos> Listar()
        {

            var db = new Context();
            var resultado = db.Sorteos.ToList();


            return resultado;
        }
    }
}
