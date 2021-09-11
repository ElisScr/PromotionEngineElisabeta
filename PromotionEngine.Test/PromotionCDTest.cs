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
        [TestMethod]
        public void Promotion3Test2()
        {
            IEnumerable<char> skus = new List<char> { 'C', 'D','C','D' };

            IPromotion prom = new PromotionCD();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char>(), result.RemainingSkus);
            Assert.AreEqual(60, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion3Test3()
        {
            IEnumerable<char> skus = new List<char> { 'C', 'C', 'D', 'C', 'D' };

            IPromotion prom = new PromotionCD();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'C'}, result.RemainingSkus);
            Assert.AreEqual(60, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion3Test4()
        {
            IEnumerable<char> skus = new List<char> { 'C', 'D','A', 'B' };

            IPromotion prom = new PromotionCD();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'A', 'B'}, result.RemainingSkus);
            Assert.AreEqual(30, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion3Test5()
        {
            IEnumerable<char> skus = new List<char> { 'A', 'B' };

            IPromotion prom = new PromotionCD();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'A', 'B' }, result.RemainingSkus);
            Assert.AreEqual(0, result.PromotionPrice);
        }
        [TestMethod]
        public void Promotion3Test6()
        {
            IEnumerable<char> skus = new List<char> { 'A', 'B', 'C' };

            IPromotion prom = new PromotionCD();
            PromotionResult result = prom.Apply(skus);

            CollectionAssert.AreEquivalent(new List<char> { 'A', 'B' , 'C'}, result.RemainingSkus);
            Assert.AreEqual(0, result.PromotionPrice);
        }
    }
}
