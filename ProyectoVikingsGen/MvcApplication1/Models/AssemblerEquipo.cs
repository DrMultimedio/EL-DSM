using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models
{
    public class AssemblerEquipo
    {

   
        public Equipo ConvertEnToModelUI(EquipoEN en)
        {
            Equipo c = new Equipo();
            c.id = en.Id;
            c.Jugador = en.Jugador;
            c.Objetos = en.Objeto;
            c.GrebasEquipadas = en.GrebasEquipadas;
            c.PecheraEquipada = en.PecheraEquipada;
            c.ArmaEquipada = en.ArmaEquipada;
            c.CascoEquipado = en.CascoEquipado;


            return c;
        }
        public IList<Equipo> ConvertListENToModel(IList<EquipoEN> ens)
        {
            IList<Equipo> c = new List<Equipo>();
            foreach (EquipoEN en in ens)
            {
                c.Add(ConvertEnToModelUI(en));
            }
            return c;

        }
    }
}