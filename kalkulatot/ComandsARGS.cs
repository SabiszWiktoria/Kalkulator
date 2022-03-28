using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulatot
{
    public class ComandsARGS
    {

        private CalculationArguments _calculationArguments;
        private Calculation _calculation;
     
        private ArgumentsOutput _displayInConsole;
        private readonly IOutput _output;

        public ComandsARGS(IOutput output,CalculationArguments calculationArguments,Calculation calculation)
        {
            _calculation = calculation;
            _output = output;
            _calculationArguments = calculationArguments;
           
            _displayInConsole = new ArgumentsOutput(_output, _calculationArguments,_calculation);
           
        }
        public void SelectingCommandARGS(string[] inputParts)
        {
            if (inputParts[1].ToLower() == "show")
            {
                _displayInConsole.DisplayArguments();
                return;
            }
            if (inputParts[1].ToLower() == "clear")
            {
                _calculationArguments.RemoveAll();
                return;
            }
            if (inputParts.Length > 1)
            {
                if (inputParts[2].ToLower() == "clear")
                {
                    _calculationArguments.Remove(inputParts[1]);
                    return;
                }
            }
        }
    }
}
