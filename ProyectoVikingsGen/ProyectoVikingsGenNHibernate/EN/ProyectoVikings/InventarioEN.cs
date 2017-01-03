
using System;
// Definición clase InventarioEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class InventarioEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo invMax
 */
private int invMax;



/**
 *	Atributo jugador
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador;



/**
 *	Atributo objeto
 */
private System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual int InvMax {
        get { return invMax; } set { invMax = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN Jugador {
        get { return jugador; } set { jugador = value;  }
}



public virtual System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> Objeto {
        get { return objeto; } set { objeto = value;  }
}





public InventarioEN()
{
        objeto = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN>();
}



public InventarioEN(int id, int invMax, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto
                    )
{
        this.init (Id, invMax, jugador, objeto);
}


public InventarioEN(InventarioEN inventario)
{
        this.init (Id, inventario.InvMax, inventario.Jugador, inventario.Objeto);
}

private void init (int id
                   , int invMax, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto)
{
        this.Id = id;


        this.InvMax = invMax;

        this.Jugador = jugador;

        this.Objeto = objeto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        InventarioEN t = obj as InventarioEN;
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
