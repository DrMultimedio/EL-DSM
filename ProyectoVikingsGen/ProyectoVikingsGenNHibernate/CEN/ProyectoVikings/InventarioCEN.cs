

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
 *      Definition of the class InventarioCEN
 *
 */
public partial class InventarioCEN
{
private IInventarioCAD _IInventarioCAD;

public InventarioCEN()
{
        this._IInventarioCAD = new InventarioCAD ();
}

public InventarioCEN(IInventarioCAD _IInventarioCAD)
{
        this._IInventarioCAD = _IInventarioCAD;
}

public IInventarioCAD get_IInventarioCAD ()
{
        return this._IInventarioCAD;
}

public int New_ (int p_InvMax, int p_jugador)
{
        InventarioEN inventarioEN = null;
        int oid;

        //Initialized InventarioEN
        inventarioEN = new InventarioEN ();
        inventarioEN.InvMax = p_InvMax;


        if (p_jugador != -1) {
                // El argumento p_jugador -> Property jugador es oid = false
                // Lista de oids id
                inventarioEN.Jugador = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN ();
                inventarioEN.Jugador.Id = p_jugador;
        }

        //Call to InventarioCAD

        oid = _IInventarioCAD.New_ (inventarioEN);
        return oid;
}

public void Modify (int p_Inventario_OID, int p_InvMax)
{
        InventarioEN inventarioEN = null;

        //Initialized InventarioEN
        inventarioEN = new InventarioEN ();
        inventarioEN.Id = p_Inventario_OID;
        inventarioEN.InvMax = p_InvMax;
        //Call to InventarioCAD

        _IInventarioCAD.Modify (inventarioEN);
}

public void Destroy (int id
                     )
{
        _IInventarioCAD.Destroy (id);
}

public ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN DameInventarioPorJugador (int ? oid_jugador)
{
        return _IInventarioCAD.DameInventarioPorJugador (oid_jugador);
}
public void ObjetoRelationer (int p_Inventario_OID, System.Collections.Generic.IList<int> p_objeto_OIDs)
{
        //Call to InventarioCAD

        _IInventarioCAD.ObjetoRelationer (p_Inventario_OID, p_objeto_OIDs);
}
public System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> DameObjetosJugador ()
{
        return _IInventarioCAD.DameObjetosJugador ();
}
}
}
