
using System;
// Definición clase ArmaduraEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class ArmaduraEN                                                                     : ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN


{
/**
 *	Atributo defensa
 */
private int defensa;



/**
 *	Atributo vida
 */
private int vida;






public virtual int Defensa {
        get { return defensa; } set { defensa = value;  }
}



public virtual int Vida {
        get { return vida; } set { vida = value;  }
}





public ArmaduraEN() : base ()
{
}



public ArmaduraEN(int id, int defensa, int vida
                  , string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado
                  )
{
        this.init (Id, defensa, vida, nombre, inventario, inventarioEquipado);
}


public ArmaduraEN(ArmaduraEN armadura)
{
        this.init (Id, armadura.Defensa, armadura.Vida, armadura.Nombre, armadura.Inventario, armadura.InventarioEquipado);
}

private void init (int id
                   , int defensa, int vida, string nombre, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> inventarioEquipado)
{
        this.Id = id;


        this.Defensa = defensa;

        this.Vida = vida;

        this.Nombre = nombre;

        this.Inventario = inventario;

        this.InventarioEquipado = inventarioEquipado;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        ArmaduraEN t = obj as ArmaduraEN;
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
