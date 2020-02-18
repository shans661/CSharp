using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Interfaces;

namespace Visitor.Features
{
    /// <summary>
    /// Concrete employee
    /// </summary>
    class Employee : IEmployee
    {
        private IVisitor m_Visitor;
        public Employee(string name, double income, int leaves)
        {
            Name = name;
            Income = income;
            Leaves = leaves;
        }

        public string Name { get; set; }
        public double Income { get; set; }
        public int Leaves { get; set; }
        public void Accept(IVisitor visitor)
        {
            m_Visitor = visitor;
        }
    }
}
