
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;



/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CP.ProyectoVikings_Batalla_PVE_resolver) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class Batalla_PVECP : BasicCP
{
public bool Resolver (int id_jugador, int id_monstruo, int batalla_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CP.ProyectoVikings_Batalla_PVE_resolver) ENABLED START*/

        IBatalla_PVECAD batalla_PVECAD = null;
        Batalla_PVECEN batalla_PVECEN = null;

        bool resultado = false;


        try
        {
                SessionInitializeTransaction ();
                batalla_PVECAD = new Batalla_PVECAD (session);
                batalla_PVECEN = new Batalla_PVECEN (batalla_PVECAD);



                // Write here your custom transaction ...


                JugadorCAD jugadorCAD1 = null;
                MonstruoCAD monstruoCAD = null;

                jugadorCAD1 = new JugadorCAD ();
                monstruoCAD = new MonstruoCAD ();

                JugadorCEN jugadorCEN1 = null;
                MonstruoCEN monstruoCEN = null;

                jugadorCEN1 = new JugadorCEN (jugadorCAD1);
                monstruoCEN = new MonstruoCEN (monstruoCAD);

                JugadorEN jugadorEN1 = null;
                MonstruoEN monstruoEN = null;

                jugadorEN1 = jugadorCEN1.ReadOID (id_jugador);
                monstruoEN = monstruoCEN.ReadOID (id_monstruo);

                //ahora empiezo a resolver la batalla
                //vamos restando el ataque de uno a la vida del otro hasta que la vida de uno de los dos llegue a cero

                int vida1 = jugadorEN1.Vidamax;
                int vida2 = monstruoEN.Vida;

                int ataque1 = jugadorEN1.Ataque;
                int ataque2 = monstruoEN.Ataque;

                int defensa1 = jugadorEN1.Defensa;
                int defensa2 = monstruoEN.Defensa;

                int danyo1 = ataque1 - defensa2;
                int danyo2 = ataque2 - defensa1;


                int var = 1;

                while (vida1 > 0 && vida2 > 0) {
                        vida2 -= danyo1;
                        vida1 -= danyo2;
                }

                if (vida1 <= 0) {
                        batalla_PVECEN.Modify (batalla_oid, 10, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum.Jugador);
                        resultado = false;
                }
                else{
                        batalla_PVECEN.Modify (batalla_oid, 10, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum.monstruo);
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
