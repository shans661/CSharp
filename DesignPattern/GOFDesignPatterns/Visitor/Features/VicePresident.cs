using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Features
{
    /// <summary>
    /// Vice president class
    /// </summary>
    class VicePresident : Employee
    {
        public VicePresident(string name, double income, int leaves) : base(name, income, leaves)
        {
            Console.WriteLine("Vice President is created");
        }
    }
}
