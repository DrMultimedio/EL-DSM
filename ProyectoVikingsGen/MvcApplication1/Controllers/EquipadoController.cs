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
    public class EquipoController : BasicController
    {
        //
        // GET: /Equipo/

        public ActionResult Index()
        {
            SessionInitialize();
            EquipoCAD cad = new EquipoCAD(session);
            var aux = cad.ReadAllDefault(0, 0);

            SessionClose();

            return View(aux);
        }

        //
        // GET: /Equipo/Details/5

        public ActionResult Details(int id)
        {
            Equipo ev = null;
            SessionInitialize();
            EquipoEN evEN = new EquipoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEquipo().ConvertEnToModelUI(evEN);
            SessionClose();
            return View(ev);
        }

        //
        // GET: /Equipo/Create

        public ActionResult Create()
        {

            SessionInitialize();
            //muy posiblemente si falla, es por esto
            Equipo ev = new Equipo();
            ev.Jugador.Nombre = User.Identity.Name;

            SessionClose();
            return View(ev);
        }

        //
        // POST: /Equipo/Create

        [HttpPost]
        public ActionResult Create(Equipo ev)
        {
            try
            {
                JugadorCAD cad = new JugadorCAD();
                EquipoCEN cen = new EquipoCEN();
                EquipoEN even = new EquipoEN();
                even.ArmaEquipada = ev.ArmaEquipada;
                even.CascoEquipado = ev.CascoEquipado;
                even.GrebasEquipadas= ev.GrebasEquipadas;
                even.Id = ev.id;
                even.Objeto = ev.Objetos;
                even.PecheraEquipada = ev.PecheraEquipada;

                even.Jugador = cad.DameJugadorPorNombre(User.Identity.Name);
                cen.New_(even.Jugador.Id, even.ArmaEquipada, even.PecheraEquipada, even.GrebasEquipadas,even.CascoEquipado);

                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }


        //
        // GET: /Equipo/Edit/5

        public ActionResult Edit(int id)
        {
            Equipo ev = null;
            SessionInitialize();
            EquipoEN even = new EquipoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEquipo().ConvertEnToModelUI(even);
            JugadorEN usu = ev.Jugador;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(ev);

        }

        //
        // POST: /Equipo/Edit/5

        [HttpPost]
        public ActionResult Edit(Equipo ev)
        {
            try
            {
                EquipoCEN cen = new EquipoCEN();

                cen.Modify(ev.id, ev.ArmaEquipada, ev.PecheraEquipada, ev.GrebasEquipadas, ev.CascoEquipado);
                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Equipo/Delete/5

        public ActionResult Delete(int id)
        {
            Equipo ev = null;
            SessionInitialize();
            EquipoEN even = new EquipoCAD(session).ReadOIDDefault(id);
            ev = new AssemblerEquipo().ConvertEnToModelUI(even);
            JugadorEN usu = ev.Jugador;
            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Details", new { id = id });
            }
            SessionClose();
            return View(ev);
        }

        //
        // POST: /Equipo/Delete/5

        [HttpPost]
        public ActionResult Delete(Equipo ev)
        {
            try
            {

                EquipoCEN cen = new EquipoCEN();
                cen.Destroy(ev.id);


                return RedirectToAction("List");
            }
            catch
            {
                return View();
            }
        }

        //
        // GET: /Equipo/List

        public ActionResult List()
        {

            //list para que me devuelva la lista de Equipos del jugador
            SessionInitialize();
            EquipoCAD cad = new EquipoCAD(session);
            JugadorCAD usucad = new JugadorCAD(session);
            JugadorEN usuen = usucad.DameJugadorPorNombre(User.Identity.Name);
            var aux = cad.ReadAllDefault(0,0);          
            SessionClose();


            return View(aux);
        }
    }
}