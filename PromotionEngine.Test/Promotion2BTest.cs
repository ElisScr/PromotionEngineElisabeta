using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine.Test
{
    [TestClass]
   public class Promotion2BTest
    {
        [TestMethod]
        public void Promotion2Test1()
        {
            IEnumerable<char> skus = new List<char> { 'B', 'B'};

            IPromotion prom = new Promotion2B();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char>(), result.RemainingSkus);
            Assert.AreEqual(45, result.PromotionPrice);
        }
    }
}
