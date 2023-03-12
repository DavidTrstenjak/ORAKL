using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORAKL_NIOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            broj0.Show();
            broj1.Show();
            broj2.Show();
            broj3.Show();
            broj4.Show();
            broj5.Show();
            broj6.Show();
            broj7.Show();
            broj8.Show();
            broj9.Show();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string dodaj0 = broj0.Text;
            string dodaj1 = broj1.Text;
            string dodaj2 = broj2.Text;
            string dodaj3 = broj3.Text;
            string dodaj4 = broj4.Text;
            string dodaj5 = broj5.Text;
            string dodaj6 = broj6.Text;
            string dodaj7 = broj7.Text;
            string dodaj8 = broj8.Text;
            string dodaj9 = broj9.Text;

            

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string djelatnik = textBox1.Text;
            string zaporka = textBox2.Text;
            if (djelatnik == "255880" && zaporka == "5880")
            {
                Form2 noviProzor = new Form2();
                noviProzor.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Pogrešno korisničko ime ili lozinka.");
            }
        }
    }
}
