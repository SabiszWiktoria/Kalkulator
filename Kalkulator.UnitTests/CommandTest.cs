using kalkulatot;
using NUnit.Framework;
using System;
namespace Kalkulator.UnitTests
{
    class CommandTest
    {
        [Test]
        public void Equation_test()
        {
            //arrange
            var command = new Command();
            //act
           var result= command.Equation("calc 45 + 45");

            //assert
            Assert.AreEqual(result, 90);
        }
       
        
    }
}
