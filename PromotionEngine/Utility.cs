using System.Collections.Generic;
using System.Linq;

namespace PromotionEngine
{
  static class Utility
    {
        public static List<dynamic> GetDynamicList(IEnumerable<char> skus)
        {
            return skus.GroupBy(item => item)
                   .Select(item => new
                   {
                       Name = item.Key,
                       Count = item.Count()
                   }).ToList<dynamic>();
        }

        public static int GetCountOfItem(List<dynamic> itemCount, char item)
        {
            return itemCount.FirstOrDefault(c => c.Name == item)?.Count ?? 0;
        }
    }
}
