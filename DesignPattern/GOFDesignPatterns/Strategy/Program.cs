using Strategy.Algorithms;
using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------");
            SortedList m_SortedList = new SortedList();
            m_SortedList.Add("Shiva");
            m_SortedList.Add("Shankara");
            m_SortedList.Add("Aish");
            m_SortedList.Add("Krithi");
            m_SortedList.Add("Raj");

            m_SortedList.Sort(new QuickSort());
            m_SortedList.Sort(new BubbleSort());
            m_SortedList.Sort(new MergeSort());

            Console.WriteLine("---------------------------");
            Console.ReadKey();
        }
    }
}
