using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models
{
    public class AssemblerInventario
    {

        //modificar model para añadir variables de composicion

        public Inventario ConvertEnToModelUI(InventarioEN en)
        {
            Inventario c = new Inventario();
            c.id = en.Id;
            c.invMax = en.InvMax;
            c.Jugador = en.Jugador;
            c.Objetos = en.Objeto;


            return c;
        }
        public IList<Inventario> ConvertListENToModel(IList<InventarioEN> ens)
        {
            IList<Inventario> c = new List<Inventario>();
            foreach (InventarioEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }

    }
}