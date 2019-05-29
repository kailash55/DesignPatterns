using System;
using System.Collections.Generic;
using System.Text;

namespace ASPPatterns.Chap3.Layered.Model
{
    public class Price
    {
        private IDiscountStrategy _discountStrategy = new NullDiscountStratergy();

        private decimal _rrp;
        private decimal _sellingPrice;

        public Price(decimal RRP, decimal SellingPrice)
        {
            _rrp = RRP;
            _sellingPrice = SellingPrice;
        }

        public void SetDiscountStatergy(IDiscountStrategy discountStrategy)
        {
            _discountStrategy = discountStrategy;
        }

        public decimal SellingPrice
        {
            get
            {
                return _discountStrategy.ApplyExtraDiscountsTo(_sellingPrice);
            }
        }

        public decimal RRP
        {
            get { return _rrp; }
        }
    }
}
