using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculator.One_Argument;
using Calculator.Two_Arguments;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public void TwoArgumentButtonClick(object sender, EventArgs e)
        {
            try
            {

                double firstArgument;
                double secondArgument;
                double result;

                firstArgument = Convert.ToDouble(textBox1.Text);
                secondArgument = Convert.ToDouble(textBox2.Text);


                var calc = CalculatorsFactory.CreateCalculator(((Button) sender).Name);
                result = calc.Calculate(firstArgument, secondArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            { textBox3.Text = "ERROR";}

        }
        public void OneArgumentButtonClick(object sender, EventArgs e)
        {
            try
            {
                double firstArgument;
                double result;

                firstArgument = Convert.ToDouble(textBox1.Text);

                if (degrees.Checked && (((Button) sender).Name == "sin"
                                        || ((Button) sender).Name == "cos"
                                        || ((Button) sender).Name == "tg"
                                        || ((Button) sender).Name == "ctg"))
                {
                    firstArgument = firstArgument * Math.PI / 180;
                }

                var calc = AdditionalFactory.CreateAdditionalCalculator(((Button) sender).Name);
                result = calc.Calculate(firstArgument);
                textBox3.Text = result.ToString();
            }
            catch (Exception exc)
            { textBox3.Text = "ERROR"; }
        }
        
    }
}
