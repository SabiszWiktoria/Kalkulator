using System;
using System.Collections.Generic;
using org.mariuszgromada.math.mxparser;
using System.Linq;

namespace kalkulatot
{
    class Program
    {
      static  Dictionary<string, Argument> Key = new Dictionary<string, Argument>();
     //  static HelpPl helpPl = new HelpPl();
      // static HelpEn helpEn = new HelpEn();
        
        static CalculationArguments key = new CalculationArguments();
        static Command command =new  Command();
      /*
        static void Create(string name,string value)
        {
            if ( Key.ContainsKey(name))
            {
                Key.Remove(name);
                Key.Add(name, new Argument(value));
            }
            else
            {
                Key.Add(name, new Argument(value));
            }
           
        }
        static void ShowArgument(string name)
        {
            Console.WriteLine(name + " = " + Key[name].getArgumentValue());
        }
        static void ShowAllArguments()
        {
            List<Argument> e = Key.Values.ToList();

            for (int i = 0; i < e.Count; i++)
            {
                Console.WriteLine(e[i].getArgumentValue());
            }
        }
        static void RemoveAllvalues()
        {
            foreach (var item in Key)
            {
                Key.Remove(item.Key);
            }
        }
        static void RemoveOnlyValue(string key)
        {
            Key.Remove(key);
        }

        static void ShowHelp(string language)
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
        static void HelpHender(string[] inputParts)
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

        static void Equation(string UserInput)
        {
            string[] inputParts = UserInput.Split(" ");
            string equation;
            if (inputParts[0] == "=")
            {
                equation = UserInput.Remove(0, 1);
                Expression e = new Expression(equation, Key.Values.ToArray());
                Console.WriteLine(e.calculate());
            }
            if (inputParts[0].ToLower() == "calc")
            {
                equation = UserInput.Remove(0, 4);
                Expression e = new Expression(equation, Key.Values.ToArray());
                Console.WriteLine(e.calculate());
            }


        }
        static void ArgsHander(string[] inputParts)
        {
            if (inputParts[1].ToLower() == "show")
            {
                ShowAllArguments();
                return;
            }
            if (inputParts[1].ToLower() == "clear")
            {
                RemoveAllvalues();
                return;
            }
            if (inputParts.Length > 1)
            {
                if (inputParts[2].ToLower() == "clear")
                {
                    RemoveOnlyValue(inputParts[1]);
                    return;
                }
            }
        }
        static void ArgHander(string[] inputParts)
        {
            if (inputParts.Length > 2)
            {
                Create(inputParts[1], inputParts[1] + " = " + inputParts[inputParts.Length - 1]);
                return;
            }
            else
            {
                ShowArgument(inputParts[1]);
                return;
            }
        }
        static void ProcessCommand(string UserInput)
        {  
            string[] inputParts= UserInput.Split(" ");
            if (inputParts[0].ToLower() == "help")
            {
                HelpHender(inputParts);
            }
            if (inputParts[0].ToLower() == "args")
            {
                ArgsHander(inputParts);  
            }
            if ( Key.ContainsKey(UserInput))
            {
                ShowArgument(UserInput);
            }
            if (inputParts[0].ToLower() == "arg")
            {
                ArgHander(inputParts);  
            }
            if (inputParts[0].ToLower() == "clear")
            {
                ClearConsole();
            }
            if(inputParts[0].ToLower() == "calc"|| inputParts[0] == "="){ 
                Equation(UserInput);
                return;  
            }
            if (inputParts.Length > 1)
            {
                if (inputParts[1] == "=")
                {
                    Create(inputParts[0], inputParts[0] + "  " + inputParts[1] + " " + inputParts[inputParts.Length - 1]);
                    return;
                }
            }

        }

        static void ClearConsole()
        {
            Console.Clear();
            return;
        }
      */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string variableFromConsole;
            do
            {
                variableFromConsole = Console.ReadLine();
               command.ProcessCommand(variableFromConsole);
            } while (variableFromConsole!="quit");
          
        }
    }
}
