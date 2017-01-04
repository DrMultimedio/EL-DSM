
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
 * Clase Armadura:
 *
 */

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial class ArmaduraCAD : BasicCAD, IArmaduraCAD
{
public ArmaduraCAD() : base ()
{
}

public ArmaduraCAD(ISession sessionAux) : base (sessionAux)
{
}



public ArmaduraEN ReadOIDDefault (int id
                                  )
{
        ArmaduraEN armaduraEN = null;

        try
        {
                SessionInitializeTransaction ();
                armaduraEN = (ArmaduraEN)session.Get (typeof(ArmaduraEN), id);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaduraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return armaduraEN;
}

public System.Collections.Generic.IList<ArmaduraEN> ReadAllDefault (int first, int size)
{
        System.Collections.Generic.IList<ArmaduraEN> result = null;
        try
        {
                using (ITransaction tx = session.BeginTransaction ())
                {
                        if (size > 0)
                                result = session.CreateCriteria (typeof(ArmaduraEN)).
                                         SetFirstResult (first).SetMaxResults (size).List<ArmaduraEN>();
                        else
                                result = session.CreateCriteria (typeof(ArmaduraEN)).List<ArmaduraEN>();
                }
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaduraCAD.", ex);
        }

        return result;
}

// Modify default (Update all attributes of the class)

public void ModifyDefault (ArmaduraEN armadura)
{
        try
        {
                SessionInitializeTransaction ();
                ArmaduraEN armaduraEN = (ArmaduraEN)session.Load (typeof(ArmaduraEN), armadura.Id);

                armaduraEN.Defensa = armadura.Defensa;


                armaduraEN.Vida = armadura.Vida;

                session.Update (armaduraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaduraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}


public int New_ (ArmaduraEN armadura)
{
        try
        {
                SessionInitializeTransaction ();

                session.Save (armadura);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaduraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }

        return armadura.Id;
}

public void Modify (ArmaduraEN armadura)
{
        try
        {
                SessionInitializeTransaction ();
                ArmaduraEN armaduraEN = (ArmaduraEN)session.Load (typeof(ArmaduraEN), armadura.Id);

                armaduraEN.Nombre = armadura.Nombre;


                armaduraEN.Precio = armadura.Precio;


                armaduraEN.Defensa = armadura.Defensa;


                armaduraEN.Vida = armadura.Vida;

                session.Update (armaduraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaduraCAD.", ex);
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
                ArmaduraEN armaduraEN = (ArmaduraEN)session.Load (typeof(ArmaduraEN), id);
                session.Delete (armaduraEN);
                SessionCommit ();
        }

        catch (Exception ex) {
                SessionRollBack ();
                if (ex is ProyectoVikingsGenNHibernate.Exceptions.ModelException)
                        throw ex;
                throw new ProyectoVikingsGenNHibernate.Exceptions.DataLayerException ("Error in ArmaduraCAD.", ex);
        }


        finally
        {
                SessionClose ();
        }
}
}
}
