using System;
using System.Collections.Generic;
using System.Text;

namespace Memento.Mementos
{
    /// <summary>
    /// Memnto class - to store in the state
    /// </summary>
    class Mement
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Budget { get; set; }

        public Mement(string name, string phone, string budget)
        {
            Console.WriteLine($"Saved state is Name: {name}, Phone: {phone}, Budget : {budget}");
            Name = name;
            Phone = phone;
            Budget = budget;
        }
    }
}
