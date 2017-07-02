
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;



/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CP.ProyectoVikings_Batalla_PVP_resolver) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class Batalla_PVPCP : BasicCP
{
public bool Resolver (int jugador_oid, int jugador_oid1, int batalla_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CP.ProyectoVikings_Batalla_PVP_resolver) ENABLED START*/

        IBatalla_PVPCAD batalla_PVPCAD = null;
        Batalla_PVPCEN batalla_PVPCEN = null;

        bool resultado = false;


        try
        {
                SessionInitializeTransaction ();
                batalla_PVPCAD = new Batalla_PVPCAD (session);
                batalla_PVPCEN = new  Batalla_PVPCEN (batalla_PVPCAD);



                // Write here your custom transaction ...


                //definimos la variable CAD
                JugadorCAD jugadorCAD1 = null;
                JugadorCAD jugadorCAD2 = null;
                //inicializamos la variable
                jugadorCAD1 = new JugadorCAD ();
                jugadorCAD2 = new JugadorCAD ();

                JugadorCEN jugadorCEN1 = null;
                JugadorCEN jugadorCEN2 = null;

                JugadorCP jugadorCP = new JugadorCP ();

                jugadorCEN1 = new JugadorCEN (jugadorCAD1);
                jugadorCEN2 = new JugadorCEN (jugadorCAD2);

                JugadorEN jugadorEN1 = null;
                JugadorEN jugadorEN2 = null;

                jugadorEN1 = jugadorCEN1.ReadOID (jugador_oid);
                jugadorEN2 = jugadorCEN2.ReadOID (jugador_oid1);

                EquipoCAD equipoCAD = new EquipoCAD ();
                EquipoCEN equipoCEN = new EquipoCEN ();

                EquipoEN equipoJug1 = null;
                EquipoEN equipoJug2 = null;

                equipoJug1 = jugadorCEN1.DameEquipo (jugador_oid);
                equipoJug2 = jugadorCEN1.DameEquipo (jugador_oid1);

                //ahora empiezo a resolver la batalla
                //vamos restando el ataque de uno a la vida del otro hasta que la vida de uno de los dos llegue a cero

                int vida1 = jugadorEN1.Vidamax;
                int vida2 = jugadorEN2.Vidamax;

                int ataque1 = jugadorEN1.Ataque + jugadorCP.CalcularDanyoExtra (jugador_oid);
                int ataque2 = jugadorEN2.Ataque + jugadorCP.CalcularDanyoExtra (jugador_oid1);

                int defensa1 = jugadorEN1.Defensa + jugadorCP.CalcularDefensaExtra (jugador_oid);;
                int defensa2 = jugadorEN2.Defensa + jugadorCP.CalcularDefensaExtra (jugador_oid1);

                int danyo1 = ataque1 - defensa2;
                int danyo2 = ataque2 - defensa1;


                int var = 1;

                while (vida1 > 0 && vida2 > 0) {
                        vida2 -= danyo1 + 1;
                        vida1 -= danyo2 + 1;
                }

                if (vida1 <= 0) {
                        batalla_PVPCEN.Modify (batalla_oid, 10, jugador_oid);
                        resultado = false;
                }
                else{
                        batalla_PVPCEN.Modify (batalla_oid, 10, jugador_oid1);
                        resultado = true;
                }



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return resultado;


        /*PROTECTED REGION END*/
}
}
}
