using System;
using System.Collections.Generic;
using System.Text;

namespace Composite.AbstarctClass
{
    /// <summary>
    /// Component Tree node
    /// </summary>
    abstract class DrawingElement
    {
        public string m_Name;

        public DrawingElement(string name)
        {
            m_Name = name;
        }
        public abstract void Add(DrawingElement element);
        public abstract void Remove(DrawingElement element);
        public abstract void Display();
    }
}
