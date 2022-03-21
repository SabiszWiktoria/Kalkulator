using kalkulatot;
using NUnit.Framework;
using System;
namespace Kalkulator.UnitTests
    
{
    class DictionaryKeysTest
    {
        [Test]
        public void Create_New_Argument_Value()
        {
            //arrange
            var calculationArguments = new CalculationArguments();
            //act
             calculationArguments.Create("w","w = 45");
            var result = calculationArguments.GetValue("w");
            //assert
            Assert.That(result == 45);
        }

        [Test]
        public void Create_New_Argument_Name()
        {
            //arrange
            var calculationArguments = new CalculationArguments();
            //act
            calculationArguments.Create("w", "w = 45");
            var result = calculationArguments.Arguments["w"].getArgumentName();
            //assert
            Assert.That(result == "w");
        }
    }
}
