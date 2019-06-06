using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GestorParaVentaDeLoteria.UI.Controllers
{
    public class SorteosController : Controller
    {
        // GET: Sorteos
        public ActionResult Index()
        {

            ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();

            var lista = ClienteDeServicioDeSorteo.Listar();

            return View(lista);
        }

        // GET: Sorteos/Details/5
        public ActionResult Details(int id)
        {
            ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
            var sorteoConsultado = ClienteDeServicioDeSorteo.ConsultarSorteo(id);
            return View(sorteoConsultado);
        }

        // GET: Sorteos/Create
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

                ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();

                ClienteDeServicioDeSorteo.Agregar(elSorteo);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Sorteos/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Sorteos/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult ActivarSorteo(int id)
        {
            ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
            Modelo.SorteosHistorico elSorteoHistorico = new Modelo.SorteosHistorico();

            elSorteoHistorico = ClienteDeServicioDeSorteo.ConsultarIdDeSorteoHistorico(id);

            return View(elSorteoHistorico);
        }

        // POST
        [HttpPost]
        public ActionResult ActivarSorteo(Modelo.SorteosHistorico elSorteoHistorico)
        {
            try
            {
                ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
                ClienteDeServicioDeSorteo.ActivarSorteo(elSorteoHistorico);
                return RedirectToAction("index", "Sorteos");
            }
            catch
            {
                return View();
            }
        }


        public ActionResult InactivarSorteo(int id)
        {
            ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
            Modelo.SorteosHistorico elSorteoHistorico = new Modelo.SorteosHistorico();

            elSorteoHistorico = ClienteDeServicioDeSorteo.ConsultarIdDeSorteoHistorico(id);

            return View(elSorteoHistorico);
        }

        // POST
        [HttpPost]
        public ActionResult InactivarSorteo(Modelo.SorteosHistorico elSorteoHistorico)
        {
            try
            {
                ServicioDeSorteo.ServicioDeSorteoClient ClienteDeServicioDeSorteo = new ServicioDeSorteo.ServicioDeSorteoClient();
                ClienteDeServicioDeSorteo.InactivarSorteo(elSorteoHistorico);
                return RedirectToAction("index", "Sorteos");
            }
            catch
            {
                return View();
            }
        }


    }
}
