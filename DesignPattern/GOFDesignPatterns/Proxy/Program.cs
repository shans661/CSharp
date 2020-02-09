using Proxy.Features;
using System;

namespace Proxy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            MathProxy mathProxy = new MathProxy();
            mathProxy.Add(33, 99);
            mathProxy.Subtract(99, 66);
            mathProxy.Multiply(11, 11);
            mathProxy.Division(99, 11);
            Console.WriteLine("---------------------");
            Console.ReadKey();
        }
    }
}
