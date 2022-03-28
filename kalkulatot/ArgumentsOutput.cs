using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulatot
{
  public  class ArgumentsOutput
    {
        private readonly IOutput _output;
        private readonly CalculationArguments _calculationArguments;
        private readonly Calculation _calculation;

        public ArgumentsOutput(IOutput output, CalculationArguments calculationArguments, Calculation calculation)
        {
            _output = output;
            _calculationArguments = calculationArguments;
            _calculation = calculation;
        }

        public void DisplayArgument(string name)
        {
           _output.Write(_calculationArguments.Get(name).ToString());
        }

        public void DisplayArguments()
        {
            List<Argument> e = _calculationArguments.GetAll();
            for (int i = 0; i < e.Count; i++)
            {
                _output.Write(e[i].getArgumentValue().ToString());
            }
           
        }

        public void DisplayEquation(string UserInput)
        {
            _output.Write(_calculation.Equation(UserInput,_calculationArguments).ToString());

        }
    }
}
