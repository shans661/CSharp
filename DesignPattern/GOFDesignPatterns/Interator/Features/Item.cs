using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Features
{
    /// <summary>
    /// Model
    /// </summary>
    class Item
    {
        public string Name { get; private set; }

        public Item(string name)
        {
            Name = name;
        }
    }
}
