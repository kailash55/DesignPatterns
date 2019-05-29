using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class TradeDiscountStratergy : IDiscountStrategy
    {
        public decimal ApplyExtraDiscountsTo(decimal OriginalSalesPrice)
        {
            decimal price = OriginalSalesPrice;
            price = price * 0.95M;
            return price;
        }
    }
}
