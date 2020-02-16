using System;
using System.Collections.Generic;
using System.Text;

namespace Strategy.Interfaces
{
    /// <summary>
    /// Interface for sorting
    /// </summary>
    interface ISort
    {
        void Sort(List<string> items);
    }
}
