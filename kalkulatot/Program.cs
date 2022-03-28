using System;
using System.Collections.Generic;
using org.mariuszgromada.math.mxparser;
using System.Linq;

namespace kalkulatot
{
    class Program
    {
        static void Main(string[] args)
        {
            IOutput output = new ConsoleOutput();
            Calculation calculation = new Calculation();
            CalculationArguments calculationArguments = new CalculationArguments();
            ArgumentsOutput argumentsOutput = new ArgumentsOutput(output, calculationArguments, calculation);
            Command command = new Command(output,calculationArguments,calculation);
            Console.WriteLine("Hello World!");
            string variableFromConsole;
            do
            {
                variableFromConsole = Console.ReadLine();
                try
                {
                    command.ProcessCommand(variableFromConsole);
                }
                catch (Exception e)
                {
                    Console.WriteLine("Error: " + e.Message);
                }
            } while (variableFromConsole != "quit");

        }
    }
}
