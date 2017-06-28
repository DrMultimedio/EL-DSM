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


//modificar
namespace MvcApplication1.Models
{
    public class AssemblerBatallaPVE
    {
        public Batalla_PVE ConvertEnToModelUI(Batalla_PVEEN en)
        {
            Batalla_PVE c = new Batalla_PVE();
            c.id = en.Id;
            c.tipoGanador = en.TipoGanador;
            c.Recompensa = en.Recompensa;
            c.Jugador = en.Jugador;
            c.Monstruo = en.Monstruo;
            
            return c;
        }
        public IList<Batalla_PVE> ConvertListENToModel(IList<Batalla_PVEEN> ens)
        {
            IList<Batalla_PVE> c = new List<Batalla_PVE>();
            foreach (Batalla_PVEEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }
    }
}