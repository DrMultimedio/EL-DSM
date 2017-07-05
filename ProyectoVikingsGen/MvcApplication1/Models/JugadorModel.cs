using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;

using System.IO;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using System;
namespace MvcApplication1.Models

{
    public class Jugador
    {
        public int id { get; set; }

        [Display(Prompt = "Nombre del cliente", Description = "Nombre del cliente", Name = "Nombre: ")]
        [Required(ErrorMessage = "Debe indicar un nombre para el cliente")]
        [StringLength(maximumLength: 200, ErrorMessage = "El nombre no puede tener más de 200 caracteres")]
        public string Nombre { get; set; }

        [Display(Prompt = "Email del cliente", Description = "Email del cliente", Name = "Email: ")]
        [Required(ErrorMessage = "Debe indicar un email para el cliente")]
      
        public string Email { get; set; }


        [Display(Prompt = "Fecha de la reserva", Description = "Fecha de la reserva", Name = "Fecha de la reserva: ")]
        [Required(ErrorMessage = "Debe indicar una Fecha de la reserva")]
        public Nullable<DateTime> Fecha { get; set; }

        [Display(Prompt = "Contrasena del jugador", Description = "Contrasena del jugador", Name = "Contrasena")]
        [Required(ErrorMessage = "Debe indicar una contrasena para el jugador")]
        [DataType(DataType.Password)]
        public string Contrasena { get; set; }

        [Display(Prompt = "Genero del jugador", Description = "Genero del Jugador", Name = "Jugador")]
        [Required(ErrorMessage = "Debe indicar un genero para el Jugador")]
        public string Genero { get; set; }

        [Display(Prompt = "vidamax del jugador", Description = "vidamax del jugador", Name = "vidamax")]
        [Required(ErrorMessage = "Debe indicar una vidamax para el jugador")]
        [DataType(DataType.Currency, ErrorMessage = "La vidamax debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "La vida max tiene que estar entre 1 y 200")]
        public int Vidamax { get; set; }

        [Display(Prompt = "vidaAct del jugador", Description = "vidaAct del jugador", Name = "vidaAct")]
        [Required(ErrorMessage = "Debe indicar una vidaAct para el jugador")]
        [DataType(DataType.Currency, ErrorMessage = "La vidaAct debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 200, ErrorMessage = "La vida actual tiene que estar entre 0 y 200")]
        public int VidaAct { get; set; }

        [Display(Prompt = "Ataque del jugador", Description = "Ataque del jugador", Name = "Ataque")]
        [Required(ErrorMessage = "Debe indicar una Ataque para el jugador")]
        [DataType(DataType.Currency, ErrorMessage = "La Ataque debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El ataque tiene que estar entre 1 y 200")]
        public int Ataque { get; set; }


        [Display(Prompt = "Defensa del jugador", Description = "Defensa del jugador", Name = "Defensa")]
        [Required(ErrorMessage = "Debe indicar una Defensa para el jugador")]
        [DataType(DataType.Currency, ErrorMessage = "La Defensa debe ser un valor numérico")]
        [Range(minimum: 1, maximum: 200, ErrorMessage = "El Oro tiene que estar entre 1 y 120")]
        public int Defensa { get; set; }



        [Display(Prompt = "Oro del jugador", Description = "Oro del jugador", Name = "Oro")]
        [Required(ErrorMessage = "Debe indicar una Oro para el jugador")]
        [DataType(DataType.Currency, ErrorMessage = "La Oro debe ser un valor numérico")]
        [Range(minimum: 0, maximum: 200, ErrorMessage = "El oro tiene que estar entre 0 y 120")]
        public int Oro { get; set; }

        [Display(Prompt = "Inventario del Jugador", Description = "Inventado del Jugador", Name = "Inventario")]
        public InventarioEN Inventario { get; set; }

        [Display(Prompt = "Inventario Equipado", Description = "Inventado Equipado", Name = "InventarioEQ")]
        public EquipoEN InventarioEq { get; set; }

        [Display(Prompt = "Numero de batallas PVP como Jugador 1", Description = "Numero Batallas PVP como Jugador1", Name = "Batallas PVP con Jugador1")]

        public IList<Batalla_PVPEN> Batallas1 { get; set; }

        [Display(Prompt = "Numero de batallas PVP como Jugador 2", Description = "Numero Batallas PVP como Jugador2", Name = "Batallas PVP con Jugador2")]

        public IList<Batalla_PVPEN> Batallas2 { get; set; }

        [Display(Prompt = "Numero de batallas PVE ", Description = "Numero Batallas PVE", Name = "Batallas PVE")]

        public IList<Batalla_PVEEN> BatallasPVE { get; set; }





    }
}