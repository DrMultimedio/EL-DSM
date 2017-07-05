using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

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
            c.Tipo = en.Tipo;
            c.InventarioEq = en.Equipo;
            c.Ataque = en.Ataque;
            c.Defensa = en.Defensa;
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