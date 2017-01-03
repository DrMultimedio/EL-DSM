
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





public ObjetoEN()
{
        inventario = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN>();
        inventarioEquipado = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN>();
}



public ObjetoEN(int id, string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado
                )
{
        this.init (Id, nombre, inventario, inventarioEquipado);
}


public ObjetoEN(ObjetoEN objeto)
{
        this.init (Id, objeto.Nombre, objeto.Inventario, objeto.InventarioEquipado);
}

private void init (int id
                   , string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Inventario = inventario;

        this.InventarioEquipado = inventarioEquipado;
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
