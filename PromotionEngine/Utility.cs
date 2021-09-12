using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
   class Utility
    {
        public List<dynamic> GetDynamicList(IEnumerable<char> skus)
        {
            return skus.GroupBy(item => item)
                   .Select(item => new
                   {
                       Name = item.Key,
                       Count = item.Count()
                   }).ToList<dynamic>();
        }

        public int GetCountOfItem(List<dynamic> itemCount, char item)
        {
            return itemCount.FirstOrDefault(c => c.Name == item)?.Count ?? 0;
        }
    }
}
