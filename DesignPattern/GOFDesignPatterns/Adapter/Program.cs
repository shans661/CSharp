using Adapter.Features;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            //Fetches different compound from chemical datbase and displays
            Console.WriteLine("-----------------------------------");
            Compund water = new RichCompound("Water");
            water.Display();

            Console.WriteLine("-----------------------------------");
            Compund benzene = new RichCompound("Benzene");
            benzene.Display();

            Console.WriteLine("-----------------------------------");
            Compund ethanol = new RichCompound("Ethanol");
            ethanol.Display();

            Console.ReadKey();
        }
    }
}
