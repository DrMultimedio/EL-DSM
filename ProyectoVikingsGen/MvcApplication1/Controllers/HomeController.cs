using MvcApplication1.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using WebMatrix.WebData;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CP.ProyectoVikings;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Controllers
{
    public class HomeController : BasicController
    {
        public ActionResult Index()
        {
            SessionInitialize();
            Batalla_PVECAD pve = new Batalla_PVECAD(session);
            var aux = pve.ReadAll(0, 20);
            Batalla_PVECAD pvp= new Batalla_PVECAD(session);
            var aux2 = pvp.ReadAll(0, 20);
            JugadorCAD jug = new JugadorCAD(session);
            var aux3 = jug.ReadAllDefault(0, 20);

            ViewData["BatallaPVEs"] = aux;
            ViewData["BatallaPVPs"] = aux2;
            ViewData["Jugadores"] = aux3;

            SessionClose();

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}