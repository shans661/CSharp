using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy
{
    /// <summary>
    /// Sort the items
    /// </summary>
    class SortedList
    {
        List<string> m_Items = new List<string>();

        public void Add(string item)
        {
            m_Items.Add(item);
            Console.WriteLine($"Item {item} added");
        }

        public void Sort(ISort sortAlgo)
        {
            Console.WriteLine($"{sortAlgo.GetType().Name} initiatd");
            sortAlgo.Sort(m_Items);
        }
    }
}
