
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
 *	Atributo inventarioEquipado
 */
private System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado;



/**
 *	Atributo precio
 */
private int precio;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> Inventario {
        get { return inventario; } set { inventario = value;  }
}



public virtual System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> InventarioEquipado {
        get { return inventarioEquipado; } set { inventarioEquipado = value;  }
}



public virtual int Precio {
        get { return precio; } set { precio = value;  }
}





public ObjetoEN()
{
        inventario = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN>();
        inventarioEquipado = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN>();
}



public ObjetoEN(int id, string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado, int precio
                )
{
        this.init (Id, nombre, inventario, inventarioEquipado, precio);
}


public ObjetoEN(ObjetoEN objeto)
{
        this.init (Id, objeto.Nombre, objeto.Inventario, objeto.InventarioEquipado, objeto.Precio);
}

private void init (int id
                   , string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado, int precio)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Inventario = inventario;

        this.InventarioEquipado = inventarioEquipado;

        this.Precio = precio;
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
