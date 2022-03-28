using kalkulatot;
using NUnit.Framework;
using System;

namespace Kalkulator.UnitTests
{
    class CalculationArgumentsTest
    {
      
        [Test]
        public void Create_New_Argument_Value()
        {
            //arrange
            var calculationArguments = new CalculationArguments();
            //act
            calculationArguments.Create("w", "w = 45");
            var result = calculationArguments.GetValue("w");
            //assert
            Assert.That(result == 45);
        }
       [Test]
        public void Remove_All_Arguments()
        {
            //arrange
            var calculationArguments = new CalculationArguments();
            //act
            calculationArguments.Create("w", "w = 45");
            calculationArguments.Create("y", "y = 45");
            calculationArguments.RemoveAll();
            var result = calculationArguments.GetAll();
            //assert
            Assert.IsEmpty( result);
        }
        [Test]
        public void Remove_Argument()
        {
            //arrange
            var calculationArguments = new CalculationArguments();
            //act
            calculationArguments.Create("w", "w = 45");
            calculationArguments.Create("y", "y = 45");
            calculationArguments.Remove("w");
            var result = calculationArguments.Get("y");
            //assert
            Assert.IsNotEmpty(result);
        }


    }
}

