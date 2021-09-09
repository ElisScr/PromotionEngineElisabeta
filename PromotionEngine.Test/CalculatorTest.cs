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

        [TestMethod]
        public void CalculatorScenario2()
        {
            var skus = new List<char> { 'A', 'A', 'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C' };
            int result = calc.GetTotalPrice(skus);

            Assert.AreEqual(370, result);
        }

        [TestMethod]
        public void CalculatorScenario3()
        {
            var skus = new List<char> {'A', 'A', 'A', 'B', 'B', 'B', 'B', 'B', 'C', 'D' };
            int result = calc.GetTotalPrice(skus);

            Assert.AreEqual(280, result);
        }

    }
}
