using Memento.Mementos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Sales
{
    /// <summary>
    /// Sales prospect class
    /// </summary>
    class SalesProspect
    {
        public string Name { get; set; }

        public string Phone { get; set; }
        public string Budget { get; set; }

        public Mement SaveState()
        {
            Console.WriteLine("Save state initiated");
            return new Mement(Name, Phone, Budget);
        }

        public void RestoreState(Mement memento)
        {
            Name = memento.Name;
            Phone = memento.Phone;
            Budget = memento.Budget;
            Console.WriteLine("Restore state is completed");
        }

        public void Display()
        {
            Console.WriteLine($"Name: {Name}");
            Console.WriteLine($"Phone: {Phone}");
            Console.WriteLine($"Budget: {Budget}");
        }
    }
}
