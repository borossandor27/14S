using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace WindowsFormsTagdij
{
    public partial class Form_ClubTags : Form
    {
        MySqlConnection connection;
        MySqlCommand command;
        public Form_ClubTags()
        {
            InitializeComponent();
        }

        private void Form_ClubTags_Load(object sender, EventArgs e)
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "tagdij";
            connection=new MySqlConnection(builder.ConnectionString);
            try
            {
                connection.Open();
                command = connection.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + Environment.NewLine + "Program leáll!");
                Environment.Exit(0);
            }
            Tagok_Update();
        }

        /// <summary>
        /// A listBox_Klubtagokat frissíti az adatbázis tartalma alapján
        /// </summary>
        private void Tagok_Update()
        {
            listBox_KlubTagok.Items.Clear();
            try
            {
                command.CommandText = "SELECT `azon`,`nev`,`szulev`,`irszam`,`orsz` FROM `ugyfel` WHERE 1;";
                using (MySqlDataReader dr = command.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        //-- aktuálisan kiolvasott rekord feldolgozása
                        Tag beolvasott = new Tag(dr.GetInt32("azon"), dr.GetString("nev"), dr.GetInt32("szulev"), dr.GetInt32("irszam").ToString(), dr.GetString("orsz"));
                        listBox_KlubTagok.Items.Add(beolvasott);
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void listBox_KlubTagok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_KlubTagok.SelectedIndex<0)
            {
                return;
            }
            //-- Biztosan kattintott a felhasználó
            Tag kivalasztottTag = (Tag)listBox_KlubTagok.SelectedItem;
            textBox_Azonosito.Text = kivalasztottTag.Azon.ToString();
            textBox_Nev.Text = kivalasztottTag.Nev;
            textBox_Orszag.Text = kivalasztottTag.Orsz;
            numericUpDown_IranyitoSzam.Value = decimal.Parse(kivalasztottTag.Irszam);
            numericUpDown_SzuletesiEv.Value = kivalasztottTag.Szulev;
        }
    }
}
