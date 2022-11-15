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
            connection = new MySqlConnection(builder.ConnectionString);
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
            finally 
            { 
                connection.Close();
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
                if (connection.State == ConnectionState.Closed)
                {
                    connection.Open();
                }
                
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
            finally 
            {
                connection.Close();
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

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (!vannak_adatok())
            {
                return;
            }
            //-- kapott adatok kiírása ----------------------------
            command.CommandText = "INSERT INTO `ugyfel` (`azon`, `nev`, `szulev`, `irszam`, `orsz`) VALUES (NULL, @nev, @szulev, @irsz, @orsz);";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_Nev.Text);
            command.Parameters.AddWithValue("@szulev", numericUpDown_SzuletesiEv.Value);
            command.Parameters.AddWithValue("@irsz", numericUpDown_IranyitoSzam.Value);
            command.Parameters.AddWithValue("@orsz", textBox_Orszag.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1 )
            {
                MessageBox.Show("Sikeres rögzítés!");
                textBox_Azonosito.Text = "";
                textBox_Nev.Text = "";
                textBox_Orszag.Text = "";
                numericUpDown_SzuletesiEv.Value = numericUpDown_SzuletesiEv.Minimum;
                numericUpDown_IranyitoSzam.Value = numericUpDown_IranyitoSzam.Value;
                connection.Close();
                Tagok_Update();
            }
            else
            {
                MessageBox.Show("Sikertelen rögzítés!");
            }
            connection.Close();
        }

        private bool vannak_adatok()
        {
            //-- adatok ellenőrzése --------------------------------
            if (string.IsNullOrEmpty(textBox_Nev.Text))
            {
                MessageBox.Show("Nem adott meg nevet!");
                textBox_Nev.Focus();
                return false;
            }
            if (string.IsNullOrEmpty(textBox_Orszag.Text))
            {
                MessageBox.Show("Nem adott meg országot!");
                textBox_Orszag.Focus();
                return false;
            }
            if (numericUpDown_IranyitoSzam.Value < 1)
            {
                MessageBox.Show("Nem adott meg irányítószámot!");
                numericUpDown_IranyitoSzam.Focus();
                return false;
            }
            if (numericUpDown_SzuletesiEv.Value < 1900 && numericUpDown_SzuletesiEv.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Érvénytelen évszám");
                numericUpDown_SzuletesiEv.Focus();
                return false;
            }
            return true;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {
            if (!vannak_adatok())
            {
                return;
            }
            //-- adatfeldolgozás ----------------------------------
            command.CommandText = "UPDATE `ugyfel` SET `nev`=@nev,`szulev`=@szulev,`irszam`=@irsz,`orsz`=@orsz WHERE `azon`=@azon";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", textBox_Nev.Text);
            command.Parameters.AddWithValue("@szulev", numericUpDown_SzuletesiEv.Value);
            command.Parameters.AddWithValue("@irsz", numericUpDown_IranyitoSzam.Value);
            command.Parameters.AddWithValue("@orsz", textBox_Orszag.Text);
            command.Parameters.AddWithValue("@azon", textBox_Azonosito.Text);
            connection.Open();
            if (command.ExecuteNonQuery() == 1)
            {
                MessageBox.Show("Sikeres módosítás!");
                textBox_Azonosito.Text = "";
                textBox_Nev.Text = "";
                textBox_Orszag.Text = "";
                numericUpDown_SzuletesiEv.Value = numericUpDown_SzuletesiEv.Minimum;
                numericUpDown_IranyitoSzam.Value = numericUpDown_IranyitoSzam.Value;
                connection.Close();
                Tagok_Update();
            }
            else
            {
                MessageBox.Show("Sikertelen módosítás!");
            }
            connection.Close();
        }
    }
}
