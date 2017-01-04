
/*PROTECTED REGION ID(CreateDB_imports) ENABLED START*/
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using ProyectoVikingsGenNHibernate.EN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CEN.ProyectoVikings;
using ProyectoVikingsGenNHibernate.CAD.ProyectoVikings;

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

                // Jugadores
                int jugador1 = jugadorCEN.New_ ("Paco", "paco@gmail.com", new DateTime (1997, 11, 19), "Pato", 20, 20, 1, 1, 0);
                int jugador2 = jugadorCEN.New_ ("Jose", "jose@gmail.com", new DateTime (1957, 12, 19), "Pato", 20, 20, 1, 1, 0);

                // Objetos
                int armadura1 = armaduraCEN.New_ ("Grebas del abismo 2.0", 12, 10);
                int armadura2 = armaduraCEN.New_ ("Armadura de carton", 3, 4);
                int calzado1 = calzadoCEN.New_ ("Botas del abismo 2.0", 12, 10);
                int calzado2 = calzadoCEN.New_ ("Zapatos de carton", 3, 4);
                int casco1 = cascoCEN.New_ ("Casco del abismo 2.0", 12, 10);
                int casco2 = cascoCEN.New_ ("Casco de carton", 3, 4);
                int arma1 = armaCEN.New_ ("Espada del abismo 2.0", 12);
                int arma2 = armaCEN.New_ ("Espada de carton", 3);

                //Monstruos
                int monstruo1 = monstruoCEN.New_ ("Mariano", 30, 2, 2);
                int monstruo2 = monstruoCEN.New_ ("Joutn", 30, 2, 2);

                //inventario

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
