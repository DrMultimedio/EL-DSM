
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;



/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CP.ProyectoVikings_Jugador_comprar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class JugadorCP : BasicCP
{
public void Comprar (int p_oid, int o_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CP.ProyectoVikings_Jugador_comprar) ENABLED START*/

        IJugadorCAD jugadorCAD = null;
        JugadorCEN jugadorCEN = null;



        try
        {
                SessionInitializeTransaction ();
                jugadorCAD = new JugadorCAD (session);
                jugadorCEN = new  JugadorCEN (jugadorCAD);



                // Write here your custom transaction ...
                //definimos inventario y objeto y sus CAD y CEN
                InventarioCAD inventarioCAD = null;
                inventarioCAD = new InventarioCAD ();
                InventarioCEN inventarioCEN = null;
                inventarioCEN = new InventarioCEN ();

                ObjetoCAD objetoCAD = null;
                objetoCAD = new ObjetoCAD ();
                ObjetoCEN objetoCEN = null;
                objetoCEN = new ObjetoCEN ();

                int oro = jugadorCEN.DameOro();
                

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
