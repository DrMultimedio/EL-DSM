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
    [Authorize(Roles = "usuario")]

    public class JugadorController : BasicController
    {
        //
        // GET: /Jugador/

        public ActionResult Index()
        {
            if (Roles.IsUserInRole("usuario"))
            {
                SessionInitialize();
                JugadorCAD cad = new JugadorCAD(session);
                var aux = cad.ReadAllDefault(0, -1).ToList();
                var aux2 = new List<JugadorEN>();
                foreach (JugadorEN element in aux)
                {
                    if (!Roles.IsUserInRole("admin"))
                    {
                        aux2.Add(element);
                    }
                }
                SessionClose();

                return View(aux2);
            }
            return RedirectToAction("Index", "Home");

        }
        public ActionResult Index2()
        {
            if (Roles.IsUserInRole("usuario"))
            {
                SessionInitialize();
                JugadorCAD cad = new JugadorCAD(session);
                var aux = cad.ReadAllDefault(0, -1).ToList();
                var aux2 = new List<JugadorEN>();
                foreach (JugadorEN element in aux)
                {
                    if (Roles.IsUserInRole("admin"))
                    {
                        aux2.Add(element);
                    }
                }
                SessionClose();

                return View(aux2);
            }
            return RedirectToAction("Index", "Home");

        }

        //
        // GET: /Jugador/Details/5

        public ActionResult Details(int id)
        {
            Jugador usu = null;
            JugadorEN usuEN;
            SessionInitialize();
            if (id <= 0)
            {
                usuEN = new JugadorCAD(session).ReadOID(id);
            }
            else
            {
                usuEN = new JugadorCAD(session).ReadOIDDefault(id);
            }
            usu = new AssemblerJugador().ConvertEnToModelUI(usuEN);

            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            SessionClose();
            return View(usu);

        }

        //
        // GET: /Jugador/Create

        public ActionResult Create()
        {
            if (Roles.IsUserInRole("admin"))
            {
                Jugador usu = new Jugador();

                return View(usu);
            }
            return RedirectToAction("Index", "Home");
        }

        //
        // POST: /Jugador/Create

        [HttpPost]
        public ActionResult Create(Jugador model)
        {
            WebSecurity.CreateUserAndAccount(model.Nombre, model.Contrasena);
            if (!Roles.RoleExists("usuario"))
            {
                Roles.CreateRole("usuario");
            }
            if (!Roles.RoleExists("admin"))
            {
                Roles.CreateRole("admin");
            }
            if (ModelState.IsValid)
            {

                
                try
                {
                    JugadorCEN usu = new JugadorCEN();
                    JugadorEN usuen = new JugadorEN();
                    usuen.Password = model.Contrasena;
                    usuen.Cumple= model.Fecha;
                    usuen.Email = model.Email;
                   

                    usu.Registro(usuen);
                    Roles.AddUserToRole(model.Nombre, "usuario");
                    WebSecurity.Login(model.Nombre, model.Contrasena);


                    return RedirectToAction("Index");
                }
                catch
                {
                    return View();
                }
            }

            // Si llegamos a este punto, es que se ha producido un error y volvemos a mostrar el formulario
            return View(model);
        }

        //
        // GET: /Jugador/Edit/5

        public ActionResult Edit(int id)
        {
            Jugador usu = null;
            SessionInitialize();
            JugadorEN usuen = new JugadorCAD(session).ReadOIDDefault(id);
            usu = new AssemblerJugador().ConvertEnToModelUI(usuen);

            if (User.Identity.Name != usu.Nombre && !Roles.IsUserInRole("admin"))
            {
                return RedirectToAction("Index", "Home");
            }
            SessionClose();
            return View(usu);
        }

        //
        // POST: /Jugador/Edit/5

        [HttpPost]
        public ActionResult Edit(Jugador usu)
        {

          
            try
            {
                JugadorCEN cen = new JugadorCEN();
                
             
                cen.Modify(usu.id, usu.Nombre, usu.Email, usu.Fecha, usu.Genero, usu.Vidamax, usu.VidaAct, usu.Ataque, usu.Defensa, usu.Oro,usu.Contrasena);
                return RedirectToAction("Details", new { id = usu.id });
            }
            catch
            {
                return View();
            }
        }



        //
        // GET: /Jugador/Delete/5

        public ActionResult Delete(int id)
        {
            SessionInitialize();
            JugadorCAD usuCAD = new JugadorCAD(session);
            JugadorCEN cen = new JugadorCEN(usuCAD);
            JugadorEN usuEN = usuCAD.ReadOID(id);
            Jugador usu = new AssemblerJugador().ConvertEnToModelUI(usuEN);
            SessionClose();

            if (User.Identity.Name == usuEN.Nombre || Roles.IsUserInRole("admin"))
            {
                return View(usu);
            }
            return RedirectToAction("Index", "Home");

        }

        //
        // POST: /Jugador/Delete/5

        [HttpPost]
        public ActionResult Delete(Jugador usu)
        {
            try
            {
                new JugadorCEN().Destroy(usu.id);
                Membership.DeleteUser(User.Identity.Name);
                WebSecurity.Logout();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}