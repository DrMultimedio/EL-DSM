
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;



/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CP.ProyectoVikings_Jugador_calcularDanyoExtra) ENABLED START*/
//  references to other libraries

using System.Collections.Generic;


/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class JugadorCP : BasicCP
{
public int CalcularDanyoExtra (int p_oid)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CP.ProyectoVikings_Jugador_calcularDanyoExtra) ENABLED START*/

        IJugadorCAD jugadorCAD = null;
        JugadorCEN jugadorCEN = null;

        int result = -1;


        try
        {
                SessionInitializeTransaction ();
                jugadorCAD = new JugadorCAD (session);
                jugadorCEN = new  JugadorCEN (jugadorCAD);



                // Write here your custom transaction ...

                ObjetoCAD objetosCAD = null;
                objetosCAD = new ObjetoCAD ();


                ObjetoCEN objetosCEN = null;
                objetosCEN = new ObjetoCEN ();

                ObjetoEN objetoEN = null;


                InventarioCAD inventarioCAD = null;
                inventarioCAD = new InventarioCAD ();


                InventarioCEN inventarioCEN = null;
                inventarioCEN = new InventarioCEN ();

                InventarioEN inventarioEN = null;

                inventarioEN = jugadorCEN.DameInventario (p_oid);
                System.Console.WriteLine ("Anters");

                IList<ObjetoEN> objetos = objetosCEN.DameObjetosPorInventario (inventarioEN.Id);
                System.Console.WriteLine ("despuers");
                
                   foreach (ObjetoEN o in inventarioEN.Objeto) {
                           System.Console.WriteLine (o.Nombre);
                           System.Console.WriteLine ("Hola");
                   }
                



                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                System.Console.WriteLine (ex.InnerException);

                throw ex;
        }
        finally
        {
                SessionClose ();
        }
        return result;


        /*PROTECTED REGION END*/
}
}
}
