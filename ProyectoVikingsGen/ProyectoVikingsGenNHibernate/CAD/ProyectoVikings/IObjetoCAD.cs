
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IObjetoCAD
{
ObjetoEN ReadOIDDefault (int id
                         );

void ModifyDefault (ObjetoEN objeto);



int New_ (ObjetoEN objeto);

void Modify (ObjetoEN objeto);


void Destroy (int id
              );


ObjetoEN ReadOID (int id
                  );


System.Collections.Generic.IList<ObjetoEN> ReadAll (int first, int size);


System.Collections.Generic.IList<int> DameObjetosPorInventario (int i_oid);
}
}
