using System.Collections.Generic;

namespace PromotionEngine
{
   public static class SKU
    {
      public  static Dictionary<char, int> Prices = new Dictionary<char, int>
        {
            ['A'] = 50,
            ['B'] = 30,
            ['C'] = 20,
            ['D'] = 15
        };
    }
}
