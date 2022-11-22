using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsForms_Gyumolcsos
{
    public partial class Form1 : Form
    {
        DataBase dataBase = new DataBase();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GyumolcsokBetoltese();
        }

        private void GyumolcsokBetoltese()
        {
            listBox_Gyumolcsok.Items.Clear();
            foreach (Gyumolcs item in dataBase.getAllGyumolcs())
            {
                listBox_Gyumolcsok.Items.Add(item);
            }
        }

        private void button_Insert_Click(object sender, EventArgs e)
        {
            if (HianyzoAdat())
            {
                return;
            }
            Gyumolcs ujGyumolcs = new Gyumolcs(1, textBox_GyumolcsNev.Text, (double)numericUpDown_Egysegar.Value, (double)numericUpDown_Mennyiseg.Value);
            if (dataBase.addGyumolcs(ujGyumolcs))
            {
                MessageBox.Show("Sikeres rögzítés");
                textBox_GyumolcsNev.Text = "";
                textBox_Id.Text = "";

            }
            else
            {
                MessageBox.Show("A rögzítés sikertelen");
            }
            GyumolcsokBetoltese();
        }

        private bool HianyzoAdat()
        {
            if (String.IsNullOrEmpty(textBox_GyumolcsNev.Text))
            {
                MessageBox.Show("Érvénytelen gyömölcsnév!");
                textBox_GyumolcsNev.Focus();
                return true;
            }
            return false;
        }

        private void button_Update_Click(object sender, EventArgs e)
        {

        }

        private void listBox_Gyumolcsok_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox_Gyumolcsok.SelectedIndex < 0)
            {
                return;
            }
            Gyumolcs gyumolcs = (Gyumolcs)listBox_Gyumolcsok.SelectedItem;
            textBox_GyumolcsNev.Text=gyumolcs.Nev;
            textBox_Id.Text=gyumolcs.Id.ToString();
            numericUpDown_Egysegar.Value = (decimal) gyumolcs.Egysegar;
            numericUpDown_Mennyiseg.Value = (decimal) gyumolcs.Mennyiseg;
        }
    }
}
