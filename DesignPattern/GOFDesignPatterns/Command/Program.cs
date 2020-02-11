using Command.Commandz;
using Command.Invoker;
using System;

namespace Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Command execution strated");
            Commands calculatorCommand = new CalculatorCommand();
            User user = new User(calculatorCommand);
            user.ExecuteCommand("+", 33);
            user.UnDoCommand();
            Console.WriteLine("-----------------------");
            Console.ReadKey();
        }
    }
}
