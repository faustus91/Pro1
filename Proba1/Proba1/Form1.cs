using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void Addition(object sender, EventArgs e)
        {
            String peremennaya1 = textBox1.Text;
            double Chislo1 = Convert.ToDouble(peremennaya1);
            String peremennaya2 = textBox2.Text;
            double Chislo2 = Convert.ToDouble(peremennaya2);
            textBox3.Text = Convert.ToString(Chislo1 + Chislo2);
            
        }

        private void Subtraction(object sender, EventArgs e)
        {
            String peremennaya1 = textBox1.Text;
            double Chislo1 = Convert.ToDouble(peremennaya1);
            String peremennaya2 = textBox2.Text;
            double Chislo2 = Convert.ToDouble(peremennaya2);
            textBox3.Text = Convert.ToString(Chislo1 - Chislo2);
        }

        private void Multiplication(object sender, EventArgs e)
        {
            String peremennaya1 = textBox1.Text;
            double Chislo1 = Convert.ToDouble(peremennaya1);
            String peremennaya2 = textBox2.Text;
            double Chislo2 = Convert.ToDouble(peremennaya2);
            textBox3.Text = Convert.ToString(Chislo1 * Chislo2);
        }

        private void Division(object sender, EventArgs e)
        {
            String peremennaya1 = textBox1.Text;
            double Chislo1 = Convert.ToDouble(peremennaya1);
            String peremennaya2 = textBox2.Text;
            double Chislo2 = Convert.ToDouble(peremennaya2);
            textBox3.Text = Convert.ToString(Chislo1 / Chislo2);
        }
    }
}
