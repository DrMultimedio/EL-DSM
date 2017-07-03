
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;


/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Jugador_registro) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
public partial class JugadorCEN
{
public bool Registro (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Jugador_registro) ENABLED START*/

        // Write here your custom code...
        JugadorCEN jugadorCEN = new JugadorCEN ();

        if (jugadorCEN.DameJugadorPorNombre (jugador.Nombre) == null) {
                jugador.Password = Utils.Util.GetEncondeMD5 (jugador.Password);
                _IJugadorCAD.New_ (jugador);
                return true;
        }


        return false;

        /*PROTECTED REGION END*/
}
}
}
