using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Features
{
    /// <summary>
    /// Director employee
    /// </summary>
    class Director : Employee
    {
        public Director(string name, double income, int leaves) : base(name, income, leaves)
        {
            Console.WriteLine("Director is created");
        }
    }
}
