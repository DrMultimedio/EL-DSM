
using System;
// Definición clase ObjetoEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class ObjetoEN
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
 *	Atributo inventario
 */
private System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario;



/**
 *	Atributo precio
 */
private int precio;



/**
 *	Atributo tipo
 */
private ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum tipo;



/**
 *	Atributo ataque
 */
private int ataque;



/**
 *	Atributo defensa
 */
private int defensa;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> Inventario {
        get { return inventario; } set { inventario = value;  }
}



public virtual int Precio {
        get { return precio; } set { precio = value;  }
}



public virtual ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum Tipo {
        get { return tipo; } set { tipo = value;  }
}



public virtual int Ataque {
        get { return ataque; } set { ataque = value;  }
}



public virtual int Defensa {
        get { return defensa; } set { defensa = value;  }
}





public ObjetoEN()
{
        inventario = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN>();
}



public ObjetoEN(int id, string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, int precio, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum tipo, int ataque, int defensa
                )
{
        this.init (Id, nombre, inventario, precio, tipo, ataque, defensa);
}


public ObjetoEN(ObjetoEN objeto)
{
        this.init (Id, objeto.Nombre, objeto.Inventario, objeto.Precio, objeto.Tipo, objeto.Ataque, objeto.Defensa);
}

private void init (int id
                   , string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, int precio, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum tipo, int ataque, int defensa)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Inventario = inventario;

        this.Precio = precio;

        this.Tipo = tipo;

        this.Ataque = ataque;

        this.Defensa = defensa;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ObjetoEN t = obj as ObjetoEN;
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
