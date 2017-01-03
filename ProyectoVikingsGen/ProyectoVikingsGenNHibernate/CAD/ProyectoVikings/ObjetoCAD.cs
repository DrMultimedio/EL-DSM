
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
 * Clase Objeto:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class ObjetoCAD : BasicCAD, IObjetoCAD
{
public ObjetoCAD() : base ()
{
}

public ObjetoCAD(ISession sessionAux) : base (sessionAux)
{
}



public ObjetoEN ReadOIDDefault (int id
                                )
{
        ObjetoEN objetoEN = null;

        try
        {
                SessionInitializeTransaction ();
                objetoEN = (ObjetoEN)session.Get (typeof(ObjetoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ObjetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return objetoEN;
}

public System.Collections.Generic.IList<ObjetoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ObjetoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ObjetoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ObjetoEN>();
                        else
                                result = session.CreateCriteria (typeof(ObjetoEN)).List<ObjetoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ObjetoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ObjetoEN objeto)
{
        try
        {
                SessionInitializeTransaction ();
                ObjetoEN objetoEN = (ObjetoEN)session.Load (typeof(ObjetoEN), objeto.Id);

                objetoEN.Nombre = objeto.Nombre;



                session.Update (objetoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ObjetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ObjetoEN objeto)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (objeto);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ObjetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return objeto.Id;
}

public void Modify (ObjetoEN objeto)
{
        try
        {
                SessionInitializeTransaction ();
                ObjetoEN objetoEN = (ObjetoEN)session.Load (typeof(ObjetoEN), objeto.Id);

                objetoEN.Nombre = objeto.Nombre;

                session.Update (objetoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ObjetoCAD.", ex);
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
                ObjetoEN objetoEN = (ObjetoEN)session.Load (typeof(ObjetoEN), id);
                session.Delete (objetoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ObjetoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
