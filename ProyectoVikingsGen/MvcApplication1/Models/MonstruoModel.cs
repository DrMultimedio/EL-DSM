using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models

{
    public class Monstruo
    {
        public int id { get; set; }

        [Display(Prompt = "Nombre del monstruo", Description = "Nombre del monstruo", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el monstruo")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }



        [Display(Prompt = "vida del monstruo", Description = "vida del monstruo", Name = "vida")]
        [Required(ErrorMessage = "Debe indicar una vidamax para el monstruo")]
        [DataType(DataType.Currency, ErrorMessage = "La vidamax debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "La vida max tiene que estar entre 1 y 200")]
        public int Vida { get; set; }



        [Display(Prompt = "Ataque del monstruo", Description = "Ataque del monstruo", Name = "Ataque")]
        [Required(ErrorMessage = "Debe indicar una Ataque para el monstruo")]
        [DataType(DataType.Currency, ErrorMessage = "La Ataque debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El ataque tiene que estar entre 1 y 200")]
        public int Ataque { get; set; }


        [Display(Prompt = "Defensa del monstruo", Description = "Defensa del monstruo", Name = "Defensa")]
        [Required(ErrorMessage = "Debe indicar una Defensa para el monstruo")]
        [DataType(DataType.Currency, ErrorMessage = "La Defensa debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El Oro tiene que estar entre 1 y 120")]
        public int Defensa { get; set; }


        [Display(Prompt = "Batalla_PVE", Description = "Batallas PVE", Name = "Batallas_PVE")]
        
        public IList<Batalla_PVEEN> Batalla_PVE { get; set; }

    }
}
