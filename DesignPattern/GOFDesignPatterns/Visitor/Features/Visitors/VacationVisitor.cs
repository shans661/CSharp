using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Features.Visitors
{
    /// <summary>
    /// Concrete visitor
    /// </summary>
    class VacationVisitor : IVisitor
    {
        /// <summary>
        /// Acts on emloyee
        /// </summary>
        /// <param name="element"></param>
        public void Visit(IEmployee element)
        {
            Employee employee = element as Employee;

            employee.Leaves += 3;
            Console.WriteLine($"Leaves updated for {employee.GetType().Name} and leaves are {employee.Leaves}");
        }
    }
}
