using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class Promotion2B : IPromotion
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

            int numberOfPromotions2B = count.Find(a => a.Name == 'B').Count / 2;
            List<char> temp = Enumerable.Repeat('B', numberOfPromotions2B * 2).ToList();
            PromotionResult result = new PromotionResult
            {
                PromotionPrice = numberOfPromotions2B * 45,
                RemainingSkus = skus.Where(t => !temp.Remove(t)).ToList()
            };
            return result;
        }
    }
}
