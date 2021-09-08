using System.Collections.Generic;

namespace PromotionEngine
{
    public interface IPromotion
    {
        PromotionResult Apply(IEnumerable<char> skus);
    }
}