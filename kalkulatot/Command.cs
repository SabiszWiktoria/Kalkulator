using System;
using System.Collections.Generic;
using org.mariuszgromada.math.mxparser;
using System.Linq;




namespace kalkulatot
{
    public class Command
    {
       // private readonly IOutput _output;
        public HelpPl helpPl = new HelpPl();
        public HelpEn helpEn = new HelpEn();
        private ComandsARG comandsARG;
        private ComandsARGS comandsARGS;
        private readonly IOutput _output;
        private CalculationArguments _calculationArguments;
        private Calculation _calculation;

     
        private readonly ArgumentsOutput _displayInConsole;
        public Command(IOutput output,CalculationArguments calculationArguments,Calculation calculation)
            {
            _calculation = calculation;
            _calculationArguments = calculationArguments;
            _output = output;
            comandsARG = new ComandsARG(_output, _calculationArguments, _calculation);
            comandsARGS = new ComandsARGS(_output, _calculationArguments, _calculation);
            _displayInConsole = new ArgumentsOutput(_output, _calculationArguments,_calculation);
        }
        public void ShowHelp(string language)
        {
            if (language == "pl")
            {
                helpPl.Show();
            }
            if (language == "en")
            {
                helpEn.Show();
            }

        }
        public void HelpHender(string[] inputParts)
        {
            if (inputParts.Length == 1)
            {
                ShowHelp("pl");
                return;
            }
            else
            {
                ShowHelp(inputParts[1].ToLower());
                return;
            }
        }

        
      
        public void ProcessCommand(string UserInput)
        {
            string[] inputParts = UserInput.Split(" ");
            if (inputParts[0].ToLower() == "help")
            {
                HelpHender(inputParts);
            }
            if (inputParts[0].ToLower() == "args")
            {
                comandsARGS.SelectingCommandARGS(inputParts);
            }
            if (_calculationArguments.GetArgumetn().ContainsKey(UserInput))
            {
                _displayInConsole.DisplayArgument(UserInput);
            }
            if (inputParts[0].ToLower() == "arg")
            {
                comandsARG.SelectingCommandARG(inputParts);
            }
            if (inputParts[0].ToLower() == "clear")
            {
                ClearConsole();
            }
            if (inputParts[0].ToLower() == "calc" || inputParts[0] == "=")
            {
                _displayInConsole.DisplayEquation(UserInput);
                return;
            }
            if (inputParts.Length > 1)
            {
                if (inputParts[1] == "=")
                {
                    _calculationArguments.Create(inputParts[0], inputParts[0] + "  " + inputParts[1] + " " + inputParts[inputParts.Length - 1]);
                    return;
                }
            }

        }

        public void ClearConsole()
        {
            Console.Clear();
            return;
        }
    }
}
