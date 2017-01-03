
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IBatalla_PVECAD
{
Batalla_PVEEN ReadOIDDefault (int id
                              );

void ModifyDefault (Batalla_PVEEN batalla_PVE);



int New_ (Batalla_PVEEN batalla_PVE);

void Modify (Batalla_PVEEN batalla_PVE);


void Destroy (int id
              );




Batalla_PVEEN ReadOID (int id
                       );


System.Collections.Generic.IList<Batalla_PVEEN> ReadAll (int first, int size);
}
}
