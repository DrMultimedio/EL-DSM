

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.Exceptions;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;


namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
/*
 *      Definition of the class CascoCEN
 *
 */
public partial class CascoCEN
{
private ICascoCAD _ICascoCAD;

public CascoCEN()
{
        this._ICascoCAD = new CascoCAD ();
}

public CascoCEN(ICascoCAD _ICascoCAD)
{
        this._ICascoCAD = _ICascoCAD;
}

public ICascoCAD get_ICascoCAD ()
{
        return this._ICascoCAD;
}

public int New_ (string p_Nombre, int p_Vida, int p_Defensa)
{
        CascoEN cascoEN = null;
        int oid;

        //Initialized CascoEN
        cascoEN = new CascoEN ();
        cascoEN.Nombre = p_Nombre;

        cascoEN.Vida = p_Vida;

        cascoEN.Defensa = p_Defensa;

        //Call to CascoCAD

        oid = _ICascoCAD.New_ (cascoEN);
        return oid;
}

public void Modify (int p_Casco_OID, string p_Nombre, int p_Vida, int p_Defensa)
{
        CascoEN cascoEN = null;

        //Initialized CascoEN
        cascoEN = new CascoEN ();
        cascoEN.Id = p_Casco_OID;
        cascoEN.Nombre = p_Nombre;
        cascoEN.Vida = p_Vida;
        cascoEN.Defensa = p_Defensa;
        //Call to CascoCAD

        _ICascoCAD.Modify (cascoEN);
}

public void Destroy (int id
                     )
{
        _ICascoCAD.Destroy (id);
}
}
}
