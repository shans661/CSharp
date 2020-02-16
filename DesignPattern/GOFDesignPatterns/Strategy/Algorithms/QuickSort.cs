using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Algorithms
{
    /// <summary>
    /// Concrete sort
    /// </summary>
    class QuickSort : ISort
    {
        public void Sort(List<string> items)
        {
            items.Sort();
            Console.WriteLine("Quick sort started");
            foreach (var item in items)
            {
                Console.WriteLine($"Item : {item}");
            }
        }
    }
}
