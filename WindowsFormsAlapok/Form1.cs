using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAlapok
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                return;
            }
            if (checkBox1.Checked)
            {
                MessageBox.Show("Elfogadta!");
            }
            else
            {
                MessageBox.Show("Nem fogadta el!");
            }
            MessageBox.Show("Helló "+textBox1.Text+"!");
        }
    }
}
