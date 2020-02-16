using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock
{
    /// <summary>
    /// Concrete stock - Siemens
    /// </summary>
    class Siemens : Stocks
    {
        public Siemens(string name, int value) : base(name, value)
        {
        }
    }
}
