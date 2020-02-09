using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Features
{
    /// <summary>
    /// Main object
    /// </summary>
    class Math : IMath
    {
        public double Add(double x, double y)
        {
            return x + y;
        }

        public double Division(double x, double y)
        {
            return x / y;
        }

        public double Multiply(double x, double y)
        {
            return x * y;
        }

        public double Subtract(double x, double y)
        {
            return x - y;
        }
    }
}
