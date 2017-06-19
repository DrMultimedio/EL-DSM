

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
 *      Definition of the class JugadorCEN
 *
 */
public partial class JugadorCEN
{
private IJugadorCAD _IJugadorCAD;

public JugadorCEN()
{
        this._IJugadorCAD = new JugadorCAD ();
}

public JugadorCEN(IJugadorCAD _IJugadorCAD)
{
        this._IJugadorCAD = _IJugadorCAD;
}

public IJugadorCAD get_IJugadorCAD ()
{
        return this._IJugadorCAD;
}

public int New_ (string p_Nombre, string p_Email, Nullable<DateTime> p_Cumple, string p_Genero, int p_Vidamax, int p_VidaAct, int p_Ataque, int p_Defensa, int p_Oro, String p_Password)
{
        JugadorEN jugadorEN = null;
        int oid;

        //Initialized JugadorEN
        jugadorEN = new JugadorEN ();
        jugadorEN.Nombre = p_Nombre;

        jugadorEN.Email = p_Email;

        jugadorEN.Cumple = p_Cumple;

        jugadorEN.Genero = p_Genero;

        jugadorEN.Vidamax = p_Vidamax;

        jugadorEN.VidaAct = p_VidaAct;

        jugadorEN.Ataque = p_Ataque;

        jugadorEN.Defensa = p_Defensa;

        jugadorEN.Oro = p_Oro;

        jugadorEN.Password = Utils.Util.GetEncondeMD5 (p_Password);

        //Call to JugadorCAD

        oid = _IJugadorCAD.New_ (jugadorEN);
        return oid;
}

public void Modify (int p_Jugador_OID, string p_Nombre, string p_Email, Nullable<DateTime> p_Cumple, string p_Genero, int p_Vidamax, int p_VidaAct, int p_Ataque, int p_Defensa, int p_Oro, String p_Password)
{
        JugadorEN jugadorEN = null;

        //Initialized JugadorEN
        jugadorEN = new JugadorEN ();
        jugadorEN.Id = p_Jugador_OID;
        jugadorEN.Nombre = p_Nombre;
        jugadorEN.Email = p_Email;
        jugadorEN.Cumple = p_Cumple;
        jugadorEN.Genero = p_Genero;
        jugadorEN.Vidamax = p_Vidamax;
        jugadorEN.VidaAct = p_VidaAct;
        jugadorEN.Ataque = p_Ataque;
        jugadorEN.Defensa = p_Defensa;
        jugadorEN.Oro = p_Oro;
        jugadorEN.Password = Utils.Util.GetEncondeMD5 (p_Password);
        //Call to JugadorCAD

        _IJugadorCAD.Modify (jugadorEN);
}

public void Destroy (int id
                     )
{
        _IJugadorCAD.Destroy (id);
}

public JugadorEN ReadOID (int id
                          )
{
        JugadorEN jugadorEN = null;

        jugadorEN = _IJugadorCAD.ReadOID (id);
        return jugadorEN;
}

public System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN> DameJugadoresBatalla ()
{
        return _IJugadorCAD.DameJugadoresBatalla ();
}
public System.Collections.Generic.IList<JugadorEN> DameJugadores (int first, int size)
{
        System.Collections.Generic.IList<JugadorEN> list = null;

        list = _IJugadorCAD.DameJugadores (first, size);
        return list;
}
public ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN DameInventario (int jugador_oid)
{
        return _IJugadorCAD.DameInventario (jugador_oid);
}
}
}
