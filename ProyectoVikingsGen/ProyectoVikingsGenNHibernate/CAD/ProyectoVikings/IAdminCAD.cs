
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IAdminCAD
{
AdminEN ReadOIDDefault (int id
                        );

void ModifyDefault (AdminEN admin);



int New_ (AdminEN admin);

void Modify (AdminEN admin);


void Destroy (int id
              );
}
}
