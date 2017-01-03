
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
 * Clase Batalla_PVE:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class Batalla_PVECAD : BasicCAD, IBatalla_PVECAD
{
public Batalla_PVECAD() : base ()
{
}

public Batalla_PVECAD(ISession sessionAux) : base (sessionAux)
{
}



public Batalla_PVEEN ReadOIDDefault (int id
                                     )
{
        Batalla_PVEEN batalla_PVEEN = null;

        try
        {
                SessionInitializeTransaction ();
                batalla_PVEEN = (Batalla_PVEEN)session.Get (typeof(Batalla_PVEEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return batalla_PVEEN;
}

public System.Collections.Generic.IList<Batalla_PVEEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Batalla_PVEEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Batalla_PVEEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<Batalla_PVEEN>();
                        else
                                result = session.CreateCriteria (typeof(Batalla_PVEEN)).List<Batalla_PVEEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Batalla_PVEEN batalla_PVE)
{
        try
        {
                SessionInitializeTransaction ();
                Batalla_PVEEN batalla_PVEEN = (Batalla_PVEEN)session.Load (typeof(Batalla_PVEEN), batalla_PVE.Id);



                batalla_PVEEN.Recompensa = batalla_PVE.Recompensa;


                batalla_PVEEN.TipoGanador = batalla_PVE.TipoGanador;

                session.Update (batalla_PVEEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (Batalla_PVEEN batalla_PVE)
{
        try
        {
                SessionInitializeTransaction ();
                if (batalla_PVE.Monstruo != null) {
                        // Argumento OID y no colección.
                        batalla_PVE.Monstruo = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.MonstruoEN), batalla_PVE.Monstruo.Id);

                        batalla_PVE.Monstruo.Batalla_PVE
                                = batalla_PVE;
                }
                if (batalla_PVE.Jugador != null) {
                        // Argumento OID y no colección.
                        batalla_PVE.Jugador = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN), batalla_PVE.Jugador.Id);

                        batalla_PVE.Jugador.Batalla_PVE
                                = batalla_PVE;
                }

                session.Save (batalla_PVE);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return batalla_PVE.Id;
}

public void Modify (Batalla_PVEEN batalla_PVE)
{
        try
        {
                SessionInitializeTransaction ();
                Batalla_PVEEN batalla_PVEEN = (Batalla_PVEEN)session.Load (typeof(Batalla_PVEEN), batalla_PVE.Id);

                batalla_PVEEN.Recompensa = batalla_PVE.Recompensa;


                batalla_PVEEN.TipoGanador = batalla_PVE.TipoGanador;

                session.Update (batalla_PVEEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
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
                Batalla_PVEEN batalla_PVEEN = (Batalla_PVEEN)session.Load (typeof(Batalla_PVEEN), id);
                session.Delete (batalla_PVEEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: Batalla_PVEEN
public Batalla_PVEEN ReadOID (int id
                              )
{
        Batalla_PVEEN batalla_PVEEN = null;

        try
        {
                SessionInitializeTransaction ();
                batalla_PVEEN = (Batalla_PVEEN)session.Get (typeof(Batalla_PVEEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return batalla_PVEEN;
}

public System.Collections.Generic.IList<Batalla_PVEEN> ReadAll (int first, int size)
{
        System.Collections.Generic.IList<Batalla_PVEEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(Batalla_PVEEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<Batalla_PVEEN>();
                else
                        result = session.CreateCriteria (typeof(Batalla_PVEEN)).List<Batalla_PVEEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVECAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
