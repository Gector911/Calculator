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
        public void Definition2(object sender, EventArgs e)
        {
            double firstArgument;
            double result;

            firstArgument = Convert.ToDouble(textBox1.Text);

            
             if (radioButton2.Checked && ((Button)sender).Name != "button10"
                                      && ((Button)sender).Name != "button9")
            {
                firstArgument = firstArgument * Math.PI  / 180;
            }

            var calc = AdditionalFactory.CreateAdditionalCalculator(((Button)sender).Name);
            result = calc.Calculate(firstArgument);
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

        private void button5_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
