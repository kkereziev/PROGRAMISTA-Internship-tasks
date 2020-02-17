using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCards
{
    public class GoldCard : DiscountCard
    {
        private double discount;
        
        public GoldCard(string owner, int turnover) 
            : base(owner, turnover)
        {
            this.DiscountRate = 2.0;
        }

        public override double DiscountRate
        {
            get => this.discount;
            protected set
            {
                if (this.Turnover > 100)
                {
                    value += this.Turnover / 100;
                    if (value > 10)
                    {
                        value = 10.0;
                    }
                }
                this.discount = value;
            }
        }
    }
}
