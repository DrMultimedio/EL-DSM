

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
 *      Definition of the class CalzadoCEN
 *
 */
public partial class CalzadoCEN
{
private ICalzadoCAD _ICalzadoCAD;

public CalzadoCEN()
{
        this._ICalzadoCAD = new CalzadoCAD ();
}

public CalzadoCEN(ICalzadoCAD _ICalzadoCAD)
{
        this._ICalzadoCAD = _ICalzadoCAD;
}

public ICalzadoCAD get_ICalzadoCAD ()
{
        return this._ICalzadoCAD;
}

public int New_ (string p_Nombre, int p_Vida, int p_Defensa)
{
        CalzadoEN calzadoEN = null;
        int oid;

        //Initialized CalzadoEN
        calzadoEN = new CalzadoEN ();
        calzadoEN.Nombre = p_Nombre;

        calzadoEN.Vida = p_Vida;

        calzadoEN.Defensa = p_Defensa;

        //Call to CalzadoCAD

        oid = _ICalzadoCAD.New_ (calzadoEN);
        return oid;
}

public void Modify (int p_Calzado_OID, string p_Nombre, int p_Vida, int p_Defensa)
{
        CalzadoEN calzadoEN = null;

        //Initialized CalzadoEN
        calzadoEN = new CalzadoEN ();
        calzadoEN.Id = p_Calzado_OID;
        calzadoEN.Nombre = p_Nombre;
        calzadoEN.Vida = p_Vida;
        calzadoEN.Defensa = p_Defensa;
        //Call to CalzadoCAD

        _ICalzadoCAD.Modify (calzadoEN);
}

public void Destroy (int id
                     )
{
        _ICalzadoCAD.Destroy (id);
}
}
}
