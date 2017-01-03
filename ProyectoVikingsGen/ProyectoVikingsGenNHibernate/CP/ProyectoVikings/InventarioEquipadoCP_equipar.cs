
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;



/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CP.ProyectoVikings_InventarioEquipado_equipar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class InventarioEquipadoCP : BasicCP
{
public void Equipar (int p_InventarioEquipado_OID, System.Collections.Generic.IList<int> p_objeto_0_OIDs)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CP.ProyectoVikings_InventarioEquipado_equipar) ENABLED START*/

        IInventarioEquipadoCAD inventarioEquipadoCAD = null;
        InventarioEquipadoCEN inventarioEquipadoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                inventarioEquipadoCAD = new InventarioEquipadoCAD (session);
                inventarioEquipadoCEN = new  InventarioEquipadoCEN (inventarioEquipadoCAD);






                //Call to InventarioEquipadoCAD

                inventarioEquipadoCAD.Equipar (p_InventarioEquipado_OID, p_objeto_0_OIDs);



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
