using Microsoft.VisualStudio.TestTools.UnitTesting;
using WindowsFormsApplication1;
using System.Collections.Generic;

namespace CalculatorTest
{

    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            Calculator calc = new Calculator("");
            string[] expr = new string[] { "3", "*", "4"};
            CalculatorMessage message = calc.evalulate(new List<string>(expr));
            Assert.Equals(message.getBody(), "12");
        }
    }
}
