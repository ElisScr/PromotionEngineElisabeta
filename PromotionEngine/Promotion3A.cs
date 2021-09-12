using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class Promotion3A : IPromotion
    {
        private Utility utility = new Utility();
        private const int promotionValue = 130;
        private const int elementMulti = 3;
        public PromotionResult Apply(IEnumerable<char> skus)
        {
            var listOfItemCount = utility.GetDynamicList(skus);
            int numberOfPromotions3A = utility.GetCountOfItem(listOfItemCount, 'A') / elementMulti;
            
            return new PromotionResult
            {
                PromotionPrice = numberOfPromotions3A * promotionValue,
                RemainingSkus = skus.OrderBy(x=>x).Skip(numberOfPromotions3A * elementMulti).ToList()
            };
        }
    }
}