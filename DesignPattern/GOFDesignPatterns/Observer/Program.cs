using Observer.Investor;
using Observer.Stock;
using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Siemens m_SiemensStock = new Siemens("Siemens", 119);
            m_SiemensStock.AddInvestor(new Investors("Shiva"));
            m_SiemensStock.AddInvestor(new Investors("Shankara"));
            m_SiemensStock.AddInvestor(new Investors("Aish"));

            m_SiemensStock.StockValue = 120;
            m_SiemensStock.StockValue = 120;
            m_SiemensStock.StockValue = 113;

            Console.WriteLine("-----------------------------------");

            Console.ReadKey();
        }
    }
}
