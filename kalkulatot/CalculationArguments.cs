using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalkulatot
{
 public   class CalculationArguments
    {
         public Dictionary<string, Argument> Arguments = new Dictionary<string, Argument>();
        public double GetValue(string key)
        {
            var argument = Arguments[key];
            return argument.getArgumentValue();
        }

        public void Create(string name, string value)
        {
            if (Arguments.ContainsKey(name))
            {
                Arguments.Remove(name);
                Arguments.Add(name, new Argument(value));
            }
            else
            {
                Arguments.Add(name, new Argument(value));
            }
           
           

        }
        public void ShowArgument(string name)
        {
            Console.WriteLine(name + " = " + Arguments[name].getArgumentValue());
        }
        public void ShowAllArguments()
        {
            List<Argument> e = Arguments.Values.ToList();

            for (int i = 0; i < e.Count; i++)
            {
                Console.WriteLine(e[i].getArgumentValue());
            }
        }
        public void RemoveAllvalues()
        {
            foreach (var item in Arguments)
            {
                Arguments.Remove(item.Key);
            }
        }
        public void RemoveOnlyValue(string key)
        {
            Arguments.Remove(key);
        }
    }
}
