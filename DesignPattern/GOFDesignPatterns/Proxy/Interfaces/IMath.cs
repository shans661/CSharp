using System;
using System.Collections.Generic;
using System.Text;

namespace Proxy.Interfaces
{
    /// <summary>
    /// Interface for the math object
    /// </summary>
    interface IMath
    {
        double Add(double x, double y);
        double Subtract(double x, double y);
        double Multiply(double x, double y);
        double Division(double x, double y);
    }
}
