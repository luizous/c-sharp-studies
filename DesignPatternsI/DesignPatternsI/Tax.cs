using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsI
{
    public interface Tax
    {
        double Calculate(Budget budget);
    }
}
