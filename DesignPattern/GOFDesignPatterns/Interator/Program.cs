using Interator.Features;
using System;

namespace Interator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Collection collection = new Collection();
            collection.Items.Add(new Item("Item-A"));
            collection.Items.Add(new Item("Item-B"));
            collection.Items.Add(new Item("Item-C"));
            collection.Items.Add(new Item("Item-D"));
            collection.Items.Add(new Item("Item-E"));
            collection.Items.Add(new Item("Item-F"));

            Iterator iterator = collection.CreateIterator();
            iterator.FirstItem();
            iterator.NextItem();
            iterator.CurrentItem();
            iterator.IsDone();
            iterator.NextItem();
            iterator.LastItem();
            iterator.CurrentItem();
            iterator.IsDone();
            Console.WriteLine("----------------------------");
            Console.ReadKey();
        }
    }
}
