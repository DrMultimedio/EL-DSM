
using System;
// Definición clase AdminEN
namespace ProyectoVikingsGenNHibernate.EN.ProyectoVikings
{
public partial class AdminEN                                                                        : ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN


{
public AdminEN() : base ()
{
}



public AdminEN(int id,
               string nombre, string email, Nullable<DateTime> cumple, string genero, int vidamax, int vidaAct, int ataque, int defensa, int oro, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN> batalla_PVE, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN> batalla_PVP, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN> batalla_PVP_0, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN inventarioEquipado, String password
               )
{
        this.init (Id, nombre, email, cumple, genero, vidamax, vidaAct, ataque, defensa, oro, inventario, batalla_PVE, batalla_PVP, batalla_PVP_0, inventarioEquipado, password);
}


public AdminEN(AdminEN admin)
{
        this.init (Id, admin.Nombre, admin.Email, admin.Cumple, admin.Genero, admin.Vidamax, admin.VidaAct, admin.Ataque, admin.Defensa, admin.Oro, admin.Inventario, admin.Batalla_PVE, admin.Batalla_PVP, admin.Batalla_PVP_0, admin.InventarioEquipado, admin.Password);
}

private void init (int id
                   , string nombre, string email, Nullable<DateTime> cumple, string genero, int vidamax, int vidaAct, int ataque, int defensa, int oro, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEN inventario, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVEEN> batalla_PVE, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN> batalla_PVP, System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.Batalla_PVPEN> batalla_PVP_0, ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN inventarioEquipado, String password)
{
        this.Id = id;


        this.Nombre = nombre;

        this.Email = email;

        this.Cumple = cumple;

        this.Genero = genero;

        this.Vidamax = vidamax;

        this.VidaAct = vidaAct;

        this.Ataque = ataque;

        this.Defensa = defensa;

        this.Oro = oro;

        this.Inventario = inventario;

        this.Batalla_PVE = batalla_PVE;

        this.Batalla_PVP = batalla_PVP;

        this.Batalla_PVP_0 = batalla_PVP_0;

        this.InventarioEquipado = inventarioEquipado;

        this.Password = password;
}

public override bool Equals (object obj)
{
        if (obj == null)
                return false;
        AdminEN t = obj as AdminEN;
        if (t == null)
                return false;
        if (Id.Equals (t.Id))
                return true;
        else
                return false;
}

public override int GetHashCode ()
{
        int hash = 13;

        hash += this.Id.GetHashCode ();
        return hash;
}
}
}
