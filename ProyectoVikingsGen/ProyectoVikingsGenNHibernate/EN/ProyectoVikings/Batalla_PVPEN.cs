
using System;
// Definición clase Batalla_PVPEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class Batalla_PVPEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo jugador
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador;



/**
 *	Atributo jugador_0
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador_0;



/**
 *	Atributo recompensa
 */
private int recompensa;



/**
 *	Atributo idGanador
 */
private int idGanador;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN Jugador {
        get { return jugador; } set { jugador = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN Jugador_0 {
        get { return jugador_0; } set { jugador_0 = value;  }
}



public virtual int Recompensa {
        get { return recompensa; } set { recompensa = value;  }
}



public virtual int IdGanador {
        get { return idGanador; } set { idGanador = value;  }
}





public Batalla_PVPEN()
{
}



public Batalla_PVPEN(int id, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador_0, int recompensa, int idGanador
                     )
{
        this.init (Id, jugador, jugador_0, recompensa, idGanador);
}


public Batalla_PVPEN(Batalla_PVPEN batalla_PVP)
{
        this.init (Id, batalla_PVP.Jugador, batalla_PVP.Jugador_0, batalla_PVP.Recompensa, batalla_PVP.IdGanador);
}

private void init (int id
                   , ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador_0, int recompensa, int idGanador)
{
        this.Id = id;


        this.Jugador = jugador;

        this.Jugador_0 = jugador_0;

        this.Recompensa = recompensa;

        this.IdGanador = idGanador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Batalla_PVPEN t = obj as Batalla_PVPEN;
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
