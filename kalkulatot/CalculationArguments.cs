using kalkulatot;
using org.mariuszgromada.math.mxparser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalkulatot
{
   
}

public class CalculationArguments
{
 
    private Dictionary<string, Argument> _arguments = new Dictionary<string, Argument>();
   

    public Dictionary<string,Argument> GetArgumetn()
    {
        return _arguments;
    }
    public double GetValue(string key)
    {
        var argument = _arguments[key];
        return argument.getArgumentValue();
    }

    public void Create(string name, string value)
    {
        _arguments[name] = new Argument(value);
        
    }
    public string Get(string name)
    {
        if (!_arguments.ContainsKey(name))
        {
            throw new KeyNotFoundException("Could not find key: " + name);
        }
        string displayValue = name + " = " + _arguments[name].getArgumentValue();
        return displayValue;
      
    }
    public List<Argument> GetAll()
    {
        List<Argument> e = _arguments.Values.ToList();
        return e;
       
    }
    public void RemoveAll()
    {
        _arguments.Clear();       
    }
    public void Remove(string key)
    {
        _arguments.Remove(key);
    }

    public Argument[] ToArray()
    {
        return _arguments.Values.ToArray();
    }
}

