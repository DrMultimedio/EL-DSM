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
    public class ObjetoController : BasicController
    {
        //
        // GET: /Objeto/

        public ActionResult Index()
        {
            SessionInitialize();
            ObjetoCAD cad = new ObjetoCAD(session);
            var aux = cad.ReadAll(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Objeto/Details/5

        public ActionResult Details(int id)
        {
            Objeto ev = null;
            SessionInitialize();
            ObjetoEN evEN = new ObjetoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerObjeto().ConvertEnToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /Objeto/Create

        public ActionResult Create()
        {

            SessionInitialize();
            //muy posiblemente si falla, es por esto
            Objeto ev = new Objeto();

            SessionClose();
            return View(ev);
        }

        //
        // POST: /Objeto/Create

        [HttpPost]
        public ActionResult Create(Objeto ev)
        {
            try
            {
                JugadorCAD cad = new JugadorCAD();
                ObjetoCEN cen = new ObjetoCEN();
                ObjetoEN even = new ObjetoEN();
                even.Ataque = ev.Ataque;
                even.Defensa = ev.Defensa;
                even.Tipo = ev.Tipo;

                even.Inventario = ev.Inventarios;
                even.Equipo = ev.InventarioEq;
                even.Nombre = ev.Nombre;
                even.Id = ev.id;
                even.Precio = ev.Precio;
                cen.New_(even.Nombre, even.Precio, even.Tipo, even.Ataque, even.Defensa);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Objeto/Edit/5

        public ActionResult Edit(int id)
        {
            Objeto ev = null;
            SessionInitialize();
            ObjetoEN even = new ObjetoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerObjeto().ConvertEnToModelUI(even);

            SessionClose();
            return View(ev);

        }

        //
        // POST: /Objeto/Edit/5

        [HttpPost]
        public ActionResult Edit(Objeto ev)
        {
            try
            {
                ObjetoCEN cen = new ObjetoCEN();

                cen.Modify(ev.id, ev.Nombre, ev.Precio, ev.Tipo, ev.Ataque, ev.Defensa);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Objeto/Delete/5

        public ActionResult Delete(int id)
        {
            Objeto ev = null;
            SessionInitialize();
            ObjetoEN even = new ObjetoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerObjeto().ConvertEnToModelUI(even);

            SessionClose();
            return View(ev);
        }

        //
        // POST: /Objeto/Delete/5

        [HttpPost]
        public ActionResult Delete(Objeto ev)
        {
            try
            {

                ObjetoCEN cen = new ObjetoCEN();
                cen.Destroy(ev.id);


                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Objeto/List

        public ActionResult List()
        {
            SessionInitialize();
            ObjetoCAD cad = new ObjetoCAD(session);

            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }
    }
}
