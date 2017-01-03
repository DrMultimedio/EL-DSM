

using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.Exceptions;

using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;


namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
/*
 *      Definition of the class AdminCEN
 *
 */
public partial class AdminCEN
{
private IAdminCAD _IAdminCAD;

public AdminCEN()
{
        this._IAdminCAD = new AdminCAD ();
}

public AdminCEN(IAdminCAD _IAdminCAD)
{
        this._IAdminCAD = _IAdminCAD;
}

public IAdminCAD get_IAdminCAD ()
{
        return this._IAdminCAD;
}

public int New_ (string p_Nombre, string p_Email, Nullable<DateTime> p_Cumple, string p_Genero, int p_Vidamax, int p_VidaAct, int p_Ataque, int p_Defensa, int p_Oro)
{
        AdminEN adminEN = null;
        int oid;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.Nombre = p_Nombre;

        adminEN.Email = p_Email;

        adminEN.Cumple = p_Cumple;

        adminEN.Genero = p_Genero;

        adminEN.Vidamax = p_Vidamax;

        adminEN.VidaAct = p_VidaAct;

        adminEN.Ataque = p_Ataque;

        adminEN.Defensa = p_Defensa;

        adminEN.Oro = p_Oro;

        //Call to AdminCAD

        oid = _IAdminCAD.New_ (adminEN);
        return oid;
}

public void Modify (int p_Admin_OID, string p_Nombre, string p_Email, Nullable<DateTime> p_Cumple, string p_Genero, int p_Vidamax, int p_VidaAct, int p_Ataque, int p_Defensa, int p_Oro)
{
        AdminEN adminEN = null;

        //Initialized AdminEN
        adminEN = new AdminEN ();
        adminEN.Id = p_Admin_OID;
        adminEN.Nombre = p_Nombre;
        adminEN.Email = p_Email;
        adminEN.Cumple = p_Cumple;
        adminEN.Genero = p_Genero;
        adminEN.Vidamax = p_Vidamax;
        adminEN.VidaAct = p_VidaAct;
        adminEN.Ataque = p_Ataque;
        adminEN.Defensa = p_Defensa;
        adminEN.Oro = p_Oro;
        //Call to AdminCAD

        _IAdminCAD.Modify (adminEN);
}

public void Destroy (int id
                     )
{
        _IAdminCAD.Destroy (id);
}
}
}
