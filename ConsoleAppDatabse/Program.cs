using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace ConsoleAppDatabse
{
    internal class Program
    {
        static MySqlConnection connection; //-- alkalmazás és adatbázis közötti hálózati kapcsolatért
        static MySqlCommand command; //-- SQL parancsok tárolása és végrehajtása
        static MySqlDataReader reader; //-- kapott adatok átmeneti tárolása
        static void Main(string[] args)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "pizza";
            connection = new MySqlConnection(builder.ConnectionString);
            command = connection.CreateCommand();
            command.CommandText = "SELECT `pazon`,`pnev`,`par` FROM `pizza` WHERE 1";
            try
            {
                connection.Open();
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        int pazon = dr.GetInt16("pazon");
                        string pnev = dr.GetString("pnev");
                        int par = dr.GetInt16("par");
                        Console.WriteLine($"{pazon}.{pnev,-17} - {par.ToString("#,##0 Ft"),11}");
                    }
                }
                connection.Close();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }
            Console.WriteLine("\nProgram vége!");
            Console.ReadLine();
        }
    }
}
