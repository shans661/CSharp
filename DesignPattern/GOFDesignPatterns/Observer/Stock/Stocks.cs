using Observer.Investor;
using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Stock
{
    /// <summary>
    /// Abstract class for the stock
    /// </summary>
    class Stocks
    {
        public Stocks(string name, int value)
        {
            Console.WriteLine($"Stock {name} with initial value is created {value}");
            StockName = name;
            StockValue = value;
        }
        Dictionary<string, IInvestor> m_Investors = new Dictionary<string, IInvestor>();
        private int m_StockValue;

        public string StockName { get; set; }
        public int StockValue
        {
            get { return m_StockValue; }
            set
            {
                if (StockValue != value)
                {
                    Console.WriteLine("Stock value is changed");
                    m_StockValue = value;
                    Notify();
                }
                else
                {
                    Console.WriteLine("Stock value is same");
                }
            }
        }

        public void AddInvestor(Investors investor)
        {
            Console.WriteLine($"Investor {investor.Name} added ");
            m_Investors.Add(investor.Name,investor);
        }

        public void RemoveInvestor(string name)
        {
            if(m_Investors.ContainsKey(name))
            {
                Console.WriteLine($"Investor {name} is removed from the stock");
                m_Investors.Remove(name);
            }
            else
            {
                Console.WriteLine($"Investor {name} is not exists in the stock");
            }
        }

        public void Notify()
        {
            Console.WriteLine("Stock value change is notified to the user");
            foreach(var item in m_Investors)
            {
                item.Value.Update(this);
            }
        }
    }
}
