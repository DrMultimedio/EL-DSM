
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IArmaCAD
{
ArmaEN ReadOIDDefault (int id
                       );

void ModifyDefault (ArmaEN arma);



int New_ (ArmaEN arma);

void Modify (ArmaEN arma);


void Destroy (int id
              );
}
}
