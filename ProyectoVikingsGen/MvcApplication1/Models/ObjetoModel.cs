using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;                        
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace MvcApplication1.Models
{
    public class Objeto
    {
        public int id { get; set; }

        [Display(Prompt = "Nombre del Objeto", Description = "Nombre del Objeto", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el Objeto")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Precio del Objeto", Description = "Precio del Objeto", Name = "Precio")]
        [Required(ErrorMessage = "Debe indicar un precio para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "La Precio debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "La Precio tiene que estar entre 1 y 200")]
        public int Precio { get; set; }

        [Display(Prompt = "Tipo del Objeto", Description = "Tipo del Objeto", Name = "Tipo")]
        [Required(ErrorMessage = "Debe indicar una Tipo para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "El Tipo debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El Tipo tiene que estar entre 1 y 200")]
        public ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum Tipo { get; set; }

        [Display(Prompt = "Ataque del Objeto", Description = "Ataque del Objeto", Name = "Ataque")]
        [Required(ErrorMessage = "Debe indicar una Ataque para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "El Ataque debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El Ataque tiene que estar entre 1 y 200")]
        public int Ataque { get; set; }

        [Display(Prompt = "Defensa del Objeto", Description = "Defensa del Objeto", Name = "Defensa")]
        [Required(ErrorMessage = "Debe indicar una Defensa para el Objeto")]
        [DataType(DataType.Currency, ErrorMessage = "El Defensa debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El Defensa tiene que estar entre 1 y 200")]
        public int Defensa { get; set; }


        [Display(Prompt = "Inventario Equipado", Description = "Inventarios donde el objeto esta equipado", Name = "InventarioEQ")]
        public IList<EquipoEN> InventarioEq { get; set; }
        
        
        [Display(Prompt = "Inventarios en los que esta equipado este objeto", Description = "Inventarios que contienen este objeto", Name = "Inventarios")]

        public IList<InventarioEN> Inventarios { get; set; }
    }

    
}
