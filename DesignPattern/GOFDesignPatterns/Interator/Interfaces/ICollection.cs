using Interator.Features;
using System;
using System.Collections.Generic;
using System.Text;

namespace Interator.Interfaces
{
    /// <summary>
    /// Interface for the collection
    /// </summary>
    interface ICollection
    {
        Iterator CreateIterator();
    }
}
