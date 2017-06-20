
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


/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Equipo_equipar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
public partial class EquipoCEN
{
public void Equipar (int p_Equipo_OID, System.Collections.Generic.IList<int> p_objeto_OIDs)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Equipo_equipar_customized) START*/
        EquipoCAD equipoCAD = new EquipoCAD();
        EquipoCEN equipoCEN = new EquipoCEN();

        EquipoEN equipoEN = new EquipoEN();
        equipoEN = equipoCEN.DameEquipo(p_Equipo_OID);

        
        //Call to EquipoCAD
        
        _IEquipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);

        /*PROTECTED REGION END*/
}
}
}
