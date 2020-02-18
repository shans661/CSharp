using System;
using System.Collections.Generic;
using System.Text;
using Visitor.Features;
using Visitor.Interfaces;

namespace Visitor
{
    /// <summary>
    /// Employees
    /// </summary>
    class Employees
    {
        List<Employee> m_Employees = new List<Employee>();

        public void Add(Employee employee)
        {
            Console.WriteLine($"Employee {employee.GetType().Name} added");
            m_Employees.Add(employee);
        }

        public void Visit(IVisitor visitor)
        {
            Console.WriteLine($"Visitor {visitor.GetType().Name} will visit all the employee");
            foreach(var item in m_Employees)
            {
                visitor.Visit(item);
                Console.WriteLine($"{visitor.GetType().Name} is visited employee {item.Name}");
            }
        }
    }
}
