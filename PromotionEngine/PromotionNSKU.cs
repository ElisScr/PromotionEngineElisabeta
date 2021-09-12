using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    /// <summary>
    /// Promotion for buying 'n' items of a SKU for a fixed price
    /// </summary>
    public class PromotionNSKU : IPromotion
    {
        private char SKU { get; set; }
        private int MultiplicationNUmber { get; set; }
        private int PromotionValue { get; set; }

        public PromotionNSKU(char item, int n, int value)
        {
            SKU = item;
            MultiplicationNUmber = n;
            PromotionValue = value;
        }
        public PromotionResult Apply(IEnumerable<char> skus)
        {
            var listOfItemCount = Utility.GetDynamicList(skus);
            int numberOfPromotions = Utility.GetCountOfItem(listOfItemCount, SKU) / MultiplicationNUmber;
            List<char> temp = Enumerable.Repeat(SKU, numberOfPromotions * MultiplicationNUmber).ToList();

            return new PromotionResult
            {
                PromotionPrice = numberOfPromotions * PromotionValue,
                RemainingSkus = skus.Where(t => !temp.Remove(t)).ToList()
            };

        }
    }
}
