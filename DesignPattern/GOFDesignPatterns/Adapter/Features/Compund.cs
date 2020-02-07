using System;
using System.Collections.Generic;
using System.Text;

namespace Adapter.Features
{
    //Target type
    class Compund
    {
        public Compund(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
        public string Formula { get; set; }
        public int MeltingPoint { get; set; }
        public int BoiingPoint { get; set; }

        public virtual void Display()
        {
            Console.WriteLine($"Compound {Name} details");
        }
    }
}
