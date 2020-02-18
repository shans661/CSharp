using System;
using Visitor.Features;
using Visitor.Features.Visitors;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------");
            //Employee created and added into employees list
            Employees employees = new Employees();
            employees.Add(new Director("Shiva", 5000, 30));
            employees.Add(new VicePresident("Shankara", 33333, 60));
            employees.Add(new Director("Aish", 66666, 90));

            // Visitor will act upon the employees
            VacationVisitor vacationVisitor = new VacationVisitor();
            employees.Visit(vacationVisitor);
            employees.Visit(vacationVisitor);
            employees.Visit(vacationVisitor);
            Console.WriteLine("-----------------------------");
            Console.ReadKey();
        }
    }
}
