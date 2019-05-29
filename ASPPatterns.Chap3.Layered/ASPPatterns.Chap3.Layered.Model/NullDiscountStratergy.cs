using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class NullDiscountStratergy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal OriginalSalesPrice)
        {
            return OriginalSalesPrice;
        }
    }
}
