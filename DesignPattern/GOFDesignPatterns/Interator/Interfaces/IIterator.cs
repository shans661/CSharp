using Interator.Features;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Interfaces
{
    /// <summary>
    /// Iterface for the iterator
    /// </summary>
    interface IIterator
    {
        Item CurrentItem();
        Item NextItem();
        Item FirstItem();
        Item LastItem();
        bool IsDone();
    }
}
