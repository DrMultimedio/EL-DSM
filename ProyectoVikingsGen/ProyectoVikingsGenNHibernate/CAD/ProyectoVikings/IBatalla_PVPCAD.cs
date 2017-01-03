
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IBatalla_PVPCAD
{
Batalla_PVPEN ReadOIDDefault (int id
                              );

void ModifyDefault (Batalla_PVPEN batalla_PVP);



int New_ (Batalla_PVPEN batalla_PVP);

void Modify (Batalla_PVPEN batalla_PVP);


void Destroy (int id
              );
}
}
