using Interator.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Features
{
    /// <summary>
    /// Concrete collection
    /// </summary>
    class Collection : ICollection
    {
        public List<Item> Items { get; set; }

        public Collection()
        {
            Items = new List<Item>();
        }
        public Iterator CreateIterator()
        {
            Console.WriteLine("Iterator is created");
            return new Iterator(this);
        }
    }
}
