using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsI
{
    public class ICMS : Tax
    {
        public double Calculate(Budget budget)
        {
            return budget.Value * 0.1;
        }
    }
}
