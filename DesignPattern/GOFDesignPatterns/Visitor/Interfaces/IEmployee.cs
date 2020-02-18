using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
    /// <summary>
    /// Employee interface
    /// </summary>
    interface IEmployee
    {
        void Accept(IVisitor visitor);
    }
}
