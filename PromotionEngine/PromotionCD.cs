using System;
using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class PromotionCD : IPromotion
    {
        private Utility utility = new Utility();
        private const int promotionValue = 30;
        public PromotionResult Apply(IEnumerable<char> skus)
        {           
            var listOfItemCount = utility.GetDynamicList(skus);           
            int numberOfPromotionsCD =Math.Min(utility.GetCountOfItem(listOfItemCount, 'C'),
                utility.GetCountOfItem(listOfItemCount, 'D'));
            List<char> temp = Enumerable.Repeat('D', numberOfPromotionsCD)
                .Concat(Enumerable.Repeat('C', numberOfPromotionsCD)).ToList();
            
            return new PromotionResult
            {
                PromotionPrice = numberOfPromotionsCD * promotionValue,
                RemainingSkus = skus.Where(t => !temp.Remove(t)).ToList()
            };
        }
    }
}
