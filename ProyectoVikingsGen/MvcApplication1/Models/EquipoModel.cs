using System;
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
    public class Equipo

    {
        public int id { get; set; }

        [Display(Prompt = "cantidad del inventario", Description = "cantidad del inventario", Name = "cantidad")]
        [Required(ErrorMessage = "Debe indicar una cantidadmax para el inventario")]
        [DataType(DataType.Currency, ErrorMessage = "La cantidadmax debe ser un valor numérico")]
        [Display(Prompt = "Jugador del  inventario equipado", Description = "Jugador en el inventario", Name = "Jugador")]
        public JugadorEN Jugador{ get; set; }

        [Display(Prompt = "Objetos equipados de los Inventarios", Description = "Objetos equipados de los Inventarios", Name = "Objetos equipados de los Inventarios")]

        public IList<ObjetoEN> Objetos{ get; set; }
    }
}