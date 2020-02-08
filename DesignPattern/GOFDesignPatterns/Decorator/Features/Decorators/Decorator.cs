using Decorator.AbstractClass;
using System;
using System.Collections.Generic;
using System.Text;

namespace Decorator.Features.Decorators
{
    /// <summary>
    /// Decorator created
    /// </summary>
    class Decorator : LibraryItem
    {
        protected LibraryItem LibraryItem;

        public Decorator(LibraryItem libraryItem)
        {
            LibraryItem = libraryItem;
        }
        public override void Display()
        {
            LibraryItem.Display();
        }
    }
}
