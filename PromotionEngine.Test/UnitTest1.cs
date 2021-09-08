using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Promotion1Test1()
        {
            IEnumerable<char> skus = new List<char> { 'A', 'A', 'A' };

            IPromotion prom = new Promotion3A();
            PromotionResult result = prom.Apply( skus );

            Assert.AreEqual(new List<char>(), result.RemainingSkus);
            Assert.AreEqual(130, result.PromotionPrice);
        }
    }
}
