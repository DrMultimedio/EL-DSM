
using System;
// Definición clase ArmaEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class ArmaEN                                                                 : ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN


{
/**
 *	Atributo ataque
 */
private int ataque;






public virtual int Ataque {
        get { return ataque; } set { ataque = value;  }
}





public ArmaEN() : base ()
{
}



public ArmaEN(int id, int ataque
              , string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado, int precio
              )
{
        this.init (Id, ataque, nombre, inventario, inventarioEquipado, precio);
}


public ArmaEN(ArmaEN arma)
{
        this.init (Id, arma.Ataque, arma.Nombre, arma.Inventario, arma.InventarioEquipado, arma.Precio);
}

private void init (int id
                   , int ataque, string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado, int precio)
{
        this.Id = id;


        this.Ataque = ataque;

        this.Nombre = nombre;

        this.Inventario = inventario;

        this.InventarioEquipado = inventarioEquipado;

        this.Precio = precio;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ArmaEN t = obj as ArmaEN;
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
