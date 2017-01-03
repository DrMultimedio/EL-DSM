
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IMonstruoCAD
{
MonstruoEN ReadOIDDefault (int id
                           );

void ModifyDefault (MonstruoEN monstruo);



int New_ (MonstruoEN monstruo);

void Modify (MonstruoEN monstruo);


void Destroy (int id
              );
}
}
