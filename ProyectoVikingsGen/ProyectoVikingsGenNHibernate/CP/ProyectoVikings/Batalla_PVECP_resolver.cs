
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;



/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CP.ProyectoVikings_Batalla_PVE_resolver) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class Batalla_PVECP : BasicCP
{
public void Resolver (int id_jugador, int id_monstruo)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CP.ProyectoVikings_Batalla_PVE_resolver) ENABLED START*/

        IBatalla_PVECAD batalla_PVECAD = null;
        Batalla_PVECEN batalla_PVECEN = null;



        try
        {
                SessionInitializeTransaction ();
                batalla_PVECAD = new Batalla_PVECAD (session);
                batalla_PVECEN = new  Batalla_PVECEN (batalla_PVECAD);



                // Write here your custom transaction ...

                throw new NotImplementedException ("Method Resolver() not yet implemented.");



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
