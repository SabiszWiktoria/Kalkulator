using System;
using System.Collections.Generic;
using org.mariuszgromada.math.mxparser;
using System.Linq;




namespace kalkulatot
{
    public class Command
    {
        public HelpPl helpPl = new HelpPl();
        public HelpEn helpEn = new HelpEn();
        public CalculationArguments Key = new CalculationArguments();
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

        public double Equation(string UserInput)
        {
            string[] inputParts = UserInput.Split(" ");
            var charsToRemove = inputParts[0].Length;
            string equation = UserInput.Remove(0, charsToRemove);
            Expression e = new Expression(equation, Key.Arguments.Values.ToArray());
            Console.WriteLine(e.calculate());
            return e.calculate();
        }

        public void ArgsHander(string[] inputParts)
        {
            if (inputParts[1].ToLower() == "show")
            {
                Key.ShowAllArguments();
                return;
            }
            if (inputParts[1].ToLower() == "clear")
            {
                Key.RemoveAllvalues();
                return;
            }
            if (inputParts.Length > 1)
            {
                if (inputParts[2].ToLower() == "clear")
                {
                    Key.RemoveOnlyValue(inputParts[1]);
                    return;
                }
            }
        }
        public void ArgHander(string[] inputParts)
        {
            if (inputParts.Length > 2)
            {
                Key.Create(inputParts[1], inputParts[1] + " = " + inputParts[inputParts.Length - 1]);
                return;
            }
            else
            {
                Key.ShowArgument(inputParts[1]);
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
                ArgsHander(inputParts);
            }
            if (Key.Arguments.ContainsKey(UserInput))
            {
                Key.ShowArgument(UserInput);
            }
            if (inputParts[0].ToLower() == "arg")
            {
                ArgHander(inputParts);
            }
            if (inputParts[0].ToLower() == "clear")
            {
                ClearConsole();
            }
            if (inputParts[0].ToLower() == "calc" || inputParts[0] == "=")
            {
                Equation(UserInput);
                return;
            }
            if (inputParts.Length > 1)
            {
                if (inputParts[1] == "=")
                {
                    Key.Create(inputParts[0], inputParts[0] + "  " + inputParts[1] + " " + inputParts[inputParts.Length - 1]);
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
