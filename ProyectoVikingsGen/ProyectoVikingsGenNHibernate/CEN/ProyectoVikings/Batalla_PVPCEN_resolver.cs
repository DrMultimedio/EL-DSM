
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


/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Batalla_PVP_resolver) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
public partial class Batalla_PVPCEN
{
public bool Resolver (int jugador_oid, int jugador_oid1, int batalla_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Batalla_PVP_resolver) ENABLED START*/

        // Write here your custom code...
        Batalla_PVPCEN batallacen = new Batalla_PVPCEN;    

            JugadorCAD jugadorCAD1 = null;
            JugadorCAD jugadorCAD2 = null;

            jugadorCAD1 = new JugadorCAD ();
            jugadorCAD2 = new JugadorCAD ();

            JugadorCEN jugadorCEN1 = null;
            JugadorCEN jugadorCEN2 = null;

            jugadorCEN1 = new JugadorCEN (jugadorCAD1);
            jugadorCEN2 = new JugadorCEN (jugadorCAD2);

            JugadorEN jugadorEN1 = null;
            JugadorEN jugadorEN2 = null;

            jugadorEN1 = jugadorCEN1.ReadOID (jugador_oid);
            jugadorEN2 = jugadorCEN2.ReadOID (jugador_oid1);

            //ahora empiezo a resolver la batalla
            //vamos restando el ataque de uno a la vida del otro hasta que la vida de uno de los dos llegue a cero

            int vida1 = jugadorEN1.Vidamax;
            int vida2 = jugadorEN2.Vidamax;

            int ataque1 = jugadorEN1.Ataque;
            int ataque2 = jugadorEN2.Ataque;

            int defensa1 = jugadorEN1.Defensa;
            int defensa2 = jugadorEN2.Defensa;

            int danyo1 = ataque1 - defensa2;
            int danyo2 = ataque2 - defensa1;
        
            Boolean resultado = false;

            int var = 1;

            while (vida1 > 0 && vida2 > 0) {
                    vida2 -= danyo1;
                    vida1 -= danyo2;               
            }

            if (vida1 <= 0) {
            
                batallacen.Modify(batalla_oid, 10, jugador_oid1);
                resultado = false;
            
               
            }
            else{
                batallacen.Modify(batalla_oid, 10, jugador_oid1);
                resultado =  true;
            }
        return resultado;

        /*PROTECTED REGION END*/
}
}
}
