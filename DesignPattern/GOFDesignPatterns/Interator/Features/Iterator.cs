using Interator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Features
{
    /// <summary>
    /// Concrete iterator
    /// </summary>
    class Iterator : IIterator
    {
        Collection Collection;
        int step = 1;
        int curr = 0;
        public Iterator(Collection collection)
        {
            Collection = collection;
        }
        public Item CurrentItem()
        {
            return Collection.Items[curr];
        }

        public Item FirstItem()
        {
            curr = 0;
            Console.WriteLine($"First item is {Collection.Items[curr].Name}");
            return Collection.Items[curr];
        }

        public bool IsDone()
        {
            if(curr >= Collection.Items.Count)
            {
                Console.WriteLine("Traversing is done");
                return true;
            }
            Console.WriteLine("Traversing is not done");
            return false;
        }

        public Item LastItem()
        {
            curr = Collection.Items.Count - 1;
            Console.WriteLine($"Last item is {Collection.Items[curr].Name}");
            return Collection.Items[curr];
        }

        public Item NextItem()
        {
            curr += step;
            if (!IsDone())
            {
                Console.WriteLine($"Next item is {Collection.Items[curr].Name}");
                return Collection.Items[curr];
            }
            return new Item("");
        }
    }
}
