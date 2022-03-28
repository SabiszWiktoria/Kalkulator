using System;
using System.Collections.Generic;
using System.Text;

namespace kalkulatot
{
    public interface IOutput
    {
        public void Write(string output);
    }

   public class ConsoleOutput : IOutput
    {
        public void Write(string output)
        {
            Console.WriteLine(output);
        }

    }
}
