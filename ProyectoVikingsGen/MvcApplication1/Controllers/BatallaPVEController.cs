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
    public class BatallaPVEController : BasicController
    {
        //
        // GET: /BatallaPVE/
       
        public ActionResult Index()
        {
            SessionInitialize();
            Batalla_PVECAD cad = new Batalla_PVECAD(session);
            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /BatallaPVE/Details/5

        public ActionResult Details(int id)
        {
            Batalla_PVE ev = null;
            SessionInitialize();
            Batalla_PVEEN evEN = new Batalla_PVECAD(session).ReadOIDDefault(id);
            ev = new AssemblerBatallaPVE().ConvertEnToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /BatallaPVE/Create

        public ActionResult Create()
        {

            SessionInitialize();
            //muy posiblemente si falla, es por esto
            Batalla_PVE ev = new Batalla_PVE();
            ev.Jugador.Nombre = User.Identity.Name;

            SessionClose();
            return View(ev);
        }

        //
        // POST: /BatallaPVE/Create

        [HttpPost]
        public ActionResult Create(Batalla_PVE ev)
        {
            try
            {
                JugadorCAD cad = new JugadorCAD();
                Batalla_PVECEN cen = new Batalla_PVECEN();
                Batalla_PVEEN even = new Batalla_PVEEN();
                even.Monstruo = ev.Monstruo;
                even.Recompensa = ev.Recompensa;
                even.TipoGanador = ev.tipoGanador;

                even.Jugador = cad.DameJugadorPorNombre(User.Identity.Name);
                cen.New_(even.Monstruo.Id, even.Jugador.Id, ev.Recompensa, ev.tipoGanador);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }
    

        //
        // GET: /Batalla_PVE/Edit/5

        public ActionResult Edit(int id)
    {
        Batalla_PVE ev = null;
        SessionInitialize();
        Batalla_PVEEN even = new Batalla_PVECAD(session).ReadOIDDefault(id);
        ev = new AssemblerBatallaPVE().ConvertEnToModelUI(even);
        JugadorEN usu = ev.Jugador;
        if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))                
        {
            return RedirectToAction("Details", new { id = id });
        }
        SessionClose();
        return View(ev);

    }

    //
    // POST: /Batalla_PVE/Edit/5

    [HttpPost]
        public ActionResult Edit(Batalla_PVE ev)
        {
            try
            {
                Batalla_PVECEN cen = new Batalla_PVECEN();

                cen.Modify(ev.id, ev.Recompensa, ev.tipoGanador);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Batalla_PVE/Delete/5

        public ActionResult Delete(int id)
        {
            Batalla_PVE ev = null;
            SessionInitialize();
            Batalla_PVEEN even = new Batalla_PVECAD(session).ReadOIDDefault(id);
            ev = new AssemblerBatallaPVE().ConvertEnToModelUI(even);
            JugadorEN usu = ev.Jugador;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(ev);
        }

        //
        // POST: /Batalla_PVE/Delete/5

        [HttpPost]
        public ActionResult Delete(Batalla_PVE ev)
        {
            try
            {

                Batalla_PVECEN cen = new Batalla_PVECEN();
                cen.Destroy(ev.id);
                

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Batalla_PVE/List

        public ActionResult List()
        {
            SessionInitialize();
            Batalla_PVECAD cad = new Batalla_PVECAD(session);
            JugadorCAD usucad = new JugadorCAD(session);
            JugadorEN usuen = usucad.DameJugadorPorNombre(User.Identity.Name);
            var aux = cad.ReadAll(0, 0);

            SessionClose();

            return View(aux);
        }
    }
}