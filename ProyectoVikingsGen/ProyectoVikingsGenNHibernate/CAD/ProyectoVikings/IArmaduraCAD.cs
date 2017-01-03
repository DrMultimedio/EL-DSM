
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IArmaduraCAD
{
ArmaduraEN ReadOIDDefault (int id
                           );

void ModifyDefault (ArmaduraEN armadura);



int New_ (ArmaduraEN armadura);

void Modify (ArmaduraEN armadura);


void Destroy (int id
              );
}
}
