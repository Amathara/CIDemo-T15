using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal interface ICalculator
    {

        int Add(int a, int b);

        int Subtract(int a, int b);

        int Multiply(int a, int b);

        double Divide(int a, int b);

        double Exponetial(double a, double b);
    }
}
