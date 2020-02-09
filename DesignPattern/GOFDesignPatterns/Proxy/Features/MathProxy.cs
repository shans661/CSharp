using Proxy.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Features
{
    /// <summary>
    /// Proxy object
    /// </summary>
    class MathProxy : IMath
    {
        Math math = new Math();
        public double Add(double x, double y)
        {
            var result =  math.Add(x , y);
            Console.WriteLine($"Addition of {x} and {y} is {result}");

            return result;
        }

        public double Division(double x, double y)
        {
            var result = math.Division(x, y);
            Console.WriteLine($"Division of {x} and {y} is {result}");

            return result;
        }

        public double Multiply(double x, double y)
        {
            var result = math.Multiply(x, y);
            Console.WriteLine($"Multiplication of {x} and {y} is {result}");

            return result;
        }

        public double Subtract(double x, double y)
        {
            var result = math.Subtract(x, y);
            Console.WriteLine($"Subtraction of {x} and {y} is {result}");

            return result;
        }
    }
}
