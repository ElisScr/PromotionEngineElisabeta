using System;
using System.Collections.Generic;
using System.Text;

namespace PromotionEngine
{
    static class SKU
    {
        static Dictionary<char, int> Prices = new Dictionary<char, int>
        {
            ['A'] = 50,
            ['B'] = 30,
            ['C'] = 20,
            ['D'] = 15
        };
    }
}
