using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models

{
    public class Casco
    {
        public int id { get; set; }

        [Display(Prompt = "Nombre del Objeto", Description = "Nombre del Objeto", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el Objeto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Precio del Objeto", Description = "Precio del Objeto", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar una Preciomax para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "La Precio debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "La Precio tiene que estar entre 1 y 200")]
        public int Precio { get; set; }

        [Display(Prompt = "vida del Objeto", Description = "vida del Objeto", Name = "vida")]
        [Required(ErrorMessage = "Debe indicar una vidamax para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "La vidamax debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "La vida max tiene que estar entre 1 y 200")]
        public int Vida { get; set; }


        [Display(Prompt = "Defensa del Objeto", Description = "Defensa del Objeto", Name = "Defensa")]
        [Required(ErrorMessage = "Debe indicar una Defensa para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "La Defensa debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El Oro tiene que estar entre 1 y 120")]
        public int Defensa { get; set; }

        [Display(Prompt = "Inventarios en los que se encuentra el objeto", Description = "Inventarios en los que se encuentra el objeto", Name = "Inventarios")]

        public IList<InventarioEN> Inventario { get; set; }

    }

}