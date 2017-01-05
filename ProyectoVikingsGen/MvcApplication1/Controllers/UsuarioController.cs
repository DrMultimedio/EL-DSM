using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApplication1.Controllers
{
    public class UsuarioController : BasicController
    {
        // Anyadir BasicController en vez de Controller a la linea 9
        // GET: /Usuario/

        public ActionResult Index()
        {
            // JugadorCEN jugador = new JugadorCEN();
            SessionInitialize();
            JugadorCAD jugador = new JugadorCAD(session);
            IList<JugadorEN> list = jugador.ReadAllDefault(0,10).ToList();
            SessionClose();
            return View(list);
        }

        //
        // GET: /Usuario/Details/5

        public ActionResult Details(int id)
        {
            return View();
        }

        //
        // GET: /Usuario/Create

        public ActionResult Create()
        {
            JugadorEN jugador = new JugadorEN();
            return View(jugador);
        }

        //
        // POST: /Usuario/Create

        [HttpPost]
        public ActionResult Create(JugadorEN jugador)
        {
            try
            {
                // TODO: Add insert logic here
                // SessionInitialize();
                JugadorCAD cad = new JugadorCAD(session);
                var resp = cad.New_(jugador);
                // SessionClose();

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Usuario/Edit/5

        public ActionResult Edit(int id)
        {
            return View();
        }

        //
        // POST: /Usuario/Edit/5

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

        //
        // GET: /Usuario/Delete/5

        public ActionResult Delete(int id)
        {
            return View();
        }

        //
        // POST: /Usuario/Delete/5

        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
