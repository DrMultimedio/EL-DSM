using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CP.ProyectoVikings;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Controllers
{
    [Authorize(Roles = "usuario")]
    public class BatallaPVPController : BasicController
    {
        //
        // GET: /BatallaPVP/

        public ActionResult Index()
        {
            SessionInitialize();
            Batalla_PVPCAD cad = new Batalla_PVPCAD(session);
            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /BatallaPVP/Details/5

        public ActionResult Details(int id)
        {
            Batalla_PVP ev = null;
            SessionInitialize();
            Batalla_PVPEN evEN = new Batalla_PVPCAD(session).ReadOIDDefault(id);
            ev = new AssemblerBatalla_PVP().ConvertEnToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /BatallaPVP/Create

        public ActionResult Create()
        {

            SessionInitialize();
            //muy posiblemente si falla, es por esto
            Batalla_PVP ev = new Batalla_PVP();
            ev.Jugador.Nombre = User.Identity.Name;

            SessionClose();
            return View(ev);
        }

        //
        // POST: /BatallaPVP/Create

        [HttpPost]
        public ActionResult Create(Batalla_PVP ev)
        {
            try
            {
                JugadorCAD cad = new JugadorCAD();
                Batalla_PVPCEN cen = new Batalla_PVPCEN();
                Batalla_PVPEN even = new Batalla_PVPEN();
                even.Jugador_0 = ev.Jugador2;
                even.Recompensa = ev.Recompensa;
                even.IdGanador = ev.IdGanador;

                even.Jugador = cad.DameJugadorPorNombre(User.Identity.Name);
                cen.New_(even.Jugador.Id, even.Jugador_0.Id, ev.Recompensa, ev.IdGanador);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Batalla_PVP/Edit/5

        public ActionResult Edit(int id)
        {
            Batalla_PVP ev = null;
            SessionInitialize();
            Batalla_PVPEN even = new Batalla_PVPCAD(session).ReadOIDDefault(id);
            ev = new AssemblerBatalla_PVP().ConvertEnToModelUI(even);
            JugadorEN usu = ev.Jugador;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(ev);

        }

        //
        // POST: /Batalla_PVP/Edit/5

        [HttpPost]
        public ActionResult Edit(Batalla_PVP ev)
        {
            try
            {
                Batalla_PVPCEN cen = new Batalla_PVPCEN();

                cen.Modify(ev.id, ev.Recompensa, ev.IdGanador);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Batalla_PVP/Delete/5

        public ActionResult Delete(int id)
        {
            Batalla_PVP ev = null;
            SessionInitialize();
            Batalla_PVPEN even = new Batalla_PVPCAD(session).ReadOIDDefault(id);
            ev = new AssemblerBatalla_PVP().ConvertEnToModelUI(even);
            JugadorEN usu = ev.Jugador;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(ev);
        }

        //
        // POST: /Batalla_PVP/Delete/5

        [HttpPost]
        public ActionResult Delete(Batalla_PVP ev)
        {
            try
            {

                Batalla_PVPCEN cen = new Batalla_PVPCEN();
                cen.Destroy(ev.id);


                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Batalla_PVP/List

        public ActionResult List()
        {
            SessionInitialize();
            Batalla_PVPCAD cad = new Batalla_PVPCAD(session);
            JugadorCAD usucad = new JugadorCAD(session);
            JugadorEN usuen = usucad.DameJugadorPorNombre(User.Identity.Name);
            var aux = cad.ReadAllDefault(0, 0);
            SessionClose();

            return View(aux);
        }
    }
}