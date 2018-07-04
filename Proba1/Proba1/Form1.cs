using System;
using System.Windows.Forms;

namespace Proba1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void TwoArgumentsOperation(object sender, EventArgs e)
        {
            String variable1 = textBox1.Text;
            double firstArgument = Convert.ToDouble(variable1);
            String variable2 = textBox2.Text;
            double secondArgument = Convert.ToDouble(variable2);
            string operation = ((Button)sender).Name;
            ITwoArgumentsCalculator calculator = TwoArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument, secondArgument);
            textBox3.Text = Convert.ToString(result);

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Squaring(object sender, EventArgs e)
        {
            String variable1 = textBox1.Text;
            double firstArgument = Convert.ToDouble(variable1);
            String variable2 = textBox2.Text;
            string operation = ((Button)sender).Name;
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument);
            textBox3.Text = Convert.ToString(result);
        }

        private void Square_root_Click(object sender, EventArgs e)
        {
            String variable1 = textBox1.Text;
            double firstArgument = Convert.ToDouble(variable1);
            String variable2 = textBox2.Text;
            string operation = ((Button)sender).Name;
            IOneArgumentsCalculator calculator = OneArgumentsFactory.CreateCalculator(operation);
            double result = calculator.Calculate(firstArgument);
            textBox3.Text = Convert.ToString(result);
        }
    }

}
