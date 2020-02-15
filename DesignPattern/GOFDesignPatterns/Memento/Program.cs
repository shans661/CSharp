using Memento.Mementos;
using Memento.Sales;
using System;

namespace Memento
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            SalesProspect salesProspect = new SalesProspect();
            salesProspect.Name = "XYZ";
            salesProspect.Phone = "123456789";
            salesProspect.Budget = "123";
            salesProspect.Display();

            ProspectMemory prospectMemory = new ProspectMemory();
            prospectMemory.Memento = salesProspect.SaveState();

            salesProspect.Name = "Shiva";
            salesProspect.Phone = "9844715540";
            salesProspect.Budget = "3333333";
            salesProspect.Display();

            salesProspect.RestoreState(prospectMemory.Memento);
            salesProspect.Display();
            Console.WriteLine("-------------------------");
            Console.ReadKey();
        }
    }
}
