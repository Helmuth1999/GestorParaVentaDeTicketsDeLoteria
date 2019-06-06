using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestorParaVentaDeLoteria.LogicaDeNegocio
{
    public class AdministradorDeSorteos
    {
        public void AgreagarSorteo(Modelo.Sorteos elSorteo)
        {
            AccesoADatos.OperacionesDeSorteos operacionesDeSorteos = new AccesoADatos.OperacionesDeSorteos();
            elSorteo.Estado = Modelo.Estado.Activo;

            operacionesDeSorteos.Agregar(elSorteo);

            Modelo.SorteosHistorico elsorteosHistorico= new Modelo.SorteosHistorico();
            AccesoADatos.OperacionesDeSorteosHistorico operacionesDeSorteosHistorico = new AccesoADatos.OperacionesDeSorteosHistorico();
            elsorteosHistorico.IdSorteo = elSorteo.Id;
            elsorteosHistorico.Id_AspNetUser = "a";//////////////ARREGLAR
            elsorteosHistorico.TipoDeModificacion = Modelo.TipoDeModificacion.Insercion;
            elsorteosHistorico.FechaDeModificacion = DateTime.Now;
            elsorteosHistorico.DescripcionDeLaModificacion = "Registro de sorteo";

            operacionesDeSorteosHistorico.Agregar(elsorteosHistorico);

        }

        public void ActivarSorteo(Modelo.SorteosHistorico sorteosHistorico)
        {
            AccesoADatos.OperacionesDeSorteos operacionesDeSorteos = new AccesoADatos.OperacionesDeSorteos();

            Modelo.Sorteos elsorteoAModificar;
            elsorteoAModificar = operacionesDeSorteos.ObtenerSorteoPorId(sorteosHistorico.IdSorteo);
            elsorteoAModificar.Estado = Modelo.Estado.Activo;
            operacionesDeSorteos.Actualizar(elsorteoAModificar);

            AccesoADatos.OperacionesDeSorteosHistorico operacionesDeSorteosHistorico = new AccesoADatos.OperacionesDeSorteosHistorico();

            Modelo.SorteosHistorico elsorteosHistoricoAModificar;
            elsorteosHistoricoAModificar = ConsultarSortesHistoricoPorId(sorteosHistorico.Id);
            elsorteosHistoricoAModificar.IdSorteo = sorteosHistorico.IdSorteo;
            elsorteosHistoricoAModificar.Id_AspNetUser = "a";//////////////ARREGLAR
            elsorteosHistoricoAModificar.TipoDeModificacion = Modelo.TipoDeModificacion.Activacion;
            elsorteosHistoricoAModificar.FechaDeModificacion = DateTime.Now;
            elsorteosHistoricoAModificar.DescripcionDeLaModificacion = sorteosHistorico.DescripcionDeLaModificacion;

            operacionesDeSorteosHistorico.Agregar(elsorteosHistoricoAModificar);
        }

        public Modelo.SorteosHistorico ConsultarSortesHistoricoPorId(int Id)
        {
            AccesoADatos.OperacionesDeSorteosHistorico operacionesDeSorteosHistorico = new AccesoADatos.OperacionesDeSorteosHistorico();
            return operacionesDeSorteosHistorico.ObtenerSorteoHistoricoPorId(Id);
        }

        public void	InactivarSorteo(Modelo.SorteosHistorico sorteosHistorico)
        {
            AccesoADatos.OperacionesDeSorteos operacionesDeSorteos = new AccesoADatos.OperacionesDeSorteos();

            Modelo.Sorteos elsorteoAModificar;
            elsorteoAModificar = operacionesDeSorteos.ObtenerSorteoPorId(sorteosHistorico.IdSorteo);
            elsorteoAModificar.Estado = Modelo.Estado.Inactivo;
            operacionesDeSorteos.Actualizar(elsorteoAModificar);

            AccesoADatos.OperacionesDeSorteosHistorico operacionesDeSorteosHistorico = new AccesoADatos.OperacionesDeSorteosHistorico();

            Modelo.SorteosHistorico elsorteosHistoricoAModificar;
            elsorteosHistoricoAModificar = ConsultarSortesHistoricoPorId(sorteosHistorico.Id);
            elsorteosHistoricoAModificar.IdSorteo = sorteosHistorico.IdSorteo;
            elsorteosHistoricoAModificar.Id_AspNetUser = "a";//////////////ARREGLAR
            elsorteosHistoricoAModificar.TipoDeModificacion = Modelo.TipoDeModificacion.Inactivacion;
            elsorteosHistoricoAModificar.FechaDeModificacion = DateTime.Now;
            elsorteosHistoricoAModificar.DescripcionDeLaModificacion = sorteosHistorico.DescripcionDeLaModificacion;

            operacionesDeSorteosHistorico.Agregar(elsorteosHistoricoAModificar);
        }

        public Modelo.Sorteos ConsultarSorteo(int Id)
        {

            AccesoADatos.OperacionesDeSorteos operacionesDeSorteos= new AccesoADatos.OperacionesDeSorteos();

            return operacionesDeSorteos.Consultar(Id);
        }

        public List<Modelo.Sorteos> ListarSorteos()
        {
            AccesoADatos.OperacionesDeSorteos operacionesDeSorteos = new AccesoADatos.OperacionesDeSorteos();

            return operacionesDeSorteos.Listar();
        }

        public List<Modelo.SorteosHistorico> ListarHistoricoDeSorteo( int idSorteo)
        {
            AccesoADatos.OperacionesDeSorteosHistorico operacionesDeSorteosHistorico = new AccesoADatos.OperacionesDeSorteosHistorico();
            return operacionesDeSorteosHistorico.ObtenerListaConElHistoricoDelSorteo(idSorteo);
        }
    }
}
