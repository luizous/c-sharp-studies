﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    public interface Tax
    {
        double Calculate(Budget budget);
    }
}
