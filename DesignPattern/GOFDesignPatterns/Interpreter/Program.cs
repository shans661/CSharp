using Interpreter.AbstractClas;
using Interpreter.Features;
using Interpreter.Features.Expressions;
using System;
using System.Collections.Generic;

namespace Interpreter
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------------");
            string input = "MCMXXVIII";
            Context context = new Context(input);
            Console.WriteLine($"Input Roman is {input}");
            // Build the 'parse tree'

            List<Expression> tree = new List<Expression>();
            tree.Add(new TausendExpression());
            tree.Add(new HundredExpression());
            tree.Add(new TenExpression());
            tree.Add(new OneExpression());

            foreach(var item in tree)
            {
                item.Interpret(context);
            }

            Console.WriteLine($"Output Decimal is {context.OutPut}");
            Console.WriteLine("-------------------------------");
            Console.ReadKey();
        }
    }
}
