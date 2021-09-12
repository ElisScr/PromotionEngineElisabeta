using System.Collections.Generic;

namespace PromotionEngine
{
    /// <summary>
    /// Interface containing the methods for each promotion
    /// </summary>
    public interface IPromotion
    {
        /// <summary>
        /// Method for applying the promotion
        /// </summary>
        /// <param name="skus">The list of single character SKU ids (A, B, C.	) 
        /// over which the promotion will need to be applied</param>
        /// <returns>An object containing the price of SKUs that the promotion applies to 
        /// and the rest of the products that the promotion didn't apply to</returns>
        PromotionResult Apply(IEnumerable<char> skus);
    }
}