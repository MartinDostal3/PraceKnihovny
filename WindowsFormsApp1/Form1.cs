using CelaCisla;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);


            int soucet = Operace.Soucet(a, b);
            MessageBox.Show("součet je: " + soucet);

            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int zbytek;

            int podil = Operace.CelociselnyPodil(a, b, out zbytek);
            MessageBox.Show("Celociselny podil je: " + podil + " a zbytek je: " + zbytek);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int rozdil = Operace.Rozdil(a, b);
            MessageBox.Show("Rozdil je: " + rozdil);

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);

            int soucin = Operace.Soucin(a, b);
            MessageBox.Show("Soucin podil je: " + soucin);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox3.Text);

            if(Operace.JeLiche(a))
            {
                MessageBox.Show("Ano, je liché");
            }
            else
           {
                MessageBox.Show("Ne, není liché, je sudé");
           }
        }
    }
}
