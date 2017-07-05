using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;


namespace MvcApplication1.Models
{
    public class Equipo

    {
        public int id { get; set; }

        [Display(Prompt = "Arma equipada", Description = "Lleva un arma equipada", Name = "Arma Equipada")]
        [Required(ErrorMessage = "Debe indicar si lleva un arma equipada")]

        public bool ArmaEquipada { get; set; }

        [Display(Prompt = "Grebas equipada", Description = "Lleva un grebas equipada", Name = "Grebas Equipada")]
        [Required(ErrorMessage = "Debe indicar si lleva un grebas equipada")]

        public bool GrebasEquipadas { get; set; }
        
        [Display(Prompt = "Pechera equipada", Description = "Lleva un pechera equipada", Name = "Pechera Equipada")]
        [Required(ErrorMessage = "Debe indicar si lleva un pechera equipada")]

                
        public bool PecheraEquipada { get; set; }

        [Display(Prompt = "Casco equipada", Description = "Lleva un casco equipada", Name = "Casco Equipada")]
        [Required(ErrorMessage = "Debe indicar si lleva un casco equipada")]

        public bool CascoEquipado { get; set; }

        [Display(Prompt = "Jugador", Description = "Jugador ", Name = "Jugador")]
        public JugadorEN Jugador { get; set; }

        [Display(Prompt = "Objetos equipados de los Inventarios", Description = "Objetos equipados de los Inventarios", Name = "Objetos equipados de los Inventarios")]

        public IList<ObjetoEN> Objetos{ get; set; }
    }
}