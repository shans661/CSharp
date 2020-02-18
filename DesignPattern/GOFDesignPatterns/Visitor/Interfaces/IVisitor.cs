using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Interfaces
{
    /// <summary>
    /// Visitor interface
    /// </summary>
    interface IVisitor
    {
        void Visit(IEmployee element);
    }
}
