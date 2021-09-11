using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PromotionEngine
{
    public class PromotionCD : IPromotion
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
            
            int numberOfPromotionsCD =Math.Min(count.FirstOrDefault(c => c.Name == 'C')?.Count ?? 0,
                count.FirstOrDefault(c => c.Name == 'D')?.Count ?? 0);
            List<char> temp = Enumerable.Repeat('D', numberOfPromotionsCD)
                .Concat(Enumerable.Repeat('C', numberOfPromotionsCD)).ToList();
            
            PromotionResult result = new PromotionResult
            {
                PromotionPrice = numberOfPromotionsCD * 30,
                RemainingSkus = skus.Where(t => !temp.Remove(t)).ToList()
            };
            return result;
        }
    }
}
