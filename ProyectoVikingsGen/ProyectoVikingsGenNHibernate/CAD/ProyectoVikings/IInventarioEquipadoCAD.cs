
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IInventarioEquipadoCAD
{
InventarioEquipadoEN ReadOIDDefault (int id
                                     );

void ModifyDefault (InventarioEquipadoEN inventarioEquipado);



int New_ (InventarioEquipadoEN inventarioEquipado);

void Modify (InventarioEquipadoEN inventarioEquipado);


void Destroy (int id
              );


void Equipar (int p_InventarioEquipado_OID, System.Collections.Generic.IList<int> p_objeto_0_OIDs);
}
}
