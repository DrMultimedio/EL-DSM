
using System;
// Definición clase JugadorEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class JugadorEN
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
 *	Atributo email
 */
private string email;



/**
 *	Atributo cumple
 */
private Nullable<DateTime> cumple;



/**
 *	Atributo genero
 */
private string genero;



/**
 *	Atributo vidamax
 */
private int vidamax;



/**
 *	Atributo vidaAct
 */
private int vidaAct;



/**
 *	Atributo ataque
 */
private int ataque;



/**
 *	Atributo defensa
 */
private int defensa;



/**
 *	Atributo oro
 */
private int oro;



/**
 *	Atributo inventario
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN inventario;



/**
 *	Atributo batalla_PVE
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN batalla_PVE;



/**
 *	Atributo batalla_PVP
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN batalla_PVP;



/**
 *	Atributo batalla_PVP_0
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN batalla_PVP_0;



/**
 *	Atributo inventarioEquipado
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN inventarioEquipado;



/**
 *	Atributo password
 */
private String password;






public virtual int Id {
        get { return id; } set { id = value;  }
}



public virtual string Nombre {
        get { return nombre; } set { nombre = value;  }
}



public virtual string Email {
        get { return email; } set { email = value;  }
}



public virtual Nullable<DateTime> Cumple {
        get { return cumple; } set { cumple = value;  }
}



public virtual string Genero {
        get { return genero; } set { genero = value;  }
}



public virtual int Vidamax {
        get { return vidamax; } set { vidamax = value;  }
}



public virtual int VidaAct {
        get { return vidaAct; } set { vidaAct = value;  }
}



public virtual int Ataque {
        get { return ataque; } set { ataque = value;  }
}



public virtual int Defensa {
        get { return defensa; } set { defensa = value;  }
}



public virtual int Oro {
        get { return oro; } set { oro = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN Inventario {
        get { return inventario; } set { inventario = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN Batalla_PVE {
        get { return batalla_PVE; } set { batalla_PVE = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN Batalla_PVP {
        get { return batalla_PVP; } set { batalla_PVP = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN Batalla_PVP_0 {
        get { return batalla_PVP_0; } set { batalla_PVP_0 = value;  }
}



public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN InventarioEquipado {
        get { return inventarioEquipado; } set { inventarioEquipado = value;  }
}



public virtual String Password {
        get { return password; } set { password = value;  }
}





public JugadorEN()
{
}



public JugadorEN(int id, string nombre, string email, Nullable<DateTime> cumple, string genero, int vidamax, int vidaAct, int ataque, int defensa, int oro, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN inventario, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN batalla_PVE, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN batalla_PVP, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN batalla_PVP_0, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN inventarioEquipado, String password
                 )
{
        this.init (Id, nombre, email, cumple, genero, vidamax, vidaAct, ataque, defensa, oro, inventario, batalla_PVE, batalla_PVP, batalla_PVP_0, inventarioEquipado, password);
}


public JugadorEN(JugadorEN jugador)
{
        this.init (Id, jugador.Nombre, jugador.Email, jugador.Cumple, jugador.Genero, jugador.Vidamax, jugador.VidaAct, jugador.Ataque, jugador.Defensa, jugador.Oro, jugador.Inventario, jugador.Batalla_PVE, jugador.Batalla_PVP, jugador.Batalla_PVP_0, jugador.InventarioEquipado, jugador.Password);
}

private void init (int id
                   , string nombre, string email, Nullable<DateTime> cumple, string genero, int vidamax, int vidaAct, int ataque, int defensa, int oro, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN inventario, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN batalla_PVE, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN batalla_PVP, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN batalla_PVP_0, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN inventarioEquipado, String password)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Email = email;

        this.Cumple = cumple;

        this.Genero = genero;

        this.Vidamax = vidamax;

        this.VidaAct = vidaAct;

        this.Ataque = ataque;

        this.Defensa = defensa;

        this.Oro = oro;

        this.Inventario = inventario;

        this.Batalla_PVE = batalla_PVE;

        this.Batalla_PVP = batalla_PVP;

        this.Batalla_PVP_0 = batalla_PVP_0;

        this.InventarioEquipado = inventarioEquipado;

        this.Password = password;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        JugadorEN t = obj as JugadorEN;
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
