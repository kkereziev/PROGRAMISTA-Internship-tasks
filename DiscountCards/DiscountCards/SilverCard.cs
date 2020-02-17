using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCards
{
    public class SilverCard : DiscountCard
    {
        private double discount;
        
        public SilverCard(string owner, int turnover) 
            : base(owner, turnover)
        {
            this.DiscountRate = 2.0;
        }

        public override double DiscountRate
        {
            get => this.discount;
            protected set
            {
                if (this.Turnover > 300)
                {
                    value = 3.5;
                }
                this.discount = value;
            }
        }
    }
}
