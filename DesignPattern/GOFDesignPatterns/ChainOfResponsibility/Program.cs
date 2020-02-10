using ChainOfResponsibility.Features;
using ChainOfResponsibility.Features.Approvers;
using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------------------");
            Purchase purchase = new Purchase();
            purchase.ProductName = "Washing Machine";
            purchase.Quntity = 1;
            purchase.Price = 25000;

            Director director = new Director();
            VicePresident vicePresident = new VicePresident();
            President president = new President();
            director.SetSuccessor(vicePresident);
            vicePresident.SetSuccessor(president);

            director.ProcessRequest(purchase);
            Console.WriteLine("------------------------------");

            Console.ReadKey();
        }
    }
}
