using System;

namespace Strategy
{
    class Program
    {
        // Design Pattern: Strategy
        static void Main(string[] args)
        {
            Tax iss = new ISS();
            Tax icms = new ICMS();
            Tax iccc = new ICCC();

            Budget budget = new Budget(3500.0);

            TaxCalculator calculator = new TaxCalculator();

            calculator.PerformCalculation(budget, iccc);

            Console.ReadKey();
        }
    }
}
