﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ICCC : Tax
    {
        public double Calculate(Budget budget)
        {
            if (budget.Value < 1000.0)
            {
                return budget.Value * 0.05;
            }
            else if (budget.Value >= 1000.0 || budget.Value <= 3000.0)
            {
                return budget.Value * 0.07;
            }
            else
            {
                return budget.Value * 0.08 + 30.0;
            }
        }
    }
}
