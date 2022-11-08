using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlap
{
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void button_Udvozol_Click(object sender, EventArgs e)
        {
            //-- Ellenőrizzük, adott-e meg nevet
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Nem adott meg nevet!", "Hiányzó adat", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                MessageBox.Show("Üdvözöllek " + textBox1.Text + "!");
            }

        }
    }
}
