﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace SalesWebMvc2.Models.Enums
{
    public enum SaleStatus : int
    {
        Pending = 0,
        Billed = 1,
        Canceled = 2
    }
}
