

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
 *      Definition of the class InventarioEquipadoCEN
 *
 */
public partial class InventarioEquipadoCEN
{
private IInventarioEquipadoCAD _IInventarioEquipadoCAD;

public InventarioEquipadoCEN()
{
        this._IInventarioEquipadoCAD = new InventarioEquipadoCAD ();
}

public InventarioEquipadoCEN(IInventarioEquipadoCAD _IInventarioEquipadoCAD)
{
        this._IInventarioEquipadoCAD = _IInventarioEquipadoCAD;
}

public IInventarioEquipadoCAD get_IInventarioEquipadoCAD ()
{
        return this._IInventarioEquipadoCAD;
}

public int New_ (int p_InvMax, int p_jugador, int p_jugador_0)
{
        InventarioEquipadoEN inventarioEquipadoEN = null;
        int oid;

        //Initialized InventarioEquipadoEN
        inventarioEquipadoEN = new InventarioEquipadoEN ();
        inventarioEquipadoEN.InvMax = p_InvMax;


        if (p_jugador != -1) {
                // El argumento p_jugador -> Property jugador es oid = false
                // Lista de oids id
                inventarioEquipadoEN.Jugador = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN ();
                inventarioEquipadoEN.Jugador.Id = p_jugador;
        }


        if (p_jugador_0 != -1) {
                // El argumento p_jugador_0 -> Property jugador_0 es oid = false
                // Lista de oids id
                inventarioEquipadoEN.Jugador_0 = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN ();
                inventarioEquipadoEN.Jugador_0.Id = p_jugador_0;
        }

        //Call to InventarioEquipadoCAD

        oid = _IInventarioEquipadoCAD.New_ (inventarioEquipadoEN);
        return oid;
}

public void Modify (int p_InventarioEquipado_OID, int p_InvMax)
{
        InventarioEquipadoEN inventarioEquipadoEN = null;

        //Initialized InventarioEquipadoEN
        inventarioEquipadoEN = new InventarioEquipadoEN ();
        inventarioEquipadoEN.Id = p_InventarioEquipado_OID;
        inventarioEquipadoEN.InvMax = p_InvMax;
        //Call to InventarioEquipadoCAD

        _IInventarioEquipadoCAD.Modify (inventarioEquipadoEN);
}

public void Destroy (int id
                     )
{
        _IInventarioEquipadoCAD.Destroy (id);
}
}
}
