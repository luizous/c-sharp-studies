using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public class Budget
    {
        public double Value { get; private set; }

        public Budget(double value)
        {
            this.Value = value;
        }
    }
}
