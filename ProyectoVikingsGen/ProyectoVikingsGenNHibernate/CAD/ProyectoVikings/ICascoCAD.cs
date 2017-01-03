
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface ICascoCAD
{
CascoEN ReadOIDDefault (int id
                        );

void ModifyDefault (CascoEN casco);



int New_ (CascoEN casco);

void Modify (CascoEN casco);


void Destroy (int id
              );
}
}
