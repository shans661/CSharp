using Strategy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Algorithms
{
    /// <summary>
    /// Concrete sort
    /// </summary>
    class MergeSort : ISort
    {
        public void Sort(List<string> items)
        {
            items.Sort();
            Console.WriteLine("Merge sort started");
            foreach (var item in items)
            {
                Console.WriteLine($"Item : {item}");
            }
        }
    }
}
