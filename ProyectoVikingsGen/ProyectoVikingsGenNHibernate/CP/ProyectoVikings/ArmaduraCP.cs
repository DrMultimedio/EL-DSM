
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using ProyectoVikingsGenNHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;


namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class ArmaduraCP : BasicCP
{
public ArmaduraCP() : base ()
{
}

public ArmaduraCP(ISession sessionAux)
        : base (sessionAux)
{
}
}
}
