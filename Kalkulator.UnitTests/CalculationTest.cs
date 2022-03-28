using kalkulatot;
using NUnit.Framework;
using System;

namespace Kalkulator.UnitTests
{
    class CalculationTest
    {
       
        

        
        
        [Test]
        public void Equation_test()
        {

            //arrange
            CalculationArguments _calculationArguments = new CalculationArguments();
            _calculationArguments.Create("w", "w = 45");
            _calculationArguments.Create("y", "y = 45");
            var calculation = new Calculation();
            //act
            var result = calculation.Equation("= w + y",_calculationArguments);

            //assert
            Assert.AreEqual(90,result );
        }
    }
}
