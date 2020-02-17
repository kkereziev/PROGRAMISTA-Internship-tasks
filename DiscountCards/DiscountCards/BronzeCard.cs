﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DiscountCards
{
    class BronzeCard : DiscountCard
    {
        private double discount;
       
        public BronzeCard(string owner, int turnover) 
            : base(owner, turnover)
        {
            this.DiscountRate = 0.0;
        }

        public override double DiscountRate
        {
            get => this.discount;
            protected set
            { 
                if (this.Turnover>=100 && this.Turnover<=300)
                {
                    value = 1.0;
                }
                else if (this.Turnover>300)
                {
                    value = 2.5;
                }
                this.discount = value;
            }
        }
    }
}
