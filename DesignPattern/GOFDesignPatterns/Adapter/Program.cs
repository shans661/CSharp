using Adapter.Features;
using System;

namespace Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
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
