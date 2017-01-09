
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
 * Clase Inventario:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class InventarioCAD : BasicCAD, IInventarioCAD
{
public InventarioCAD() : base ()
{
}

public InventarioCAD(ISession sessionAux) : base (sessionAux)
{
}



public InventarioEN ReadOIDDefault (int id
                                    )
{
        InventarioEN inventarioEN = null;

        try
        {
                SessionInitializeTransaction ();
                inventarioEN = (InventarioEN)session.Get (typeof(InventarioEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inventarioEN;
}

public System.Collections.Generic.IList<InventarioEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InventarioEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InventarioEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<InventarioEN>();
                        else
                                result = session.CreateCriteria (typeof(InventarioEN)).List<InventarioEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InventarioEN inventario)
{
        try
        {
                SessionInitializeTransaction ();
                InventarioEN inventarioEN = (InventarioEN)session.Load (typeof(InventarioEN), inventario.Id);

                inventarioEN.InvMax = inventario.InvMax;



                session.Update (inventarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (InventarioEN inventario)
{
        try
        {
                SessionInitializeTransaction ();
                if (inventario.Jugador != null) {
                        // Argumento OID y no colección.
                        inventario.Jugador = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN), inventario.Jugador.Id);

                        inventario.Jugador.Inventario
                                = inventario;
                }

                session.Save (inventario);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inventario.Id;
}

public void Modify (InventarioEN inventario)
{
        try
        {
                SessionInitializeTransaction ();
                InventarioEN inventarioEN = (InventarioEN)session.Load (typeof(InventarioEN), inventario.Id);

                inventarioEN.InvMax = inventario.InvMax;

                session.Update (inventarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
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
                InventarioEN inventarioEN = (InventarioEN)session.Load (typeof(InventarioEN), id);
                session.Delete (inventarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> DameInventarioPorJugador (int ? oid_jugador)
{
        System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN> result;
        try
        {
                SessionInitializeTransaction ();
                //String sql = @"FROM InventarioEN self where FROM InventarioEN WHERE id = :oid_jugador";
                //IQuery query = session.CreateQuery(sql);
                IQuery query = (IQuery)session.GetNamedQuery ("InventarioENdameInventarioPorJugadorHQL");
                query.SetParameter ("oid_jugador", oid_jugador);

                result = query.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN>();
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return result;
}
public void RelationerObjeto (int p_Inventario_OID, System.Collections.Generic.IList<int> p_objeto_OIDs)
{
        ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN inventarioEN = null;
        try
        {
                SessionInitializeTransaction ();
                inventarioEN = (InventarioEN)session.Load (typeof(InventarioEN), p_Inventario_OID);
                ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN objetoENAux = null;
                if (inventarioEN.Objeto == null) {
                        inventarioEN.Objeto = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN>();
                }

                foreach (int item in p_objeto_OIDs) {
                        objetoENAux = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN ();
                        objetoENAux = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN), item);
                        objetoENAux.Inventario.Add (inventarioEN);

                        inventarioEN.Objeto.Add (objetoENAux);
                }


                session.Update (inventarioEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
