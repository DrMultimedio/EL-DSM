
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
 * Clase Arma:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class ArmaCAD : BasicCAD, IArmaCAD
{
public ArmaCAD() : base ()
{
}

public ArmaCAD(ISession sessionAux) : base (sessionAux)
{
}



public ArmaEN ReadOIDDefault (int id
                              )
{
        ArmaEN armaEN = null;

        try
        {
                SessionInitializeTransaction ();
                armaEN = (ArmaEN)session.Get (typeof(ArmaEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return armaEN;
}

public System.Collections.Generic.IList<ArmaEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ArmaEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ArmaEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ArmaEN>();
                        else
                                result = session.CreateCriteria (typeof(ArmaEN)).List<ArmaEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ArmaEN arma)
{
        try
        {
                SessionInitializeTransaction ();
                ArmaEN armaEN = (ArmaEN)session.Load (typeof(ArmaEN), arma.Id);

                armaEN.Ataque = arma.Ataque;

                session.Update (armaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ArmaEN arma)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (arma);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return arma.Id;
}

public void Modify (ArmaEN arma)
{
        try
        {
                SessionInitializeTransaction ();
                ArmaEN armaEN = (ArmaEN)session.Load (typeof(ArmaEN), arma.Id);

                armaEN.Nombre = arma.Nombre;


                armaEN.Precio = arma.Precio;


                armaEN.Ataque = arma.Ataque;

                session.Update (armaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaCAD.", ex);
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
                ArmaEN armaEN = (ArmaEN)session.Load (typeof(ArmaEN), id);
                session.Delete (armaEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
