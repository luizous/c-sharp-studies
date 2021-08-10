using System;

namespace DesignPatternsI
{
    class Program
    {
        // Design Pattern: Strategy
        static void Main(string[] args)
        {
            Tax iss = new ISS();
            Tax icms = new ICMS();

            Budget budget = new Budget(500.0);

            TaxCalculator calculator = new TaxCalculator();

            calculator.PerformCalculation(budget, icms);

            Console.ReadKey();
        }
    }
}
