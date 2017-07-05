using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models
{

    public class Batalla_PVP
    {
        public int id { get; set; }

        [Display(Prompt = "IdGanador", Description = "IdGanador", Name = "IdGanador: ")]
        [Required(ErrorMessage = "Debe indicar un IdGanador")]
        [Range(minimum: 0, maximum: 100000, ErrorMessage = "La ID debe ser mayor que cero")]
        public int IdGanador { get; set; }

        [Display(Prompt = "Recompensa", Description = "Recompensa", Name = "Recompensa: ")]
        [Required(ErrorMessage = "Debe indicar un Recompensa")]
        [Range(minimum: 0, maximum: 100000, ErrorMessage = "La ID debe ser mayor que cero")]
        public int Recompensa { get; set; }


        [Display(Prompt = "Jugador 1", Description = "Jugador 1 en la batalla", Name = "Jugador1")]
        public JugadorEN Jugador { get; set; }

        [Display(Prompt = "Jugador 2", Description = "Jugador 2 en la batalla", Name = "Jugador2")]
        public JugadorEN Jugador2 { get; set; }

    }
}
