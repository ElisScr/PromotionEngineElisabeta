using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    /// <summary>
    /// Promotion for buying SKU 1 & SKU 2 for a fixed price 
    /// </summary>
    public class PromotionSKU1SKU2 : IPromotion
    {
        private char SKU1 { get; set; }
        private char SKU2 { get; set; }
        private int PromotionValue { get; set; }
        public PromotionSKU1SKU2(char item1, char item2, int promotionValue)
        {
            SKU1 = item1;
            SKU2 = item2;
            PromotionValue = promotionValue;
        }
        public PromotionResult Apply(IEnumerable<char> skus)
        {           
            var listOfItemCount = Utility.GetDynamicList(skus);           
            int numberOfPromotions =Math.Min(Utility.GetCountOfItem(listOfItemCount, SKU1),
                Utility.GetCountOfItem(listOfItemCount, SKU2));
            List<char> temp = Enumerable.Repeat(SKU1, numberOfPromotions)
                .Concat(Enumerable.Repeat(SKU2, numberOfPromotions)).ToList();
            
            return new PromotionResult
            {
                PromotionPrice = numberOfPromotions * PromotionValue,
                RemainingSkus = skus.Where(t => !temp.Remove(t)).ToList()
            };
        }
    }
}
