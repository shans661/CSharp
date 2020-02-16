using System;
using Template.Features;

namespace Template
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------------");
            DataAccessObject dataAccessObject = new Products();
            //Run will execute the order as per template
            dataAccessObject.Run();

            Console.WriteLine("--------------------------------");

            Console.ReadKey();
        }
    }
}
