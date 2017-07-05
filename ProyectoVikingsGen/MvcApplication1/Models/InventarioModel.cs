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
    public class Inventario

    {
        public int id { get; set; }

        [Display(Prompt = "cantidad del inventario", Description = "cantidad del inventario", Name = "cantidad")]
        [Required(ErrorMessage = "Debe indicar una cantidadmax para el inventario")]
        [DataType(DataType.Currency, ErrorMessage = "La cantidadmax debe ser un valor numérico")]

        public int invMax;
        [Display(Prompt = "Jugador del  inventario", Description = "Jugador en el inventario", Name = "Jugador")]
        public JugadorEN Jugador { get; set; }

        [Display(Prompt = "Objetos de los Inventarios", Description = "Objetos de los Inventarios", Name = "Objetos de los Inventarios")]

        public IList<ObjetoEN> Objetos { get; set; }

    }
}