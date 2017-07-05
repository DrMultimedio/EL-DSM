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
    public class MonstruoController : BasicController
    {
        //
        // GET: /BatallaPVE/

        public ActionResult Index()
        {
            SessionInitialize();
            MonstruoCAD cad = new MonstruoCAD(session);
            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /BatallaPVE/Details/5

        public ActionResult Details(int id)
        {
            Monstruo ev = null;
            SessionInitialize();
            MonstruoEN evEN = new MonstruoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerMonstruo().ConvertEnToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /BatallaPVE/Create

        public ActionResult Create()
        {

            SessionInitialize();
            //muy posiblemente si falla, es por esto
            Monstruo ev = new Monstruo();
            

            SessionClose();
            return View(ev);
        }

        //
        // POST: /BatallaPVE/Create

        [HttpPost]
        public ActionResult Create(Monstruo ev)
        {
            try
            {
                JugadorCAD cad = new JugadorCAD();
                MonstruoCEN cen = new MonstruoCEN();
                MonstruoEN even = new MonstruoEN();
                even.Ataque= ev.Ataque;
                even.Defensa= ev.Defensa;
                even.Vida = ev.Vida;
                even.Nombre = ev.Nombre;

                
                cen.New_(even.Nombre, even.Vida, ev.Ataque, ev.Defensa);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Monstruo/Edit/5

        public ActionResult Edit(int id)
        {
            Monstruo ev = null;
            SessionInitialize();
            MonstruoEN even = new MonstruoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerMonstruo().ConvertEnToModelUI(even);
            SessionClose();
            return View(ev);

        }

        //
        // POST: /Monstruo/Edit/5

        [HttpPost]
        public ActionResult Edit(Monstruo ev)
        {
            try
            {
                MonstruoCEN cen = new MonstruoCEN();

                cen.Modify(ev.id, ev.Nombre, ev.Vida,ev.Ataque,ev.Defensa);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Monstruo/Delete/5

        public ActionResult Delete(int id)
        {
            Monstruo ev = null;
            SessionInitialize();
            MonstruoEN even = new MonstruoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerMonstruo().ConvertEnToModelUI(even);
 
            SessionClose();
            return View(ev);
        }

        //
        // POST: /Monstruo/Delete/5

        [HttpPost]
        public ActionResult Delete(Monstruo ev)
        {
            try
            {

                MonstruoCEN cen = new MonstruoCEN();
                cen.Destroy(ev.id);


                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Monstruo/List

        public ActionResult List()
        {
            SessionInitialize();
            MonstruoCAD cad = new MonstruoCAD(session);

            var aux = cad.ReadAllDefault(0,0);

            SessionClose();

            return View(aux);
        }
    }
}