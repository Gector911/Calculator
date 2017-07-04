using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Definition(object sender, EventArgs e)
        {
            double firstArgument;
            double secondArgument;
            double result;

            firstArgument = Convert.ToDouble(textBox1.Text);
            secondArgument = Convert.ToDouble(textBox2.Text);

            var calc = CalculatorsFactory.CreateCalculator(((Button)sender).Name);
            result = calc.Calculate(firstArgument, secondArgument);
            textBox3.Text = result.ToString();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Definition(sender, e);
        }
    }
}
