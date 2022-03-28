using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulatot
{
   public class ComandsARG
    {
        private CalculationArguments _calculationArguments;
        private Calculation _calculation;

        private ArgumentsOutput _displayInConsole;
        private readonly IOutput _output;

        public ComandsARG(IOutput output, CalculationArguments calculationArguments, Calculation calculation)
        {
            _calculation = calculation;
            _output = output;
            _calculationArguments = calculationArguments;

            _displayInConsole = new ArgumentsOutput(_output, _calculationArguments, _calculation);

        }
        public void SelectingCommandARG(string[] inputParts)
        {
            if (inputParts.Length > 2)
            {
                _calculationArguments.Create(inputParts[1], inputParts[1] + " = " + inputParts[inputParts.Length - 1]);
                return;
            }
            else
            {
                _displayInConsole.DisplayArgument(inputParts[1]);
                return;
            }
        }
    }
}
