

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
 *      Definition of the class ArmaCEN
 *
 */
public partial class ArmaCEN
{
private IArmaCAD _IArmaCAD;

public ArmaCEN()
{
        this._IArmaCAD = new ArmaCAD ();
}

public ArmaCEN(IArmaCAD _IArmaCAD)
{
        this._IArmaCAD = _IArmaCAD;
}

public IArmaCAD get_IArmaCAD ()
{
        return this._IArmaCAD;
}

public int New_ (string p_Nombre, int p_Ataque)
{
        ArmaEN armaEN = null;
        int oid;

        //Initialized ArmaEN
        armaEN = new ArmaEN ();
        armaEN.Nombre = p_Nombre;

        armaEN.Ataque = p_Ataque;

        //Call to ArmaCAD

        oid = _IArmaCAD.New_ (armaEN);
        return oid;
}

public void Modify (int p_Arma_OID, string p_Nombre, int p_Ataque)
{
        ArmaEN armaEN = null;

        //Initialized ArmaEN
        armaEN = new ArmaEN ();
        armaEN.Id = p_Arma_OID;
        armaEN.Nombre = p_Nombre;
        armaEN.Ataque = p_Ataque;
        //Call to ArmaCAD

        _IArmaCAD.Modify (armaEN);
}

public void Destroy (int id
                     )
{
        _IArmaCAD.Destroy (id);
}
}
}
