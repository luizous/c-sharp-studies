using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsI
{
    public class TaxCalculator
    {
        public void PerformCalculation(Budget budget, Tax tax)
        {
            double a = tax.Calculate(budget);
            Console.WriteLine(a);
        }
    }
}
