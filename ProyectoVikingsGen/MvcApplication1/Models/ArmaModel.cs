﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
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
    public class Arma
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

        [Display(Prompt = "Ataque del Objeto", Description = "Ataque del Objeto", Name = "Ataque")]
        [Required(ErrorMessage = "Debe indicar una Ataque para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "La Ataque debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El ataque tiene que estar entre 1 y 200")]
        public int Ataque { get; set; }

        [Display(Prompt = "Inventarios en los que se encuentra el objeto", Description = "Inventarios en los que se encuentra el objeto", Name = "Inventarios")]

        public IList<InventarioEN> Inventario { get; set; }

    }
}