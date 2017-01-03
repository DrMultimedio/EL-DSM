

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
 *      Definition of the class Batalla_PVECEN
 *
 */
public partial class Batalla_PVECEN
{
private IBatalla_PVECAD _IBatalla_PVECAD;

public Batalla_PVECEN()
{
        this._IBatalla_PVECAD = new Batalla_PVECAD ();
}

public Batalla_PVECEN(IBatalla_PVECAD _IBatalla_PVECAD)
{
        this._IBatalla_PVECAD = _IBatalla_PVECAD;
}

public IBatalla_PVECAD get_IBatalla_PVECAD ()
{
        return this._IBatalla_PVECAD;
}

public int New_ (int p_monstruo, int p_jugador, int p_Recompensa, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum p_tipoGanador)
{
        Batalla_PVEEN batalla_PVEEN = null;
        int oid;

        //Initialized Batalla_PVEEN
        batalla_PVEEN = new Batalla_PVEEN ();

        if (p_monstruo != -1) {
                // El argumento p_monstruo -> Property monstruo es oid = false
                // Lista de oids id
                batalla_PVEEN.Monstruo = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN ();
                batalla_PVEEN.Monstruo.Id = p_monstruo;
        }


        if (p_jugador != -1) {
                // El argumento p_jugador -> Property jugador es oid = false
                // Lista de oids id
                batalla_PVEEN.Jugador = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN ();
                batalla_PVEEN.Jugador.Id = p_jugador;
        }

        batalla_PVEEN.Recompensa = p_Recompensa;

        batalla_PVEEN.TipoGanador = p_tipoGanador;

        //Call to Batalla_PVECAD

        oid = _IBatalla_PVECAD.New_ (batalla_PVEEN);
        return oid;
}

public void Modify (int p_Batalla_PVE_OID, int p_Recompensa, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum p_tipoGanador)
{
        Batalla_PVEEN batalla_PVEEN = null;

        //Initialized Batalla_PVEEN
        batalla_PVEEN = new Batalla_PVEEN ();
        batalla_PVEEN.Id = p_Batalla_PVE_OID;
        batalla_PVEEN.Recompensa = p_Recompensa;
        batalla_PVEEN.TipoGanador = p_tipoGanador;
        //Call to Batalla_PVECAD

        _IBatalla_PVECAD.Modify (batalla_PVEEN);
}

public void Destroy (int id
                     )
{
        _IBatalla_PVECAD.Destroy (id);
}

public Batalla_PVEEN ReadOID (int id
                              )
{
        Batalla_PVEEN batalla_PVEEN = null;

        batalla_PVEEN = _IBatalla_PVECAD.ReadOID (id);
        return batalla_PVEEN;
}

public System.Collections.Generic.IList<Batalla_PVEEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Batalla_PVEEN> list = null;

        list = _IBatalla_PVECAD.ReadAll (first, size);
        return list;
}
}
}
