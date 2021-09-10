using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Test
{
    [TestClass]
    public class PromotionCDTest
    {

        [TestMethod]
        public void Promotion3Test1()
        {
            IEnumerable<char> skus = new List<char> { 'C', 'D' };

            IPromotion prom = new PromotionCD();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char>(), result.RemainingSkus);
            Assert.AreEqual(30, result.PromotionPrice);
        }
    }
}
