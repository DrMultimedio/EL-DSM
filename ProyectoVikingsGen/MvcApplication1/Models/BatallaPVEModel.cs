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
  
        public class Batalla_PVE
        {
            public int id { get; set; }

            [Display(Prompt = "TipoGanador", Description = "TipoGanador", Name = "TipoGanador: ")]
            [Required(ErrorMessage = "Debe indicar un TipoGanador")]
            
            public  ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum tipoGanador { get; set; }

            [Display(Prompt = "Recompensa", Description = "Recompensa", Name = "Recompensa: ")]
            [Required(ErrorMessage = "Debe indicar un Recompensa")]
            [Range(minimum: 0, maximum: 100000, ErrorMessage = "La ID debe ser mayor que cero")]
            public int Recompensa { get; set; }

        [Display(Prompt = "Jugador", Description = "Jugador en la batalla", Name = "Jugador")]
        public JugadorEN Jugador { get; set; }


        [Display(Prompt = "Monstruo", Description = "Monstruo en la batalla", Name = "Monstruo")]
        public MonstruoEN Monstruo { get; set; }


    }
    }