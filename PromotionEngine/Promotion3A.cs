using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
    public class Promotion3A : IPromotion
    {
        public PromotionResult Apply(IEnumerable<char> skus)
        {
            var count = skus.GroupBy(item => item)
                      .Select(item => new
                      {
                          Name = item.Key,
                          Count = item.Count()
                      })                      
                      .ToList();

            int numberOfPromotions3A = count.Find(a => a.Name == 'A').Count / 3;

            PromotionResult result = new PromotionResult

            {
                PromotionPrice = numberOfPromotions3A * 130,
                RemainingSkus = skus.OrderBy(x=>x).Skip(numberOfPromotions3A * 3).ToList()
            };

            return result;
        }
    }
}