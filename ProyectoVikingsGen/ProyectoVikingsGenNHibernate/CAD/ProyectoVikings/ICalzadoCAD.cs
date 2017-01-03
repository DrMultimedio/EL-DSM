
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface ICalzadoCAD
{
CalzadoEN ReadOIDDefault (int id
                          );

void ModifyDefault (CalzadoEN calzado);



int New_ (CalzadoEN calzado);

void Modify (CalzadoEN calzado);


void Destroy (int id
              );
}
}
