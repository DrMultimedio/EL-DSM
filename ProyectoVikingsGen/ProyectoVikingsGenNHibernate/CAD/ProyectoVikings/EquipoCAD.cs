
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
 * Clase Equipo:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class EquipoCAD : BasicCAD, IEquipoCAD
{
public EquipoCAD() : base ()
{
}

public EquipoCAD(ISession sessionAux) : base (sessionAux)
{
}



public EquipoEN ReadOIDDefault (int id
                                )
{
        EquipoEN equipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                equipoEN = (EquipoEN)session.Get (typeof(EquipoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return equipoEN;
}

public System.Collections.Generic.IList<EquipoEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<EquipoEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(EquipoEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<EquipoEN>();
                        else
                                result = session.CreateCriteria (typeof(EquipoEN)).List<EquipoEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (EquipoEN equipo)
{
        try
        {
                SessionInitializeTransaction ();
                EquipoEN equipoEN = (EquipoEN)session.Load (typeof(EquipoEN), equipo.Id);


                equipoEN.ArmaEquipada = equipo.ArmaEquipada;


                equipoEN.PecheraEquipada = equipo.PecheraEquipada;


                equipoEN.GrebasEquipadas = equipo.GrebasEquipadas;


                equipoEN.CascoEquipado = equipo.CascoEquipado;


                session.Update (equipoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (EquipoEN equipo)
{
        try
        {
                SessionInitializeTransaction ();
                if (equipo.Jugador != null) {
                        // Argumento OID y no colección.
                        equipo.Jugador = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN), equipo.Jugador.Id);

                        equipo.Jugador.Equipo
                                = equipo;
                }

                session.Save (equipo);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return equipo.Id;
}

public void Modify (EquipoEN equipo)
{
        try
        {
                SessionInitializeTransaction ();
                EquipoEN equipoEN = (EquipoEN)session.Load (typeof(EquipoEN), equipo.Id);

                equipoEN.ArmaEquipada = equipo.ArmaEquipada;


                equipoEN.PecheraEquipada = equipo.PecheraEquipada;


                equipoEN.GrebasEquipadas = equipo.GrebasEquipadas;


                equipoEN.CascoEquipado = equipo.CascoEquipado;

                session.Update (equipoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
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
                EquipoEN equipoEN = (EquipoEN)session.Load (typeof(EquipoEN), id);
                session.Delete (equipoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

public void Desequipar (int p_Equipo_OID, System.Collections.Generic.IList<int> p_objeto_OIDs)
{
        try
        {
                SessionInitializeTransaction ();
                ProyectoVikingsGenNHibernate.EN.ProyectoVikings.EquipoEN equipoEN = null;
                equipoEN = (EquipoEN)session.Load (typeof(EquipoEN), p_Equipo_OID);

                ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN objetoENAux = null;
                if (equipoEN.Objeto != null) {
                        foreach (int item in p_objeto_OIDs) {
                                objetoENAux = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN), item);
                                if (equipoEN.Objeto.Contains (objetoENAux) == true) {
                                        equipoEN.Objeto.Remove (objetoENAux);
                                        objetoENAux.Equipo.Remove (equipoEN);
                                }
                                else
                                        throw new ModelException ("The identifier " + item + " in p_objeto_OIDs you are trying to unrelationer, doesn't exist in EquipoEN");
                        }
                }

                session.Update (equipoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
public void Equipar (int p_Equipo_OID, System.Collections.Generic.IList<int> p_objeto_OIDs)
{
        ProyectoVikingsGenNHibernate.EN.ProyectoVikings.EquipoEN equipoEN = null;
        try
        {
                SessionInitializeTransaction ();
                equipoEN = (EquipoEN)session.Load (typeof(EquipoEN), p_Equipo_OID);
                ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN objetoENAux = null;
                if (equipoEN.Objeto == null) {
                        equipoEN.Objeto = new System.Collections.Generic.List<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN>();
                }

                foreach (int item in p_objeto_OIDs) {
                        objetoENAux = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN ();
                        objetoENAux = (ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN)session.Load (typeof(ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN), item);
                        objetoENAux.Equipo.Add (equipoEN);

                        equipoEN.Objeto.Add (objetoENAux);
                }


                session.Update (equipoEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}

//Sin e: DameEquipo
//Con e: EquipoEN
public EquipoEN DameEquipo (int id
                            )
{
        EquipoEN equipoEN = null;

        try
        {
                SessionInitializeTransaction ();
                equipoEN = (EquipoEN)session.Get (typeof(EquipoEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in EquipoCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return equipoEN;
}
}
}
