

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
 *      Definition of the class EquipoCEN
 *
 */
public partial class EquipoCEN
{
private IEquipoCAD _IEquipoCAD;

public EquipoCEN()
{
        this._IEquipoCAD = new EquipoCAD ();
}

public EquipoCEN(IEquipoCAD _IEquipoCAD)
{
        this._IEquipoCAD = _IEquipoCAD;
}

public IEquipoCAD get_IEquipoCAD ()
{
        return this._IEquipoCAD;
}

public int New_ (int p_jugador, bool p_ArmaEquipada, bool p_PecheraEquipada, bool p_GrebasEquipadas, bool p_CascoEquipado)
{
        EquipoEN equipoEN = null;
        int oid;

        //Initialized EquipoEN
        equipoEN = new EquipoEN ();

        if (p_jugador != -1) {
                // El argumento p_jugador -> Property jugador es oid = false
                // Lista de oids id
                equipoEN.Jugador = new ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN ();
                equipoEN.Jugador.Id = p_jugador;
        }

        equipoEN.ArmaEquipada = p_ArmaEquipada;

        equipoEN.PecheraEquipada = p_PecheraEquipada;

        equipoEN.GrebasEquipadas = p_GrebasEquipadas;

        equipoEN.CascoEquipado = p_CascoEquipado;

        //Call to EquipoCAD

        oid = _IEquipoCAD.New_ (equipoEN);
        return oid;
}

public void Modify (int p_Equipo_OID, bool p_ArmaEquipada, bool p_PecheraEquipada, bool p_GrebasEquipadas, bool p_CascoEquipado)
{
        EquipoEN equipoEN = null;

        //Initialized EquipoEN
        equipoEN = new EquipoEN ();
        equipoEN.Id = p_Equipo_OID;
        equipoEN.ArmaEquipada = p_ArmaEquipada;
        equipoEN.PecheraEquipada = p_PecheraEquipada;
        equipoEN.GrebasEquipadas = p_GrebasEquipadas;
        equipoEN.CascoEquipado = p_CascoEquipado;
        //Call to EquipoCAD

        _IEquipoCAD.Modify (equipoEN);
}

public void Destroy (int id
                     )
{
        _IEquipoCAD.Destroy (id);
}

public void Desequipar (int p_Equipo_OID, System.Collections.Generic.IList<int> p_objeto_OIDs)
{
        //Call to EquipoCAD

        _IEquipoCAD.Desequipar (p_Equipo_OID, p_objeto_OIDs);
}
public EquipoEN DameEquipo (int id
                            )
{
        EquipoEN equipoEN = null;

        equipoEN = _IEquipoCAD.DameEquipo (id);
        return equipoEN;
}
}
}
