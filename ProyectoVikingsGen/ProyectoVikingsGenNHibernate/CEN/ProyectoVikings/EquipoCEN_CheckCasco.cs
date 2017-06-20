
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


/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Equipo_checkCasco) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
public partial class EquipoCEN
{
public bool CheckCasco (int p_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Equipo_checkCasco) ENABLED START*/

        // Write here your custom code...

        EquipoCAD equipoCAD = new EquipoCAD ();
        EquipoCEN equipoCEN = new EquipoCEN (equipoCAD);

        EquipoEN equipo = equipoCEN.DameEquipo (p_oid);

        if (equipo.CascoEquipado == true) {
                return true;
        }
        else
                return false;

        /*PROTECTED REGION END*/
}
}
}
