using Singleton.Features;
using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {

            LoadBalancer L1 = LoadBalancer.GetLoadBalancer;
            LoadBalancer L2 = LoadBalancer.GetLoadBalancer;
            LoadBalancer L3 = LoadBalancer.GetLoadBalancer;

            if(L1 == L2 && L1==L3 && L2==L3)
            {
                Console.WriteLine("Same load balancers");
            }

            for (int i= 0; i<20; i++)
            {
                Console.WriteLine("---------------------");
                var server = L1.NextSerer();
                Console.WriteLine($"Server is {server.Name} and ip address {server.IPAddress}");
            }

            Console.ReadKey();
        }
    }
}
