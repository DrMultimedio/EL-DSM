
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
 * Clase Monstruo:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class MonstruoCAD : BasicCAD, IMonstruoCAD
{
public MonstruoCAD() : base ()
{
}

public MonstruoCAD(ISession sessionAux) : base (sessionAux)
{
}



public MonstruoEN ReadOIDDefault (int id
                                  )
{
        MonstruoEN monstruoEN = null;

        try
        {
                SessionInitializeTransaction ();
                monstruoEN = (MonstruoEN)session.Get (typeof(MonstruoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in MonstruoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return monstruoEN;
}

public System.Collections.Generic.IList<MonstruoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<MonstruoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(MonstruoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<MonstruoEN>();
                        else
                                result = session.CreateCriteria (typeof(MonstruoEN)).List<MonstruoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in MonstruoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (MonstruoEN monstruo)
{
        try
        {
                SessionInitializeTransaction ();
                MonstruoEN monstruoEN = (MonstruoEN)session.Load (typeof(MonstruoEN), monstruo.Id);

                monstruoEN.Nombre = monstruo.Nombre;


                monstruoEN.Vida = monstruo.Vida;


                monstruoEN.Ataque = monstruo.Ataque;


                monstruoEN.Defensa = monstruo.Defensa;


                session.Update (monstruoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in MonstruoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (MonstruoEN monstruo)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (monstruo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in MonstruoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return monstruo.Id;
}

public void Modify (MonstruoEN monstruo)
{
        try
        {
                SessionInitializeTransaction ();
                MonstruoEN monstruoEN = (MonstruoEN)session.Load (typeof(MonstruoEN), monstruo.Id);

                monstruoEN.Nombre = monstruo.Nombre;


                monstruoEN.Vida = monstruo.Vida;


                monstruoEN.Ataque = monstruo.Ataque;


                monstruoEN.Defensa = monstruo.Defensa;

                session.Update (monstruoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in MonstruoCAD.", ex);
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
                MonstruoEN monstruoEN = (MonstruoEN)session.Load (typeof(MonstruoEN), id);
                session.Delete (monstruoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in MonstruoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN> DameMonstruosBatalla ()
{
        System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM MonstruoEN self where FROM MonstruoEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("MonstruoENdameMonstruosBatallaHQL");

                result = query.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in MonstruoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
