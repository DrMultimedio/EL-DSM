

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.Exceptions;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;


namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
/*
 *      Definition of the class Batalla_PVPCEN
 *
 */
public partial class Batalla_PVPCEN
{
private IBatalla_PVPCAD _IBatalla_PVPCAD;

public Batalla_PVPCEN()
{
        this._IBatalla_PVPCAD = new Batalla_PVPCAD ();
}

public Batalla_PVPCEN(IBatalla_PVPCAD _IBatalla_PVPCAD)
{
        this._IBatalla_PVPCAD = _IBatalla_PVPCAD;
}

public IBatalla_PVPCAD get_IBatalla_PVPCAD ()
{
        return this._IBatalla_PVPCAD;
}

public int New_ (int p_jugador, int p_jugador_0, int p_Recompensa, int p_idGanador)
{
        Batalla_PVPEN batalla_PVPEN = null;
        int oid;

        //Initialized Batalla_PVPEN
        batalla_PVPEN = new Batalla_PVPEN ();

        if (p_jugador != -1) {
                // El argumento p_jugador -> Property jugador es oid = false
                // Lista de oids id
                batalla_PVPEN.Jugador = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN ();
                batalla_PVPEN.Jugador.Id = p_jugador;
        }


        if (p_jugador_0 != -1) {
                // El argumento p_jugador_0 -> Property jugador_0 es oid = false
                // Lista de oids id
                batalla_PVPEN.Jugador_0 = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN ();
                batalla_PVPEN.Jugador_0.Id = p_jugador_0;
        }

        batalla_PVPEN.Recompensa = p_Recompensa;

        batalla_PVPEN.IdGanador = p_idGanador;

        //Call to Batalla_PVPCAD

        oid = _IBatalla_PVPCAD.New_ (batalla_PVPEN);
        return oid;
}

public void Modify (int p_Batalla_PVP_OID, int p_Recompensa, int p_idGanador)
{
        Batalla_PVPEN batalla_PVPEN = null;

        //Initialized Batalla_PVPEN
        batalla_PVPEN = new Batalla_PVPEN ();
        batalla_PVPEN.Id = p_Batalla_PVP_OID;
        batalla_PVPEN.Recompensa = p_Recompensa;
        batalla_PVPEN.IdGanador = p_idGanador;
        //Call to Batalla_PVPCAD

        _IBatalla_PVPCAD.Modify (batalla_PVPEN);
}

public void Destroy (int id
                     )
{
        _IBatalla_PVPCAD.Destroy (id);
}
}
}
