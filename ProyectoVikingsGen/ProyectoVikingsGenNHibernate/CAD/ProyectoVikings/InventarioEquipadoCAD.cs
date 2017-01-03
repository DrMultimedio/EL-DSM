
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
 * Clase InventarioEquipado:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class InventarioEquipadoCAD : BasicCAD, IInventarioEquipadoCAD
{
public InventarioEquipadoCAD() : base ()
{
}

public InventarioEquipadoCAD(ISession sessionAux) : base (sessionAux)
{
}



public InventarioEquipadoEN ReadOIDDefault (int id
                                            )
{
        InventarioEquipadoEN inventarioEquipadoEN = null;

        try
        {
                SessionInitializeTransaction ();
                inventarioEquipadoEN = (InventarioEquipadoEN)session.Get (typeof(InventarioEquipadoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioEquipadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inventarioEquipadoEN;
}

public System.Collections.Generic.IList<InventarioEquipadoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<InventarioEquipadoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(InventarioEquipadoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<InventarioEquipadoEN>();
                        else
                                result = session.CreateCriteria (typeof(InventarioEquipadoEN)).List<InventarioEquipadoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioEquipadoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (InventarioEquipadoEN inventarioEquipado)
{
        try
        {
                SessionInitializeTransaction ();
                InventarioEquipadoEN inventarioEquipadoEN = (InventarioEquipadoEN)session.Load (typeof(InventarioEquipadoEN), inventarioEquipado.Id);


                session.Update (inventarioEquipadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioEquipadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (InventarioEquipadoEN inventarioEquipado)
{
        try
        {
                SessionInitializeTransaction ();
                if (inventarioEquipado.Jugador != null) {
                        // Argumento OID y no colección.
                        inventarioEquipado.Jugador = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN), inventarioEquipado.Jugador.Id);

                        inventarioEquipado.Jugador.Inventario
                                = inventarioEquipado;
                }
                if (inventarioEquipado.Jugador_0 != null) {
                        // Argumento OID y no colección.
                        inventarioEquipado.Jugador_0 = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN), inventarioEquipado.Jugador_0.Id);

                        inventarioEquipado.Jugador_0.InventarioEquipado
                                = inventarioEquipado;
                }

                session.Save (inventarioEquipado);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioEquipadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return inventarioEquipado.Id;
}

public void Modify (InventarioEquipadoEN inventarioEquipado)
{
        try
        {
                SessionInitializeTransaction ();
                InventarioEquipadoEN inventarioEquipadoEN = (InventarioEquipadoEN)session.Load (typeof(InventarioEquipadoEN), inventarioEquipado.Id);

                inventarioEquipadoEN.InvMax = inventarioEquipado.InvMax;

                session.Update (inventarioEquipadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioEquipadoCAD.", ex);
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
                InventarioEquipadoEN inventarioEquipadoEN = (InventarioEquipadoEN)session.Load (typeof(InventarioEquipadoEN), id);
                session.Delete (inventarioEquipadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioEquipadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Equipar (int p_InventarioEquipado_OID, System.Collections.Generic.IList<int> p_objeto_0_OIDs)
{
        ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN inventarioEquipadoEN = null;
        try
        {
                SessionInitializeTransaction ();
                inventarioEquipadoEN = (InventarioEquipadoEN)session.Load (typeof(InventarioEquipadoEN), p_InventarioEquipado_OID);
                ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN objeto_0ENAux = null;
                if (inventarioEquipadoEN.Objeto_0 == null) {
                        inventarioEquipadoEN.Objeto_0 = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN>();
                }

                foreach (int item in p_objeto_0_OIDs) {
                        objeto_0ENAux = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN ();
                        objeto_0ENAux = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN), item);
                        objeto_0ENAux.InventarioEquipado.Add (inventarioEquipadoEN);

                        inventarioEquipadoEN.Objeto_0.Add (objeto_0ENAux);
                }


                session.Update (inventarioEquipadoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in InventarioEquipadoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
