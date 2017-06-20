
using System;
// Definición clase EquipoEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class EquipoEN
{
/**
 *	Atributo jugador
 */
private ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador;



/**
 *	Atributo armaEquipada
 */
private bool armaEquipada;



/**
 *	Atributo pecheraEquipada
 */
private bool pecheraEquipada;



/**
 *	Atributo grebasEquipadas
 */
private bool grebasEquipadas;



/**
 *	Atributo cascoEquipado
 */
private bool cascoEquipado;



/**
 *	Atributo objeto
 */
private System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto;



/**
 *	Atributo id
 */
private int id;






public virtual ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN Jugador {
        get { return jugador; } set { jugador = value;  }
}



public virtual bool ArmaEquipada {
        get { return armaEquipada; } set { armaEquipada = value;  }
}



public virtual bool PecheraEquipada {
        get { return pecheraEquipada; } set { pecheraEquipada = value;  }
}



public virtual bool GrebasEquipadas {
        get { return grebasEquipadas; } set { grebasEquipadas = value;  }
}



public virtual bool CascoEquipado {
        get { return cascoEquipado; } set { cascoEquipado = value;  }
}



public virtual System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> Objeto {
        get { return objeto; } set { objeto = value;  }
}



public virtual int Id {
        get { return id; } set { id = value;  }
}





public EquipoEN()
{
        objeto = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN>();
}



public EquipoEN(int id, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, bool armaEquipada, bool pecheraEquipada, bool grebasEquipadas, bool cascoEquipado, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto
                )
{
        this.init (Id, jugador, armaEquipada, pecheraEquipada, grebasEquipadas, cascoEquipado, objeto);
}


public EquipoEN(EquipoEN equipo)
{
        this.init (Id, equipo.Jugador, equipo.ArmaEquipada, equipo.PecheraEquipada, equipo.GrebasEquipadas, equipo.CascoEquipado, equipo.Objeto);
}

private void init (int id
                   , ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN jugador, bool armaEquipada, bool pecheraEquipada, bool grebasEquipadas, bool cascoEquipado, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objeto)
{
        this.Id = id;


        this.Jugador = jugador;

        this.ArmaEquipada = armaEquipada;

        this.PecheraEquipada = pecheraEquipada;

        this.GrebasEquipadas = grebasEquipadas;

        this.CascoEquipado = cascoEquipado;

        this.Objeto = objeto;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        EquipoEN t = obj as EquipoEN;
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
