using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class Promotion2B : IPromotion
    {
        private Utility utility = new Utility();
        private const int promotionValue = 45;
        private const int elementMulti = 2;
        public PromotionResult Apply(IEnumerable<char> skus)
        {
            var listOfItemCount = utility.GetDynamicList(skus);
            int numberOfPromotions2B = utility.GetCountOfItem(listOfItemCount, 'B') / elementMulti;
            List<char> temp = Enumerable.Repeat('B', numberOfPromotions2B * elementMulti).ToList();
            
            return new PromotionResult
            {
                PromotionPrice = numberOfPromotions2B * promotionValue,
                RemainingSkus = skus.Where(t => !temp.Remove(t)).ToList()
            };
        }
    }
}
