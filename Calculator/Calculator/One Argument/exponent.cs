﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator.One_Argument
{
    public class exponent : CalcForOneArgument
    {
        public double Calculate(double firstArgument)
        {
            return (Math.Exp(firstArgument));
        }
    }
}
