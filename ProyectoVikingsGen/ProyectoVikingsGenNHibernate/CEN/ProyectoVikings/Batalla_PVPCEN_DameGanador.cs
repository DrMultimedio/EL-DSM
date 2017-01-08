
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


/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Batalla_PVP_dameGanador) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
public partial class Batalla_PVPCEN
{
public int DameGanador (int b_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Batalla_PVP_dameGanador) ENABLED START*/

        // Write here your custom code...

        Batalla_PVPEN en = _IBatalla_PVPCAD.ReadOIDDefault (b_oid);

        return en.IdGanador;

        /*PROTECTED REGION END*/
}
}
}
