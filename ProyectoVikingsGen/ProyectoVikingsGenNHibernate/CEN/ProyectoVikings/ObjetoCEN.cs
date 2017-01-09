

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

public int New_ (string p_Nombre, int p_Precio)
{
        ObjetoEN objetoEN = null;
        int oid;

        //Initialized ObjetoEN
        objetoEN = new ObjetoEN ();
        objetoEN.Nombre = p_Nombre;

        objetoEN.Precio = p_Precio;

        //Call to ObjetoCAD

        oid = _IObjetoCAD.New_ (objetoEN);
        return oid;
}

public void Modify (int p_Objeto_OID, string p_Nombre, int p_Precio)
{
        ObjetoEN objetoEN = null;

        //Initialized ObjetoEN
        objetoEN = new ObjetoEN ();
        objetoEN.Id = p_Objeto_OID;
        objetoEN.Nombre = p_Nombre;
        objetoEN.Precio = p_Precio;
        //Call to ObjetoCAD

        _IObjetoCAD.Modify (objetoEN);
}

public void Destroy (int id
                     )
{
        _IObjetoCAD.Destroy (id);
}

public ObjetoEN ReadOID (int id
                         )
{
        ObjetoEN objetoEN = null;

        objetoEN = _IObjetoCAD.ReadOID (id);
        return objetoEN;
}

public System.Collections.Generic.IList<ObjetoEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<ObjetoEN> list = null;

        list = _IObjetoCAD.ReadAll (first, size);
        return list;
}
public System.Collections.Generic.IList<int> DameObjetosPorInventario (int i_oid)
{
        return _IObjetoCAD.DameObjetosPorInventario (i_oid);
}
}
}
