
using System;
using System.Text;
using System.Collections.Generic;
using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;


/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Jugador_login) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CEN.ProyectoVikings
{
public partial class JugadorCEN
{
public bool Login (int p_oid, string password)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CEN.ProyectoVikings_Jugador_login) ENABLED START*/

        // Write here your custom code...

        bool result = false;
        JugadorEN en = _IJugadorCAD.ReadOIDDefault (p_oid);

        System.Console.WriteLine (Utils.Util.GetEncondeMD5 (password));
        System.Console.WriteLine (en.Password);

        if (en.Password.Equals (Utils.Util.GetEncondeMD5 (password)))
                result = true;
        return result;

        //throw new NotImplementedException ("Method Login() not yet implemented.");

        /*PROTECTED REGION END*/
}
}
}
