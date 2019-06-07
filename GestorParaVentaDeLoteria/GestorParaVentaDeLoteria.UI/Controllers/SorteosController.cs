using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
/*web.conf quitar el string de coneccion de ahi, es solo en el servicio. AREGLAR LA SI porque no hace nada. Terminar mi parte*/
namespace GestorParaVentaDeLoteria.UI.Controllers
{
    public class SorteosController : Controller
    {
        // GET: Sorteos
        [AllowAnonymous]
        public ActionResult Index()
        {

            /*ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();

             var lista = ClienteDeServicioDeSorteo.Listar(); */
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
           var lista= administradorDeSorteos.ListarSorteos();

            return View(lista);
        }

        // GET: Sorteos/Details/5
        [AllowAnonymous]
        public ActionResult Details(int id)
        {
            /* ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
             var sorteoConsultado = ClienteDeServicioDeSorteo.ConsultarSorteo(id);*/

            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            var lista = administradorDeSorteos.ListarHistoricoDeSorteo(id);

            return View(lista);
        }

        // GET: Sorteos/Create
        [AllowAnonymous]
        public ActionResult Create()
        {
            return View();
        }

        // POST: Sorteos/Create
        [HttpPost]
        public ActionResult Create(Modelo.Sorteos elSorteo)
        {
            try
            {

                /*  ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();

                  ClienteDeServicioDeSorteo.Agregar(elSorteo); */
                LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
                administradorDeSorteos.AgreagarSorteo(elSorteo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        [AllowAnonymous]
        public ActionResult ActivarSorteo(int id)
        {
            /*ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
            Modelo.SorteosHistorico elSorteoHistorico = new Modelo.SorteosHistorico();

            elSorteoHistorico = ClienteDeServicioDeSorteo.ConsultarIdDeSorteoHistorico(id);*/
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            Modelo.SorteosHistorico elSorteoHistorico = new Modelo.SorteosHistorico();

            elSorteoHistorico = administradorDeSorteos.ObtenerSorteoHistoricoPorId(id); 

            return View(elSorteoHistorico);
        }

        // POST
        [HttpPost]
        public ActionResult ActivarSorteo(Modelo.SorteosHistorico elSorteoHistorico)
        {
           // try
         //   {
                /* ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
                 ClienteDeServicioDeSorteo.ActivarSorteo(elSorteoHistorico);*/
                LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
                administradorDeSorteos.ActivarSorteo(elSorteoHistorico);
                return RedirectToAction("index", "Sorteos");
       /*     }
            catch
            {
                return View("ERROR ACTV");
            }*/
        }

        [AllowAnonymous]
        public ActionResult InactivarSorteo(int id)
        {
            /*ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
            Modelo.SorteosHistorico elSorteoHistorico = new Modelo.SorteosHistorico();*/
            LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
            Modelo.SorteosHistorico elSorteoHistorico = new Modelo.SorteosHistorico();

            elSorteoHistorico = administradorDeSorteos.ObtenerSorteoHistoricoPorId(id);

            return View(elSorteoHistorico);
        }

        // POST
        [HttpPost]
        public ActionResult InactivarSorteo(Modelo.SorteosHistorico elSorteoHistorico)
        {
            try
            {
                /* ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
                 ClienteDeServicioDeSorteo.InactivarSorteo(elSorteoHistorico);*/
                LogicaDeNegocio.AdministradorDeSorteos administradorDeSorteos = new LogicaDeNegocio.AdministradorDeSorteos();
                administradorDeSorteos.InactivarSorteo(elSorteoHistorico);
                return RedirectToAction("index", "Sorteos");
            }
            catch
            {
                return View("ERROR INAC");
            }
        }

    

    }
}
