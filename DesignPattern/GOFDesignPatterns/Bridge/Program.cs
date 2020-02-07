using Bridge.Features.Abstration;
using System;

namespace Bridge
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Customers customers = new Customers();
            customers.ShowCustomer();
            customers.NextCustomer();

            Console.WriteLine("----------------------------");
            customers.ShowCustomer();
            customers.NextCustomer();

            Console.WriteLine("----------------------------");
            customers.ShowCustomer();
            customers.NextCustomer();

            Console.WriteLine("----------------------------");
            customers.AddCustomer("Saikat");
            customers.ShowCustomer();
            customers.NextCustomer();

            Console.WriteLine("----------------------------");
            customers.DeleteCustomer("Saikat");
            customers.ShowCustomer();
            customers.NextCustomer();

            Console.WriteLine("----------------------------");
            customers.ShowAllCustomer();

            Console.ReadKey();
        }
    }
}
