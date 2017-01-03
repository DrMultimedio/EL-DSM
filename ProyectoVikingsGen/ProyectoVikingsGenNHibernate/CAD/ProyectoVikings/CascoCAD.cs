
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
 * Clase Casco:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class CascoCAD : BasicCAD, ICascoCAD
{
public CascoCAD() : base ()
{
}

public CascoCAD(ISession sessionAux) : base (sessionAux)
{
}



public CascoEN ReadOIDDefault (int id
                               )
{
        CascoEN cascoEN = null;

        try
        {
                SessionInitializeTransaction ();
                cascoEN = (CascoEN)session.Get (typeof(CascoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CascoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return cascoEN;
}

public System.Collections.Generic.IList<CascoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<CascoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(CascoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<CascoEN>();
                        else
                                result = session.CreateCriteria (typeof(CascoEN)).List<CascoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CascoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (CascoEN casco)
{
        try
        {
                SessionInitializeTransaction ();
                CascoEN cascoEN = (CascoEN)session.Load (typeof(CascoEN), casco.Id);

                cascoEN.Vida = casco.Vida;


                cascoEN.Defensa = casco.Defensa;

                session.Update (cascoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CascoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (CascoEN casco)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (casco);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CascoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return casco.Id;
}

public void Modify (CascoEN casco)
{
        try
        {
                SessionInitializeTransaction ();
                CascoEN cascoEN = (CascoEN)session.Load (typeof(CascoEN), casco.Id);

                cascoEN.Nombre = casco.Nombre;


                cascoEN.Vida = casco.Vida;


                cascoEN.Defensa = casco.Defensa;

                session.Update (cascoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CascoCAD.", ex);
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
                CascoEN cascoEN = (CascoEN)session.Load (typeof(CascoEN), id);
                session.Delete (cascoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in CascoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
