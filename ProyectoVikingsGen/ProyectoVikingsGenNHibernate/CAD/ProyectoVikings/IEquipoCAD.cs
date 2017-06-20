
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IEquipoCAD
{
EquipoEN ReadOIDDefault (int id
                         );

void ModifyDefault (EquipoEN equipo);



int New_ (EquipoEN equipo);

void Modify (EquipoEN equipo);


void Destroy (int id
              );


void Desequipar (int p_Equipo_OID, System.Collections.Generic.IList<int> p_objeto_OIDs);

void Equipar (int p_Equipo_OID, System.Collections.Generic.IList<int> p_objeto_OIDs);

EquipoEN DameEquipo (int id
                     );
}
}
