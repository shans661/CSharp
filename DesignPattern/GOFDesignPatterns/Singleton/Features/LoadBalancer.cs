using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton.Features
{
    /// <summary>
    /// Singleton class
    /// </summary>
    class LoadBalancer
    {
        Random m_Random = new Random();

        private static LoadBalancer Balancer = new LoadBalancer();

        //Private constructor always returns same object
        private LoadBalancer()
        {
            Servers = new List<Server>()
            {
                new Server()
                {
                    Name="Server1",
                    IPAddress="120.1.1.1"
                },
                 new Server()
                {
                    Name="Server2",
                    IPAddress="120.1.1.2"
                },
                  new Server()
                {
                    Name="Server3",
                    IPAddress="120.1.1.3"
                },
                   new Server()
                {
                    Name="Server4",
                    IPAddress="120.1.1.4"
                },
                    new Server()
                {
                    Name="Server5",
                    IPAddress="120.1.1.5"
                }
            };
        }

        public static List<Server> Servers { get; set; }
        public static LoadBalancer GetLoadBalancer
        {
            get
            {
                return Balancer;
            }
        }

        public Server NextSerer()
        {
            var next = m_Random.Next(Servers.Count);
            return Servers[next];
        }
    }
}
