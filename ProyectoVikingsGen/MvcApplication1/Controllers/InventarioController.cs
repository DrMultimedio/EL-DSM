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
    public class InventarioController : BasicController
    {
        //
        // GET: /BatallaPVE/

        public ActionResult Index()
        {
            SessionInitialize();
            InventarioCAD cad = new InventarioCAD(session);
            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /BatallaPVE/Details/5

        public ActionResult Details(int id)
        {
            Inventario ev = null;
            SessionInitialize();
            InventarioEN evEN = new InventarioCAD(session).ReadOIDDefault(id);
            ev = new AssemblerInventario().ConvertEnToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /BatallaPVE/Create

        public ActionResult Create()
        {

            SessionInitialize();
            //muy posiblemente si falla, es por esto
            Inventario ev = new Inventario();


            SessionClose();
            return View(ev);
        }

        //
        // POST: /BatallaPVE/Create

        [HttpPost]
        public ActionResult Create(Inventario ev)
        {
            try
            {
                JugadorCAD cad = new JugadorCAD();
                InventarioCEN cen = new InventarioCEN();
                InventarioEN even = new InventarioEN();
                even.InvMax = ev.invMax;
                even.Objeto= ev.Objetos;
                

                even.Jugador = cad.DameJugadorPorNombre(User.Identity.Name);
                cen.New_(even.InvMax,even.Jugador.Id);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Inventario/Edit/5

        public ActionResult Edit(int id)
        {
            Inventario ev = null;
            SessionInitialize();
            InventarioEN even = new InventarioCAD(session).ReadOIDDefault(id);
            ev = new AssemblerInventario().ConvertEnToModelUI(even);
            SessionClose();
            return View(ev);

        }

        //
        // POST: /Inventario/Edit/5

        [HttpPost]
        public ActionResult Edit(Inventario ev)
        {
            try
            {
                InventarioCEN cen = new InventarioCEN();

                cen.Modify(ev.id, ev.invMax);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Inventario/Delete/5

        public ActionResult Delete(int id)
        {
            Inventario ev = null;
            SessionInitialize();
            InventarioEN even = new InventarioCAD(session).ReadOIDDefault(id);
            ev = new AssemblerInventario().ConvertEnToModelUI(even);

            SessionClose();
            return View(ev);
        }

        //
        // POST: /Inventario/Delete/5

        [HttpPost]
        public ActionResult Delete(Inventario ev)
        {
            try
            {

                InventarioCEN cen = new InventarioCEN();
                cen.Destroy(ev.id);


                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Inventario/List

        public ActionResult List()
        {
            SessionInitialize();
            InventarioCAD cad = new InventarioCAD(session);

            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }
    }
}