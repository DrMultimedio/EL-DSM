
using System;
// Definición clase CascoEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class CascoEN                                                                        : ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN


{
/**
 *	Atributo vida
 */
private int vida;



/**
 *	Atributo defensa
 */
private int defensa;






public virtual int Vida {
        get { return vida; } set { vida = value;  }
}



public virtual int Defensa {
        get { return defensa; } set { defensa = value;  }
}





public CascoEN() : base ()
{
}



public CascoEN(int id, int vida, int defensa
               , string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, int precio
               )
{
        this.init (Id, vida, defensa, nombre, inventario, precio);
}


public CascoEN(CascoEN casco)
{
        this.init (Id, casco.Vida, casco.Defensa, casco.Nombre, casco.Inventario, casco.Precio);
}

private void init (int id
                   , int vida, int defensa, string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, int precio)
{
        this.Id = id;


        this.Vida = vida;

        this.Defensa = defensa;

        this.Nombre = nombre;

        this.Inventario = inventario;

        this.Precio = precio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        CascoEN t = obj as CascoEN;
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
