using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace GestorParaVentaDeLoteria.SI
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "ServicioDeSorteo" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione ServicioDeSorteo.svc o ServicioDeSorteo.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class ServicioDeSorteo : IServicioDeSorteo
    {
        public List<Modelo.Sorteos> Listar()
        {
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            return administradorDeSorteos.ListarSorteos();
        }

        public void Agregar(Modelo.Sorteos item)
        {
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            administradorDeSorteos.AgreagarSorteo(item);
        }

        public void ActivarSorteo(Modelo.SorteosHistorico item)
        {
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            administradorDeSorteos.ActivarSorteo(item);
        }

        public void InactivarSorteo(Modelo.SorteosHistorico item)
        {
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            administradorDeSorteos.InactivarSorteo(item);
        }

        public Modelo.SorteosHistorico ConsultarIdDeSorteoHistorico(int Id)
        {

            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();

            return administradorDeSorteos.ConsultarIdDeSorteoHistorico(Id);
        }


        public Modelo.Sorteos ConsultarSorteo(int idSorteo)
        {

            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();

            return administradorDeSorteos.ConsultarSorteo(idSorteo);
        }

        public List<Modelo.SorteosHistorico> ListarHistoricoDeSorteo(int idSorteo)
        {
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            return administradorDeSorteos.ListarHistoricoDeSorteo(idSorteo);
        }



    }
}
