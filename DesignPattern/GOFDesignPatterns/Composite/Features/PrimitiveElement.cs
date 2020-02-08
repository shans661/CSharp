using Composite.AbstarctClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Features
{
    /// <summary>
    /// Leaf node
    /// </summary>
    class PrimitiveElement : DrawingElement
    {
        public PrimitiveElement(string name): base(name)
        {

        }
        public override void Add(DrawingElement element)
        {
            Console.WriteLine("Cannot add to primitive element");
        }

        public override void Display()
        {
            Console.WriteLine($"Element is {m_Name}");
        }

        public override void Remove(DrawingElement element)
        {
            Console.WriteLine("Cannot remove item from primitive element");
        }
    }
}
