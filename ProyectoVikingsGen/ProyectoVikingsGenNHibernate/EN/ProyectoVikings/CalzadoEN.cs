
using System;
// Definición clase CalzadoEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class CalzadoEN                                                                      : ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN


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





public CalzadoEN() : base ()
{
}



public CalzadoEN(int id, int vida, int defensa
                 , string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, int precio
                 )
{
        this.init (Id, vida, defensa, nombre, inventario, precio);
}


public CalzadoEN(CalzadoEN calzado)
{
        this.init (Id, calzado.Vida, calzado.Defensa, calzado.Nombre, calzado.Inventario, calzado.Precio);
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
        CalzadoEN t = obj as CalzadoEN;
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
