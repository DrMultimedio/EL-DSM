
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



System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.InventarioEquipadoEN> DameInventarioPorJugadorEquipado ();
}
}
