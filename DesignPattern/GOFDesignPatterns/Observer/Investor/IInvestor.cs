using Observer.Stock;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Investor
{
    /// <summary>
    /// Interface for interface
    /// </summary>
    interface IInvestor
    {
        void Update(Stocks stock);
    }
}
