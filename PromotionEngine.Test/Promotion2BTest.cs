using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace PromotionEngine.Test
{
    [TestClass]
   public class Promotion2BTest
    {
        [TestMethod]
        public void Promotion2Test1()
        {
            IEnumerable<char> skus = new List<char> { 'B', 'B'};

            IPromotion prom = new PromotionNSKU('B', 2, 45);
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char>(), result.RemainingSkus);
            Assert.AreEqual(45, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion2Test2()
        {
            IEnumerable<char> skus = new List<char> { 'B', 'B','B','B' };

            IPromotion prom = new PromotionNSKU('B', 2, 45);
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char>(), result.RemainingSkus);
            Assert.AreEqual(90, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion2Test3()
        {
            IEnumerable<char> skus = new List<char> { 'A', 'A', 'A', 'B', 'C', 'C' };

            IPromotion prom = new PromotionNSKU('B', 2, 45);
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'A', 'A', 'A', 'B', 'C', 'C' }, result.RemainingSkus);
            Assert.AreEqual(0, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion2Test4()
        {
            IEnumerable<char> skus = new List<char> { 'B', 'B','B','B','B' };

            IPromotion prom = new PromotionNSKU('B', 2, 45);
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'B' }, result.RemainingSkus);
            Assert.AreEqual(90, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion2Test5()
        {
            IEnumerable<char> skus = new List<char> { 'B', 'A', 'C', 'B', 'A' };

            IPromotion prom = new PromotionNSKU('B', 2, 45);
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'A', 'C','A' }, result.RemainingSkus);
            Assert.AreEqual(45, result.PromotionPrice);
        }
    }
}
