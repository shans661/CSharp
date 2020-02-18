using System;
using System.Collections.Generic;
using System.Text;

namespace Visitor.Features
{
    /// <summary>
    /// President class
    /// </summary>
    class President : Employee
    {
        public President(string name, double income, int leaves) : base(name, income, leaves)
        {
            Console.WriteLine("President is created");
        }
    }
}
