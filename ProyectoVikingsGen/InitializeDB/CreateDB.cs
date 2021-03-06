
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CP.ProyectoVikings;
using ProyectoVikingsGenNHibernate.Utils;
/*PROTECTED REGION END*/
namespace InitializeDB
{
public class CreateDB
{
public static void Create (string databaseArg, string userArg, string passArg)
{
        String database = databaseArg;
        String user = userArg;
        String pass = passArg;

        // Conex DB
        SqlConnection cnn = new SqlConnection (@"Server=(local)\sqlexpress; database=master; integrated security=yes");

        // Order T-SQL create user
        String createUser = @"IF NOT EXISTS(SELECT name FROM master.dbo.syslogins WHERE name = '" + user + @"')
            BEGIN
                CREATE LOGIN ["                                                                                                                                     + user + @"] WITH PASSWORD=N'" + pass + @"', DEFAULT_DATABASE=[master], CHECK_EXPIRATION=OFF, CHECK_POLICY=OFF
            END"                                                                                                                                                                                                                                                                                    ;

        //Order delete user if exist
        String deleteDataBase = @"if exists(select * from sys.databases where name = '" + database + "') DROP DATABASE [" + database + "]";
        //Order create databas
        string createBD = "CREATE DATABASE " + database;
        //Order associate user with database
        String associatedUser = @"USE [" + database + "];CREATE USER [" + user + "] FOR LOGIN [" + user + "];USE [" + database + "];EXEC sp_addrolemember N'db_owner', N'" + user + "'";
        SqlCommand cmd = null;

        try
        {
                // Open conex
                cnn.Open ();

                //Create user in SQLSERVER
                cmd = new SqlCommand (createUser, cnn);
                cmd.ExecuteNonQuery ();

                //DELETE database if exist
                cmd = new SqlCommand (deleteDataBase, cnn);
                cmd.ExecuteNonQuery ();

                //CREATE DB
                cmd = new SqlCommand (createBD, cnn);
                cmd.ExecuteNonQuery ();

                //Associate user with db
                cmd = new SqlCommand (associatedUser, cnn);
                cmd.ExecuteNonQuery ();

                System.Console.WriteLine ("DataBase create sucessfully..");
        }
        catch (Exception ex)
        {
                throw ex;
        }
        finally
        {
                if (cnn.State == ConnectionState.Open) {
                        cnn.Close ();
                }
        }
}

public static void InitializeData ()
{
        /*PROTECTED REGION ID(initializeDataMethod) ENABLED START*/
        try
        {
                // Insert the initilizations of entities using the CEN classes

                JugadorCAD jugadorCAD = new JugadorCAD ();
                JugadorCEN jugadorCEN = new JugadorCEN ();
                JugadorEN jugadorEN = new JugadorEN ();
                InventarioCAD inventarioCAD = new InventarioCAD ();
                InventarioCEN inventarioCEN = new InventarioCEN ();

                EquipoCAD equipoCAD = new EquipoCAD ();
                EquipoCEN equipoCEN = new EquipoCEN ();
                EquipoCP equipoCP = new EquipoCP ();

                ObjetoCAD objetoCAD = new ObjetoCAD ();
                ObjetoCEN objetoCEN = new ObjetoCEN ();



                MonstruoCAD monstruoCAD = new MonstruoCAD ();
                MonstruoCEN monstruoCEN = new MonstruoCEN ();

                Batalla_PVECAD batallaPVECAD = new Batalla_PVECAD ();
                Batalla_PVECEN batallaPVECEN = new Batalla_PVECEN ();

                Batalla_PVPCAD batallaPVPCAD = new Batalla_PVPCAD ();
                Batalla_PVPCEN batallaPVPCEN = new Batalla_PVPCEN ();

                Batalla_PVECP batallaPVECCP = new Batalla_PVECP ();
                Batalla_PVPCP batallaPVPCCP = new Batalla_PVPCP ();

                Batalla_PVEEN batallapveEN = null;

                System.Collections.Generic.IList<int> equipar = new System.Collections.Generic.List<int>();


                // Jugadores
                int jugador1 = jugadorCEN.New_ ("Paco", "paco@gmail.com", new DateTime (1997, 11, 19), "Pato22", 20, 20, 3, 1, 300, "Paco1");
                int jugador2 = jugadorCEN.New_ ("Jose", "jose@gmail.com", new DateTime (1957, 12, 19), Util.GetEncondeMD5 ("Pato22"), 20, 20, 3, 1, 0, "Jose1");
                int jugador3 = jugadorCEN.New_ ("ThorTilla", "jose@gmail.com", new DateTime (1957, 12, 19), Util.GetEncondeMD5 ("Pato22"), 50, 40, 5, 1, 0, "Jose1");
                //inventario
                int inventario1 = inventarioCEN.New_ (10, jugador1);
                int inventario2 = inventarioCEN.New_ (10, jugador2);
                int inventario3 = inventarioCEN.New_ (10, jugador3);
                //equipo
                int equipo1 = equipoCEN.New_ (jugador1, false, false, false, false);
                int equipo2 = equipoCEN.New_ (jugador2, false, false, false, false);
                int equipo3 = equipoCEN.New_ (jugador3, false, false, false, false);

                // Objetos
                int armadura1 = objetoCEN.New_ ("Pechera del abismo 2.0", 12, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Pecho, 10, 3);
                int armadura2 = objetoCEN.New_ ("Armadura de carton ", 2, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Pecho, 4, 1);
                int calzado1 = objetoCEN.New_ ("Grebas del abismo ", 68, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Grebas, 8, 2);
                int calzado2 = objetoCEN.New_ ("Zapatos de carton", 8, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Grebas, 2, 1);
                int casco1 = objetoCEN.New_ ("Casco del abismo", 68, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Casco, 12, 5);
                int casco2 = objetoCEN.New_ ("Casco de carton", 8, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Casco, 3, 2);
                int arma1 = objetoCEN.New_ ("Hacha del abismo", 68, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Arma, 0, 52);
                int arma2 = objetoCEN.New_ ("Hacha de carton", 8, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoObjetoEnum.Arma, 0, 14);

                //Monstruos
                int monstruo1 = monstruoCEN.New_ ("Mariano", 30, 2, 2);
                int monstruo2 = monstruoCEN.New_ ("Joutn", 30, 2, 2);
                int monstruo3 = monstruoCEN.New_ ("Ardilla", 15, 1, 2);

                //batallas
                int batalla1 = batallaPVECEN.New_ (monstruo1, jugador1, 0, ProyectoVikingsGenNHibernate.Enumerated.ProyectoVikings.TipoGanadorEnum.monstruo);
                int batalla2 = batallaPVPCEN.New_ (jugador1, jugador1, 0, jugador1);
                JugadorCP jugadorCP = new JugadorCP ();

                //Probamos el legoin
                System.Console.WriteLine ("Login que va");

                if (jugadorCEN.Login (jugador1, "Paco1")) {
                        System.Console.WriteLine ("Loguiado");
                }
                else{
                        System.Console.WriteLine ("No logiado");
                }

                System.Console.WriteLine ("Login que no va");

                if (jugadorCEN.Login (jugador2, "Paco1")) {
                        System.Console.WriteLine ("Loguiado");
                }
                else{
                        System.Console.WriteLine ("No logiado");
                }
                //pruebas objetos

                System.Console.WriteLine ("Oro antes " + jugadorCEN.ReadOID (jugador1).Oro);

                jugadorCP.Comprar (jugador1, objetoCEN.ReadOID (armadura1));
                System.Console.WriteLine ("Oro despues " + jugadorCEN.ReadOID (jugador1).Oro);
                IList<ObjetoEN> objetos = objetoCEN.DameObjetos (0, 2);
                foreach (ObjetoEN j in objetos) {
                        System.Console.WriteLine (j.Nombre);
                }

                //LE BATALLAS PVE
                System.Console.WriteLine ("Batalla perdida");

                if (batallaPVECCP.Resolver (jugador1, monstruo2, batalla1)) {
                        System.Console.WriteLine ("Gana el jugador");
                        System.Console.WriteLine (batallaPVECEN.DameGanador (batalla1));
                }
                else{
                        System.Console.WriteLine ("Gana el Monstruo");
                        System.Console.WriteLine (batallaPVECEN.DameGanador (batalla1));
                }
                System.Console.WriteLine ("Batalla ganada");

                if (batallaPVECCP.Resolver (jugador1, monstruo3, batalla1)) {
                        System.Console.WriteLine ("Gana el jugador");
                        System.Console.WriteLine (batallaPVECEN.DameGanador (batalla1));
                }
                else{
                        System.Console.WriteLine ("Gana el Monstruo");
                        System.Console.WriteLine (batallaPVECEN.DameGanador (batalla1));
                }
                //LE BATALLAS PVP
                System.Console.WriteLine ("Batalla perdida PVP");

                if (batallaPVPCCP.Resolver (jugador1, jugador3, batalla2)) {
                        System.Console.WriteLine ("Gana el jugador 1");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }
                else{
                        System.Console.WriteLine ("Gana el jugador 2");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }
                System.Console.WriteLine ("Batalla ganada PVP");

                if (batallaPVPCCP.Resolver (jugador3, jugador2, batalla2)) {
                        System.Console.WriteLine ("Gana el jugador 1");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }
                else{
                        System.Console.WriteLine ("Gana el jugador 2");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }                System.Console.WriteLine ("Batalla ganada PVP");

                if (batallaPVPCCP.Resolver (jugador3, jugador2, batalla2)) {
                        System.Console.WriteLine ("Gana el jugador 1");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }
                else{
                        System.Console.WriteLine ("Gana el jugador 2");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }

                System.Console.WriteLine ("Ni idea de quien gana");

                if (batallaPVPCCP.Resolver (jugador1, jugador2, batalla2)) {
                        System.Console.WriteLine ("Gana el jugador 1");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }
                else{
                        System.Console.WriteLine ("Gana el jugador 2");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }

                //pruebas equipo
                EquipoEN equipoEN = equipoCEN.DameEquipo (equipo1);
                System.Console.WriteLine ("Pregunto si llevo equipada un arma " + equipoCEN.CheckArma (equipo1));
                System.Console.WriteLine ("Equipo un arma");

                equipar.Add (arma1);
                equipoCP.Equipar (equipo1, equipar);
                System.Console.WriteLine ("Pregunto si llevo equipada un arma " + equipoCEN.CheckArma (equipo1));
                System.Console.WriteLine ("Pregunto si llevo equipada un casco " + equipoCEN.CheckCasco (equipo1));
                System.Console.WriteLine ("Gana jugador 1");

                if (batallaPVPCCP.Resolver (jugador1, jugador2, batalla2)) {
                        System.Console.WriteLine ("Gana el jugador 1");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }
                else{
                        System.Console.WriteLine ("Gana el jugador 2");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador (batalla2));
                }                //le prueba del algodon
                IList<JugadorEN> jugadores = jugadorCEN.DameJugadores (0, 14);

                foreach (JugadorEN j in jugadores) {
                        System.Console.WriteLine (j.Nombre);
                }
                System.Console.WriteLine ("Calcular danyo");

                jugadorCP.CalcularDanyoExtra (jugador1);
                System.Console.WriteLine ("Salimso de calcular danyo");

                System.Console.WriteLine ("Pedimos usuario por nombre");

                String paco = jugadorCEN.DameJugadorPorNombre ("Paco").Nombre;

                System.Console.WriteLine (paco);

                // p.e. CustomerCEN customer = new CustomerCEN();
                // customer.New_ (p_user:"user", p_password:"1234");



                /*PROTECTED REGION END*/
        }
        catch (Exception ex)
        {
                System.Console.WriteLine (ex.InnerException);
                throw ex;
        }
}
}
}
