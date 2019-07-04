using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public static class ProductListExtentionMethods
    {
        public static void Apply(this IList<Product> products, IDiscountStrategy discountStrategy)
        {
            foreach (var p in products)
            {
                p.Price.SetDiscountStatergy(discountStrategy);
            }
        }
    }
}
