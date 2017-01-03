

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
 *      Definition of the class ObjetoCEN
 *
 */
public partial class ObjetoCEN
{
private IObjetoCAD _IObjetoCAD;

public ObjetoCEN()
{
        this._IObjetoCAD = new ObjetoCAD ();
}

public ObjetoCEN(IObjetoCAD _IObjetoCAD)
{
        this._IObjetoCAD = _IObjetoCAD;
}

public IObjetoCAD get_IObjetoCAD ()
{
        return this._IObjetoCAD;
}

public int New_ (string p_Nombre)
{
        ObjetoEN objetoEN = null;
        int oid;

        //Initialized ObjetoEN
        objetoEN = new ObjetoEN ();
        objetoEN.Nombre = p_Nombre;

        //Call to ObjetoCAD

        oid = _IObjetoCAD.New_ (objetoEN);
        return oid;
}

public void Modify (int p_Objeto_OID, string p_Nombre)
{
        ObjetoEN objetoEN = null;

        //Initialized ObjetoEN
        objetoEN = new ObjetoEN ();
        objetoEN.Id = p_Objeto_OID;
        objetoEN.Nombre = p_Nombre;
        //Call to ObjetoCAD

        _IObjetoCAD.Modify (objetoEN);
}

public void Destroy (int id
                     )
{
        _IObjetoCAD.Destroy (id);
}
}
}