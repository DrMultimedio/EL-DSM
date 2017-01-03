
using System;
// Definición clase Batalla_PVEEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class Batalla_PVEEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo monstruo
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN monstruo;



/**
 *	Atributo jugador
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador;



/**
 *	Atributo recompensa
 */
private int recompensa;



/**
 *	Atributo tipoGanador
 */
private ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum tipoGanador;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN Monstruo {
        get { return monstruo; } set { monstruo = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN Jugador {
        get { return jugador; } set { jugador = value;  }
}



public virtual int Recompensa {
        get { return recompensa; } set { recompensa = value;  }
}



public virtual ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum TipoGanador {
        get { return tipoGanador; } set { tipoGanador = value;  }
}





public Batalla_PVEEN()
{
}



public Batalla_PVEEN(int id, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN monstruo, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, int recompensa, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum tipoGanador
                     )
{
        this.init (Id, monstruo, jugador, recompensa, tipoGanador);
}


public Batalla_PVEEN(Batalla_PVEEN batalla_PVE)
{
        this.init (Id, batalla_PVE.Monstruo, batalla_PVE.Jugador, batalla_PVE.Recompensa, batalla_PVE.TipoGanador);
}

private void init (int id
                   , ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN monstruo, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, int recompensa, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum tipoGanador)
{
        this.Id = id;


        this.Monstruo = monstruo;

        this.Jugador = jugador;

        this.Recompensa = recompensa;

        this.TipoGanador = tipoGanador;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        Batalla_PVEEN t = obj as Batalla_PVEEN;
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
