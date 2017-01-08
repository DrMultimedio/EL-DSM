
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

                ArmaduraCAD armaduraCAD = new ArmaduraCAD ();
                ArmaduraCEN armaduraCEN = new ArmaduraCEN ();
                ArmaCAD armaCAD = new ArmaCAD ();
                ArmaCEN armaCEN = new ArmaCEN ();
                CalzadoCAD calzadoCAD = new CalzadoCAD ();
                CalzadoCEN calzadoCEN = new CalzadoCEN ();
                CascoCAD cascoCAD = new CascoCAD ();
                CascoCEN cascoCEN = new CascoCEN ();

                MonstruoCAD monstruoCAD = new MonstruoCAD ();
                MonstruoCEN monstruoCEN = new MonstruoCEN ();

                Batalla_PVECAD batallaPVECAD = new Batalla_PVECAD ();
                Batalla_PVECEN batallaPVECEN = new Batalla_PVECEN ();

                Batalla_PVPCAD batallaPVPCAD = new Batalla_PVPCAD ();
                Batalla_PVPCEN batallaPVPCEN = new Batalla_PVPCEN ();

                Batalla_PVECP batallaPVECCP = new Batalla_PVECP ();
                Batalla_PVPCP batallaPVPCCP = new Batalla_PVPCP();

                Batalla_PVEEN batallapveEN = null;


                // Jugadores
                int jugador1 = jugadorCEN.New_ ("Paco", "paco@gmail.com", new DateTime (1997, 11, 19), "Pato", 20, 20, 3, 1, 0, "Paco1");
                int jugador2 = jugadorCEN.New_ ("Jose", "jose@gmail.com", new DateTime (1957, 12, 19), Util.GetEncondeMD5 ("Pato"), 20, 20, 3, 1, 0, "Jose1");
                int jugador3 = jugadorCEN.New_ ("ThorTilla", "jose@gmail.com", new DateTime (1957, 12, 19), Util.GetEncondeMD5 ("Pato"), 50, 40, 5, 1, 0, "Jose1");

                // Objetos
                int armadura1 = armaduraCEN.New_ ("Grebas del abismo 2.0", 12, 10, 3);
                int armadura2 = armaduraCEN.New_ ("Armadura de carton", 3, 4, 3);
                int calzado1 = calzadoCEN.New_ ("Botas del abismo 2.0", 12, 10, 3);
                int calzado2 = calzadoCEN.New_ ("Zapatos de carton", 3, 4, 3);
                int casco1 = cascoCEN.New_ ("Casco del abismo 2.0", 12, 10, 3);
                int casco2 = cascoCEN.New_ ("Casco de carton", 3, 4, 3);
                int arma1 = armaCEN.New_ ("Espada del abismo 2.0", 12, 3);
                int arma2 = armaCEN.New_ ("Espada de carton", 3, 3);

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
                        System.Console.WriteLine (batallaPVPCEN.DameGanador(batalla2));
                }
                else{
                        System.Console.WriteLine ("Gana el jugador 2");
                        System.Console.WriteLine (batallaPVPCEN.DameGanador(batalla2));
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

                System.Console.WriteLine("Ni idea de quien gana");

                if (batallaPVPCCP.Resolver(jugador1, jugador2, batalla2))
                {
                    System.Console.WriteLine("Gana el jugador 1");
                    System.Console.WriteLine(batallaPVPCEN.DameGanador(batalla2));
                }
                else
                {
                    System.Console.WriteLine("Gana el jugador 2");
                    System.Console.WriteLine(batallaPVPCEN.DameGanador(batalla2));
                }

                //inventario

                //le prueba del algodon
                IList<JugadorEN> jugadores = jugadorCEN.DameJugadores (0, 14);

                foreach (JugadorEN j in jugadores) {
                        System.Console.WriteLine (j.Nombre);
                }


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
