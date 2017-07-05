using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models

{
    public class AssemblerBatalla_PVP
    {

        //modificar model y añadir variables de composicion
        public Batalla_PVP ConvertEnToModelUI(Batalla_PVPEN en)
        {
            Batalla_PVP c = new Batalla_PVP();
            c.id = en.Id;
            c.IdGanador = en.IdGanador;
            c.Recompensa = en.Recompensa;
            c.Jugador= en.Jugador;
            c.Jugador2= en.Jugador_0;

            return c;
        }
        public IList<Batalla_PVP> ConvertListENToModel(IList<Batalla_PVPEN> ens)
        {
            IList<Batalla_PVP> c = new List<Batalla_PVP>();
            foreach (Batalla_PVPEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }
    }
}