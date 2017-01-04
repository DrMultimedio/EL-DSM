

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
 *      Definition of the class MonstruoCEN
 *
 */
public partial class MonstruoCEN
{
private IMonstruoCAD _IMonstruoCAD;

public MonstruoCEN()
{
        this._IMonstruoCAD = new MonstruoCAD ();
}

public MonstruoCEN(IMonstruoCAD _IMonstruoCAD)
{
        this._IMonstruoCAD = _IMonstruoCAD;
}

public IMonstruoCAD get_IMonstruoCAD ()
{
        return this._IMonstruoCAD;
}

public int New_ (string p_Nombre, int p_Vida, int p_Ataque, int p_Defensa)
{
        MonstruoEN monstruoEN = null;
        int oid;

        //Initialized MonstruoEN
        monstruoEN = new MonstruoEN ();
        monstruoEN.Nombre = p_Nombre;

        monstruoEN.Vida = p_Vida;

        monstruoEN.Ataque = p_Ataque;

        monstruoEN.Defensa = p_Defensa;

        //Call to MonstruoCAD

        oid = _IMonstruoCAD.New_ (monstruoEN);
        return oid;
}

public void Modify (int p_Monstruo_OID, string p_Nombre, int p_Vida, int p_Ataque, int p_Defensa)
{
        MonstruoEN monstruoEN = null;

        //Initialized MonstruoEN
        monstruoEN = new MonstruoEN ();
        monstruoEN.Id = p_Monstruo_OID;
        monstruoEN.Nombre = p_Nombre;
        monstruoEN.Vida = p_Vida;
        monstruoEN.Ataque = p_Ataque;
        monstruoEN.Defensa = p_Defensa;
        //Call to MonstruoCAD

        _IMonstruoCAD.Modify (monstruoEN);
}

public void Destroy (int id
                     )
{
        _IMonstruoCAD.Destroy (id);
}

public System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN> DameMonstruosBatalla ()
{
        return _IMonstruoCAD.DameMonstruosBatalla ();
}
}
}
