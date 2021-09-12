using System.Collections.Generic;

namespace PromotionEngine
{
    /// <summary>
    /// Class used to apply all the active promotions
    /// </summary>
    public class Calculator
    {
        IList<IPromotion> promotions = new List<IPromotion> { new PromotionNSKU('A', 3, 130), 
                                                              new PromotionNSKU('B', 2, 45), 
                                                              new PromotionSKU1SKU2('C', 'D', 30) };
       /// <summary>
       /// Calculates the total price for a list of SKUs, applying all the active promotions
       /// </summary>
       /// <param name="skus">Input SKUs</param>
       /// <returns>Total price</returns>
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
