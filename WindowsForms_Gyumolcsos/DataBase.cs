using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsForms_Gyumolcsos
{
    
    internal class DataBase
    {
        MySqlConnection connection;
        MySqlCommand command;

        public DataBase(string server="localhost", string user="root", string password="", string db ="gyumolcsok")
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();  
            builder.Server = server;
            builder.UserID = user;
            builder.Password = password;
            builder.Database = db;
            connection = new MySqlConnection(builder.ConnectionString);
            if (KapcsolatOK())
            {
                command = connection.CreateCommand();
            }
        }

        public List<Gyumolcs> getAllGyumolcs()
        {
            List<Gyumolcs> list = new List<Gyumolcs>();
            command.CommandText = "SELECT * From GYUMOLCSOK;";
            Nyitas();
            using (MySqlDataReader dr = command.ExecuteReader())
            {
                while (dr.Read())
                {
                    Gyumolcs gyumolcs = new Gyumolcs(dr.GetInt32("id"), dr.GetString("nev"), dr.GetDouble("egysegar"), dr.GetDouble("mennyiseg"));
                    list.Add(gyumolcs);
                }
            }
            Zaras();
            return list;
        }

        private void Zaras()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void Nyitas()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        private bool KapcsolatOK()
        {
            try
            {
                connection.Open();
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        internal bool addGyumolcs(Gyumolcs ujGyumolcs)
        {
            command.CommandText = "INSERT INTO gyumolcsok (id, nev, mennyiseg, egysegar) VALUES (null, @nev, @mennyiseg, @egysegar);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", ujGyumolcs.Nev);
            command.Parameters.AddWithValue("@mennyiseg", ujGyumolcs.Mennyiseg);
            command.Parameters.AddWithValue("@egysegar", ujGyumolcs.Egysegar);
            Nyitas();
            if (command.ExecuteNonQuery()==1)
            {
                Zaras();

                return true;
            }
            else
            {
                Zaras();
                return false;
            }
        }
    }
}
