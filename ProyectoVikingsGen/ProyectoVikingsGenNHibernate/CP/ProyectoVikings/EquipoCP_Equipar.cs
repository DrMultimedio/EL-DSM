
using System;
using System.Text;

using NHibernate;
using NHibernate.Cfg;
using NHibernate.Criterion;
using NHibernate.Exceptions;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;



/*PROTECTED REGION ID(usingProyectoVikingsGenNHibernate.CP.ProyectoVikings_Equipo_equipar) ENABLED START*/
//  references to other libraries
/*PROTECTED REGION END*/

namespace ProyectoVikingsGenNHibernate.CP.ProyectoVikings
{
public partial class EquipoCP : BasicCP
{
public void Equipar (int p_Equipo_OID, System.Collections.Generic.IList<int> p_objeto_OIDs)
{
        /*PROTECTED REGION ID(ProyectoVikingsGenNHibernate.CP.ProyectoVikings_Equipo_equipar) ENABLED START*/

        IEquipoCAD equipoCAD = null;
        EquipoCEN equipoCEN = null;



        try
        {
                SessionInitializeTransaction ();
                equipoCAD = new EquipoCAD (session);
                equipoCEN = new  EquipoCEN (equipoCAD);

                EquipoEN equipoEN = equipoCEN.DameEquipo (p_Equipo_OID);
                ObjetoCAD objetoCAD = new ObjetoCAD (session);
                ObjetoCEN objetoCEN = new ObjetoCEN ();

                System.Collections.Generic.IList<ProyectoVikingsGenNHibernate.EN.ProyectoVikings.ObjetoEN> objetos = objetoCEN.DameObjetosPorEquipo (p_Equipo_OID);
                System.Collections.Generic.IList<int> desequipar = new System.Collections.Generic.List<int>();
                ObjetoEN objeto = objetoCEN.ReadOID (p_objeto_OIDs [0]);

                switch (objetoCEN.DameTipo (objeto.Id)) {
                case Enumerated.ProyectoVikings.TipoObjetoEnum.Arma:
                        if (equipoCEN.CheckArma (p_Equipo_OID)) {
                                foreach (ObjetoEN o in objetos) {
                                        if (o.Tipo == Enumerated.ProyectoVikings.TipoObjetoEnum.Arma) {
                                                desequipar.Add (o.Id);
                                                equipoCEN.Desequipar (p_Equipo_OID, desequipar);
                                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                        }
                                }
                        }
                        else{
                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                equipoEN.ArmaEquipada = true;
                        }
                        break;

                case Enumerated.ProyectoVikings.TipoObjetoEnum.Casco:
                        if (equipoCEN.CheckArma (p_Equipo_OID)) {
                                foreach (ObjetoEN o in objetos) {
                                        if (o.Tipo == Enumerated.ProyectoVikings.TipoObjetoEnum.Casco) {
                                                desequipar.Add (o.Id);
                                                equipoCEN.Desequipar (p_Equipo_OID, desequipar);
                                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                        }
                                }
                        }
                        else{
                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                equipoEN.CascoEquipado = true;
                        }
                        break;

                case Enumerated.ProyectoVikings.TipoObjetoEnum.Grebas:
                        if (equipoCEN.CheckArma (p_Equipo_OID)) {
                                foreach (ObjetoEN o in objetos) {
                                        if (o.Tipo == Enumerated.ProyectoVikings.TipoObjetoEnum.Grebas) {
                                                desequipar.Add (o.Id);
                                                equipoCEN.Desequipar (p_Equipo_OID, desequipar);
                                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                        }
                                }
                        }
                        else{
                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                equipoEN.GrebasEquipadas = true;
                        }
                        break;


                case Enumerated.ProyectoVikings.TipoObjetoEnum.Pecho:
                        if (equipoCEN.CheckArma (p_Equipo_OID)) {
                                foreach (ObjetoEN o in objetos) {
                                        if (o.Tipo == Enumerated.ProyectoVikings.TipoObjetoEnum.Pecho) {
                                                desequipar.Add (o.Id);
                                                equipoCEN.Desequipar (p_Equipo_OID, desequipar);
                                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                        }
                                }
                        }
                        else{
                                equipoCAD.Equipar (p_Equipo_OID, p_objeto_OIDs);
                                equipoEN.PecheraEquipada = true;
                        }
                        break;
                }


                //Call to EquipoCAD




                SessionCommit ();
        }
        catch (Exception ex)
        {
                SessionRollBack ();
                throw ex;
        }
        finally
        {
                SessionClose ();
        }


        /*PROTECTED REGION END*/
}
}
}
