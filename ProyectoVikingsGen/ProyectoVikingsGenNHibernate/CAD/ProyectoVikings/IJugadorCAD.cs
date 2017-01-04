
using System;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;

namespace ProyectoVikingsGenNHibernate.CAD.ProyectoVikings
{
public partial interface IJugadorCAD
{
JugadorEN ReadOIDDefault (int id
                          );

void ModifyDefault (JugadorEN jugador);



int New_ (JugadorEN jugador);

void Modify (JugadorEN jugador);


void Destroy (int id
              );




JugadorEN ReadOID (int id
                   );



System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.JugadorEN> DameJugadoresBatalla ();


System.Collections.Generic.IList<JugadorEN> DameJugadores (int first, int size);
}
}
