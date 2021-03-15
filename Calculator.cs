using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Demo
{
    public class Calculator
    {
        public static double chia(int a, int b)
        {
            if (b == 0)
                throw new DivideByZeroException("Invalid Data");

            return a*1.0 / b;
        }
    }
}
