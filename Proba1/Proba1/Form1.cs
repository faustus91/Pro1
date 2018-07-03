﻿using System;
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
            String variable1 = textBox1.Text;
            double value1 = Convert.ToDouble(variable1);
            String variable2 = textBox2.Text;
            double value2 = Convert.ToDouble(variable2);
            textBox3.Text = Convert.ToString(value1 - value2);
        }

        private void Multiplication(object sender, EventArgs e)
        {
            String variable1 = textBox1.Text;
            double value1 = Convert.ToDouble(variable1);
            String variable2 = textBox2.Text;
            double value2 = Convert.ToDouble(variable2);
            textBox3.Text = Convert.ToString(value1 * value2);
        }

        private void Division(object sender, EventArgs e)
        {
            String variable1 = textBox1.Text;
            double value1 = Convert.ToDouble(variable1);
            String variable2 = textBox2.Text;
            double value2 = Convert.ToDouble(variable2);
            textBox3.Text = Convert.ToString(value1 / value2);
        }

        private void g(object sender, EventArgs e)
        {
            String variable1 = textBox1.Text;
            double value1 = Convert.ToDouble(variable1);
            String variable2 = textBox2.Text;
            double value2 = Convert.ToDouble(variable2);
            double result;
            switch (((Button)sender).Name)
            {
                case "Add":
                    result = value1 + value2;

        break;
                case "minus":
                    result = value1 - value2;

        break;
                case "multi":
                    result = value1 * value2;
                    break;

                case "Div":
                    result = value1 / value2;
                    break;

                default:
                    throw new Exception("error");

            
            }
            textBox3.Text = Convert.ToString(result);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }

}
