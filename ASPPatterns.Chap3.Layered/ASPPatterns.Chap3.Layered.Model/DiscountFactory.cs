using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public static class DiscountFactory
    {
        public static IDiscountStrategy GetDiscountStatergyFor(CustomerType customerType)
        {
            switch (customerType)
            {
                case CustomerType.Trade:
                    return new NullDiscountStratergy();
                default:    
                    return new TradeDiscountStratergy();
                
            }
        }
    }
}
