using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class ICMS : Tax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
