
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;


/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Objeto_dameTipo) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
public partial class ObjetoCEN
{
public ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum DameTipo (int p_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Objeto_dameTipo) ENABLED START*/

        // Write here your custom code...

        ObjetoCEN objetoCEN = new ObjetoCEN ();

        return objetoCEN.ReadOID (p_oid).Tipo;


        /*PROTECTED REGION END*/
}
}
}
