using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalkulatot
{
 public   class Calculation:CalculationArguments
    {

        public double Equation(string UserInput, CalculationArguments calculationArguments)
        {
            string[] inputParts = UserInput.Split(" ");
            var charsToRemove = inputParts[0].Length;
            string equation = UserInput.Remove(0, charsToRemove);
            Expression e = new Expression(equation, calculationArguments.ToArray());
      //      _output.Write(e.calculate().ToString());
            return e.calculate();
        }
    }
}
