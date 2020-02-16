using System;
using System.Collections.Generic;
using System.Text;
using Observer.Stock;

namespace Observer.Investor
{
    /// <summary>
    /// Concrete investor
    /// </summary>
    class Investors : IInvestor
    {
        public string Name { get; set; }

        public Stocks Stock { get; set; }

        public Investors(string name)
        {
            Name = name;
        }
        public void Update(Stocks stock)
        {
            Stock = stock;
            Console.WriteLine($"Investor {Name} is stock {Stock.StockName} value is updated to {Stock.StockValue}");
        }
    }
}
