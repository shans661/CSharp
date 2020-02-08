using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.AbstractClass
{
    /// <summary>
    /// Component abstract class
    /// </summary>
    abstract class LibraryItem
    {
        public int NumberOfCopies { get; set; }

        public abstract void Display();

    }
}
