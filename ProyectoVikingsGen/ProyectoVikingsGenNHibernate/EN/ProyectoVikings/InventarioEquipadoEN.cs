
using System;
// Definición clase InventarioEquipadoEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class InventarioEquipadoEN                                                                   : ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN


{
/**
 *	Atributo jugador_0
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador_0;






public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN Jugador_0 {
        get { return jugador_0; } set { jugador_0 = value;  }
}





public InventarioEquipadoEN() : base ()
{
}



public InventarioEquipadoEN(int id, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador_0
                            , int invMax, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto
                            )
{
        this.init (Id, jugador_0, invMax, jugador, objeto);
}


public InventarioEquipadoEN(InventarioEquipadoEN inventarioEquipado)
{
        this.init (Id, inventarioEquipado.Jugador_0, inventarioEquipado.InvMax, inventarioEquipado.Jugador, inventarioEquipado.Objeto);
}

private void init (int id
                   , ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador_0, int invMax, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto)
{
        this.Id = id;


        this.Jugador_0 = jugador_0;

        this.InvMax = invMax;

        this.Jugador = jugador;

        this.Objeto = objeto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InventarioEquipadoEN t = obj as InventarioEquipadoEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
