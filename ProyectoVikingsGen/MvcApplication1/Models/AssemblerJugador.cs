using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models
{
    public class AssemblerJugador
    {
        //modificar model para añadir variables de composicion
        public Jugador ConvertEnToModelUI(JugadorEN en)
        {
            Jugador c = new Jugador();
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




            //batallas salientes que me han hecho "_0", mientras no estabas.
            //batallas entrandes que has iniciado tu.


            return c;
        }
        public IList<Jugador> ConvertListENToModel(IList<JugadorEN> ens)
        {
            IList<Jugador> c = new List<Jugador>();
            foreach (JugadorEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }

    }
}