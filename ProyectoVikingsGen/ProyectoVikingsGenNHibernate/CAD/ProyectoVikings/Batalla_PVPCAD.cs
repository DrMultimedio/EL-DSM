
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
 * Clase Batalla_PVP:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class Batalla_PVPCAD : BasicCAD, IBatalla_PVPCAD
{
public Batalla_PVPCAD() : base ()
{
}

public Batalla_PVPCAD(ISession sessionAux) : base (sessionAux)
{
}



public Batalla_PVPEN ReadOIDDefault (int id
                                     )
{
        Batalla_PVPEN batalla_PVPEN = null;

        try
        {
                SessionInitializeTransaction ();
                batalla_PVPEN = (Batalla_PVPEN)session.Get (typeof(Batalla_PVPEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return batalla_PVPEN;
}

public System.Collections.Generic.IList<Batalla_PVPEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<Batalla_PVPEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(Batalla_PVPEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<Batalla_PVPEN>();
                        else
                                result = session.CreateCriteria (typeof(Batalla_PVPEN)).List<Batalla_PVPEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVPCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (Batalla_PVPEN batalla_PVP)
{
        try
        {
                SessionInitializeTransaction ();
                Batalla_PVPEN batalla_PVPEN = (Batalla_PVPEN)session.Load (typeof(Batalla_PVPEN), batalla_PVP.Id);



                batalla_PVPEN.Recompensa = batalla_PVP.Recompensa;


                batalla_PVPEN.IdGanador = batalla_PVP.IdGanador;

                session.Update (batalla_PVPEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (Batalla_PVPEN batalla_PVP)
{
        try
        {
                SessionInitializeTransaction ();
                if (batalla_PVP.Jugador != null) {
                        // Argumento OID y no colección.
                        batalla_PVP.Jugador = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN), batalla_PVP.Jugador.Id);

                        batalla_PVP.Jugador.Batalla_PVP
                                = batalla_PVP;
                }
                if (batalla_PVP.Jugador_0 != null) {
                        // Argumento OID y no colección.
                        batalla_PVP.Jugador_0 = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN), batalla_PVP.Jugador_0.Id);

                        batalla_PVP.Jugador_0.Batalla_PVP_0
                                = batalla_PVP;
                }

                session.Save (batalla_PVP);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return batalla_PVP.Id;
}

public void Modify (Batalla_PVPEN batalla_PVP)
{
        try
        {
                SessionInitializeTransaction ();
                Batalla_PVPEN batalla_PVPEN = (Batalla_PVPEN)session.Load (typeof(Batalla_PVPEN), batalla_PVP.Id);

                batalla_PVPEN.Recompensa = batalla_PVP.Recompensa;


                batalla_PVPEN.IdGanador = batalla_PVP.IdGanador;

                session.Update (batalla_PVPEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVPCAD.", ex);
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
                Batalla_PVPEN batalla_PVPEN = (Batalla_PVPEN)session.Load (typeof(Batalla_PVPEN), id);
                session.Delete (batalla_PVPEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in Batalla_PVPCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
