

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
 *      Definition of the class ArmaduraCEN
 *
 */
public partial class ArmaduraCEN
{
private IArmaduraCAD _IArmaduraCAD;

public ArmaduraCEN()
{
        this._IArmaduraCAD = new ArmaduraCAD ();
}

public ArmaduraCEN(IArmaduraCAD _IArmaduraCAD)
{
        this._IArmaduraCAD = _IArmaduraCAD;
}

public IArmaduraCAD get_IArmaduraCAD ()
{
        return this._IArmaduraCAD;
}

public int New_ (string p_Nombre, int p_Defensa, int p_Vida)
{
        ArmaduraEN armaduraEN = null;
        int oid;

        //Initialized ArmaduraEN
        armaduraEN = new ArmaduraEN ();
        armaduraEN.Nombre = p_Nombre;

        armaduraEN.Defensa = p_Defensa;

        armaduraEN.Vida = p_Vida;

        //Call to ArmaduraCAD

        oid = _IArmaduraCAD.New_ (armaduraEN);
        return oid;
}

public void Modify (int p_Armadura_OID, string p_Nombre, int p_Defensa, int p_Vida)
{
        ArmaduraEN armaduraEN = null;

        //Initialized ArmaduraEN
        armaduraEN = new ArmaduraEN ();
        armaduraEN.Id = p_Armadura_OID;
        armaduraEN.Nombre = p_Nombre;
        armaduraEN.Defensa = p_Defensa;
        armaduraEN.Vida = p_Vida;
        //Call to ArmaduraCAD

        _IArmaduraCAD.Modify (armaduraEN);
}

public void Destroy (int id
                     )
{
        _IArmaduraCAD.Destroy (id);
}
}
}
