using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulatot
{
  public  class Help
    {
        private string delarationVarable = "'arg x 25' , 'y = 25'";
        private string calculation = " 'calc (x + y)/2' , '=  (x + y)/2'";
        private string help = "'help pl , help en'";
        private string quit = "'quit'";

        private string ShowAllArguments = "args show";
        private string ShowOnlyArgument = "arg x, x, = x";
        public string RemoweAllArguments = "args clear";
        public string RemoveOnlyArgument = "args x clear";
        public string ClearConsole = "clear";

           
        
        public string descriptionDelarationVarable { get; set; }
        public string descriptionCalculation { get; set; }
        public string descriptionHelp { get; set; }
        public string descriptionQuit { get; set; }

        public string descriptionShowAllArguments { get; set; }
        public string descriptionShowOnlyArgument { get; set; }
        public string descriptionRemoweAllArguments { get; set; }
        public string descriptionRemoveOnlyArgument { get; set; }
        public string descriptionClearConsole { get; set; }



        public void Show()
        {
            Console.WriteLine(descriptionDelarationVarable + " " + delarationVarable);
            Console.WriteLine(descriptionCalculation + " " + calculation);
            Console.WriteLine(descriptionHelp + " " + help);
            Console.WriteLine(descriptionQuit + " " + quit);
            Console.WriteLine(descriptionShowAllArguments + " " + ShowAllArguments);
            Console.WriteLine(descriptionShowOnlyArgument + " " + ShowOnlyArgument);
            Console.WriteLine(descriptionRemoweAllArguments + " " + RemoweAllArguments);
            Console.WriteLine(descriptionRemoveOnlyArgument + " " + RemoveOnlyArgument);
            Console.WriteLine(descriptionClearConsole + " " + ClearConsole);
        }
    }
}
