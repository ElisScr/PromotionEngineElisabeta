using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Test
{
    [TestClass]
    public class CalculatorTest
    {
        Calculator calc = new Calculator();

        [TestMethod]
        public void CalculatorScenario1()
        {
            var skus = new List<char> { 'A', 'B', 'C' };
            int result = calc.GetTotalPrice(skus);

            Assert.AreEqual(100, result);
        }



    }
}
