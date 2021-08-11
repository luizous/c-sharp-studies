using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ISS : Tax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.06;
        }
    }
}
