using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models

{
    public class AssemblerMonstruo
    {

        //modificar model y añadir variables de composicion
        public Monstruo ConvertEnToModelUI(MonstruoEN en)
        {
            Monstruo c = new Monstruo();
            c.id = en.Id;
            c.Ataque = en.Ataque;
            c.Defensa = en.Defensa;
            c.Nombre = en.Nombre;
            c.Vida = en.Vida;
            c.Batalla_PVE = en.Batalla_PVE;
            
            return c;
        }
        public IList<Monstruo> ConvertListENToModel(IList<MonstruoEN> ens)
        {
            IList<Monstruo> c = new List<Monstruo>();
            foreach (MonstruoEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }
    }
}