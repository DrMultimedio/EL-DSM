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
    //modificar model para añadir variables de composicion
    public class AssemblerObjeto
    {
        public Objeto ConvertEnToModelUI(ObjetoEN en)
        {
            Objeto c = new Objeto();
            c.id= en.Id;
            c.Nombre = en.Nombre;
            c.Precio = en.Precio;
            c.Inventarios = en.Inventario;
            return c;
        }
        public IList<Objeto> ConvertListENToModel(IList<ObjetoEN> ens)
        {
            IList<Objeto> c = new List<Objeto>();
            foreach (ObjetoEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }
    }
}