using Composite.AbstarctClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.Features
{
    /// <summary>
    /// Composite element
    /// </summary>
     class CompositeElement : DrawingElement
    {
        List<DrawingElement> elements = new List<DrawingElement>();

        public CompositeElement(string name) : base(name)
        {

        }
        public override void Add(DrawingElement element)
        {
            elements.Add(element);
        }

        public override void Display()
        {
            Console.WriteLine($"Element group is {m_Name}");
            foreach (var item in elements)
            {
                Console.WriteLine($"Element is {item.m_Name}");
            }
        }

        public override void Remove(DrawingElement element)
        {
            elements.Remove(element);
        }
    }
}
