using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCards
{
    public abstract class DiscountCard
    {
        protected DiscountCard(string owner, int turnover)
        {
            this.Owner = owner;
            this.Turnover = turnover;
        }

        public string Owner { get; private set; }

        public int Turnover { get; private set; }

        public abstract double DiscountRate { get; protected set; }

        public double Discount(double purchaseValue)
        {
            var result = Math.Round(purchaseValue * (this.DiscountRate / 100), 2);
            return result;
        }
    }
}
