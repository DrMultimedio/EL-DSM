using System.Collections.Generic;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;

namespace MvcApplication1.Models
{

    public class AssemblerAdmin
    {

        //modificar esto 
        public Admin ConvertEnToModelUI(AdminEN en)
        {
            Admin c = new Admin();
            c.id = en.Id;
            c.Ataque = en.Ataque;
            c.Contrasena = en.Password;
            c.Defensa = en.Defensa;
            c.Email = en.Email;
            c.Fecha = en.Cumple;
            c.Genero = en.Genero;
            c.Nombre = en.Nombre;
            c.Oro = en.Oro;
            c.VidaAct = en.VidaAct;
            c.Vidamax = en.Vidamax;
            c.Batallas1 = en.Batalla_PVP;
            c.Batallas2 = en.Batalla_PVP_0;
            c.BatallasPVE = en.Batalla_PVE;
            c.InventarioEq = en.Equipo;
            c.Inventario = en.Inventario;
                
            


            return c;
        }
        public IList<Admin> ConvertListENToModel(IList<AdminEN> ens)
        {
            IList<Admin> c = new List<Admin>();
            foreach (AdminEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }

    }
}