
using System;
using System.Text;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.Exceptions;


/*
 * Clase Calzado:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class CalzadoCAD : BasicCAD, ICalzadoCAD
{
public CalzadoCAD() : base ()
{
}

public CalzadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public CalzadoEN ReadOIDDefault (int id
                                 )
{
        CalzadoEN calzadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                calzadoEN = (CalzadoEN)session.Get (typeof(CalzadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CalzadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return calzadoEN;
}

public System.Collections.Generic.IList<CalzadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CalzadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CalzadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CalzadoEN>();
                        else
                                result = session.CreateCriteria (typeof(CalzadoEN)).List<CalzadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CalzadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CalzadoEN calzado)
{
        try
        {
                SessionInitializeTransaction ();
                CalzadoEN calzadoEN = (CalzadoEN)session.Load (typeof(CalzadoEN), calzado.Id);

                calzadoEN.Vida = calzado.Vida;


                calzadoEN.Defensa = calzado.Defensa;

                session.Update (calzadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CalzadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CalzadoEN calzado)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (calzado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CalzadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return calzado.Id;
}

public void Modify (CalzadoEN calzado)
{
        try
        {
                SessionInitializeTransaction ();
                CalzadoEN calzadoEN = (CalzadoEN)session.Load (typeof(CalzadoEN), calzado.Id);

                calzadoEN.Nombre = calzado.Nombre;


                calzadoEN.Precio = calzado.Precio;


                calzadoEN.Vida = calzado.Vida;


                calzadoEN.Defensa = calzado.Defensa;

                session.Update (calzadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CalzadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Destroy (int id
                     )
{
        try
        {
                SessionInitializeTransaction ();
                CalzadoEN calzadoEN = (CalzadoEN)session.Load (typeof(CalzadoEN), id);
                session.Delete (calzadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CalzadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
