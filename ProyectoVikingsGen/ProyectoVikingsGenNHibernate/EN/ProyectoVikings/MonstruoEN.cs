
using System;
// Definición clase MonstruoEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class MonstruoEN
{
/**
 *	Atributo id
 */
private int id;



/**
 *	Atributo nombre
 */
private string nombre;



/**
 *	Atributo vida
 */
private int vida;



/**
 *	Atributo ataque
 */
private int ataque;



/**
 *	Atributo defensa
 */
private int defensa;



/**
 *	Atributo batalla_PVE
 */
private System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN> batalla_PVE;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual int Vida {
        get { return vida; } set { vida = value;  }
}



public virtual int Ataque {
        get { return ataque; } set { ataque = value;  }
}



public virtual int Defensa {
        get { return defensa; } set { defensa = value;  }
}



public virtual System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN> Batalla_PVE {
        get { return batalla_PVE; } set { batalla_PVE = value;  }
}





public MonstruoEN()
{
        batalla_PVE = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN>();
}



public MonstruoEN(int id, string nombre, int vida, int ataque, int defensa, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN> batalla_PVE
                  )
{
        this.init (Id, nombre, vida, ataque, defensa, batalla_PVE);
}


public MonstruoEN(MonstruoEN monstruo)
{
        this.init (Id, monstruo.Nombre, monstruo.Vida, monstruo.Ataque, monstruo.Defensa, monstruo.Batalla_PVE);
}

private void init (int id
                   , string nombre, int vida, int ataque, int defensa, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN> batalla_PVE)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Vida = vida;

        this.Ataque = ataque;

        this.Defensa = defensa;

        this.Batalla_PVE = batalla_PVE;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        MonstruoEN t = obj as MonstruoEN;
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
