﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLID2OCP.WITH_ACP.Discounts
{
    public class PremiumDiscountStrategy : IDiscountStrategy
    {
        public double ApplyDiscount(Product product)
        {
            return product.Price * 0.3; // 30% desconto
        }
    }
}