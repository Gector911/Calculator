using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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


            if (degrees.Checked && ((Button)sender).Name != "button10"
                                     && ((Button)sender).Name != "button9")
            {
                firstArgument = firstArgument * Math.PI / 180;
            }

            var calc = AdditionalFactory.CreateAdditionalCalculator(((Button)sender).Name);
            result = calc.Calculate(firstArgument);
            textBox3.Text = result.ToString();

        }
        private void min_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void Subtruction_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void Addition_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void Multiplication_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void Division_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void power_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void max_Click(object sender, EventArgs e)
        {
            Definition(sender, e);
        }

        private void sqrt_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void sin_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void cos_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void sinh_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void tg_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void ctg_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void cosh_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void arcsin_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void arccos_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void tgh_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void arctg_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void lg_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void ln_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void exponent_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }

        private void decad_Click(object sender, EventArgs e)
        {
            Definition2(sender, e);
        }
    }
}
