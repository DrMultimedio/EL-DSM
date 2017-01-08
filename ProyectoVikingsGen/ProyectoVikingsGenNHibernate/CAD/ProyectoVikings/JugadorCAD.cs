
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
 * Clase Jugador:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class JugadorCAD : BasicCAD, IJugadorCAD
{
public JugadorCAD() : base ()
{
}

public JugadorCAD(ISession sessionAux) : base (sessionAux)
{
}



public JugadorEN ReadOIDDefault (int id
                                 )
{
        JugadorEN jugadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                jugadorEN = (JugadorEN)session.Get (typeof(JugadorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return jugadorEN;
}

public System.Collections.Generic.IList<JugadorEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<JugadorEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(JugadorEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<JugadorEN>();
                        else
                                result = session.CreateCriteria (typeof(JugadorEN)).List<JugadorEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (JugadorEN jugador)
{
        try
        {
                SessionInitializeTransaction ();
                JugadorEN jugadorEN = (JugadorEN)session.Load (typeof(JugadorEN), jugador.Id);

                jugadorEN.Nombre = jugador.Nombre;


                jugadorEN.Email = jugador.Email;


                jugadorEN.Cumple = jugador.Cumple;


                jugadorEN.Genero = jugador.Genero;


                jugadorEN.Vidamax = jugador.Vidamax;


                jugadorEN.VidaAct = jugador.VidaAct;


                jugadorEN.Ataque = jugador.Ataque;


                jugadorEN.Defensa = jugador.Defensa;


                jugadorEN.Oro = jugador.Oro;







                jugadorEN.Password = jugador.Password;

                session.Update (jugadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (JugadorEN jugador)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (jugador);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return jugador.Id;
}

public void Modify (JugadorEN jugador)
{
        try
        {
                SessionInitializeTransaction ();
                JugadorEN jugadorEN = (JugadorEN)session.Load (typeof(JugadorEN), jugador.Id);

                jugadorEN.Nombre = jugador.Nombre;


                jugadorEN.Email = jugador.Email;


                jugadorEN.Cumple = jugador.Cumple;


                jugadorEN.Genero = jugador.Genero;


                jugadorEN.Vidamax = jugador.Vidamax;


                jugadorEN.VidaAct = jugador.VidaAct;


                jugadorEN.Ataque = jugador.Ataque;


                jugadorEN.Defensa = jugador.Defensa;


                jugadorEN.Oro = jugador.Oro;


                jugadorEN.Password = jugador.Password;

                session.Update (jugadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
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
                JugadorEN jugadorEN = (JugadorEN)session.Load (typeof(JugadorEN), id);
                session.Delete (jugadorEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: ReadOID
//Con e: JugadorEN
public JugadorEN ReadOID (int id
                          )
{
        JugadorEN jugadorEN = null;

        try
        {
                SessionInitializeTransaction ();
                jugadorEN = (JugadorEN)session.Get (typeof(JugadorEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return jugadorEN;
}

public System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN> DameJugadoresBatalla ()
{
        System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM JugadorEN self where FROM JugadorEN";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("JugadorENdameJugadoresBatallaHQL");

                result = query.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public System.Collections.Generic.IList<JugadorEN> DameJugadores (int first, int size)
{
        System.Collections.Generic.IList<JugadorEN> result = null;
        try
        {
                SessionInitializeTransaction ();
                if (size > 0)
                        result = session.CreateCriteria (typeof(JugadorEN)).
                                 SetFirstResult (first).SetMaxResults (size).List<JugadorEN>();
                else
                        result = session.CreateCriteria (typeof(JugadorEN)).List<JugadorEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in JugadorCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
}
}
