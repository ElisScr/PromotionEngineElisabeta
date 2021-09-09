using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    [TestClass]
    public class PromotionTest
    {
        [TestMethod]
        public void Promotion1Test1()
        {
            IEnumerable<char> skus = new List<char> { 'A', 'A', 'A' };

            IPromotion prom = new Promotion3A();
            PromotionResult result = prom.Apply( skus );

            CollectionAssert.AreEquivalent(new List<char>(), result.RemainingSkus);
            Assert.AreEqual(130, result.PromotionPrice);
        }

        [TestMethod]
        public void Promotion1Test2()
        {
            IEnumerable<char> skus = new List<char> { 'A', 'A', 'A', 'B', 'C', 'C' };

            IPromotion prom = new Promotion3A();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'B', 'C', 'C' }, result.RemainingSkus);
            Assert.AreEqual(130, result.PromotionPrice);
        }

        [TestMethod]
        public void Promotion1Test3()
        {
            IEnumerable<char> skus = new List<char> { 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'A', 'B', 'C', 'C' };

            IPromotion prom = new Promotion3A();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'A', 'A', 'B', 'C', 'C' }, result.RemainingSkus);
            Assert.AreEqual(260, result.PromotionPrice);
        }

        [TestMethod]
        public void Promotion1Test4()
        {
            IEnumerable<char> skus = new List<char> {  'A', 'B', 'C', 'C' };

            IPromotion prom = new Promotion3A();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> {  'A', 'B', 'C', 'C' }, result.RemainingSkus);
            Assert.AreEqual(0, result.PromotionPrice);
        }

        [TestMethod]
        public void Promotion1Test5()
        {
            IEnumerable<char> skus = new List<char> { 'B', 'A', 'C', 'A', 'A' };

            IPromotion prom = new Promotion3A();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'C', 'B' }, result.RemainingSkus);
            Assert.AreEqual(130, result.PromotionPrice);
        }
    }
}
