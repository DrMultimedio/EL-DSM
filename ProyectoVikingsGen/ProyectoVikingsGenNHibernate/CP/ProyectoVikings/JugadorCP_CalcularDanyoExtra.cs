
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

        int result = 0;


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

                EquipoCAD equipoCAD = null;
                equipoCAD = new EquipoCAD ();


                EquipoCEN equipoCEN = null;
                equipoCEN = new EquipoCEN ();

                EquipoEN equipoEN = null;
                JugadorEN jugador = null;
                jugador = jugadorCEN.ReadOID (p_oid);

                equipoEN = jugadorCEN.DameEquipo (p_oid);

                IList<ObjetoEN> objetos = objetosCEN.DameObjetosPorEquipo (equipoEN.Id);

                foreach (ObjetoEN o in objetos) {
                        System.Console.WriteLine (o.Nombre);
                        result = result + o.Ataque;
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
