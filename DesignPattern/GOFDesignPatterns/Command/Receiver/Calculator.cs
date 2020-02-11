using System;
using System.Collections.Generic;
using System.Text;

namespace Command.Receiver
{
    /// <summary>
    /// Invoker class
    /// </summary>
    class Calculator
    {
        public int Operation(string Op, int x, int result=0)
        {
            switch(Op)
            {
                case "+":
                    result = x + result;
                    break;
                case "-":
                    result = result - x;
                    break;
                case "*":
                    result = x * result;
                    break;
                case "/":
                    result = result / x;
                    break;
            }
            Console.WriteLine($"Result is {result}");
            return result;
            
        }
    }
}
