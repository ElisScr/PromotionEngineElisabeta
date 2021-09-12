using System.Collections.Generic;

namespace PromotionEngine
{
    public class Calculator
    {
        IList<IPromotion> promotions = new List<IPromotion> { new PromotionNSKU('A', 3, 130), 
                                                              new PromotionNSKU('B', 2, 45), 
                                                              new PromotionSKU1SKU2('C', 'D', 30) };
        public int GetTotalPrice(List<char> skus)
        {
            int total = 0;

            foreach (var p in promotions)
            {              
                PromotionResult promotionResult = p.Apply(skus);
                total += promotionResult.PromotionPrice;
                skus = promotionResult.RemainingSkus;
            }
            foreach (var item in skus)
            {
                total += SKU.Prices.GetValueOrDefault(item);
            }            
            return total;
        }
    }
}
